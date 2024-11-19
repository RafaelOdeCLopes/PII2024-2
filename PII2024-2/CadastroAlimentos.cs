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
using System.Data.SqlTypes;

namespace PII2024_2
{
    public partial class CadastroAlimentos : Frm_Menu
    {
        bool sidebarExpand;
        bool homeCollapsed;
        SQLServer sql = new SQLServer();
        Alimentos alimento = new Alimentos();

        public CadastroAlimentos()
        {
            InitializeComponent();
            sql.Conectar();

            // Preencher cmbEmpresa com os nomes das empresas fabricantes
            using (SqlCommand cmd = new SqlCommand("SELECT id_empresa_fabricante, nome_empresa FROM empresas_fabricantes", sql.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dtEmpresa = new DataTable();
                    dtEmpresa.Load(reader);
                    cmbEmpresa.DataSource = dtEmpresa;
                    cmbEmpresa.DisplayMember = "nome_empresa"; // Exibe o nome da empresa
                    cmbEmpresa.ValueMember = "id_empresa_fabricante"; // Armazena a chave primária
                }
            }

            // Preencher cmbDoacao com os nomes dos doadores
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT d.id_doador, d.nome 
                FROM doacoes AS do
                INNER JOIN doadores AS d ON do.id_doador = d.id_doador", sql.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dtDoacao = new DataTable();
                    dtDoacao.Load(reader);
                    cmbDoacao.DataSource = dtDoacao;
                    cmbDoacao.DisplayMember = "nome"; // Exibe o nome do doador
                    cmbDoacao.ValueMember = "id_doador"; // Armazena a chave primária
                }
            }
        }

        private void btnSalvarcadastroalimentos_Click(object sender, EventArgs e)
        {
            alimento.Nome = txtNome.Text;
            alimento.Descricao = txtDescricao.Text;
            alimento.DataValidade = DateTime.Parse(mtbdata.Text);
            alimento.Quantidade = int.Parse(txtQuantidade.Text);
            alimento.Origem = cmbOrigem.SelectedItem.ToString();
            alimento.IdEmpresaFabricante = int.Parse(cmbEmpresa.SelectedValue.ToString()); // Obtém a chave primária
            if (alimento.Origem == "Compra")
            {
                alimento.IdDoacao = SqlInt16.Null;
            }
            else
            {
                alimento.IdDoacao = SqlInt16.Parse(cmbDoacao.SelectedValue.ToString()); // Obtém a chave primária
            }
            alimento.Inserir();
            MessageBox.Show("Alimento inserido com sucesso!");
        }

        private void cmbOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroAlimentos_Load(object sender, EventArgs e)
        {

        }
    }
}
