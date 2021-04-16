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
    public partial class FrmIngreso : Form
    {
        public int Idtrabajador;
        private bool IsNuevo;
        private DataTable dtDetalle;
        private static FrmIngreso _instancia;
        private decimal totalPagado = 0;

        public static FrmIngreso GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmIngreso();
            }
            return _instancia;

        }
        public FrmIngreso()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtproveedor, "Seleccione el proveedor");
            this.ttMensaje.SetToolTip(this.txtSerie, "Seleccione serie del comprobante");
            this.ttMensaje.SetToolTip(this.txtCorrelativo, "Seleccione el numero de comprobante");
            this.ttMensaje.SetToolTip(this.txtstock, "Seleccione cantidad de compra");
            this.ttMensaje.SetToolTip(this.txtArticulo, "Seleccione el Articulo de compra");
            this.txtidproveedor.Visible = false;
            this.txtIdarticulo.Visible = false;
            this.txtproveedor.ReadOnly = true;
            this.txtArticulo.ReadOnly = true;
        }
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
            this.txtidingreso.Text = string.Empty;
            this.txtidproveedor.Text = string.Empty;
            this.txtproveedor.Text = string.Empty;
            this.txtSerie.Text = string.Empty;
            this.txtCorrelativo.Text = string.Empty;
            this.txtIGV.Text = string.Empty;
            this.lbtlTotalPagado.Text = "0,0";
            this.txtIGV.Text = "18";
            this.crearTabla();

        }
        private void limpiarDetalle()
        {
            this.txtIdarticulo.Text = string.Empty;
            this.txtArticulo.Text = string.Empty;
            this.txtstock.Text = string.Empty;
            this.txtprecio_compra.Text = string.Empty;
            this.txtprecio_venta.Text = string.Empty;
        }

        //habilitar controles
        private void Habilitar(bool valor)
        {
            this.txtidingreso.ReadOnly = !valor;
            this.txtSerie.ReadOnly = !valor;
            this.txtCorrelativo.ReadOnly = !valor;
            this.txtIGV.ReadOnly = !valor;
            this.dtfecha.Enabled = valor;
            this.cbtipo_comprobante.Enabled = valor;
            this.txtstock.ReadOnly = !valor;
            this.txtprecio_compra.ReadOnly = !valor;
            this.txtprecio_venta.ReadOnly = !valor;
            this.btFecha_prod.Enabled = valor;
            this.dtfecha_venc.Enabled = valor;
            this.btnBuscarArticulo.Enabled = valor;
            this.btnBuscarProveedor.Enabled = valor;
            this.btnAgregar.Enabled = valor;
            this.btnQuitar.Enabled = valor;

        }
        //habilitar botones
        private void Botones()
        {
            if (this.IsNuevo)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;

                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;

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
            this.dataListado.DataSource = NIngreso.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            //Metodo BuscarNombre
        }
        private void BuscarFechas()
        {
            this.dataListado.DataSource = NIngreso.BuscarFechas(this.fechaInicio.Value.ToString("dd/mm/yyyy"), this.dtfecha2.Value.ToString("dd/mm/yyyy"));
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void MostrarDetalle()
        {
            this.datalistadDetalle.DataSource = NIngreso.MostrarDetalle(this.txtidingreso.Text);

        }

        private void fechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVistaArticulo_Ingreso vista = new FrmVistaArticulo_Ingreso();
            vista.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.crearTabla();

        }

        public void setProveedor(string idproveedor, string nombrep)
        {
            this.txtidproveedor.Text = idproveedor;
            this.txtproveedor.Text = nombrep;
        }

        public void setArticulo(string idarticulo, string nombre)
        {
            this.txtIdarticulo.Text = idarticulo;
            this.txtArticulo.Text = nombre;
        }
        private void FrmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmVistaProveedor_Ingreso vista = new frmVistaProveedor_Ingreso();
            vista.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Anular los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NIngreso.Anular(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anuló Correctamente el Ingreso");
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

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chcEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chcEliminar.Value = !Convert.ToBoolean(chcEliminar.Value);
            }
        }
        private void crearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("precio_compra", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("stock_inicial", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("fecha_produccion", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("fecha_vencimiento", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));

            this.datalistadDetalle.DataSource = this.dtDetalle;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;

            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtSerie.Focus();
            this.limpiarDetalle();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.limpiarDetalle();
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtidproveedor.Text == string.Empty || this.txtSerie.Text == string.Empty || this.txtCorrelativo.Text == string.Empty || this.txtIGV.Text == string.Empty)
                {
                    MensajeError("Incorrectos datos, ingresar bien");
                    errorIcono.SetError(txtidproveedor, "Ingrese un Valor");
                    errorIcono.SetError(txtSerie, "Ingrese un Valor");
                    errorIcono.SetError(txtCorrelativo, "Ingrese un Valor");
                    errorIcono.SetError(txtIGV, "Ingrese un Valor");
                }
                else
                {
                    
                    {
                        rpta = NIngreso.Insertar(Idtrabajador,Convert.ToInt32
                            ( this.txtidproveedor.Text),dtfecha.Value,cbtipo_comprobante.Text,
                            txtSerie.Text,txtCorrelativo.Text,Convert.ToDecimal(txtIGV.Text),"Emitido",dtDetalle);

                    }
                   
                }

                if (rpta.Equals("OK"))
                {


                    if (this.IsNuevo)
                    {
                        this.MensajeOk("Se ingreso correctamente.");
                    }
                    
                }

                else
                {
                    this.MensajeError(rpta);
                }
                this.IsNuevo = false;
                this.limpiarDetalle();
                this.Botones();
                this.Limpiar();
                this.Mostrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtIdarticulo.Text == string.Empty || this.txtstock.Text == string.Empty || this.txtprecio_compra.Text == string.Empty || this.txtprecio_venta.Text == string.Empty)
                {
                    MensajeError("Incorrectos datos, ingresar bien");
                    errorIcono.SetError(txtIdarticulo, "Ingrese un Valor");
                    errorIcono.SetError(txtstock, "Ingrese un Valor");
                    errorIcono.SetError(txtprecio_compra, "Ingrese un Valor");
                    errorIcono.SetError(txtprecio_venta, "Ingrese un Valor");
                }
                else
                {



                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["idarticulo"]) == Convert.ToInt32(this.txtIdarticulo.Text))
                        {
                            registrar = false;
                            this.MensajeError("Ya esta ingresado este articulo");
                        }
                    }
                    if (registrar)
                    {
                        decimal subTotal = Convert.ToDecimal(this.txtstock.Text) * Convert.ToDecimal(this.txtprecio_compra.Text);
                        totalPagado = totalPagado + subTotal;
                        this.lbtlTotalPagado.Text = totalPagado.ToString("#0.00#");

                        DataRow row = this.dtDetalle.NewRow();
                        row["idarticulo"] = Convert.ToInt32(this.txtIdarticulo.Text);
                        row["articulo"] = this.txtArticulo.Text;
                        row["precio_compra"] = Convert.ToDecimal(this.txtprecio_compra.Text);
                        row["precio_venta"] = Convert.ToDecimal(this.txtprecio_venta.Text);
                        row["stock_inicial"] = Convert.ToInt32(this.txtstock.Text);
                        row["fecha_produccion"] = btFecha_prod.Value;
                        row["fecha_vencimiento"] = dtfecha_venc.Value;
                        row["subtotal"] = subTotal;
                        this.dtDetalle.Rows.Add(row);
                        this.limpiarDetalle();

                    }

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = this.datalistadDetalle.CurrentCell.RowIndex;
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuir el totalPagado
                this.totalPagado = this.totalPagado - Convert.ToDecimal(row["subtotal"].ToString());
                this.lbtlTotalPagado.Text = totalPagado.ToString("#0.00#");
                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }

        private void lbtlTotalPagado_Click(object sender, EventArgs e)
        {

        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtidingreso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idingreso"].Value);
            this.txtproveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["proveedor"].Value);
            this.dtfecha.Value= Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha"].Value);
            this.cbtipo_comprobante.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_comprobante"].Value);
            this.txtSerie.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["serie"].Value);
            this.txtCorrelativo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correlativo"].Value);
            this.lbtlTotalPagado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["total"].Value);
            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}

