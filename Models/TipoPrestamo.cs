using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_Prestamos.Models
{
    public class TipoPrestamo
    {
        public byte Id { get; set; }
        public string Nombre { get; set; }
        public byte Meses { get; set; }
    }
}