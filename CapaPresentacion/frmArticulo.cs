using CapaNegocio;
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
    public partial class frmArticulo : Form
    {
        private bool IsNuevo = false;
        private bool isEditar = false;

        private static frmArticulo _Instancia;
        public static frmArticulo GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmArticulo();
            }
            return _Instancia;
        }
        public void setCategoria(string idcategoria,string nombre)
        {
            this.txtidcategoria.Text = idcategoria;
            this.txtcategoria.Text = nombre;
        }

        public frmArticulo()
        {

            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "El nombre de la Articulo");
            this.ttMensaje.SetToolTip(this.pxImagen, "El nombre de la Imagen");
            this.ttMensaje.SetToolTip(this.txtcategoria, "El nombre de la categoria");
            this.ttMensaje.SetToolTip(this.cbidpresentacion, "El nombre de la presentacion");

            this.txtidarticulo.Visible = true;
            this.txtcategoria.ReadOnly = true;
            
            this.LlenarComboPresentacion();
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
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtidcategoria.Text = string.Empty;
            this.txtcategoria.Text = string.Empty;
            this.txtidarticulo.Text = string.Empty;
            this.pxImagen.Image = null;

        }

        //habilitar controles
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.btnBuscarCategoria.Enabled = valor;
            this.cbidpresentacion.Enabled = valor;
            this.btnCargar.Enabled = valor;
            this.btnLimpiar.Enabled = valor;
            this.txtidarticulo.ReadOnly = !valor;

        }
        //habilitar botones
        private void Botones()
        {
            if (this.IsNuevo || this.isEditar)
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
            this.dataListado.Columns[6].Visible = false;
            this.dataListado.Columns[8].Visible = false;
        }
        //metodo mosrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NArticulo.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            //Metodo BuscarNombre
        }
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NArticulo.BuscarNombre(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void LlenarComboPresentacion()
        {
            cbidpresentacion.DataSource = NPresentacion.Mostrar();
            cbidpresentacion.ValueMember = "idpresentacion";
            cbidpresentacion.DisplayMember = "nombre";


        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.isEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.isEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtidcategoria.Text == string.Empty || this.txtCodigo.Text == string.Empty)
                {
                    MensajeError("Incorrectos datos, ingresar bien");
                    errorIcono.SetError(txtNombre, "Ingrese un Valor");
                    errorIcono.SetError(txtcategoria, "Ingrese un Valor");
                    errorIcono.SetError(txtCodigo, "Ingrese un Valor");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagen = ms.GetBuffer();
                    if (this.IsNuevo)
                    {
                        rpta = NArticulo.Insertar(this.txtCodigo.Text, this.txtNombre.Text.Trim().ToUpper(), this.txtDescripcion.Text.Trim()
                          , imagen, Convert.ToInt32(this.txtidcategoria.Text), Convert.ToInt32(this.cbidpresentacion.SelectedValue));

                    }
                    else
                    {

                        rpta = NArticulo.Editar(Convert.ToInt32(this.txtidarticulo.Text), this.txtCodigo.Text, this.txtNombre.Text.Trim().ToUpper(), this.txtDescripcion.Text.Trim()
                          , imagen, Convert.ToInt32(this.txtidcategoria.Text), Convert.ToInt32(this.cbidpresentacion.SelectedValue));
                            
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
                this.isEditar = false;
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
            if (!this.txtidarticulo.Text.Equals(""))
            {
                this.isEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar el primer registro a Modificar");
            }
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
            this.txtidarticulo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idarticulo"].Value);
            this.txtCodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["codigo"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);
            byte[] imagenBuffer =(byte[]) this.dataListado.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            this.pxImagen.Image = Image.FromStream(ms);
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.txtidcategoria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcategoria"].Value);
            this.txtcategoria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Categoria"].Value);
            this.cbidpresentacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpresentacion"].Value);

            this.tabControl1.SelectedIndex = 1;
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
                            Rpta = NArticulo.Eliminar(Convert.ToInt32(Codigo));
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

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            frmVistaCategoria_Articulo form = new frmVistaCategoria_Articulo();
            form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtidarticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
           // FrmReporteArticulos frm = new FrmReporteArticulos();
            //frm.Texto = txtBuscar.Text;
           // frm.ShowDialog();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
