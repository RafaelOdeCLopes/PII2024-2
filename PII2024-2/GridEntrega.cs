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
    public partial class GridConsulta : Form
    {
        public GridConsulta()
        {
            InitializeComponent();
            // Método para configurar o ComboBox e DataGridView
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
            // Adiciona itens ao ComboBox (substituir com dados do banco futuramente)
            CbEntrega.Items.Add("Entrega A");
            CbEntrega.Items.Add("Entrega B");
            CbEntrega.Items.Add("Entrega C");

            // Configura as colunas do DataGridView
            DgvEntrega.Columns.Add("Entrega", "Tipo de Entrega");
            DgvEntrega.Columns.Add("Observacao", "Observação");

            // Evento para quando o item da ComboBox for alterado
            CbEntrega.SelectedIndexChanged += CbEntrega_SelectedIndexChanged;
        }

        private void lblPedido_Click(object sender, EventArgs e)
        {

        }

        private void GridConsulta_Load(object sender, EventArgs e)
        {

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

            // TODO: Quando o banco de dados estiver disponível, buscar as informações de entrega
            // com base na seleção do ComboBox e preencher o DataGridView com os dados completos
        }
    }
    
}
