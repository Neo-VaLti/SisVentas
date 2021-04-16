﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NArticulo
    {
        //se comunica con d arrticulo
        public static string Insertar(string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {

            {
                // se iso constructor vacio
                DArticulo Obj = new DArticulo();
                Obj.Codigo = codigo;
                Obj.Nombre = nombre;
                Obj.Descripcion = descripcion;
                Obj.Imagen = imagen;
                Obj.Idcategoria = idcategoria;
                Obj.Idpresentacion = idpresentacion;

                return Obj.Insertar(Obj);
            }
        }
        public static string Editar(int idarticulo,string codigo, string nombre, string descripcion, byte[] imagen, int idcategoria, int idpresentacion)
        {
            // se iso constructor vacio
            DArticulo Obj = new DArticulo();
                Obj.Idarticulo = idarticulo; ;
                Obj.Codigo = codigo;
                Obj.Nombre = nombre;
                Obj.Descripcion = descripcion;
                Obj.Imagen = imagen;
                Obj.Idcategoria = idcategoria;
                Obj.Idpresentacion = idpresentacion;
                return Obj.Editar(Obj);
        }
        public static string Eliminar(int idarticulo)
        {
            // se iso constructor vacio
            DArticulo Obj = new DArticulo();
            Obj.Idarticulo = idarticulo;

            return Obj.Eliminar(Obj);
        }
        public static DataTable Mostrar()
        {
            return new DArticulo().Mostrar();
        }
        //buscar nomrbre
        public static DataTable BuscarNombre(String textobuscar)
        {
            DArticulo Obj = new DArticulo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
        public static DataTable Stock_Articulos()
        {
            return new DArticulo().Stock_Articulos();
        }
    }
}