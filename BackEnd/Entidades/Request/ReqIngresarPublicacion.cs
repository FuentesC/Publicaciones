using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades.Request
{
    public class ReqIngresarPublicacion : ResBase
    {
        public Publicacion laPublicacion { get; set; }
    }
}