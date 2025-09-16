namespace pryDelgadoFabricaFiat
{
    partial class frmLogin
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
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            cmdAceptar = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lstModulo = new ComboBox();
            cmdCancelar = new Button();
            lblMódulo = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(186, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Login Sinterpart SRL";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(12, 102);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 23);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(12, 156);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(97, 23);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // cmdAceptar
            // 
            cmdAceptar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdAceptar.Location = new Point(363, 139);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(95, 40);
            cmdAceptar.TabIndex = 3;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = SystemColors.HotTrack;
            txtUsuario.Location = new Point(136, 98);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(151, 27);
            txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            txtContraseña.ForeColor = SystemColors.HotTrack;
            txtContraseña.Location = new Point(136, 152);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(151, 27);
            txtContraseña.TabIndex = 5;
            // 
            // lstModulo
            // 
            lstModulo.FormattingEnabled = true;
            lstModulo.Items.AddRange(new object[] { "ADM", "SIST ", "COM", "VTA" });
            lstModulo.Location = new Point(136, 209);
            lstModulo.Name = "lstModulo";
            lstModulo.Size = new Size(151, 28);
            lstModulo.TabIndex = 6;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(363, 202);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(95, 36);
            cmdCancelar.TabIndex = 7;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // lblMódulo
            // 
            lblMódulo.AutoSize = true;
            lblMódulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMódulo.Location = new Point(12, 209);
            lblMódulo.Name = "lblMódulo";
            lblMódulo.Size = new Size(69, 23);
            lblMódulo.TabIndex = 8;
            lblMódulo.Text = "Módulo";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 285);
            Controls.Add(lblMódulo);
            Controls.Add(cmdCancelar);
            Controls.Add(lstModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(cmdAceptar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblContraseña;
        private Button cmdAceptar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox lstModulo;
        private Button cmdCancelar;
        private Label lblMódulo;
    }
}
