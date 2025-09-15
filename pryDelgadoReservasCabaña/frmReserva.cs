using System.Diagnostics.Eventing.Reader;

namespace pryDelgadoReservasCabaña
{
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            FormatoInicio();
        }

        private void mtbDias_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbDias.Text != "")
            {
                cmdReservar.Enabled = true;
            }
            else
            {
                cmdReservar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 0)
            {
                cmdReservar.Enabled = true;
            }
            else
            {
                cmdReservar.Enabled = false;
            }
        }

        private void mskNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskNumero.TextLength < 7)
            {
                cmdReservar.Enabled = false;
            }
            else
            {
                cmdReservar.Enabled = true;
            }
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            lstTarjetas.Enabled = true;
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            lstTarjetas.Enabled = false;
        }

        private void cmdReservar_Click(object sender, EventArgs e)
        {
            CalcularReserva();
            LimpiarControles();
            FormatoInicio();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            FormatoInicio();
        }
        private void LimpiarControles()
        {
            cbxPersonas.SelectedIndex = -1;
            ckbCocina.Checked = false;
            ckbHeladera.Checked = false;
            ckbTelevisor.Checked = false;
            lstTarjetas.SelectedIndex = -1;
            txtNombre.Text = "";
            mskNumero.Text = "";
        }
        private void FormatoInicio()
        {
            cbxTipo.SelectedIndex = 0;
            cbxPersonas.SelectedIndex = 0;
            mtbDias.Text = "1";
        }

        private void CalcularReserva()
        {
            int PrecioInicial = 0;
            int Personasmax = 0;
            int Personas = Convert.ToInt32(cbxPersonas.SelectedItem);
            Decimal PrecioDiario = 0;

            if (cbxTipo.SelectedItem.ToString().Contains("A"))
            {
                PrecioInicial = 20;
                Personasmax = 4;
            }

            else if (cbxTipo.SelectedItem.ToString().Contains("B"))
            {
                PrecioInicial = 34;
                Personasmax = 8;
            }
            if (Personasmax > Personasmax)
            {
                MessageBox.Show("ERROR! " +
                    "La cabaña tipo" + " " + cbxTipo.SelectedItem +
                    "permite un maximo de" + " " + Personasmax + " " + "personas");
                return;
            }
            PrecioDiario = PrecioInicial + Personasmax;

            if (!ckbCocina.Checked)
            {
                PrecioDiario = PrecioDiario + 1m;
            }
            if (ckbHeladera.Checked)
            {
                PrecioDiario = PrecioDiario + 1.5m;
            }
            if (ckbTelevisor.Checked)
            {
                PrecioDiario = PrecioDiario + 2m;
            }

            //Convertir masked text box de dias en numero(int) y crear una variable para guardar el precio final
            int Dias = Convert.ToInt32(mtbDias.Text);
            Decimal PrecioFinal = PrecioDiario * Dias;

            string RecargoSiNo = "";
            string FormaPago = "efectivo";

            //Si abona con efectivo:

            if (rbEfectivo.Checked)

            {
                FormaPago = "Efectivo";
                PrecioFinal = PrecioFinal + 0;
                RecargoSiNo = "Sin Recargo";
            }

            //Si abona con tarjeta:

            if (rbTarjeta.Checked)

            {
                FormaPago = lstTarjetas.SelectedItem.ToString();

                if (FormaPago == "Card Blue")
                {
                    PrecioFinal = PrecioFinal * 1.20m;
                    RecargoSiNo = "20%";
                }

                else if (FormaPago == "Card Green")
                {
                    PrecioFinal = PrecioFinal * 1.20m;
                    RecargoSiNo = "20%";
                }

                else if (FormaPago == "Card Red")
                {
                    PrecioFinal = PrecioFinal * 1.10m;
                    RecargoSiNo = "10%";
                }


            }
            //Muestra los resultados:

            lstbResultado.Items.Add("A nombre de:" + " " + txtNombre.Text);
            lstbResultado.Items.Add("Télefono: " + " " + mskNumero.Text);
            lstbResultado.Items.Add("Tipo de Cabaña: " + cbxTipo.SelectedItem);
            lstbResultado.Items.Add("Cantidad de personas: " + cbxPersonas.SelectedItem);
            lstbResultado.Items.Add("Días de estadía: " + mtbDias.Text);
            lstbResultado.Items.Add("Forma de pago: " + FormaPago);
            lstbResultado.Items.Add("Recargo: " + RecargoSiNo);
            lstbResultado.Items.Add("Precio diario: U$S " + PrecioDiario);
            lstbResultado.Items.Add("Precio total: U$S " + PrecioFinal);
        }
    }
}
