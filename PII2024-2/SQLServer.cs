using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace PII2024_2
{
    internal class SQLServer
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }

        public void Conectar()
        {
            string aux = "Server=.\\SQLEXPRESS;Database=BancoPII;UID=sa;PWD=senha123";
            Conn.ConnectionString = aux;
            Conn.Open();
        }
        public void Desconectar()
        {
            Conn.Close();
        }
        public void Executar(string sql)
        {
            Conectar();
            Cmd.Connection = Conn;
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            Desconectar();
        }
        public DataTable RetornarTabela(string sql)
        {
            DataTable dt = new DataTable();
            Conectar();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            Desconectar();
            return dt;
        }

        public DataTable RetornarTabelaComParametros(string query, Dictionary<string, object> parametros)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexao = new SqlConnection("Server=.\\SQLEXPRESS;Database=BancoPII;UID=sa;PWD=senha123"))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        // Adiciona os parâmetros à consulta
                        foreach (var parametro in parametros)
                        {
                            comando.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
                        }

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        conexao.Open();
                        adaptador.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar consulta parametrizada: {ex.Message}", ex);
            }

            return dt;
        }

        public DataSet RetornarBanco(string sql)
        {
            DataSet ds = new DataSet();
            Conectar();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Desconectar();
            return ds;
        }
        public void ExecutarComParametros(string query, Dictionary<string, object> parametros)
        {
            using (SqlConnection conexao = new SqlConnection("Server=.\\SQLEXPRESS;Database=BancoPII;UID=sa;PWD=senha123"))
            {
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    foreach (var parametro in parametros)
                    {
                        comando.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
                    }
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
