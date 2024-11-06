using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII2024_2
{
    public partial class CadastroDoadores : Frm_Menu
    {
        public CadastroDoadores()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Doadores Doad = new Doadores();
            Doad.Nome = txt_NomeDoador.Text;
            Doad.Contato = txt_Contato.Text;
        }

        public void Incluir()
        {
            EmpresasFabricantes EmpFab = new EmpresasFabricantes();

            string sql = $"Insert into empresa_fabricante(nome_empresa, endereco, telefone) values ({EmpFab.NomeEmpresa}, '{EmpFab.Endereco}', '{EmpFab.Telefone}')";
            string connectionString = "Server=.\\SQLEXPRESS;Database=BancoPII;UID=sa;PWD=senha123";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT @@IDENTITY";
                cmd.Connection = connection;
                IdEmpresaFabricante1 = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir Empresa Fabricante: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void TbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
