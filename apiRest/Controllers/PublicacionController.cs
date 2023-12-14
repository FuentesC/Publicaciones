using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BackEnd.Entidades;
using BackEnd.Entidades.Request;
using BackEnd.Logica;

namespace apiRest.Controllers
{
    public class PublicacionController : ApiController
    {
        public ResObtenerListaDePublicaciones Get() { 
            LogPublicacion miLogicaEnElBackend = new LogPublicacion();
            ReqObtenerListaDePublicaciones req = new ReqObtenerListaDePublicaciones();
            return miLogicaEnElBackend.obtenerListaDePublicaciones(req);
        }

        public ResIngresarPublicacion ingresarPublicacion([FromBody] ReqIngresarPublicacion req) {
            LogPublicacion miLogicaDelBackend = new LogPublicacion();
            return miLogicaDelBackend.ingresarPublicacion(req);
        }
    }
}