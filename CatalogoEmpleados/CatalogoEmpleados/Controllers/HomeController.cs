using CatalogoEmpleados.DataBase;
using CatalogoEmpleados.Models;
using CatalogoEmpleados.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CatalogoEmpleados.Controllers
{
    public class HomeController : Controller
    {
        public DB_ITSEntities db = new DB_ITSEntities();
        public ActionResult Index()
        {
            var model = new CatalogoViewModel()
            {
                dato = CatalogoService.getAll(),
                puestos = CatalogoService.getAll2()
            };
            return View(model);
        }
        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Guardar(CatalogoViewModel model)
        {
            var empleado = new EmployeesIsmael()
            {
                CreationDate = DateTime.Now,
                Name = model.Name,
                LastName = model.LastName,
                Birthday = model.Birthday,
                RFC = model.RFC,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                IsDeleted = false,
                PositionId = model.IdPosicion,
            };
            CatalogoService.Agregar(empleado);
            return RedirectToAction("Index");
        }
        public ActionResult Editar(int id)
        {
            var Empleado = CatalogoService.Buscar(id);
            var tabla = new CatalogoViewModel()
            {
                Id = id,
                CreationDate = Empleado.CreationDate,
                puestos = CatalogoService.getAll2(),
                Name = Empleado.Name,
                LastName = Empleado.LastName,
                Birthday = Empleado.Birthday,
                RFC = Empleado.RFC,
                Email = Empleado.Email,
                PhoneNumber = Empleado.PhoneNumber,
                PositionId = Empleado.PositionId,
            };
            return View(tabla);
        }
        [HttpPost]
        public ActionResult Actualizar(CatalogoViewModel model)
        {
            var Empleado = new EmployeesIsmael()
            {
                CreationDate = model.CreationDate,
                Id = model.Id,
                Name = model.Name,
                LastName = model.LastName,
                Birthday = model.Birthday,
                RFC = model.RFC,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                PositionId = model.PositionId,
            };
            CatalogoService.Editar(Empleado);
            return RedirectToAction("Index");
        }
        public ActionResult Ver(int id)
        {

            var Empleado = CatalogoService.Buscar(id);
            var tabla = new CatalogoViewModel()
            {
                Id = id,
                CreationDate = Empleado.CreationDate,
                puestos = CatalogoService.getAll2(),
                Name = Empleado.Name,
                LastName = Empleado.LastName,
                Birthday = Empleado.Birthday,
                RFC = Empleado.RFC,
                Email = Empleado.Email,
                PhoneNumber = Empleado.PhoneNumber,
                PositionId = Empleado.PositionId,
            };
            return View(tabla);
        }
        [HttpPost]
        public ActionResult CambioEstatus(CatalogoViewModel model)
        {
            bool bit;
            var Empleado = CatalogoService.Buscar(model.Id);
             if (Empleado.IsDeleted == false)
              {
                  bit = true;
              }
              else
              {
                  bit = false;
              }

            var tabla = new EmployeesIsmael()
            {
                Id = Empleado.Id,
                CreationDate = Empleado.CreationDate,
                //puestos = CatalogoService.getAll2(),
                Name = Empleado.Name,
                LastName = Empleado.LastName,
                Birthday = Empleado.Birthday,
                RFC = Empleado.RFC,
                Email = Empleado.Email,
                PhoneNumber = Empleado.PhoneNumber,
                IsDeleted = bit,
                PositionId = Empleado.PositionId,

            };
            CatalogoService.Editar(tabla);
            return RedirectToAction("Index");
        }
    }
        
       /* public ActionResult CambioEstatus2(CatalogoViewModel model)
        {
            
            var Empleado = new EmployeesIsmael()
            {
                Id = model.Id,
                Name=model.Name,
                LastName=model.LastName,
                Email = model.Email,
                CreationDate = model.CreationDate,
                Birthday = model.Birthday,
                IsDeleted = model.isDeleted,
            };
            CatalogoService.Editar(Empleado);
            return RedirectToAction("Index");
        }
    }*/
}