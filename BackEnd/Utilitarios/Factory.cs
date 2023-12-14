using BackEnd.accesoDatos;
using BackEnd.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.Utilitarios
{
    public static class Factory
    {
        public static Usuario miFactoryDeUsuario(SP_OBTENER_USUARIOResult elTipoComplejo)
        {
            Usuario elUsuarioCreado = new Usuario();
            elUsuarioCreado.nombre = elTipoComplejo.NOMBRE;
            elUsuarioCreado.apellidos = elTipoComplejo.APELLIDOS;
            elUsuarioCreado.correoElectronico = elTipoComplejo.CORREO_ELECTRONICO;

            return elUsuarioCreado;
        }

        public static Usuario miFactoryDeUsuarioParaLista(SP_OBTENER_LISTAUSUARIOSResult elTipoComplejo)
        {
            Usuario elUsuarioCreado = new Usuario();
            elUsuarioCreado.nombre = elTipoComplejo.NOMBRE;
            elUsuarioCreado.apellidos = elTipoComplejo.APELLIDOS;
            elUsuarioCreado.correoElectronico = elTipoComplejo.CORREO_ELECTRONICO;

            return elUsuarioCreado;
        }

        public static List<Publicacion> miFactoryDeListaPublicacion(List<SP_OBTENER_PUBLICACIONESResult> listaCompleja) {
            List<Publicacion> laListaDePublicaciones = new List<Publicacion>();

            foreach (SP_OBTENER_PUBLICACIONESResult cadaTipoComplejo in listaCompleja) {
                laListaDePublicaciones.Add(miFactoryDeUnaPublicacion(cadaTipoComplejo));
            }

            return laListaDePublicaciones;
        }

        public static Publicacion miFactoryDeUnaPublicacion(SP_OBTENER_PUBLICACIONESResult unTipoComplejo) {
            Publicacion unaPublicacion = new Publicacion();

            unaPublicacion.idUsuario = (int)unTipoComplejo.ID_USUARIO;
            unaPublicacion.idTema = (int)unTipoComplejo.ID_TEMA;
            unaPublicacion.titulo = unTipoComplejo.TITULO;
            unaPublicacion.mensaje = unTipoComplejo.MENSAJE;

            return unaPublicacion;
        }
    }
}