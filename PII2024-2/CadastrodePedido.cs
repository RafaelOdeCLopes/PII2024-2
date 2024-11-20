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
        public Pedido()
        {
            InitializeComponent();
            sql.Conectar();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarpedido_Click(object sender, EventArgs e)
        {

            Ped.NomePedido = txtPedido.Text;
            Ped.IdFamilia = cmbFamilia.SelectedIndex;
            Ped.IdAlimento = cmbAlimento.SelectedIndex;
            Ped.Quantidade = txtQuantidade.TabIndex;
            Ped.DataPedido = mtbdataPedido.Value;



            Ped.Inserir();

            MessageBox.Show("Inserido Com Sucesso!");
        }
    }
}
