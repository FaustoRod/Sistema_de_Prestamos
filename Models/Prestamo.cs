using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sistema_de_Prestamos.Models
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        [Required(ErrorMessage = "Ingrese tipo de Prestamo")]
        public byte TipoPrestamoId { get; set; }

        [ForeignKey("TipoPrestamoId")]
        public virtual TipoPrestamo TipoPrestamo { get; set; }

        [Required(ErrorMessage = "Ingrese cantidad de años")]
        [Range(1,10,ErrorMessage = "Rango de años debe de ser entre 1 y 10")]
        public int CantidadAnos { get; set; }

        [Required(ErrorMessage = "Ingrese monto del prestamo")]
        [Range(1000, 999999, ErrorMessage = "Prestamo debe de entre RD$ 1,000 Y RD$ 999,999")]
        public float MontoPrestamo { get; set; }

        [Required(ErrorMessage = "Ingrese taza de interes")]
        [Range(1,100,ErrorMessage = "Taze debe de ser entre 1 y 100")]
        public float Taza { get; set; }
        public float SaldoActual { get; set; }

        [Required(ErrorMessage = "Ingrese nombre del garante")]
        [MaxLength(30,ErrorMessage = "Nombre garante muy largo")]
        public string GaranteNombre { get; set; }

        [Required(ErrorMessage = "Ingrese apellido del garante")]
        [MaxLength(30, ErrorMessage = "Apellido garante muy largo")]
        public string GaranteApellido { get; set; }

        [Required(ErrorMessage = "Ingrese Cedula del garante")]
        [RegularExpression(@"^\d{3}-\d{7}-\d{1}$", ErrorMessage = "Numero de Cedula invalido")]
        public string GaranteCedula { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$", ErrorMessage = "Ingrese numero de telefono valido")]
        public string GaranteTelefono  { get; set; }

    }
}