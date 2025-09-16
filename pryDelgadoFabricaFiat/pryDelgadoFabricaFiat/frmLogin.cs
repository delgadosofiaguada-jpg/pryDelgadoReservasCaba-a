namespace pryDelgadoFabricaFiat
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            frmBienvenida ventanaBienvenida = new frmBienvenida();
            ventanaBienvenida.ShowDialog();
        }
    }
}
