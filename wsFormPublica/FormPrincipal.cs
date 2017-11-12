using MetroFramework.Forms;
using System.Windows.Forms;

namespace wsFormPublica
{
    public partial class Catálogo : MetroForm
    {
        wsPublicacao.WebServiceFrameworkSoapClient webService = new wsPublicacao.WebServiceFrameworkSoapClient();

        public Catálogo()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente incluir o registro?", "Incluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes)
            {
                return;
            }

            wsPublicacao.DadosPublicacao dados = new wsPublicacao.DadosPublicacao()
            {
                Titulo = tbTitulo.Text,
                Autores = tbAutores.Text,
                Data = System.DateTime.Today,
                Editor = tbEditor.Text,
                EnderecoEletronico = tbEnderecoEletronico.Text,
                PalavrasChave = tbPalavraChave.Text,
                Publicacao = tbPublicacao.Text
            };

            var mensagem = string.Empty;

            if (!webService.IncluirPublicacao(out mensagem, dados))
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                LimparDados();
            }

        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            string mensagem = string.Empty;
            var dados = webService.Consultar(out mensagem, tbBuscar.Text);

            if (dados == null || dados.Rows.Count == 0)
            {
                if (string.IsNullOrEmpty(mensagem))
                {
                    mensagem = "Nenhum registro encontrado";
                }
                MessageBox.Show(mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                gridResultado.DataSource = dados;
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            LimparDados();
        }

        private void LimparDados()
        {
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
            }
        }

    }
}
