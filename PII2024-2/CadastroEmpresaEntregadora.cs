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
    public partial class CadastroEmpresaEntregadora : Form
    {
        public CadastroEmpresaEntregadora()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Frm_Menu menuPrincipal = new Frm_Menu();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
