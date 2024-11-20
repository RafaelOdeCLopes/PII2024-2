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
    public partial class CadastroDoadores : Frm_Menu
    {
        public CadastroDoadores()
        {
            InitializeComponent();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            Doadores Doad = new Doadores();
            var neo4j = new Neo4j();

            Doad.Nome = txt_Nome.Text;
            Doad.Contato = txt_Contato.Text;

            await Doad.InserirNoNeo4j(neo4j);


            MessageBox.Show("Inserido Com Sucesso!");
        }
    }
}
