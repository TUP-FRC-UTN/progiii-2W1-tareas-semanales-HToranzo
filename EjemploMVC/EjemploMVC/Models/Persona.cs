using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploMVC.Models
{
    public class Persona
    {
        public int Id { get; set; }
        [requiered]
        public String Nombre { get; set; }
        [requiered]
        public String Apellido { get; set; }
        [requiered]
        public String Telefono { get; set; }
        [requiered]
        public int Edad { get; set; }

        public int IdSexo { get; set; }
    }
}