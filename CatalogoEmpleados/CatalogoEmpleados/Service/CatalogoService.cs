using CatalogoEmpleados.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatalogoEmpleados.Service
{
    public class CatalogoService
    {

        public static List<EmployeesIsmael> getAll()
        {
            /// <summary>
            /// Método para consultar todos los empleados en la base de datos 
            /// </summary>
            /// <returns>Lista con los objetos de empleados </returns>
            try
            {
                List<EmployeesIsmael> lista = new List<EmployeesIsmael>();
                using(var db = new DB_ITSEntities())
                {
                    lista = db.EmployeesIsmael.ToList();
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Método para consultar todos los puestos en la base de datos 
        /// </summary>
        /// <returns>Lista con los objetos de puestos </returns>
        public static List<PositionsIsmael> getAll2()
        {
            try
            {
                 List <PositionsIsmael> puesto = new List<PositionsIsmael>();
                 using (var db = new DB_ITSEntities())
                 {
                     puesto = db.PositionsIsmael.ToList();
                 }
                return puesto;
               
            }
            catch (Exception)
            {
                throw;
            }
        }    
    /// <summary>
    /// Método para agregar un nuevo empleado.
    /// </summary>
    /// <returns> </returns>
    public static void Agregar(EmployeesIsmael empleado)
        {
            try
            {
                using(var db = new DB_ITSEntities())
                {
                    db.EmployeesIsmael.Add(empleado);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Método para buscar la id
        /// </summary>
        /// <returns>Lista con los objetos de los empleados </returns>
        public static EmployeesIsmael Buscar(int id)
        {
            var empleados= new EmployeesIsmael();
            try
            {
                using (var db = new DB_ITSEntities())
                {
                    empleados = db.EmployeesIsmael.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return empleados;
        }
        /// <summary>
        /// Método para modificar un empleado.
        /// </summary>
        /// <returns> </returns>
        public static void Editar(EmployeesIsmael empleados)
        {
            try
            {
                using (var db = new DB_ITSEntities())
                {
                    db.Entry(empleados).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}