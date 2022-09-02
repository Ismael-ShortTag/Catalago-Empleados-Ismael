using CatalogoEmpleados.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CatalogoEmpleados.Models
{
    public class CatalogoViewModel
    {
        public List<EmployeesIsmael> dato { get; set; }
        public List<PositionsIsmael> puestos { get; set; }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime Birthday { get; set; }
        public string RFC { get; set; }
        [Display(Name = "Correo")]
        public string Email { get; set; }
        [Display(Name = "Telefono")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Posicion")]
        public int PositionId { get; set; }
        public bool isDeleted { get; set; }
        [Display(Name = "Seleccione el Puesto")]
        public string NamePuesto { get; set; }
        public int IdPosicion { get; set; }
        [Display(Name = "Posición")]
        public string puesto { get; set; }
    }
}