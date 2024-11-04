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
    public partial class frmExibicao : Form
    {
        SQLServer sql = new SQLServer();
        public frmExibicao(string consulta, string formatacao)
        {
            InitializeComponent();
            dgvExibicao.DataSource = sql.RetornarTabela(consulta);
            if (formatacao == "alimentos")
            {
                lblTabela.Text += "Alimentos";
                dgvExibicao.Columns[0].HeaderText = "ID";
                dgvExibicao.Columns[1].HeaderText = "Nome";
                dgvExibicao.Columns[2].HeaderText = "Descrição";
                dgvExibicao.Columns[3].HeaderText = "Validade";
                dgvExibicao.Columns[4].HeaderText = "Quantidade";
                dgvExibicao.Columns[5].HeaderText = "Origem";
                dgvExibicao.Columns[6].HeaderText = "ID da Empresa Fabricante";
                dgvExibicao.Columns[7].HeaderText = "ID da Doação";
            }
            else if (formatacao == "doacoes")
            {
                lblTabela.Text += "Doações";
                dgvExibicao.Columns[0].HeaderText = "ID";
                dgvExibicao.Columns[1].HeaderText = "ID do Doador";
                dgvExibicao.Columns[2].HeaderText = "Quantidade";
                dgvExibicao.Columns[3].HeaderText = "Descrição";
                dgvExibicao.Columns[4].HeaderText = "Data da Doação";
                dgvExibicao.Columns[5].HeaderText = "ID da Empresa Fabricante";
            }
            else if (formatacao == "emp_e")
            {
                lblTabela.Text += "Empresas Entregadoras";
                dgvExibicao.Columns[0].HeaderText = "ID";
                dgvExibicao.Columns[1].HeaderText = "Nome";
                dgvExibicao.Columns[2].HeaderText = "Endereço";
                dgvExibicao.Columns[3].HeaderText = "Telefone";
            }
            else if (formatacao == "emp_f")
            {
                lblTabela.Text += "Empresas Fabricantes";
                dgvExibicao.Columns[0].HeaderText = "ID";
                dgvExibicao.Columns[1].HeaderText = "Nome";
                dgvExibicao.Columns[2].HeaderText = "Endereço";
                dgvExibicao.Columns[3].HeaderText = "Telefone";
            }
            else if (formatacao == "entregas")
            {
                lblTabela.Text += "Entregas";
                dgvExibicao.Columns[0].HeaderText = "ID";
                dgvExibicao.Columns[1].HeaderText = "ID do Pedido";
                dgvExibicao.Columns[2].HeaderText = "ID da Empresa Entregadora";
                dgvExibicao.Columns[3].HeaderText = "Data";
                dgvExibicao.Columns[4].HeaderText = "Status";
            }
            else if (formatacao == "pedidos")
            {
                lblTabela.Text += "Pedidos";
                dgvExibicao.Columns[0].HeaderText = "ID";
                dgvExibicao.Columns[1].HeaderText = "ID do Família";
                dgvExibicao.Columns[2].HeaderText = "ID do Alimento";
                dgvExibicao.Columns[3].HeaderText = "Quantidade";
                dgvExibicao.Columns[4].HeaderText = "Data";
            }
        }
    }
}
