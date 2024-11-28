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
    public partial class CadastroEntrega : Frm_Menu
    {
        SQLServer sql = new SQLServer();
        Neo4j Neo4 = new Neo4j();
        Entregas Ent = new Entregas();
        public CadastroEntrega()
        {
            InitializeComponent();
            sql.Conectar();
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT p.id, p.nome_pedido 
                FROM pedidos AS p
                INNER JOIN entregas AS e ON e.id = p.id", sql.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dtPedidos = new DataTable();
                    dtPedidos.Load(reader);
                    cbPedido.DataSource = dtPedidos;
                    cbPedido.DisplayMember = "nome_pedido"; // Exibe o nome do pedido
                    cbPedido.ValueMember = "id"; // Armazena a chave primária
                }
            }
        }
        private void CadastroEntrega_Load(object sender, EventArgs e)
        {

           /* using (SqlCommand cmd = new SqlCommand(@"
                SELECT p.id, p.nome_pedido 
                FROM pedidos AS p
                INNER JOIN entregas AS e ON e.id = p.id", sql.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dtPedidos = new DataTable();
                    dtPedidos.Load(reader);
                    cbPedido.DataSource = dtPedidos;
                    cbPedido.DisplayMember = "nome_pedido"; // Exibe o nome do pedido
                    cbPedido.ValueMember = "id"; // Armazena a chave primária
                }
            }
           */


            using (SqlCommand cmd = new SqlCommand(@"
                SELECT empe.id, empe.nome_empresa 
                FROM empresas_entregadoras AS empe
                INNER JOIN entregas AS e ON e.id = empe.id", sql.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dtPedidos = new DataTable();
                    dtPedidos.Load(reader);
                    cbEmpresa.DataSource = dtPedidos;
                    cbEmpresa.DisplayMember = "nome_empresa"; // Exibe o nome da empresa
                    cbEmpresa.ValueMember = "id"; // Armazena a chave primária
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           // Ent.NomeEntrega = txt_NomeEntrega;
            Ent.IdPedido = cbPedido.SelectedIndex;
            Ent.IdEmpresaEntregadora = cbEmpresa.SelectedIndex;
            Ent.DataEntrega = dtpData.Value;
            Ent.Status = cbStatus.SelectedItem.ToString();



            Ent.Inserir();

            MessageBox.Show("Inserido Com Sucesso!");
        }

       
    }
}
