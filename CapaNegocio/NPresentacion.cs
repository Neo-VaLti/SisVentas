using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
   public class NPresentacion
    {
        public static string Insertar(string nombre, string descripcion)
        {
            // se iso constructor vacio
            DPresentacion Obj = new DPresentacion();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idpresentacion, string nombre, string descripcion)
        {
            // se iso constructor vacio
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idpresentacion)
        {
            // se iso constructor vacio
            DPresentacion Obj = new DPresentacion();
            Obj.Idpresentacion = idpresentacion;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostrar();
        }
        //buscar nomrbre
        public static DataTable BuscarNombre(String textobuscar)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
