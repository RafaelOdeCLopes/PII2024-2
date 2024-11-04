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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex = new frmExibicao("SELECT * FROM alimentos", "alimentos");
            ex.ShowDialog();
        }

        private void doaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex = new frmExibicao("SELECT * FROM doacoes", "doacoes");
            ex.ShowDialog();
        }

        private void empresasEntregadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex = new frmExibicao("SELECT * FROM empresas_entregadoras", "emp_e");
            ex.ShowDialog();
        }

        private void empresasFabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex = new frmExibicao("SELECT * FROM empresas_fabricantes", "emp_f");
            ex.ShowDialog();
        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex = new frmExibicao("SELECT * FROM entregas", "entregas");
            ex.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex = new frmExibicao("SELECT * FROM pedidos", "pedidos");
            ex.ShowDialog();
        }
    }
}
