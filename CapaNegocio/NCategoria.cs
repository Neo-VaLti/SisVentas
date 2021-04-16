using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NCategoria
    {
        //Metodo insertar DCategoria
        public static string Insertar(string nombre, string descripcion)
        {
            // se iso constructor vacio
            DCategoria Obj = new DCategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }
        public static string Editar(int idcategoria, string nombre, string descripcion)
        {
            // se iso constructor vacio
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idcategoria)
        {
            // se iso constructor vacio
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            
            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }
        //buscar nomrbre
        public static DataTable BuscarNombre(String textobuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

       
    /*    
public static string Editar(int v1, string v2, string v3)
{
   throw new NotImplementedException();
}
*/
    }
}
