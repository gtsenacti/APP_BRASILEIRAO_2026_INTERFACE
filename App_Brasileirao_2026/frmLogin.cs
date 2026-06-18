namespace App_Brasileirao_2026
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPrincipal fp = new frmPrincipal();
            fp.Show();
        }
    }
}
