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
    public partial class Cadastro_EmpresaFabricante : Frm_Menu
    {

        public Cadastro_EmpresaFabricante()
        {
            InitializeComponent();
            SQLServer sql = new SQLServer();
            sql.Conectar();
          
        }




        private void txt_NomeFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_TelefoneFabricante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmarCadastroFabricante_Click(object sender, EventArgs e)
        {
            EmpresasFabricantes EmpFab = new EmpresasFabricantes();
            EmpFab.NomeEmpresa = txt_NomeFabricante.Text;
            EmpFab.Endereco = txt_EnderecoFabricante.Text;
            EmpFab.Telefone = txt_TelefoneFabricante.Text;

            EmpFab.Inserir();

            MessageBox.Show("Inserido Com Sucesso!");
        }

        private void Cadastro_EmpresaFabricante_Load(object sender, EventArgs e)
        {

        }
    }
}
