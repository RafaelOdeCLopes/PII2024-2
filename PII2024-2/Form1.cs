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
            frmExibicao ex1 = new frmExibicao("SELECT * FROM alimentos");
            ex1.ShowDialog();
        }

        private void doaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex2 = new frmExibicao("SELECT * FROM doacoes");
            ex2.ShowDialog();
        }

        private void empresasEntregadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex3 = new frmExibicao("SELECT * FROM empresas_entregadoras");
            ex3.ShowDialog();
        }

        private void empresasFabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex4 = new frmExibicao("SELECT * FROM empresas_fabricantes");
            ex4.ShowDialog();
        }

        private void entregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex5 = new frmExibicao("SELECT * FROM entregas");
            ex5.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibicao ex6 = new frmExibicao("SELECT * FROM pedidos");
            ex6.ShowDialog();
        }
    }
}
