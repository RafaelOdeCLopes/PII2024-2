using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2024_2
{
    internal class Conexao
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
            Cmd.Connection = Conn;
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
        }
    }
}
