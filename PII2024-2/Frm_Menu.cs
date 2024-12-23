﻿using System;
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
        bool EntregaCollapsed;
        bool PedidoCollapsed;

      
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

                //Garante que o sidebar fique na frente ao expandir
                sidebar.BringToFront();
                //GEOVANA FERNANDES
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
            CadastroEmpresasEntregadoras cadastroEmpresaEntregadora = new CadastroEmpresasEntregadoras();
            cadastroEmpresaEntregadora.Show();
            this.Close();

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

        private void btn_Entrega_Click(object sender, EventArgs e)
        {
            Entrega_Timer.Start();
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
          PedidoTimer.Start();
        }

        private void Entrega_Timer_Tick(object sender, EventArgs e)
        {
            if (EntregaCollapsed)
            {
                EntregaPanel.Height += 10;
                if (EntregaPanel.Height == EntregaPanel.MaximumSize.Height)
                {
                    EntregaCollapsed = false;
                    Entrega_Timer.Stop();
                }

            }
            else
            {
                EntregaPanel.Height -= 10;
                if (EntregaPanel.Height == EntregaPanel.MinimumSize.Height)
                {
                    EntregaCollapsed = true;
                    Entrega_Timer.Stop();
                }
            }
        }

        private void PedidoTimer_Tick(object sender, EventArgs e)
        {
            if (PedidoCollapsed)
            {
                PedidoPanel.Height += 10;
                if (PedidoPanel.Height == PedidoPanel.MaximumSize.Height)
                {
                    PedidoCollapsed = false;
                    PedidoTimer.Stop();
                }

            }
            else
            {
                PedidoPanel.Height -= 10;
                if (PedidoPanel.Height == PedidoPanel.MinimumSize.Height)
                {
                    PedidoCollapsed = true;
                    PedidoTimer.Stop();
                }
            }
        }

 

        private void btn_CadastroPed_Click(object sender, EventArgs e)
        {
            Pedido cadastrodepedido = new Pedido();
            cadastrodepedido.Show();
            this.Close();
        }

        private void btn_ConsultaPed_Click(object sender, EventArgs e)
        {
            GridPedido gridPedido = new GridPedido();
            gridPedido.Show();
        }

        private void btn_ConsultaEnt_Click(object sender, EventArgs e)
        {
            GridConsulta gridEntrega = new GridConsulta();
            gridEntrega.Show();
            this.Close();
        }

        private void btn_cadastroEnt_Click(object sender, EventArgs e)
        {
            CadastroEntrega cadastroEntregadora = new CadastroEntrega();
            cadastroEntregadora.Show();
            this.Close();
        }
    }
}
