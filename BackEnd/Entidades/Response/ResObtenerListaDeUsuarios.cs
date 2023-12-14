using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Entidades
{
    public class ResObtenerListaDeUsuarios : ResBase
    {
        public List<Usuario> listaDeUsuarios= new List<Usuario>();
    }
}