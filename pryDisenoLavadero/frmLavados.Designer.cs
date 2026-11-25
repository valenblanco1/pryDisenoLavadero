namespace pryDisenoLavadero
{
    partial class frmLavados
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
            gplavados = new GroupBox();
            btnregistrar = new Button();
            btnlimpiar = new Button();
            btncalcular = new Button();
            chkcliente = new CheckBox();
            gbentrega = new GroupBox();
            chkexpress = new CheckBox();
            chknormal = new CheckBox();
            cmbovehiculos = new ComboBox();
            lblvehiculos = new Label();
            txtpatente = new TextBox();
            txtcliente = new TextBox();
            cmboservicio = new ComboBox();
            lblservicio = new Label();
            lblpatente = new Label();
            lblcliente = new Label();
            gpimporte = new GroupBox();
            txttotalpagar = new TextBox();
            txtdescuento = new TextBox();
            txtrecargo = new TextBox();
            txtsubtotal = new TextBox();
            lbltotal = new Label();
            lbldescuento = new Label();
            lblrecargo = new Label();
            lblsubtotal = new Label();
            gpresumen = new GroupBox();
            txtrecaudacion = new TextBox();
            txtlavadosdia = new TextBox();
            lblrecaudacion = new Label();
            lbllavados = new Label();
            gplavados.SuspendLayout();
            gbentrega.SuspendLayout();
            gpimporte.SuspendLayout();
            gpresumen.SuspendLayout();
            SuspendLayout();
            // 
            // gplavados
            // 
            gplavados.Controls.Add(btnregistrar);
            gplavados.Controls.Add(btnlimpiar);
            gplavados.Controls.Add(btncalcular);
            gplavados.Controls.Add(chkcliente);
            gplavados.Controls.Add(gbentrega);
            gplavados.Controls.Add(cmbovehiculos);
            gplavados.Controls.Add(lblvehiculos);
            gplavados.Controls.Add(txtpatente);
            gplavados.Controls.Add(txtcliente);
            gplavados.Controls.Add(cmboservicio);
            gplavados.Controls.Add(lblservicio);
            gplavados.Controls.Add(lblpatente);
            gplavados.Controls.Add(lblcliente);
            gplavados.Location = new Point(12, 12);
            gplavados.Name = "gplavados";
            gplavados.Size = new Size(399, 395);
            gplavados.TabIndex = 0;
            gplavados.TabStop = false;
            gplavados.Text = "Datos del Lavado";
            // 
            // btnregistrar
            // 
            btnregistrar.Location = new Point(22, 349);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(106, 28);
            btnregistrar.TabIndex = 12;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = true;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(278, 349);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(115, 28);
            btnlimpiar.TabIndex = 11;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(149, 349);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(105, 28);
            btncalcular.TabIndex = 10;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // chkcliente
            // 
            chkcliente.AutoSize = true;
            chkcliente.Location = new Point(22, 299);
            chkcliente.Name = "chkcliente";
            chkcliente.Size = new Size(204, 19);
            chkcliente.TabIndex = 9;
            chkcliente.Text = "Cliente Frecuente (5% Descuento)";
            chkcliente.UseVisualStyleBackColor = true;
            // 
            // gbentrega
            // 
            gbentrega.Controls.Add(chkexpress);
            gbentrega.Controls.Add(chknormal);
            gbentrega.Location = new Point(16, 213);
            gbentrega.Name = "gbentrega";
            gbentrega.Size = new Size(358, 69);
            gbentrega.TabIndex = 8;
            gbentrega.TabStop = false;
            gbentrega.Text = "Entrega";
            // 
            // chkexpress
            // 
            chkexpress.AutoSize = true;
            chkexpress.Location = new Point(185, 33);
            chkexpress.Name = "chkexpress";
            chkexpress.Size = new Size(108, 19);
            chkexpress.TabIndex = 1;
            chkexpress.Text = "Express (+25 %)";
            chkexpress.UseVisualStyleBackColor = true;
            chkexpress.CheckedChanged += chkexpress_CheckedChanged;
            // 
            // chknormal
            // 
            chknormal.AutoSize = true;
            chknormal.Location = new Point(29, 33);
            chknormal.Name = "chknormal";
            chknormal.Size = new Size(66, 19);
            chknormal.TabIndex = 0;
            chknormal.Text = "Normal";
            chknormal.UseVisualStyleBackColor = true;
            chknormal.CheckedChanged += chknormal_CheckedChanged;
            // 
            // cmbovehiculos
            // 
            cmbovehiculos.FormattingEnabled = true;
            cmbovehiculos.Location = new Point(117, 144);
            cmbovehiculos.Name = "cmbovehiculos";
            cmbovehiculos.Size = new Size(42, 23);
            cmbovehiculos.TabIndex = 7;
            // 
            // lblvehiculos
            // 
            lblvehiculos.AutoSize = true;
            lblvehiculos.Location = new Point(16, 147);
            lblvehiculos.Name = "lblvehiculos";
            lblvehiculos.Size = new Size(95, 15);
            lblvehiculos.TabIndex = 6;
            lblvehiculos.Text = "Vehiculos (1 a 5):";
            // 
            // txtpatente
            // 
            txtpatente.Location = new Point(93, 61);
            txtpatente.Name = "txtpatente";
            txtpatente.Size = new Size(100, 23);
            txtpatente.TabIndex = 5;
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(93, 25);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(185, 23);
            txtcliente.TabIndex = 4;
            // 
            // cmboservicio
            // 
            cmboservicio.FormattingEnabled = true;
            cmboservicio.Location = new Point(93, 95);
            cmboservicio.Name = "cmboservicio";
            cmboservicio.Size = new Size(121, 23);
            cmboservicio.TabIndex = 3;
            cmboservicio.SelectedIndexChanged += cmboservicio_SelectedIndexChanged;
            // 
            // lblservicio
            // 
            lblservicio.AutoSize = true;
            lblservicio.Location = new Point(16, 98);
            lblservicio.Name = "lblservicio";
            lblservicio.Size = new Size(51, 15);
            lblservicio.TabIndex = 2;
            lblservicio.Text = "Servicio:";
            // 
            // lblpatente
            // 
            lblpatente.AutoSize = true;
            lblpatente.Location = new Point(16, 66);
            lblpatente.Name = "lblpatente";
            lblpatente.Size = new Size(50, 15);
            lblpatente.TabIndex = 1;
            lblpatente.Text = "Patente:";
            // 
            // lblcliente
            // 
            lblcliente.AutoSize = true;
            lblcliente.Location = new Point(16, 28);
            lblcliente.Name = "lblcliente";
            lblcliente.Size = new Size(47, 15);
            lblcliente.TabIndex = 0;
            lblcliente.Text = "Cliente:";
            // 
            // gpimporte
            // 
            gpimporte.Controls.Add(txttotalpagar);
            gpimporte.Controls.Add(txtdescuento);
            gpimporte.Controls.Add(txtrecargo);
            gpimporte.Controls.Add(txtsubtotal);
            gpimporte.Controls.Add(lbltotal);
            gpimporte.Controls.Add(lbldescuento);
            gpimporte.Controls.Add(lblrecargo);
            gpimporte.Controls.Add(lblsubtotal);
            gpimporte.Location = new Point(12, 440);
            gpimporte.Name = "gpimporte";
            gpimporte.Size = new Size(254, 156);
            gpimporte.TabIndex = 1;
            gpimporte.TabStop = false;
            gpimporte.Text = "Importe";
            // 
            // txttotalpagar
            // 
            txttotalpagar.Location = new Point(139, 120);
            txttotalpagar.Name = "txttotalpagar";
            txttotalpagar.Size = new Size(100, 23);
            txttotalpagar.TabIndex = 7;
            // 
            // txtdescuento
            // 
            txtdescuento.Location = new Point(139, 88);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.Size = new Size(100, 23);
            txtdescuento.TabIndex = 6;
            // 
            // txtrecargo
            // 
            txtrecargo.Location = new Point(139, 54);
            txtrecargo.Name = "txtrecargo";
            txtrecargo.Size = new Size(100, 23);
            txtrecargo.TabIndex = 5;
            // 
            // txtsubtotal
            // 
            txtsubtotal.Location = new Point(139, 25);
            txtsubtotal.Name = "txtsubtotal";
            txtsubtotal.Size = new Size(100, 23);
            txtsubtotal.TabIndex = 4;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(29, 123);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(78, 15);
            lbltotal.TabIndex = 3;
            lbltotal.Text = "Total a pagar:";
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.Location = new Point(29, 91);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(66, 15);
            lbldescuento.TabIndex = 2;
            lbldescuento.Text = "Descuento:";
            // 
            // lblrecargo
            // 
            lblrecargo.AutoSize = true;
            lblrecargo.Location = new Point(29, 57);
            lblrecargo.Name = "lblrecargo";
            lblrecargo.Size = new Size(53, 15);
            lblrecargo.TabIndex = 1;
            lblrecargo.Text = "Recargo:";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(28, 28);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(54, 15);
            lblsubtotal.TabIndex = 0;
            lblsubtotal.Text = "Subtotal:";
            // 
            // gpresumen
            // 
            gpresumen.Controls.Add(txtrecaudacion);
            gpresumen.Controls.Add(txtlavadosdia);
            gpresumen.Controls.Add(lblrecaudacion);
            gpresumen.Controls.Add(lbllavados);
            gpresumen.Location = new Point(305, 451);
            gpresumen.Name = "gpresumen";
            gpresumen.Size = new Size(209, 100);
            gpresumen.TabIndex = 2;
            gpresumen.TabStop = false;
            gpresumen.Text = "Resumen";
            // 
            // txtrecaudacion
            // 
            txtrecaudacion.Location = new Point(115, 61);
            txtrecaudacion.Name = "txtrecaudacion";
            txtrecaudacion.Size = new Size(77, 23);
            txtrecaudacion.TabIndex = 3;
            // 
            // txtlavadosdia
            // 
            txtlavadosdia.Location = new Point(115, 31);
            txtlavadosdia.Name = "txtlavadosdia";
            txtlavadosdia.Size = new Size(49, 23);
            txtlavadosdia.TabIndex = 2;
            // 
            // lblrecaudacion
            // 
            lblrecaudacion.AutoSize = true;
            lblrecaudacion.Location = new Point(9, 61);
            lblrecaudacion.Name = "lblrecaudacion";
            lblrecaudacion.Size = new Size(78, 15);
            lblrecaudacion.TabIndex = 1;
            lblrecaudacion.Text = "Recaudación:";
            // 
            // lbllavados
            // 
            lbllavados.AutoSize = true;
            lbllavados.Location = new Point(9, 34);
            lbllavados.Name = "lbllavados";
            lbllavados.Size = new Size(91, 15);
            lbllavados.TabIndex = 0;
            lbllavados.Text = "Lavados del dìa:";
            // 
            // frmLavados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(523, 608);
            Controls.Add(gpresumen);
            Controls.Add(gpimporte);
            Controls.Add(gplavados);
            Name = "frmLavados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lavadero Los Andes";
            Load += frmLavados_Load;
            gplavados.ResumeLayout(false);
            gplavados.PerformLayout();
            gbentrega.ResumeLayout(false);
            gbentrega.PerformLayout();
            gpimporte.ResumeLayout(false);
            gpimporte.PerformLayout();
            gpresumen.ResumeLayout(false);
            gpresumen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gplavados;
        private Label lblvehiculos;
        private TextBox txtpatente;
        private TextBox txtcliente;
        private ComboBox cmboservicio;
        private Label lblservicio;
        private Label lblpatente;
        private Label lblcliente;
        private GroupBox gbentrega;
        private CheckBox chkexpress;
        private CheckBox chknormal;
        private ComboBox cmbovehiculos;
        private Button btnlimpiar;
        private Button btncalcular;
        private CheckBox chkcliente;
        private GroupBox gpimporte;
        private Label lblsubtotal;
        private Label lbltotal;
        private Label lbldescuento;
        private Label lblrecargo;
        private Button btnregistrar;
        private TextBox txttotalpagar;
        private TextBox txtdescuento;
        private TextBox txtrecargo;
        private TextBox txtsubtotal;
        private GroupBox gpresumen;
        private Label lbllavados;
        private TextBox txtrecaudacion;
        private TextBox txtlavadosdia;
        private Label lblrecaudacion;
    }
}