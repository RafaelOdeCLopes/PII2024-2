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
    public partial class Frm_Menu : Form
    {
        bool sidebarExpand;
        bool homeCollapsed;

      
        public Frm_Menu()
        {
            InitializeComponent();




        }

       
        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Trick(object sender, EventArgs e)
        {

            //set min e max size

            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                }
            }
            
        }

        private void MenuButtom_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }



  

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                HomeContainer.Height += 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    HomeTimer.Stop();
                }

            }else
            {
                HomeContainer.Height -= 10;
                if(HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    HomeTimer.Stop();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            HomeTimer.Start();
        }

        private void btn_CadastroFamiliar_Click(object sender, EventArgs e)
        {
           FrmCadastro cadastroFamilia = new FrmCadastro();
            cadastroFamilia.Show();
            this.Close();
        }

        private void btn_CadastroEmpresaFabricante_Click(object sender, EventArgs e)
        {
            Cadastro_EmpresaFabricante cadastroEmpresa = new Cadastro_EmpresaFabricante();
            cadastroEmpresa.Show();
            this.Close();
        }

        private void btn_CadastroEntregadora_Click(object sender, EventArgs e)
        {

        }

        private void btn_CadastroDoadores_Click(object sender, EventArgs e)
        {
            CadastroDoadores cadastroDoadores = new CadastroDoadores();
            cadastroDoadores.Show();
            this.Close();
        }

        private void btn_CadastroAlimentos_Click(object sender, EventArgs e)
        {
            CadastroAlimentos cadastroAlimentos = new CadastroAlimentos();
            cadastroAlimentos.Show();
            this.Close();
        }

      

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
