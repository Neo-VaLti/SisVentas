using System;
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
    public partial class frmProveedor : Form
    {
        private bool IsNuevo=false;
        private bool IsEditar = false;


        public frmProveedor()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtrazon_social, "Ingrese Razon Social del proveedor");
            this.ttMensaje.SetToolTip(this.txtNumDocument, "Ingrese Documento de proveedor");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la direccion del proveedor");
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
            this.txtrazon_social.Text = string.Empty;
            this.txtNumDocument.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtURL.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtproveedor.Text = string.Empty;

        }

        //habilitar controles
        private void Habilitar(bool valor)
        {
            this.txtrazon_social.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.cbSector_Comercial.Enabled = valor;
            this.cbTipo_Documento.Enabled = valor;
            this.txtNumDocument.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtURL.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.txtproveedor.ReadOnly = !valor;

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

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbBuscar.Text.Equals("Razon Social"))
            {
                this.BuscarRazon_Social();
            }
            else if (cbBuscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                            Rpta = NProveedor.Eliminar(Convert.ToInt32(Codigo));
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

        private void chcEliminar_CheckedChanged(object sender, EventArgs e)
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtrazon_social.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtrazon_social.Text == string.Empty || this.txtNumDocument.Text==string.Empty ||
                    this.txtDireccion.Text==string.Empty)
                {
                    MensajeError("Incorrectos datos, ingresar bien");
                    errorIcono.SetError(txtrazon_social, "Ingrese un Valor");
                    errorIcono.SetError(txtNumDocument, "Ingrese un Valor");
                    errorIcono.SetError(txtDireccion, "Ingrese un Valor");

                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NProveedor.Insertar(this.txtrazon_social.Text.Trim().ToUpper(),
                            this.cbSector_Comercial.Text.Trim(), cbTipo_Documento.Text,
                            txtNumDocument.Text, txtDireccion.Text, txtTelefono.Text,
                            txtEmail.Text, txtURL.Text)
;
                    }
                    else
                    {

                        rpta = NProveedor.Editar(Convert.ToInt32(this.txtproveedor.Text), this.txtrazon_social.Text.Trim().ToUpper(),
                            this.cbSector_Comercial.Text.Trim(), cbTipo_Documento.Text,
                            txtNumDocument.Text, txtDireccion.Text, txtTelefono.Text,
                            txtEmail.Text, txtURL.Text);
                            
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtproveedor.Text.Equals(""))
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtproveedor.Text = string.Empty;
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chcEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chcEliminar.Value = !Convert.ToBoolean(chcEliminar.Value);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtproveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idproveedor"].Value);
            this.txtrazon_social.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["razon_social"].Value);
            this.cbSector_Comercial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sector_comercial"].Value);
            this.cbTipo_Documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value);
            this.txtNumDocument.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_documento"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.txtURL.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["url"].Value);

            this.tabControl1.SelectedIndex = 1;
        }
    }
}
