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
    public partial class FrmCadastro : Frm_Menu
    {
        public FrmCadastro()
        {
            InitializeComponent();           
            SQLServer sql = new SQLServer();
            sql.Conectar();
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {

        }

        private async void btn_salvar_Click(object sender, EventArgs e)
        {
            Familias Fam = new Familias();
            var neo4j = new Neo4j();
            Fam.NomeResponsavel = txt_NomeResponsavel.Text;
            Fam.Endereco = txt_Endereco.Text;
            Fam.Telefone = txt_Telefone.Text;
            Fam.NumeroMembros = (int)Nud_NumeroMembros.Value;

            await Fam.InserirNoNeo4j(neo4j);            


            MessageBox.Show("Inserido Com Sucesso!");
        }

        private void txt__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
