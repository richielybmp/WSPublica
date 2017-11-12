using System.Collections.Generic;
using System.Data;
using System.Web.Services;
using WSPublica.DTO;

namespace WSPublica
{
    /// <summary>
    /// Descrição resumida de WebServiceFramework
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceFramework : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Olá, Mundo";
        }

        [WebMethod]
        public DataTable Consultar(string consulta, out string mensagem)
        {
            //if (!AutenticarUsuario(usuario, out mensagem))
            //{
            //    return null;
            //}

            string ComandoSql = @"
                SELECT Titulo, Autores, PalavrasChave, Data, Publicacao, Editor, EnderecoEletronico
                FROM PUBLICACAO
                WHERE Titulo LIKE @Parametro
                    OR Autores LIKE @Parametro
                    OR PalavrasChave LIKE @Parametro
                    OR Editor LIKE @Parametro
                    OR Publicacao LIKE @Parametro";

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                { "@Parametro", string.Format("%{0}%", consulta) }
            };

            return Dados.RetornarTabela(ComandoSql, parametros, out mensagem);
        }

        //Inclui uma publicação
        [WebMethod]
        public bool IncluirPublicacao(DadosPublicacao dados, out string mensagem)
        {
            //if (!AutenticarUsuario(usuario, out mensagem)) return false;

            string comandoSql = @"
                INSERT INTO Publicacao
                (Titulo, Autores, PalavrasChave, Data, Publicacao, Editor, EnderecoEletronico)
                VALUES
                (@Titulo, @Autores, @PalavrasChave, @Data, @Publicacao, @Editor, @EnderecoEletronico)";

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
           { "@Titulo", AjustarString(dados.Titulo, 50) },
           { "@Autores", AjustarString(dados.Autores , 50) },
           { "@PalavrasChave", AjustarString(dados.PalavrasChave, 50) },
           { "@Data", dados.Data },
           { "@Publicacao", AjustarString(dados.Publicacao, 50) },
           { "@Editor", AjustarString(dados.Editor, 50) },
           { "@EnderecoEletronico", AjustarString(dados.EnderecoEletronico, 255) }
           };

            return Dados.ExecutarSQL(comandoSql, parametros, out mensagem);
        }

        [WebMethod]
        public bool Autenticar(string usuario, string senha)
        {
            return AutenticarUsuario(usuario, senha);
        }

        //Faz a autenticação do usuário
        private bool AutenticarUsuario(string usuario, string senha)
        {
            string mensagem = string.Empty;
            string ComandoSql = @"
                SELECT email FROM Usuario 
                WHERE email = @Email
                AND senha = @Senha";

            Dictionary<string, object> parametros = new Dictionary<string, object>() {
                { "@Email", usuario }, { "@Senha", senha}
            };

            if (Dados.RetornarTabela(ComandoSql, parametros, out mensagem).Rows.Count == 0)
            {
                if (string.IsNullOrEmpty(mensagem))
                {
                    mensagem = @"Usuário não encontrado.";
                }
                return false;
            }
            return true;
        }

        private static string AjustarString(string source, int length)
        {
            if (source.Length > length)
            {
                source = source.Substring(0, length);
            }
            return source;
        }

    }
}
