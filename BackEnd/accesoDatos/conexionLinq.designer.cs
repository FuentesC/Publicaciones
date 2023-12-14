﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd.accesoDatos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bdForoLatina")]
	public partial class conexionLinqDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public conexionLinqDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["bdForoLatinaConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public conexionLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_INGRESAR_USUARIO")]
		public int SP_INGRESAR_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NOMBRE", DbType="NVarChar(50)")] string nOMBRE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="APELLIDOS", DbType="NVarChar(50)")] string aPELLIDOS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CORREO_ELECTRONICO", DbType="NVarChar(MAX)")] string cORREO_ELECTRONICO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PASSWORD", DbType="NVarChar(MAX)")] string pASSWORD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nOMBRE, aPELLIDOS, cORREO_ELECTRONICO, pASSWORD, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_OBTENER_USUARIO")]
		public ISingleResult<SP_OBTENER_USUARIOResult> SP_OBTENER_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDDEUSUARIO", DbType="BigInt")] System.Nullable<long> iDDEUSUARIO)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDDEUSUARIO);
			return ((ISingleResult<SP_OBTENER_USUARIOResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_OBTENER_LISTAUSUARIOS")]
		public ISingleResult<SP_OBTENER_LISTAUSUARIOSResult> SP_OBTENER_LISTAUSUARIOS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_OBTENER_LISTAUSUARIOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_INGRESAR_PUBLICACION")]
		public int SP_INGRESAR_PUBLICACION([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID_TEMA", DbType="Int")] System.Nullable<int> iD_TEMA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID_USUARIO", DbType="Int")] System.Nullable<int> iD_USUARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TITULO", DbType="NVarChar(MAX)")] string tITULO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MENSAJE", DbType="NVarChar(MAX)")] string mENSAJE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD_TEMA, iD_USUARIO, tITULO, mENSAJE, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(4)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_OBTENER_PUBLICACIONES")]
		public ISingleResult<SP_OBTENER_PUBLICACIONESResult> SP_OBTENER_PUBLICACIONES()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_OBTENER_PUBLICACIONESResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_OBTENER_USUARIOResult
	{
		
		private long _ID_USUARIO;
		
		private string _NOMBRE;
		
		private string _APELLIDOS;
		
		private string _CORREO_ELECTRONICO;
		
		private System.DateTime _FECHA_REGISTRO;
		
		public SP_OBTENER_USUARIOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_USUARIO", DbType="BigInt NOT NULL")]
		public long ID_USUARIO
		{
			get
			{
				return this._ID_USUARIO;
			}
			set
			{
				if ((this._ID_USUARIO != value))
				{
					this._ID_USUARIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this._NOMBRE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDOS", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string APELLIDOS
		{
			get
			{
				return this._APELLIDOS;
			}
			set
			{
				if ((this._APELLIDOS != value))
				{
					this._APELLIDOS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CORREO_ELECTRONICO", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CORREO_ELECTRONICO
		{
			get
			{
				return this._CORREO_ELECTRONICO;
			}
			set
			{
				if ((this._CORREO_ELECTRONICO != value))
				{
					this._CORREO_ELECTRONICO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_REGISTRO", DbType="DateTime NOT NULL")]
		public System.DateTime FECHA_REGISTRO
		{
			get
			{
				return this._FECHA_REGISTRO;
			}
			set
			{
				if ((this._FECHA_REGISTRO != value))
				{
					this._FECHA_REGISTRO = value;
				}
			}
		}
	}
	
	public partial class SP_OBTENER_LISTAUSUARIOSResult
	{
		
		private long _ID_USUARIO;
		
		private string _NOMBRE;
		
		private string _APELLIDOS;
		
		private string _CORREO_ELECTRONICO;
		
		private System.DateTime _FECHA_REGISTRO;
		
		public SP_OBTENER_LISTAUSUARIOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_USUARIO", DbType="BigInt NOT NULL")]
		public long ID_USUARIO
		{
			get
			{
				return this._ID_USUARIO;
			}
			set
			{
				if ((this._ID_USUARIO != value))
				{
					this._ID_USUARIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this._NOMBRE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDOS", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string APELLIDOS
		{
			get
			{
				return this._APELLIDOS;
			}
			set
			{
				if ((this._APELLIDOS != value))
				{
					this._APELLIDOS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CORREO_ELECTRONICO", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CORREO_ELECTRONICO
		{
			get
			{
				return this._CORREO_ELECTRONICO;
			}
			set
			{
				if ((this._CORREO_ELECTRONICO != value))
				{
					this._CORREO_ELECTRONICO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_REGISTRO", DbType="DateTime NOT NULL")]
		public System.DateTime FECHA_REGISTRO
		{
			get
			{
				return this._FECHA_REGISTRO;
			}
			set
			{
				if ((this._FECHA_REGISTRO != value))
				{
					this._FECHA_REGISTRO = value;
				}
			}
		}
	}
	
	public partial class SP_OBTENER_PUBLICACIONESResult
	{
		
		private int _ID_PUBLICACION;
		
		private System.Nullable<int> _ID_TEMA;
		
		private System.Nullable<long> _ID_USUARIO;
		
		private string _TITULO;
		
		private string _MENSAJE;
		
		private System.Nullable<System.DateTime> _FECHA_REGISTRO;
		
		private string _NOMBRE;
		
		private string _APELLIDOS;
		
		public SP_OBTENER_PUBLICACIONESResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_PUBLICACION", DbType="Int NOT NULL")]
		public int ID_PUBLICACION
		{
			get
			{
				return this._ID_PUBLICACION;
			}
			set
			{
				if ((this._ID_PUBLICACION != value))
				{
					this._ID_PUBLICACION = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_TEMA", DbType="Int")]
		public System.Nullable<int> ID_TEMA
		{
			get
			{
				return this._ID_TEMA;
			}
			set
			{
				if ((this._ID_TEMA != value))
				{
					this._ID_TEMA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_USUARIO", DbType="BigInt")]
		public System.Nullable<long> ID_USUARIO
		{
			get
			{
				return this._ID_USUARIO;
			}
			set
			{
				if ((this._ID_USUARIO != value))
				{
					this._ID_USUARIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TITULO", DbType="NVarChar(MAX)")]
		public string TITULO
		{
			get
			{
				return this._TITULO;
			}
			set
			{
				if ((this._TITULO != value))
				{
					this._TITULO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MENSAJE", DbType="NVarChar(MAX)")]
		public string MENSAJE
		{
			get
			{
				return this._MENSAJE;
			}
			set
			{
				if ((this._MENSAJE != value))
				{
					this._MENSAJE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FECHA_REGISTRO", DbType="DateTime")]
		public System.Nullable<System.DateTime> FECHA_REGISTRO
		{
			get
			{
				return this._FECHA_REGISTRO;
			}
			set
			{
				if ((this._FECHA_REGISTRO != value))
				{
					this._FECHA_REGISTRO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOMBRE", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NOMBRE
		{
			get
			{
				return this._NOMBRE;
			}
			set
			{
				if ((this._NOMBRE != value))
				{
					this._NOMBRE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_APELLIDOS", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string APELLIDOS
		{
			get
			{
				return this._APELLIDOS;
			}
			set
			{
				if ((this._APELLIDOS != value))
				{
					this._APELLIDOS = value;
				}
			}
		}
	}
}
#pragma warning restore 1591