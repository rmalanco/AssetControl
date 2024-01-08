using AssetControl.Repositories.Interfaces;

namespace AssetControl
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void bnLogin_Click(object sender, EventArgs e)
        {
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
