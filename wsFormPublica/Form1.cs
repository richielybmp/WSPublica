using MetroFramework.Forms;
using System.Windows.Forms;

namespace wsFormPublica
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, System.EventArgs e)
        {
            wsPublicacao.WebServiceFrameworkSoapClient client = new wsPublicacao.WebServiceFrameworkSoapClient();

            if (client.Autenticar(tb_usuario.Text))
            {
                this.Hide();
                Catálogo formPrincipal = new Catálogo();
                formPrincipal.FormClosed += (s, args) => this.Close();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
