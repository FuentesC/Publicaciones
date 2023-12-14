using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades
{
    public class ResObtenerListaDePublicaciones : ResBase
    {
        public List<Publicacion> laListaDePublicaciones = new List<Publicacion>();
    }
}