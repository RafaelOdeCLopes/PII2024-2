using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PII2024_2
{
    public partial class GridConsulta : Frm_Menu
    {
        SQLServer sql = new SQLServer(); // Instância de SQLServer já configurada
        Neo4j neo4 = new Neo4j(); // Instância de Neo4j já configurada

        public GridConsulta()
        {
            InitializeComponent();
            CarregarEntregas(); // Carrega IDs das entregas no ComboBox
        }

        private void GridConsulta_Load(object sender, EventArgs e)
        {
            ConfigurarFormulario(); // Configura ComboBox e DataGridView
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

        private void CarregarEntregas()
        {
            try
            {
                string query = "SELECT id FROM entregas"; // Busca apenas o campo 'id'
                DataTable table = sql.RetornarTabela(query);

                // Configura o ComboBox corretamente
                CbEntrega.DataSource = table;
                CbEntrega.DisplayMember = "id";  // Campo exibido no ComboBox
                CbEntrega.ValueMember = "id";    // Valor real associado a cada item
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as entregas: {ex.Message}");
            }
        }

        private void CbEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há uma seleção válida no ComboBox
            if (CbEntrega.SelectedValue != null && int.TryParse(CbEntrega.SelectedValue.ToString(), out int idEntrega))
            {
                // método pra preencher o data grid view
                MostrarDetalhesEntrega(idEntrega.ToString());
            }
            else
            {
                MessageBox.Show("Carregado com sucesso!");
            }
        }

        private void MostrarDetalhesEntrega(string idEntrega)
        {
            try
            {
                string query = @"
        SELECT id_pedido AS 'Código do Pedido',
               id_empresa_entregadora AS 'Código Empresa Entregadora',
               data_entrega AS 'Data de Entrega',
               status AS 'Status da Entrega'
        FROM entregas
        WHERE id = @id"; //NÃO MUDA PRA id_entrega

                var parametros = new Dictionary<string, object>
        {
            { "@id", idEntrega } // Passa o valor do ID selecionado
        };

                DataTable dtDetalhes = sql.RetornarTabelaComParametros(query, parametros);

                // Verifica rse retorna dado
                if (dtDetalhes.Rows.Count > 0)
                {
                    // Substitui a tabela
                    DgvEntrega.DataSource = dtDetalhes;
                }
                else
                {
                    MessageBox.Show("Nenhum detalhe encontrado para esta entrega.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar os detalhes da entrega: {ex.Message}");
            }
        }
    }
}
