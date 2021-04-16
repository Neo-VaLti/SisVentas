using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NProveedor
    {
        public static string Insertar(string razon_proveedor,string sector_comercial,string tipo_documento,string num_documento,string direccion,string telefono,string email,string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Razonsocial = razon_proveedor;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Insertar(Obj);


            // se iso constructor vacio

        }
        public static string Editar(int idproveedor, string razon_proveedor, string sector_comercial, string tipo_documento, string num_documento, string direccion, string telefono, string email, string url)
        {
            // se iso constructor vacio
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor=idproveedor;
            Obj.Razonsocial = razon_proveedor;
            Obj.Sector_Comercial = sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idproveedor)
        {
            // se iso constructor vacio
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();
        }
        //buscar nomrbre
        public static DataTable BuscarRazon_social(String textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRazon_Social(Obj);
        }
        public static DataTable BuscarNum_documento(String textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
    }
}
