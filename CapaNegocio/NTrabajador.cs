using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class NTrabajador
    {
        public static string Insertar(string nombre, string apellidos, string sexo, DateTime fech_nacimiento, string num_documento, string direccion, string telefono, string email, string acceso, string usuario, string password)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fech_nacimiento;
            
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Insertar(Obj);


            // se iso constructor vacio

        }
        public static string Editar(int idtrabajador, string nombre, string apellidos, string sexo, DateTime fech_nacimiento, string num_documento, string direccion, string telefono, string email,string acceso, string usuario, string password)
        {
            // se iso constructor vacio
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fech_nacimiento;
           
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Editar(Obj);
        }
        public static string Eliminar(int idtrabajador)
        {
            // se iso constructor vacio
            DTrabajador Obj = new DTrabajador();
            Obj.Idtrabajador = idtrabajador;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DTrabajador().Mostrar();
        }
        //buscar nomrbre
        public static DataTable BuscarApellidos(String textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }
        public static DataTable BuscarNum_documento(String textobuscar)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.TextoBuscar = textobuscar ;
            return Obj.BuscarNum_Documento(Obj);
        }

        public static DataTable Login(string usuario, string password)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Usuario = usuario;
            Obj.Password = password;
            return Obj.Login(Obj);
        }

        public static string Insertar(string v1, string v2, string text1, DateTime value, object text2, string text3, string text4, string text5, string text6)
        {
            throw new NotImplementedException();
        }
    }
}
