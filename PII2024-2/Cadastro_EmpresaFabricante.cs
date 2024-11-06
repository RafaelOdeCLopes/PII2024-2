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
    public partial class Cadastro_EmpresaFabricante : Frm_Menu
    {
        int IdEmpresaFabricante;

        public int IdEmpresaFabricante1 { get => IdEmpresaFabricante; set => IdEmpresaFabricante = value; }

        public Cadastro_EmpresaFabricante()
        {
            InitializeComponent();
        }

        private void txt_NomeFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_TelefoneFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmarCadastroFabricante_Click(object sender, EventArgs e)
        {
            EmpresasFabricantes EmpFab = new EmpresasFabricantes();
            EmpFab.NomeEmpresa = txt_NomeFabricante.Text;
            EmpFab.Endereco = txt_EnderecoFabricante.Text;
            EmpFab.Telefone = txt_TelefoneFabricante.Text;

            MessageBox.Show(EmpFab.Endereco);
            MessageBox.Show(EmpFab.NomeEmpresa);
        }


        private void Cadastro_EmpresaFabricante_Load(object sender, EventArgs e)
        {

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
    }
}
