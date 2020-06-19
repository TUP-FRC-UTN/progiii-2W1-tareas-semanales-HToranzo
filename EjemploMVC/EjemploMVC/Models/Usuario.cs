using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploMVC.Models
{
    public class Usuario
    {
        [requiered]
        public String usuario { set; get; }
        [requiered]
        public String password { set; get; }
    }
}