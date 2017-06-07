using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_de_Prestamos.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Inserte nombre del cliente")]
        [MaxLength(30,ErrorMessage = "Nombre muy largo.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es requerido")]
        [MaxLength(30,ErrorMessage = "Apellido muy largo")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Ingrese numero de cedula del cliente")]
        [RegularExpression(@"^\d{3}-\d{7}-\d{1}$",ErrorMessage = "Numero de Cedula invalido")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Direccion requerida")]
        [MaxLength(250,ErrorMessage = "Direccion muy larga")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Numero de telefono requerido")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$",ErrorMessage = "Ingrese numero de telefono valido")]
        public string Telefono { get; set; }
    }
}