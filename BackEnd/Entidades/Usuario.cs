using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string password { get; set; }
        public string correoElectronico { get; set; }
    }
}