﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProveedor
    {
        //Variables
        private int _Idproveedor;
        private string _Razonsocial;
        private string _Sector_Comercial;
        private string _Tipo_Documento;
        private string _Num_Documento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Url;
        private string _TextoBuscar;

        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public string Razonsocial { get => _Razonsocial; set => _Razonsocial = value; }
        public string Sector_Comercial { get => _Sector_Comercial; set => _Sector_Comercial = value; }
        public string Tipo_Documento { get => _Tipo_Documento; set => _Tipo_Documento = value; }
        public string Num_Documento { get => _Num_Documento; set => _Num_Documento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Url { get => _Url; set => _Url = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        //
        public DProveedor()
        {

        }
        public DProveedor(int idproveedor, string razon_social, string sector_comercial, string tipo_documento, string num_documento, string direccion, string telefono, string email, string url, string textobuscar)

        {
            this.Idproveedor = idproveedor;
            this.Razonsocial = razon_social;
            this.Sector_Comercial = sector_comercial;
            this.Tipo_Documento = tipo_documento;
            this.Num_Documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Url = url;
            this.TextoBuscar = textobuscar;
        }
        //ins
        public string Insertar(DProveedor proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParRazon_Social = new SqlParameter();
                ParRazon_Social.ParameterName = "@razon_social";
                ParRazon_Social.SqlDbType = SqlDbType.VarChar;
                ParRazon_Social.Size = 150;
                ParRazon_Social.Value = proveedor.Razonsocial;
                SqlCmd.Parameters.Add(ParRazon_Social);

                SqlParameter ParSectorComercial = new SqlParameter();
                ParSectorComercial.ParameterName = "@sector_comercial";
                ParSectorComercial.SqlDbType = SqlDbType.VarChar;
                ParSectorComercial.Size = 256;
                ParSectorComercial.Value = proveedor.Sector_Comercial;
                SqlCmd.Parameters.Add(ParSectorComercial);

                SqlParameter ParSectorTipoDocumento = new SqlParameter();
                ParSectorTipoDocumento.ParameterName = "@tipo_documento";
                ParSectorTipoDocumento.SqlDbType = SqlDbType.VarChar;
                ParSectorTipoDocumento.Size = 20;
                ParSectorTipoDocumento.Value = proveedor.Tipo_Documento;
                SqlCmd.Parameters.Add(ParSectorTipoDocumento);
                //Ejecutamos nuestro comando
                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@num_documento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 11;
                ParNum_Documento.Value = proveedor.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = proveedor.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);


                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = proveedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@url";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 150;
                ParUrl.Value = proveedor.Url;
                SqlCmd.Parameters.Add(ParUrl);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public string Editar(DProveedor proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParRazon_Social = new SqlParameter();
                ParRazon_Social.ParameterName = "@razon_social";
                ParRazon_Social.SqlDbType = SqlDbType.VarChar;
                ParRazon_Social.Size = 150;
                ParRazon_Social.Value = proveedor.Razonsocial;
                SqlCmd.Parameters.Add(ParRazon_Social);

                SqlParameter ParSectorComercial = new SqlParameter();
                ParSectorComercial.ParameterName = "@sector_comercial";
                ParSectorComercial.SqlDbType = SqlDbType.VarChar;
                ParSectorComercial.Size = 256;
                ParSectorComercial.Value = proveedor.Sector_Comercial;
                SqlCmd.Parameters.Add(ParSectorComercial);

                SqlParameter ParSectorTipoDocumento = new SqlParameter();
                ParSectorTipoDocumento.ParameterName = "@tipo_documento";
                ParSectorTipoDocumento.SqlDbType = SqlDbType.VarChar;
                ParSectorTipoDocumento.Size = 20;
                ParSectorTipoDocumento.Value = proveedor.Tipo_Documento;
                SqlCmd.Parameters.Add(ParSectorTipoDocumento);
                //Ejecutamos nuestro comando
                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@num_documento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 11;
                ParNum_Documento.Value = proveedor.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = proveedor.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);


                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = proveedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@url";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 150;
                ParUrl.Value = proveedor.Url;
                SqlCmd.Parameters.Add(ParUrl);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizo el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        public string Eliminar(DProveedor proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idproveedor";
                ParIdproveedor.SqlDbType = SqlDbType.Int;
                ParIdproveedor.Value = proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdproveedor);



                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public DataTable BuscarRazon_Social(DProveedor proveedor)
        {
            DataTable DtResultado = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proveedor_razon_social";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable BuscarNum_Documento(DProveedor proveedor)
        {
            DataTable DtResultado = new DataTable("proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proveedor_num_documento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}

