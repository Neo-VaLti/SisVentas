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
    public partial class frmVistaProveedor_Ingreso : Form
    {
        public frmVistaProveedor_Ingreso()
        {
            InitializeComponent();
        }

        private void frmVistaProveedor_Ingreso_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }
        //metodo mosrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NProveedor.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            //Metodo BuscarNombre
        }
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = NProveedor.BuscarRazon_social(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = NProveedor.BuscarNum_documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Razon Social"))
            {
                this.BuscarRazon_Social();
            }
            else if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmIngreso form = FrmIngreso.GetInstancia();
            string par1, par2;
            par1=Convert.ToString(this.dataListado.CurrentRow
            .Cells["idproveedor"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow
            .Cells["razon_social"].Value);
            form.setProveedor(par1, par2);
            this.Hide();
        }
    }
}
