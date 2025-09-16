namespace pryDelgadoFabricaFiat
{
    partial class frmBienvenida
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
            lblBienvenido = new Label();
            lblSinterpart = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(178, 93);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(398, 81);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido a";
            // 
            // lblSinterpart
            // 
            lblSinterpart.AutoSize = true;
            lblSinterpart.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSinterpart.ForeColor = SystemColors.Highlight;
            lblSinterpart.Location = new Point(80, 214);
            lblSinterpart.Name = "lblSinterpart";
            lblSinterpart.Size = new Size(584, 106);
            lblSinterpart.TabIndex = 1;
            lblSinterpart.Text = "Sinterpart SRL";
            // 
            // frmBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 409);
            Controls.Add(lblSinterpart);
            Controls.Add(lblBienvenido);
            Name = "frmBienvenida";
            Text = "Bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Label lblSinterpart;
    }
}