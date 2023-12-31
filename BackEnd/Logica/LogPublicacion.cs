﻿using BackEnd.accesoDatos;
using BackEnd.Entidades;
using BackEnd.Entidades.Request;
using BackEnd.Entidades.Response;
using BackEnd.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebSockets;

namespace BackEnd.Logica
{
    public class LogPublicacion
    {
        public ResIngresarPublicacion ingresarPublicacion(ReqIngresarPublicacion req) {
            ResIngresarPublicacion res = new ResIngresarPublicacion();
            res.listaDeErrores = new List<string>();
            try
            {
                if (req == null)
                {
                    res.listaDeErrores.Add("Req nulo");
                    res.result = false;
                }
                else
                {
                    if (req.laPublicacion.idTema == 0)
                    {
                        res.listaDeErrores.Add("Id de tema faltante");
                        res.result = false;
                    }
                    if (req.laPublicacion.idUsuario == 0)
                    {
                        res.listaDeErrores.Add("Id de usuario faltante");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.laPublicacion.titulo))
                    {
                        res.listaDeErrores.Add("Título faltante");
                        res.result = false;
                    }
                    if (String.IsNullOrEmpty(req.laPublicacion.mensaje))
                    {
                        res.listaDeErrores.Add("Mensaje faltante");
                        res.result = false;
                    }
                    if (!res.listaDeErrores.Any())
                    {
                        //¿No hay nada en la lista de errores?
                        //Correcto. Todo bien. No hay nada en la lista de errores.
                        //Llamo al linq
                        int? idReturn = 0;
                        int? idDeErrorDeBaseDeDatos = 0;
                        string descripcionErrorDeBaseDeDatos = "";

                        conexionLinqDataContext miLinq = new conexionLinqDataContext();
                        miLinq.SP_INGRESAR_PUBLICACION(req.laPublicacion.idTema, req.laPublicacion.idUsuario, req.laPublicacion.titulo, req.laPublicacion.mensaje, ref idReturn, ref idDeErrorDeBaseDeDatos, ref descripcionErrorDeBaseDeDatos);

                        if (idDeErrorDeBaseDeDatos == 0) //Hubo errores en BD
                        {
                            //Todo bien. No, no hay errores en base de datos
                            res.result = true;
                        }
                        else
                        {
                            //Si, si hay errores en BD.
                            res.result = false;
                            res.listaDeErrores.Add("La base de datos retornó:" + descripcionErrorDeBaseDeDatos);
                        }
                    }
                }
            }
            catch {
                res.listaDeErrores.Add("Error no controlado en lógica");
                res.result = false;
            }
            return res;
        }

        public ResObtenerListaDePublicaciones obtenerListaDePublicaciones(ReqObtenerListaDePublicaciones req)
        {
            ResObtenerListaDePublicaciones res = new ResObtenerListaDePublicaciones();

            res.listaDeErrores = new List<string>();
            try
            {
                if(req == null) {
                    res.result = false;
                    res.listaDeErrores.Add("Request nulo");
                }
                else{
                    conexionLinqDataContext miLinq = new conexionLinqDataContext(); //Instancio Linq
                    List<SP_OBTENER_PUBLICACIONESResult> listaTipoComplejo = new List<SP_OBTENER_PUBLICACIONESResult>();
                    listaTipoComplejo = miLinq.SP_OBTENER_PUBLICACIONES().ToList();
                    res.laListaDePublicaciones = Factory.miFactoryDeListaPublicacion(listaTipoComplejo);
                    res.result = true;
                }
            }
            catch (Exception e)
            {
                res.result = false;
                res.listaDeErrores.Add("Error no controlado en lógica: " + e.StackTrace);
            }
            return res;
        }
    }
}