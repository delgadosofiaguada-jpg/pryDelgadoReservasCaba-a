using System.Diagnostics.Eventing.Reader;

namespace pryDelgadoReservasCabaña
{
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }
        int costo = 0;

        private void frmReserva_Load(object sender, EventArgs e)
        {
            if (mskDias.Text == "")
            {
                cmdReservar.Enabled = false;
            }
            else
            {
                cmdReservar.Enabled = true;
            }
            if (txtNombre.Text == "")
            {
                cmdReservar.Enabled = false;
            }
            else
            {
                cmdReservar.Enabled = true;
            }
            if (mskNumero.Text == "")
            {
                cmdReservar.Enabled = false;
            }
            else
            {
                cmdReservar.Enabled = true;
            }
        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            lstTarjetas.Enabled = true;
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            lstTarjetas.Enabled = false;
        }

        private void ckbCocina_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckbCocina.Checked)
            {
                costo = costo + 1;
            }
        }

        private void ckbHeladera_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHeladera.Checked)
            {
                costo = costo + (1 + 1 / 5);
            }
        }

        private void ckbTelevisor_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTelevisor.Checked)
            {
                costo = costo + 2;
            }
        }
        private void LimpiarControles()
        {
            lstPersonas.SelectedIndex = -1;
            mskDias.Text = "";
            ckbCocina.Checked = false;
            ckbHeladera.Checked = false;
            ckbTelevisor.Checked = false;
            lstTarjetas.SelectedIndex = -1;
            txtNombre.Text = "";
            mskNumero.Text = "";
        }
        private void FormatoInicio()
        {

        }
        private void cmdReservar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            FormatoInicio();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            FormatoInicio();
        }
    }
}
