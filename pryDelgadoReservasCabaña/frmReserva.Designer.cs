namespace pryDelgadoReservasCabaña
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            lblPersonas = new Label();
            lblDias = new Label();
            lblTipoCabaña = new Label();
            lstTipo = new ComboBox();
            lstPersonas = new ComboBox();
            mskDias = new MaskedTextBox();
            ckbCocina = new CheckBox();
            ckbHeladera = new CheckBox();
            ckbTelevisor = new CheckBox();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            lblTarjetas = new Label();
            lstTarjetas = new ComboBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label2 = new Label();
            mskNumero = new MaskedTextBox();
            cmdReservar = new Button();
            cmdCancelar = new Button();
            lstbResultado = new ListBox();
            gbTipo = new GroupBox();
            groupBox1 = new GroupBox();
            gbFormaPago = new GroupBox();
            groupBox2 = new GroupBox();
            gbFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonas.Location = new Point(300, 64);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(77, 23);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDias.Location = new Point(555, 64);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(42, 23);
            lblDias.TabIndex = 3;
            lblDias.Text = "Días";
            // 
            // lblTipoCabaña
            // 
            lblTipoCabaña.AutoSize = true;
            lblTipoCabaña.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCabaña.Location = new Point(38, 64);
            lblTipoCabaña.Name = "lblTipoCabaña";
            lblTipoCabaña.Size = new Size(43, 23);
            lblTipoCabaña.TabIndex = 4;
            lblTipoCabaña.Text = "Tipo";
            // 
            // lstTipo
            // 
            lstTipo.AutoCompleteCustomSource.AddRange(new string[] { "A" });
            lstTipo.AutoCompleteSource = AutoCompleteSource.FileSystem;
            lstTipo.FormattingEnabled = true;
            lstTipo.Items.AddRange(new object[] { "A", "B" });
            lstTipo.Location = new Point(38, 122);
            lstTipo.Name = "lstTipo";
            lstTipo.Size = new Size(151, 28);
            lstTipo.TabIndex = 5;
            lstTipo.Tag = "";
            lstTipo.SelectedIndexChanged += lstTipo_SelectedIndexChanged;
            // 
            // lstPersonas
            // 
            lstPersonas.FormattingEnabled = true;
            lstPersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            lstPersonas.Location = new Point(300, 123);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(151, 28);
            lstPersonas.TabIndex = 6;
            // 
            // mskDias
            // 
            mskDias.Location = new Point(555, 124);
            mskDias.Mask = "999";
            mskDias.Name = "mskDias";
            mskDias.Size = new Size(125, 27);
            mskDias.TabIndex = 7;
            mskDias.ValidatingType = typeof(int);
            // 
            // ckbCocina
            // 
            ckbCocina.AutoSize = true;
            ckbCocina.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbCocina.Location = new Point(41, 245);
            ckbCocina.Name = "ckbCocina";
            ckbCocina.Size = new Size(84, 27);
            ckbCocina.TabIndex = 10;
            ckbCocina.Text = "Cocina";
            ckbCocina.UseVisualStyleBackColor = true;
            ckbCocina.CheckedChanged += ckbCocina_CheckedChanged;
            // 
            // ckbHeladera
            // 
            ckbHeladera.AutoSize = true;
            ckbHeladera.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbHeladera.Location = new Point(41, 278);
            ckbHeladera.Name = "ckbHeladera";
            ckbHeladera.Size = new Size(100, 27);
            ckbHeladera.TabIndex = 11;
            ckbHeladera.Text = "Heladera";
            ckbHeladera.UseVisualStyleBackColor = true;
            ckbHeladera.CheckedChanged += ckbHeladera_CheckedChanged;
            // 
            // ckbTelevisor
            // 
            ckbTelevisor.AutoSize = true;
            ckbTelevisor.Location = new Point(41, 311);
            ckbTelevisor.Name = "ckbTelevisor";
            ckbTelevisor.Size = new Size(89, 24);
            ckbTelevisor.TabIndex = 12;
            ckbTelevisor.Text = "Televisor";
            ckbTelevisor.UseVisualStyleBackColor = true;
            ckbTelevisor.CheckedChanged += ckbTelevisor_CheckedChanged;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Checked = true;
            rbEfectivo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbEfectivo.Location = new Point(340, 246);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(90, 27);
            rbEfectivo.TabIndex = 13;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            rbEfectivo.CheckedChanged += rbEfectivo_CheckedChanged;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbTarjeta.Location = new Point(340, 279);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(81, 27);
            rbTarjeta.TabIndex = 14;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            rbTarjeta.CheckedChanged += rbTarjeta_CheckedChanged;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTarjetas.Location = new Point(596, 283);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(68, 23);
            lblTarjetas.TabIndex = 15;
            lblTarjetas.Text = "Tarjetas";
            // 
            // lstTarjetas
            // 
            lstTarjetas.Enabled = false;
            lstTarjetas.FormattingEnabled = true;
            lstTarjetas.Items.AddRange(new object[] { "Card Red", "Card Green", "Card Blue" });
            lstTarjetas.Location = new Point(283, 102);
            lstTarjetas.Name = "lstTarjetas";
            lstTarjetas.Size = new Size(151, 31);
            lstTarjetas.TabIndex = 16;
            lstTarjetas.SelectedIndexChanged += lstTarjetas_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 433);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 27);
            txtNombre.TabIndex = 18;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(41, 437);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 23);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 495);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 21;
            label2.Text = "Numero";
            // 
            // mskNumero
            // 
            mskNumero.Location = new Point(149, 492);
            mskNumero.Mask = "(351)000-0000";
            mskNumero.Name = "mskNumero";
            mskNumero.Size = new Size(220, 27);
            mskNumero.TabIndex = 22;
            // 
            // cmdReservar
            // 
            cmdReservar.Enabled = false;
            cmdReservar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdReservar.Location = new Point(552, 522);
            cmdReservar.Name = "cmdReservar";
            cmdReservar.Size = new Size(154, 40);
            cmdReservar.TabIndex = 23;
            cmdReservar.Text = "Reservar";
            cmdReservar.UseVisualStyleBackColor = true;
            cmdReservar.Click += cmdReservar_Click;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(735, 522);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(154, 40);
            cmdCancelar.TabIndex = 24;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lstbResultado
            // 
            lstbResultado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstbResultado.FormattingEnabled = true;
            lstbResultado.ItemHeight = 23;
            lstbResultado.Location = new Point(41, 612);
            lstbResultado.Name = "lstbResultado";
            lstbResultado.Size = new Size(504, 142);
            lstbResultado.TabIndex = 25;
            // 
            // gbTipo
            // 
            gbTipo.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbTipo.Location = new Point(12, 37);
            gbTipo.Name = "gbTipo";
            gbTipo.Size = new Size(821, 156);
            gbTipo.TabIndex = 26;
            gbTipo.TabStop = false;
            gbTipo.Text = "Tipo de Cabaña";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 136);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionales";
            // 
            // gbFormaPago
            // 
            gbFormaPago.Controls.Add(lstTarjetas);
            gbFormaPago.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbFormaPago.Location = new Point(313, 213);
            gbFormaPago.Name = "gbFormaPago";
            gbFormaPago.Size = new Size(520, 136);
            gbFormaPago.TabIndex = 28;
            gbFormaPago.TabStop = false;
            gbFormaPago.Text = "Forma de Pago";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 399);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 136);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Titular de la Reserva";
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 768);
            Controls.Add(rbEfectivo);
            Controls.Add(lstbResultado);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdReservar);
            Controls.Add(mskNumero);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTarjetas);
            Controls.Add(rbTarjeta);
            Controls.Add(ckbTelevisor);
            Controls.Add(ckbHeladera);
            Controls.Add(ckbCocina);
            Controls.Add(mskDias);
            Controls.Add(lstPersonas);
            Controls.Add(lstTipo);
            Controls.Add(lblTipoCabaña);
            Controls.Add(lblDias);
            Controls.Add(lblPersonas);
            Controls.Add(gbTipo);
            Controls.Add(groupBox1);
            Controls.Add(gbFormaPago);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReserva";
            Text = "Reservas de Cabañas";
            Load += frmReserva_Load;
            gbFormaPago.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPersonas;
        private Label lblDias;
        private Label lblTipoCabaña;
        private ComboBox lstTipo;
        private ComboBox lstPersonas;
        private MaskedTextBox mskDias;
        private CheckBox ckbCocina;
        private CheckBox ckbHeladera;
        private CheckBox ckbTelevisor;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private Label lblTarjetas;
        private ComboBox lstTarjetas;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label label2;
        private MaskedTextBox mskNumero;
        private Button cmdReservar;
        private Button cmdCancelar;
        private ListBox lstbResultado;
        private GroupBox gbTipo;
        private GroupBox groupBox1;
        private GroupBox gbFormaPago;
        private GroupBox groupBox2;
    }
}
