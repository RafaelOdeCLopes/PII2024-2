using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII2024_2
{
    public partial class Pedido : Frm_Menu
    {
        SQLServer sql = new SQLServer();
        Pedidos Ped = new Pedidos();
        Neo4j Neo4 = new Neo4j();
        private Neo4j neo4j;

        public Pedido()
        {
            InitializeComponent();
            neo4j = new Neo4j();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            CarregarComboBox(cmbAlimento, "SELECT id, nome FROM alimentos", "nome", "id");
            PreencherComboBox(); // Carrega dados do Neo4j no ComboBox
        }

        private void btnSalvarpedido_Click(object sender, EventArgs e)
        {

            Ped.NomePedido = txtPedido.Text;
            Ped.IdFamilia = cmbFamilia.SelectedIndex;
            Ped.IdAlimento = cmbAlimento.SelectedIndex;
            Ped.Quantidade = int.Parse(txtQuantidade.Text);
            Ped.DataPedido = mtbdataPedido.Value;



            Ped.Inserir();

            MessageBox.Show("Inserido Com Sucesso!");
        }

        public async void PreencherComboBox()
        {
            try
            {
                // Define a query para buscar os nomes
                string query = "MATCH (n:Familias) RETURN n.nomeResponsavel AS nomeResponsavel";

                // Executa a consulta e obtém os dados
                var dt = await Neo4.DTConsulta(query);

                // Verifica se há resultados
                if (dt.Rows.Count > 0)
                {
                    // Limpa o ComboBox antes de adicionar novos itens
                    cmbFamilia.Items.Clear();

                    // Adiciona os nomes ao ComboBox
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbFamilia.Items.Add(row["nomeResponsavel"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum nome encontrado no banco de dados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao preencher o ComboBox: {ex.Message}");
            }
        }

        public void CarregarComboBox(ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            try
            {
                DataTable dt = sql.RetornarTabela(query);
                cmbAlimento.DataSource = dt;
                cmbAlimento.DisplayMember = displayMember; // Nome da coluna a ser exibida
                cmbAlimento.ValueMember = valueMember;     // Nome da coluna com o valor
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Neo4.Dispose(); // Fecha e limpa a conexão do Neo4j
        }
    }
}