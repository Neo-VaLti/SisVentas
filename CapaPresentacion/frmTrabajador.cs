﻿using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmTrabajador : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public frmTrabajador()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtnombre,"Ingrese nombre del trabajador");
            this.ttMensaje.SetToolTip(this.txtApellido, "Ingrese apellido del trabajador");
            this.ttMensaje.SetToolTip(this.txtUsuario, "Ingrese nombre del trabajador");
            this.ttMensaje.SetToolTip(this.txtPassword, "Ingrese Pasword del trabajador");
            this.ttMensaje.SetToolTip(this.cbAcceso, "ingrese acceso de trabajador");

        }

        private void frmTrabajador_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        //confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas ledezma", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas ledezma", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Limpiar controles
        private void Limpiar()
        {
            this.txtnombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtNumDocument.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtidtrabajador.Text = string.Empty;


                


        }

        //habilitar controles
        private void Habilitar(bool valor)
        {
            this.txtnombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.cbsexo.Enabled = valor;

            this.txtNumDocument.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.cbAcceso.Enabled = valor;
            this.txtEmail.ReadOnly = !valor;
            this.txtUsuario.ReadOnly = !valor;
            this.txtPassword.ReadOnly = !valor;
            this.txtidtrabajador.ReadOnly = !valor;

        }
        //habilitar botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;

            }
        }
        //ocultar columns
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }
        //metodo mosrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NTrabajador.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            //Metodo BuscarNombre
        }
        private void BuscarApellidos()
        {
            this.dataListado.DataSource = NTrabajador.BuscarApellidos(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = NTrabajador.BuscarNum_documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }



        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Apellidos"))
            {
                this.BuscarApellidos();
            }
            else if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }





        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
        }

       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
            else if (cbBuscar.Text.Equals("Apellidos"))
            {
                this.BuscarApellidos();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Eliminar Registros", "Sistema de Ventas Ledezma", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NTrabajador.Eliminar(Convert.ToInt32(Codigo));
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }

                    }
                    this.Mostrar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void chcEliminar_CheckedChanged_1(object sender, EventArgs e)
        {
           
                if (chcEliminar.Checked)
                {
                    this.dataListado.Columns[0].Visible = true;
                }
                else
                {
                    this.dataListado.Columns[0].Visible = false;
                }
            }

        private void dataListado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
       
            {
                if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
                {
                    DataGridViewCheckBoxCell chcEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                    chcEliminar.Value = !Convert.ToBoolean(chcEliminar.Value);
                }
            }

        private void dataListado_DoubleClick_1(object sender, EventArgs e)
        {
           
                this.txtidtrabajador.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idtrabajador"].Value);
                this.txtnombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
                this.txtApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidos"].Value);
                this.cbsexo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sexo"].Value);
                this.dtFechaNac.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_nac"].Value);
               
                this.txtNumDocument.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_documento"].Value);
                this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
                this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
                this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.cbAcceso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["acceso"].Value);
            this.txtUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["usuario"].Value);
            this.txtPassword.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["password"].Value);

            this.tabControl1.SelectedIndex = 1;
            }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            
                this.IsNuevo = true;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.Habilitar(true);
                this.txtnombre.Focus();
            }

        
            private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.txtidtrabajador.Text = string.Empty;
            }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (!this.txtidtrabajador.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar el primer registro a Modificar");
            }
        }

        private void btnCancelar_Click_2(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtidtrabajador.Text = string.Empty;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtnombre.Text == string.Empty || this.txtNumDocument.Text == string.Empty ||
                    this.txtApellido.Text == string.Empty || this.txtDireccion.Text == string.Empty ||
                    this.txtUsuario.Text == string.Empty || this.txtPassword.Text == string.Empty)
                {
                    MensajeError("Incorrectos datos, ingresar bien");
                    errorIcono.SetError(txtnombre, "Ingrese un Valor");
                    errorIcono.SetError(txtApellido, "Ingrese un Valor");
                    errorIcono.SetError(txtNumDocument, "Ingrese un Valor");
                    errorIcono.SetError(txtDireccion, "Ingrese un Valor");
                    errorIcono.SetError(txtPassword, "Ingrese un Valor");
                    errorIcono.SetError(txtUsuario, "Ingrese un Valor");

                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NTrabajador.Insertar(this.txtnombre.Text.Trim().ToUpper(), this.txtApellido.Text.Trim().ToUpper(), this.cbsexo.Text, dtFechaNac.Value,
                          
                            txtNumDocument.Text, txtDireccion.Text, txtTelefono.Text,
                            txtEmail.Text,this.cbAcceso.Text,this.txtUsuario.Text,this.txtPassword.Text)
;
                    }
                    else
                    {

                        rpta = NTrabajador.Editar(Convert.ToInt32(this.txtidtrabajador.Text), this.txtnombre.Text.Trim().ToUpper(), this.txtApellido.Text.Trim().ToUpper(), this.cbsexo.Text, dtFechaNac.Value,
                            txtNumDocument.Text, txtDireccion.Text, txtTelefono.Text,
                            txtEmail.Text,this.cbAcceso.Text, this.txtUsuario.Text, this.txtPassword.Text);

                    }
                }

                if (rpta.Equals("OK"))
                {


                    if (this.IsNuevo)
                    {
                        this.MensajeOk("Se ingreso correctamente.");
                    }
                    else
                    {
                        this.MensajeOk("Se actualizo.");
                    }
                }

                else
                {
                    this.MensajeError(rpta);
                }
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.Mostrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        
    }
    }
    }
    


