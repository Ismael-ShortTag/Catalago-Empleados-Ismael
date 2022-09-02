using DataProject.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ContactosService
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
    }
}
