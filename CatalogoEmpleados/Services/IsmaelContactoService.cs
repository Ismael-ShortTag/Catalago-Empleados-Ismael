using DataProject.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class IsmaelContactosService
    {
        /// <summary>
        /// Método para consultar todos los contactos en la base de datos 
        /// </summary>
        /// <returns>Lista con los objetos de contactos </returns>
        public static List<Contactos> getAll()
        {
            try
            {
                List<Contactos> lista = new List<Contactos>();
                using (var db = new DB_ITSEntities())
                {
                    lista = db.Contactos.ToList();
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        /// <summary>
        /// Método para agregar un nuevo contacto.
        /// </summary>
        /// <returns>Lista con los objetos de contactos </returns>
        public static void Agregar(Contactos contacto)
        {
            try
            {
                using(var db = new DB_ITSEntities())
                {
                    db.Contactos.Add(contacto);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Contactos Buscar(int id)
        {
            var contactos = new Contactos();
            try
            {
                using(var db = new DB_ITSEntities())
                {
                    contactos = db.Contactos.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return contactos;
        }
        public static void Editar(Contactos contacto)
        {
            try
            {
                using (var db = new DB_ITSEntities())
                {
                    db.Entry(contacto).State = System.Data.Entity.EntityState.Modified;
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
