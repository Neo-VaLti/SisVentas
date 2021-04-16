using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DIngreso
    {
        private int _Idingreso;
        private int _Idtrabajador;
        private int _Idproveedor;
        private DateTime _Fecha;
        private string _tipo_Comprobante;
        private string _Serie;
        private string _Correlativo;
        private decimal _Igv;
        private string _Estado;

        public int Idingreso { get => _Idingreso; set => _Idingreso = value; }
        public int Idtrabajador { get => _Idtrabajador; set => _Idtrabajador = value; }
        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string Tipo_Comprobante { get => _tipo_Comprobante; set => _tipo_Comprobante = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Correlativo { get => _Correlativo; set => _Correlativo = value; }
        public decimal Igv { get => _Igv; set => _Igv = value; }
        public string Estado { get => _Estado; set => _Estado = value; }


        public DIngreso()
        {

        }
        public DIngreso(int idingreso, int idtrabajador, int idproveedor, DateTime fecha, string tipo_comprobante, string serie,
            string correlativo, decimal igv, string estado)
        {
            this.Idingreso = idingreso;
            this.Idtrabajador = idtrabajador;
            this.Idproveedor = idproveedor;
            this.Fecha = fecha;
            this.Tipo_Comprobante = tipo_comprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.Igv = igv;
            this.Estado = estado;
        }
        public string Insertar(DIngreso Ingreso, List<DDetalle_Ingreso> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecer el comando
                SqlTransaction SqlTra = SqlCon.BeginTransaction();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCategoria = new SqlParameter();
                ParIdCategoria.ParameterName = "@idingreso";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdCategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@idtrabajador";
                ParNombre.SqlDbType = SqlDbType.Int;
                ParNombre.Value = Ingreso.Idtrabajador;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@idproveedor";
                ParDescripcion.SqlDbType = SqlDbType.Int;

                ParDescripcion.Value = Ingreso.Idproveedor;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.Date;

                ParFecha.Value = Ingreso.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter parcomprobante = new SqlParameter();
                parcomprobante.ParameterName = "@tipo_comprobante";
                parcomprobante.SqlDbType = SqlDbType.VarChar;
                parcomprobante.Size = 20;
                parcomprobante.Value = Ingreso.Tipo_Comprobante;
                SqlCmd.Parameters.Add(parcomprobante);

                SqlParameter parserie = new SqlParameter();
                parserie.ParameterName = "@serie";
                parserie.SqlDbType = SqlDbType.VarChar;
                parserie.Size = 4;
                parserie.Value = Ingreso.Serie;
                SqlCmd.Parameters.Add(parserie);

                SqlParameter parco = new SqlParameter();
                parco.ParameterName = "@correlativo";
                parco.SqlDbType = SqlDbType.VarChar;
                parco.Size = 7;
                parco.Value = Ingreso.Correlativo;
                SqlCmd.Parameters.Add(parco);

                SqlParameter parigv = new SqlParameter();
                parigv.ParameterName = "@igv";
                parigv.SqlDbType = SqlDbType.Decimal;
                parigv.Precision = 4;
                parigv.Scale = 2;
                parigv.Value = Ingreso.Igv;
                SqlCmd.Parameters.Add(parigv);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "@estado";
                parestado.SqlDbType = SqlDbType.VarChar;

                parestado.Scale = 7;
                parestado.Value = Ingreso.Estado;
                SqlCmd.Parameters.Add(parestado);
                //Ejecutamos nuestro comando




                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso el Registro";

                if (rpta.Equals("OK"))
                {
                    this.Idingreso = Convert.ToInt32(SqlCmd.Parameters["@idingreso"].Value);
                    foreach (DDetalle_Ingreso det in Detalle)
                    {
                        det.Idingreso = this.Idingreso;

                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;

                        }

                    }
                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();

                }
                else
                {
                    SqlTra.Rollback();
                }
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

        public string Anular(DIngreso Ingreso)
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
                SqlCmd.CommandText = "spanular_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCategoria = new SqlParameter();
                ParIdCategoria.ParameterName = "@idingreso";
                ParIdCategoria.SqlDbType = SqlDbType.Int;
                ParIdCategoria.Value = Ingreso.Idingreso;
                SqlCmd.Parameters.Add(ParIdCategoria);



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
            DataTable DtResultado = new DataTable("ingreso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_ingreso";
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
        public DataTable BuscarFechas(String TextoBuscar, String TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("ingreso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_ingreso_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable MostrarDetalle(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_ingreso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
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
    
    




