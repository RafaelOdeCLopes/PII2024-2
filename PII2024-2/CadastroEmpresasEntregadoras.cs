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
    public partial class CadastroEmpresasEntregadoras : Frm_Menu
    {
        public CadastroEmpresasEntregadoras()
        {
            InitializeComponent();
        }

        private void btnSalvarEntregadora_Click(object sender, EventArgs e)
        {
            EmpresasEntregadoras EmpEntre = new EmpresasEntregadoras();
            EmpEntre.NomeEmpresa = TbNomeEmpresaEntregadora.Text;
            EmpEntre.Endereco = txtEndereçoentregadora.Text;
            EmpEntre.Telefone = txttelefoneentregadora.Text;
            EmpEntre.Inserir();
        }

    }
}
