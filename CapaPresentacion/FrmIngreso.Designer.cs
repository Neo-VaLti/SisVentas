namespace CapaPresentacion
{
    partial class FrmIngreso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtlTotalPagado = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.datalistadDetalle = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtprecio_venta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.txtprecio_compra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtfecha_venc = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.btFecha_prod = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.txtIdarticulo = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtipo_comprobante = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtidingreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtfecha2 = new System.Windows.Forms.DateTimePicker();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chcEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadDetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // txtproveedor
            // 
            this.txtproveedor.BackColor = System.Drawing.Color.Gold;
            this.txtproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproveedor.Location = new System.Drawing.Point(400, 104);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(160, 26);
            this.txtproveedor.TabIndex = 15;
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.BackColor = System.Drawing.Color.Gold;
            this.txtidproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidproveedor.Location = new System.Drawing.Point(436, 60);
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(124, 26);
            this.txtidproveedor.TabIndex = 14;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(583, 100);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(79, 38);
            this.btnBuscarProveedor.TabIndex = 13;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingresos Almacen";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(731, 107);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(58, 18);
            this.Fecha.TabIndex = 17;
            this.Fecha.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Proveedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtlTotalPagado);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.datalistadDetalle);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtIdarticulo);
            this.groupBox1.Controls.Add(this.txtIGV);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCorrelativo);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbtipo_comprobante);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtfecha);
            this.groupBox1.Controls.Add(this.Fecha);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtproveedor);
            this.groupBox1.Controls.Add(this.txtidproveedor);
            this.groupBox1.Controls.Add(this.btnBuscarProveedor);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtidingreso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, -41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 562);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos Almacen";
            // 
            // lbtlTotalPagado
            // 
            this.lbtlTotalPagado.AutoSize = true;
            this.lbtlTotalPagado.Location = new System.Drawing.Point(182, 420);
            this.lbtlTotalPagado.Name = "lbtlTotalPagado";
            this.lbtlTotalPagado.Size = new System.Drawing.Size(33, 18);
            this.lbtlTotalPagado.TabIndex = 38;
            this.lbtlTotalPagado.Text = "0.0";
            this.lbtlTotalPagado.Click += new System.EventHandler(this.lbtlTotalPagado_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 420);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 18);
            this.label16.TabIndex = 37;
            this.label16.Text = "Total Pagado $";
            // 
            // datalistadDetalle
            // 
            this.datalistadDetalle.AllowUserToAddRows = false;
            this.datalistadDetalle.AllowUserToDeleteRows = false;
            this.datalistadDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistadDetalle.Location = new System.Drawing.Point(25, 317);
            this.datalistadDetalle.Name = "datalistadDetalle";
            this.datalistadDetalle.Size = new System.Drawing.Size(987, 79);
            this.datalistadDetalle.TabIndex = 36;
            this.datalistadDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtprecio_venta);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.txtprecio_compra);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtfecha_venc);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtstock);
            this.groupBox2.Controls.Add(this.btFecha_prod);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtArticulo);
            this.groupBox2.Controls.Add(this.btnBuscarArticulo);
            this.groupBox2.Location = new System.Drawing.Point(25, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(987, 100);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 18);
            this.label13.TabIndex = 37;
            this.label13.Text = "Precio Venta";
            // 
            // txtprecio_venta
            // 
            this.txtprecio_venta.BackColor = System.Drawing.Color.Gold;
            this.txtprecio_venta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecio_venta.Location = new System.Drawing.Point(492, 61);
            this.txtprecio_venta.Name = "txtprecio_venta";
            this.txtprecio_venta.Size = new System.Drawing.Size(132, 26);
            this.txtprecio_venta.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "Precio Compra";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuitar.Location = new System.Drawing.Point(919, 54);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(43, 25);
            this.btnQuitar.TabIndex = 35;
            this.btnQuitar.Text = "-";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtprecio_compra
            // 
            this.txtprecio_compra.BackColor = System.Drawing.Color.Gold;
            this.txtprecio_compra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprecio_compra.Location = new System.Drawing.Point(492, 29);
            this.txtprecio_compra.Name = "txtprecio_compra";
            this.txtprecio_compra.Size = new System.Drawing.Size(132, 26);
            this.txtprecio_compra.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Stock Inicial";
            // 
            // dtfecha_venc
            // 
            this.dtfecha_venc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha_venc.Location = new System.Drawing.Point(761, 59);
            this.dtfecha_venc.Name = "dtfecha_venc";
            this.dtfecha_venc.Size = new System.Drawing.Size(152, 26);
            this.dtfecha_venc.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(658, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 18);
            this.label15.TabIndex = 32;
            this.label15.Text = "Fecha vencimiento";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.Color.Gold;
            this.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstock.Location = new System.Drawing.Point(119, 63);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(160, 26);
            this.txtstock.TabIndex = 4;
            // 
            // btFecha_prod
            // 
            this.btFecha_prod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btFecha_prod.Location = new System.Drawing.Point(761, 22);
            this.btFecha_prod.Name = "btFecha_prod";
            this.btFecha_prod.Size = new System.Drawing.Size(152, 26);
            this.btFecha_prod.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Articulo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(658, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 18);
            this.label14.TabIndex = 30;
            this.label14.Text = "Fecha Prod";
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.Gold;
            this.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArticulo.Location = new System.Drawing.Point(119, 29);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(160, 26);
            this.txtArticulo.TabIndex = 10;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(283, 28);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(79, 27);
            this.btnBuscarArticulo.TabIndex = 28;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = false;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdarticulo
            // 
            this.txtIdarticulo.BackColor = System.Drawing.Color.Gold;
            this.txtIdarticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdarticulo.Location = new System.Drawing.Point(120, 179);
            this.txtIdarticulo.Name = "txtIdarticulo";
            this.txtIdarticulo.Size = new System.Drawing.Size(43, 26);
            this.txtIdarticulo.TabIndex = 29;
            // 
            // txtIGV
            // 
            this.txtIGV.BackColor = System.Drawing.Color.Gold;
            this.txtIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIGV.Location = new System.Drawing.Point(786, 155);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(65, 26);
            this.txtIGV.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(755, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 18);
            this.label11.TabIndex = 25;
            this.label11.Text = "iva";
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.BackColor = System.Drawing.Color.Gold;
            this.txtCorrelativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorrelativo.Location = new System.Drawing.Point(462, 159);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(98, 26);
            this.txtCorrelativo.TabIndex = 2;
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.Gold;
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.Location = new System.Drawing.Point(400, 159);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(40, 26);
            this.txtSerie.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Numero";
            // 
            // cbtipo_comprobante
            // 
            this.cbtipo_comprobante.FormattingEnabled = true;
            this.cbtipo_comprobante.Items.AddRange(new object[] {
            "TICKET",
            "BOLETA",
            "FACTURA",
            "GUIA REMISION"});
            this.cbtipo_comprobante.Location = new System.Drawing.Point(120, 130);
            this.cbtipo_comprobante.Name = "cbtipo_comprobante";
            this.cbtipo_comprobante.Size = new System.Drawing.Size(121, 26);
            this.cbtipo_comprobante.TabIndex = 21;
            this.cbtipo_comprobante.Text = "TICKET";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Comprobante";
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(799, 100);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(200, 26);
            this.dtfecha.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(889, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 55);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(747, 402);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 55);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(583, 402);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(149, 55);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtidingreso
            // 
            this.txtidingreso.BackColor = System.Drawing.Color.Gold;
            this.txtidingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidingreso.Location = new System.Drawing.Point(104, 60);
            this.txtidingreso.Name = "txtidingreso";
            this.txtidingreso.Size = new System.Drawing.Size(119, 26);
            this.txtidingreso.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 595);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.fechaInicio);
            this.tabPage1.Controls.Add(this.dtfecha2);
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.chcEliminar);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fecha fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha Inicio";
            // 
            // fechaInicio
            // 
            this.fechaInicio.Location = new System.Drawing.Point(147, 1);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(316, 26);
            this.fechaInicio.TabIndex = 12;
            this.fechaInicio.ValueChanged += new System.EventHandler(this.fechaInicio_ValueChanged);
            // 
            // dtfecha2
            // 
            this.dtfecha2.Location = new System.Drawing.Point(623, 1);
            this.dtfecha2.Name = "dtfecha2";
            this.dtfecha2.Size = new System.Drawing.Size(318, 26);
            this.dtfecha2.TabIndex = 8;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Location = new System.Drawing.Point(6, 113);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(1301, 206);
            this.dataListado.TabIndex = 7;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(260, 81);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 18);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "lbl";
            // 
            // chcEliminar
            // 
            this.chcEliminar.AutoSize = true;
            this.chcEliminar.Location = new System.Drawing.Point(36, 81);
            this.chcEliminar.Name = "chcEliminar";
            this.chcEliminar.Size = new System.Drawing.Size(91, 22);
            this.chcEliminar.TabIndex = 5;
            this.chcEliminar.Text = "Eliminar";
            this.chcEliminar.UseVisualStyleBackColor = true;
            this.chcEliminar.CheckedChanged += new System.EventHandler(this.chcEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(815, 68);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(126, 31);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(670, 68);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 31);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(522, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(132, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(712, 26);
            this.txtBuscar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lime;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.Location = new System.Drawing.Point(919, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(43, 25);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "+";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmIngreso";
            this.Text = "Mantenimiento de Ingresos de Almacen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIngreso_FormClosing);
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistadDetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtidingreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.DateTimePicker dtfecha2;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chcEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbtipo_comprobante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdarticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtfecha_venc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker btFecha_prod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtprecio_venta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtprecio_compra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.DataGridView datalistadDetalle;
        private System.Windows.Forms.Label lbtlTotalPagado;
        private System.Windows.Forms.Label label16;
    }
}