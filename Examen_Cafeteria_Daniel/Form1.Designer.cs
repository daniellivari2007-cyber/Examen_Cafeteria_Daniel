namespace Examen_Cafeteria_Daniel
{
    partial class frmPedidos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCliente = new TextBox();
            dtpFecha = new DateTimePicker();
            chkFrecuente = new CheckBox();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            nudCantidad = new NumericUpDown();
            rbtNormal = new RadioButton();
            rbtGrande = new RadioButton();
            chkPorcionExtra = new CheckBox();
            rbtLocal = new RadioButton();
            rbtLlevar = new RadioButton();
            label2 = new Label();
            lstPedido = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblEncabezado = new Label();
            lblSubtotal = new Button();
            lblDescuento = new Button();
            lblEmpaque = new Button();
            lblItbis = new Button();
            lblTotal = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Clientes:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(70, 9);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 2;
            txtCliente.Text = "Maria Perez";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(70, 69);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 3;
            dtpFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Location = new Point(12, 38);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(116, 19);
            chkFrecuente.TabIndex = 4;
            chkFrecuente.Text = "Cliente frecuente";
            chkFrecuente.UseVisualStyleBackColor = true;
            chkFrecuente.CheckedChanged += chkFrecuente_CheckedChanged;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(70, 98);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(69, 130);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 23);
            txtPrecio.TabIndex = 6;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(69, 167);
            nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 7;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // rbtNormal
            // 
            rbtNormal.AllowDrop = true;
            rbtNormal.AutoSize = true;
            rbtNormal.Location = new Point(6, 23);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.RightToLeft = RightToLeft.No;
            rbtNormal.Size = new Size(65, 19);
            rbtNormal.TabIndex = 8;
            rbtNormal.Text = "Normal";
            rbtNormal.UseMnemonic = false;
            rbtNormal.UseVisualStyleBackColor = false;
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(7, 55);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(109, 19);
            rbtGrande.TabIndex = 9;
            rbtGrande.Text = "Grande (+RD25)";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Location = new Point(5, 307);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(147, 19);
            chkPorcionExtra.TabIndex = 10;
            chkPorcionExtra.Text = "Porcion extra (+RD$30)";
            chkPorcionExtra.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Location = new Point(6, 22);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(121, 19);
            rbtLocal.TabIndex = 11;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "Consumir en local";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(6, 55);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(131, 19);
            rbtLlevar.TabIndex = 12;
            rbtLlevar.TabStop = true;
            rbtLlevar.Text = "Para llevar (+RD$20)";
            rbtLlevar.UseVisualStyleBackColor = true;
            rbtLlevar.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 13;
            label2.Text = "Fecha:";
            label2.Click += label2_Click;
            // 
            // lstPedido
            // 
            lstPedido.FormattingEnabled = true;
            lstPedido.Location = new Point(539, 115);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(249, 109);
            lstPedido.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 101);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 15;
            label3.Text = "Producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 138);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 16;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 169);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 17;
            label5.Text = "Cantidad:";
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(539, 97);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(239, 15);
            lblEncabezado.TabIndex = 18;
            lblEncabezado.Text = "Cant        Producto            Precio             Total";
            lblEncabezado.Click += label6_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(626, 231);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(75, 23);
            lblSubtotal.TabIndex = 20;
            lblSubtotal.Text = "RD$ 560.00";
            lblSubtotal.UseVisualStyleBackColor = true;
            lblSubtotal.Click += lblSubtotal_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(626, 264);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(75, 23);
            lblDescuento.TabIndex = 21;
            lblDescuento.Text = "RD$ 56.00";
            lblDescuento.UseVisualStyleBackColor = true;
            lblDescuento.Click += lblDescuento_Click;
            // 
            // lblEmpaque
            // 
            lblEmpaque.Location = new Point(626, 293);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(75, 23);
            lblEmpaque.TabIndex = 22;
            lblEmpaque.Text = "RD$ 20.00";
            lblEmpaque.UseVisualStyleBackColor = true;
            lblEmpaque.Click += lblEmpaque_Click;
            // 
            // lblItbis
            // 
            lblItbis.Location = new Point(626, 322);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(75, 23);
            lblItbis.TabIndex = 23;
            lblItbis.Text = "RD$ 94.32";
            lblItbis.UseVisualStyleBackColor = true;
            lblItbis.Click += lblItbis_Click;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(626, 369);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(75, 23);
            lblTotal.TabIndex = 24;
            lblTotal.Text = "RD$ 618.32";
            lblTotal.UseVisualStyleBackColor = true;
            lblTotal.Click += lblTotal_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtGrande);
            groupBox1.Controls.Add(rbtNormal);
            groupBox1.Location = new Point(5, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(137, 88);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tamaño";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtLocal);
            groupBox2.Controls.Add(rbtLlevar);
            groupBox2.Location = new Point(148, 213);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(137, 88);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Servicio";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(11, 395);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 43);
            btnCalcular.TabIndex = 27;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(111, 395);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 43);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Nuevo pedidos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(221, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 43);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(539, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(249, 43);
            btnAgregar.TabIndex = 30;
            btnAgregar.Text = "Agregar al pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(557, 239);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 33;
            label10.Text = "Subtotal";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(545, 272);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 34;
            label11.Text = "Descuento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(551, 297);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 35;
            label12.Text = "Empaque";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(539, 326);
            label13.Name = "label13";
            label13.Size = new Size(69, 15);
            label13.TabIndex = 36;
            label13.Text = "ITBIS (18 %)";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(516, 373);
            label14.Name = "label14";
            label14.Size = new Size(92, 15);
            label14.TabIndex = 37;
            label14.Text = "TOTAL A PAGAR";
            // 
            // frmPedidos
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblEmpaque);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(lblEncabezado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstPedido);
            Controls.Add(label2);
            Controls.Add(chkPorcionExtra);
            Controls.Add(nudCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(chkFrecuente);
            Controls.Add(dtpFecha);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "frmPedidos";
            Text = "Cafeteria El Sabor - Pedidos";
            Load += listBox1_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private DateTimePicker dtpFecha;
        private CheckBox chkFrecuente;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private NumericUpDown nudCantidad;
        private RadioButton rbtNormal;
        private RadioButton rbtGrande;
        private CheckBox chkPorcionExtra;
        private RadioButton rbtLocal;
        private RadioButton rbtLlevar;
        private Label label2;
        private ListBox lstPedido;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblEncabezado;
        private Button lblSubtotal;
        private Button lblDescuento;
        private Button lblEmpaque;
        private Button lblItbis;
        private Button lblTotal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAgregar;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}
