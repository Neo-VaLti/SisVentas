﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmVistaCategoria_Articulo : Form
    {
        public frmVistaCategoria_Articulo()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }
        //metodo mosrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            //Metodo BuscarNombre
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NCategoria.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void frmVistaCategoria_Articulo_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            frmArticulo form = frmArticulo.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["idcategoria"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            form.setCategoria(par1,par2);
            this.Hide();
        }
    }
}
