using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WSPublica.DTO
{
    public class Dados
    {
        //Retorna uma tabela preenchida com os dados
        public static DataTable RetornarTabela(string SQL, Dictionary<string, object> parametros, out string mensagem)
        {
            using (SqlDataAdapter daConsulta = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand
                {
                    CommandText = SQL,
                    Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["padrao"].ToString())
                }
            })
            {
                try
                {
                    ConfigurarParametros(daConsulta.SelectCommand, parametros);

                    using (DataTable dtRetorno = new DataTable("PUBLICACAO"))
                    {
                        daConsulta.Fill(dtRetorno);
                        mensagem = string.Empty;
                        return dtRetorno;
                    }
                }
                catch (Exception ex)
                {
                    mensagem = string.Format("Não foi possível executar a consulta. \n{0}", ex.Message);
                }
                finally
                {
                    if (daConsulta.SelectCommand.Connection.State == ConnectionState.Open)
                    {
                        daConsulta.SelectCommand.Connection.Close();
                    }
                }
            }
            return new DataTable("default");
        }

        //Executa um comando SQL
        internal static bool ExecutarSQL(string comandoSql, Dictionary<string, object> parametros, out string mensagem)
        {
            using (SqlCommand Sqlcmd = new SqlCommand
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["padrao"].ToString()),
                CommandText = comandoSql
            })
            {
                try
                {
                    ConfigurarParametros(Sqlcmd, parametros);
                    Sqlcmd.Connection.Open();
                    Sqlcmd.ExecuteNonQuery();
                    mensagem = string.Empty;
                }
                catch (Exception ex)
                {
                    mensagem = string.Format("Não foi possível executar a consulta. \n{0}", ex.Message);
                }
                finally
                {
                    Sqlcmd.Connection.Close();
                }
            }

            return string.IsNullOrEmpty(mensagem);
        }

        private static void ConfigurarParametros(SqlCommand selectCommand, Dictionary<string, object> parametros)
        {
            foreach (string key in parametros.Keys)
            {
                selectCommand.Parameters.AddWithValue(key, parametros[key]);
            }
        }
    }
}