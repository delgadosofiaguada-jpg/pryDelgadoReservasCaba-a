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
            lblTituloTipo = new Label();
            lblPersonas = new Label();
            lblDias = new Label();
            lblTipoCabaña = new Label();
            lstTipo = new ComboBox();
            lstPersonas = new ComboBox();
            mskDias = new MaskedTextBox();
            lblFormaPago = new Label();
            lblAdicionales = new Label();
            ckbCocina = new CheckBox();
            ckbHeladera = new CheckBox();
            ckbTelevisor = new CheckBox();
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            lblTarjetas = new Label();
            lstTarjetas = new ComboBox();
            lblTitularReserva = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label2 = new Label();
            mskNumero = new MaskedTextBox();
            cmdReservar = new Button();
            cmdCancelar = new Button();
            lstbResultado = new ListBox();
            SuspendLayout();
            // 
            // lblTituloTipo
            // 
            lblTituloTipo.AutoSize = true;
            lblTituloTipo.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTituloTipo.Location = new Point(38, 9);
            lblTituloTipo.Name = "lblTituloTipo";
            lblTituloTipo.Size = new Size(137, 25);
            lblTituloTipo.TabIndex = 1;
            lblTituloTipo.Text = "Tipo de Cabaña";
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
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFormaPago.Location = new Point(337, 196);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(120, 23);
            lblFormaPago.TabIndex = 8;
            lblFormaPago.Text = "Forma de pago";
            // 
            // lblAdicionales
            // 
            lblAdicionales.AutoSize = true;
            lblAdicionales.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdicionales.Location = new Point(38, 196);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(92, 23);
            lblAdicionales.TabIndex = 9;
            lblAdicionales.Text = "Adicionales";
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
            lstTarjetas.Location = new Point(596, 321);
            lstTarjetas.Name = "lstTarjetas";
            lstTarjetas.Size = new Size(151, 28);
            lstTarjetas.TabIndex = 16;
            // 
            // lblTitularReserva
            // 
            lblTitularReserva.AutoSize = true;
            lblTitularReserva.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitularReserva.Location = new Point(38, 372);
            lblTitularReserva.Name = "lblTitularReserva";
            lblTitularReserva.Size = new Size(158, 23);
            lblTitularReserva.TabIndex = 17;
            lblTitularReserva.Text = "Titular de la Reserva";
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
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 768);
            Controls.Add(lstbResultado);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdReservar);
            Controls.Add(mskNumero);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTitularReserva);
            Controls.Add(lstTarjetas);
            Controls.Add(lblTarjetas);
            Controls.Add(rbTarjeta);
            Controls.Add(rbEfectivo);
            Controls.Add(ckbTelevisor);
            Controls.Add(ckbHeladera);
            Controls.Add(ckbCocina);
            Controls.Add(lblAdicionales);
            Controls.Add(lblFormaPago);
            Controls.Add(mskDias);
            Controls.Add(lstPersonas);
            Controls.Add(lstTipo);
            Controls.Add(lblTipoCabaña);
            Controls.Add(lblDias);
            Controls.Add(lblPersonas);
            Controls.Add(lblTituloTipo);
            Name = "frmReserva";
            Text = "Reservas de Cabañas";
            Load += frmReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTituloTipo;
        private Label lblPersonas;
        private Label lblDias;
        private Label lblTipoCabaña;
        private ComboBox lstTipo;
        private ComboBox lstPersonas;
        private MaskedTextBox mskDias;
        private Label lblFormaPago;
        private Label lblAdicionales;
        private CheckBox ckbCocina;
        private CheckBox ckbHeladera;
        private CheckBox ckbTelevisor;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private Label lblTarjetas;
        private ComboBox lstTarjetas;
        private Label lblTitularReserva;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label label2;
        private MaskedTextBox mskNumero;
        private Button cmdReservar;
        private Button cmdCancelar;
        private ListBox lstbResultado;
    }
}
