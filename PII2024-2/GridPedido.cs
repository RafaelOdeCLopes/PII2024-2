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
    public partial class GridPedido : Frm_Menu
    {
        public GridPedido()
        {
            InitializeComponent();

            // Método para configurar o ComboBox e DataGridView
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
            // Adiciona itens ao ComboBox (substituir com dados do banco futuramente)
            CbPedido.Items.Add("Pedido 1");
            CbPedido.Items.Add("Pedido 2");
            CbPedido.Items.Add("Pedido 3");

            // Configura as colunas do DataGridView
            DgvPedido.Columns.Add("Pedido", "Número do Pedido");
            DgvPedido.Columns.Add("Detalhes", "Detalhes do Pedido");

            // Evento para quando o item da ComboBox for alterado
            CbPedido.SelectedIndexChanged += CbPedido_SelectedIndexChanged;
        }


        private void GridPedido_Load(object sender, EventArgs e)
        {

        }

        private void CbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpa o DataGridView antes de adicionar novas informações
            DgvPedido.Rows.Clear();

            // Obtém o item selecionado na ComboBox
            string pedidoSelecionado = CbPedido.SelectedItem.ToString();

            // Adiciona uma linha ao DataGridView com o número do pedido e detalhes padrão
            // Os detalhes podem ser substituídos por uma consulta ao banco de dados futuramente
            DgvPedido.Rows.Add(pedidoSelecionado, "Detalhes: [inserir detalhes do banco de dados aqui]");

            // TODO: Quando o banco de dados estiver disponível, buscar as informações do pedido
            // com base na seleção do ComboBox e preencher o DataGridView com os dados completos
        }

        private void DgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
