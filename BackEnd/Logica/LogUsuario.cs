using BackEnd.accesoDatos;
using BackEnd.Entidades;
using BackEnd.Entidades.Response;
using BackEnd.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using System.Web;

namespace BackEnd.Logica
{
    public class LogUsuario
    {
        public ResIngresarUsuario ingresarUsuario(ReqIngresarUsuario req) {
            ResIngresarUsuario res = new ResIngresarUsuario();

            try
            {
                if (req == null)
                {
                    res.result = false;
                    res.listaDeErrores.Add("Request null");
                }
                else
                {
                    if (String.IsNullOrEmpty(req.elUsuario.nombre))
                    {
                        res.result = false;
                        res.listaDeErrores.Add("Nombre vacio");
                    }
                    if (String.IsNullOrEmpty(req.elUsuario.apellidos))
                    {
                        res.result = false;
                        res.listaDeErrores.Add("apellido vacio");
                    }
                    if (String.IsNullOrEmpty(req.elUsuario.correoElectronico))
                    {
                        res.result = false;
                        res.listaDeErrores.Add("Correo vacio");
                    }
                    if (String.IsNullOrEmpty(req.elUsuario.password))
                    {
                        res.result = false;
                        res.listaDeErrores.Add("Password vacio");
                    }
                    if (!res.listaDeErrores.Any())
                    {
                        //Llamo al linq
                        int? idDeBaseDeDatos = 0;
                        int? idDeErrorDeBaseDeDatos = 0;
                        string descripcionErrorDeBaseDeDatos = "";

                        conexionLinqDataContext miLinq = new conexionLinqDataContext(); //Instancio Linq

                        //Ejecuto el SP
                        miLinq.SP_INGRESAR_USUARIO(req.elUsuario.nombre, req.elUsuario.apellidos, req.elUsuario.correoElectronico, req.elUsuario.password, ref idDeBaseDeDatos, ref idDeErrorDeBaseDeDatos, ref descripcionErrorDeBaseDeDatos);

                        if (idDeBaseDeDatos > 0) //Hubo errores en BD
                        {
                            //Todo bien. No, no hay errores en base de datos
                            res.result = true;

                        }
                        else
                        {
                            //Si, si hay errores en BD.
                            res.result = false;
                            res.listaDeErrores.Add(descripcionErrorDeBaseDeDatos);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                res.result = false;
                res.listaDeErrores.Add(ex.StackTrace);
            }
            finally { 
                //Bitacorear!!!!
            }
            return res;
        }

        public ResObtenerUsuario obtenerUsuario(ReqObtenerUsuario req)
        {
            ResObtenerUsuario res = new ResObtenerUsuario();

            if (req == null)
            {
                res.result = false;
                res.listaDeErrores.Add("Request null");
            }
            else
            {
                if (req.idDelUsuario == 0)
                {
                    res.result = false;
                    res.listaDeErrores.Add("Id usuario faltante");
                }
                if (String.IsNullOrEmpty(req.session)) {
                    res.result = false;
                    res.listaDeErrores.Add("Session faltante");
                }
                if (!res.listaDeErrores.Any()) {
                    conexionLinqDataContext miLinq = new conexionLinqDataContext();
                    SP_OBTENER_USUARIOResult miTipoComplejo = (SP_OBTENER_USUARIOResult)miLinq.SP_OBTENER_USUARIO(req.idDelUsuario);
                    res.elUsuario = Factory.miFactoryDeUsuario(miTipoComplejo);             
                }
            }
            return res;
        }

        public ResObtenerListaDeUsuarios obtenerListaDeUsuarios(ReqObtenerListaDeUsuarios req)
        {
            ResObtenerListaDeUsuarios res = new ResObtenerListaDeUsuarios();

            if (req == null)
            {
                res.result = false;
                res.listaDeErrores.Add("Request null");
            }
            else
            {
                conexionLinqDataContext miLinq = new conexionLinqDataContext();
                List<SP_OBTENER_LISTAUSUARIOSResult> listaTipoComplejo = miLinq.SP_OBTENER_LISTAUSUARIOS().ToList();

                foreach (SP_OBTENER_LISTAUSUARIOSResult cadaTipoComplejo in listaTipoComplejo) {
                    res.listaDeUsuarios.Add(Factory.miFactoryDeUsuarioParaLista(cadaTipoComplejo));
                }
                
            }
            return res;
        }

    }
}