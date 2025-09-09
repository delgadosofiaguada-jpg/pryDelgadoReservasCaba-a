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
            if (mskDias.Text == "")
            {
                if (txtNombre.Text == "")
                {
                    if (mskNumero.Text == "")
                    {
                        cmdReservar.Enabled = false;
                    }
                }
            }
            else
            {
                cmdReservar.Enabled = true;
            }
        }
    }
}
