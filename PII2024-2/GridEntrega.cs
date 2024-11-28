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
    public partial class GridConsulta : Frm_Menu
    {
        private string connectionString = "Data Source=SEU_SERVIDOR;Initial Catalog=SEU_BANCO;Integrated Security=True";
        public GridConsulta()
        {
            InitializeComponent();
            ConfigurarFormulario();// Método para configurar o ComboBox e DataGridView
            CarregarEntregas(); // Método para carregar os IDs das entregas no ComboBox
        }
        private void ConfigurarFormulario()
        {
            // Configura as colunas do DataGridView
            DgvEntrega.Columns.Clear();
            DgvEntrega.Columns.Add("Pedido", "Código do Pedido");
            DgvEntrega.Columns.Add("EmpresaEntregadora", "Código Empresa Entregadora");
            DgvEntrega.Columns.Add("DataEntrega", "Data de Entrega");
            DgvEntrega.Columns.Add("StatusEntrega", "Status da Entrega");

            // Configura evento para seleção de item no ComboBox
            CbEntrega.SelectedIndexChanged += CbEntrega_SelectedIndexChanged;
        }

        // Método para carregar os IDs das entregas no ComboBox
        private void CarregarEntregas()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var query = "SELECT id_entrega FROM entregas"; // Ajuste conforme a tabela do banco de dados
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        var reader = cmd.ExecuteReader();
                        var table = new DataTable();
                        table.Load(reader);

                        CbEntrega.DataSource = table;
                        CbEntrega.DisplayMember = "id_entrega";
                        CbEntrega.ValueMember = "id_entrega";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as entregas: {ex.Message}");
            }
        }

        private void CbEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpa o DataGridView antes de adicionar novas informações
            DgvEntrega.Rows.Clear();

            // Obtém o item selecionado na ComboBox
            string entregaSelecionada = CbEntrega.SelectedItem.ToString();

            // Adiciona a linha ao DataGridView com o tipo de entrega e uma observação padrão
            // A observação pode ser substituída por uma consulta ao banco de dados futuramente
            DgvEntrega.Rows.Add(entregaSelecionada, "Observação: [inserir detalhes do banco de dados aqui]");

            // Verifica se há uma seleção válida no ComboBox
            if (CbEntrega.SelectedValue != null)
            {
                // Obtém o ID da entrega selecionada
                string idEntrega = CbEntrega.SelectedValue.ToString();
                // Chama o método para exibir os detalhes da entrega no DataGridView
                MostrarDetalhesEntrega(idEntrega);
            }
        }

        // Método para buscar detalhes da entrega no banco de dados e preencher o DataGridView
        private void MostrarDetalhesEntrega(string idEntrega)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var query = @"
                        SELECT id_pedido AS 'Código do Pedido',
                               id_empresa_entregadora AS 'Código Empresa Entregadora',
                               data_entrega AS 'Data de Entrega',
                               status AS 'Status da Entrega'
                        FROM entregas
                        WHERE id_entrega = @id_entrega";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_entrega", idEntrega);
                        using (var adapter = new SqlDataAdapter(cmd))
                        {
                            var table = new DataTable();
                            adapter.Fill(table);

                            // Preenche o DataGridView com os dados obtidos do banco de dados
                            DgvEntrega.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os detalhes da entrega: {ex.Message}");
            }
        }
    }
    
}
