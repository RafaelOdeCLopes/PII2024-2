﻿namespace PII2024_2
{
    partial class Frm_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.Entrega_Timer = new System.Windows.Forms.Timer(this.components);
            this.PedidoTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.MenuButtom = new System.Windows.Forms.PictureBox();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.btn_CadastroDoadores = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_CadastroAlimentos = new System.Windows.Forms.Button();
            this.btn_CadastroEntregadora = new System.Windows.Forms.Button();
            this.btn_CadastroEmpresaFabricante = new System.Windows.Forms.Button();
            this.btn_CadastroFamiliar = new System.Windows.Forms.Button();
            this.EntregaPanel = new System.Windows.Forms.Panel();
            this.btn_ConsultaEnt = new System.Windows.Forms.Button();
            this.btn_Entrega = new System.Windows.Forms.Button();
            this.btn_cadastroEnt = new System.Windows.Forms.Button();
            this.PedidoPanel = new System.Windows.Forms.Panel();
            this.btn_ConsultaPed = new System.Windows.Forms.Button();
            this.btn_Pedidos = new System.Windows.Forms.Button();
            this.btn_CadastroPed = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtom)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.EntregaPanel.SuspendLayout();
            this.PedidoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Trick);
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 5;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // Entrega_Timer
            // 
            this.Entrega_Timer.Interval = 5;
            this.Entrega_Timer.Tick += new System.EventHandler(this.Entrega_Timer_Tick);
            // 
            // PedidoTimer
            // 
            this.PedidoTimer.Interval = 5;
            this.PedidoTimer.Tick += new System.EventHandler(this.PedidoTimer_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackgroundImage = global::PII2024_2.Properties.Resources.Degrade_Laranjaclaro;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.HomeContainer);
            this.sidebar.Controls.Add(this.EntregaPanel);
            this.sidebar.Controls.Add(this.PedidoPanel);
            this.sidebar.Controls.Add(this.btn_sair);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.MaximumSize = new System.Drawing.Size(150, 366);
            this.sidebar.MinimumSize = new System.Drawing.Size(55, 366);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(55, 366);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl_Menu);
            this.panel1.Controls.Add(this.MenuButtom);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 81);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Location = new System.Drawing.Point(63, 26);
            this.lbl_Menu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(34, 13);
            this.lbl_Menu.TabIndex = 1;
            this.lbl_Menu.Text = "Menu";
            // 
            // MenuButtom
            // 
            this.MenuButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButtom.Image = global::PII2024_2.Properties.Resources.menu_png;
            this.MenuButtom.Location = new System.Drawing.Point(7, 7);
            this.MenuButtom.Margin = new System.Windows.Forms.Padding(2);
            this.MenuButtom.Name = "MenuButtom";
            this.MenuButtom.Size = new System.Drawing.Size(40, 45);
            this.MenuButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuButtom.TabIndex = 0;
            this.MenuButtom.TabStop = false;
            this.MenuButtom.Click += new System.EventHandler(this.MenuButtom_Click);
            // 
            // HomeContainer
            // 
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HomeContainer.Controls.Add(this.btn_CadastroDoadores);
            this.HomeContainer.Controls.Add(this.btn_Menu);
            this.HomeContainer.Controls.Add(this.btn_CadastroAlimentos);
            this.HomeContainer.Controls.Add(this.btn_CadastroEntregadora);
            this.HomeContainer.Controls.Add(this.btn_CadastroEmpresaFabricante);
            this.HomeContainer.Controls.Add(this.btn_CadastroFamiliar);
            this.HomeContainer.Location = new System.Drawing.Point(2, 87);
            this.HomeContainer.Margin = new System.Windows.Forms.Padding(2);
            this.HomeContainer.MaximumSize = new System.Drawing.Size(150, 186);
            this.HomeContainer.MinimumSize = new System.Drawing.Size(150, 40);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(150, 40);
            this.HomeContainer.TabIndex = 6;
            // 
            // btn_CadastroDoadores
            // 
            this.btn_CadastroDoadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_CadastroDoadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroDoadores.Location = new System.Drawing.Point(-19, 125);
            this.btn_CadastroDoadores.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CadastroDoadores.Name = "btn_CadastroDoadores";
            this.btn_CadastroDoadores.Size = new System.Drawing.Size(188, 32);
            this.btn_CadastroDoadores.TabIndex = 7;
            this.btn_CadastroDoadores.Text = "          Cadastro Doadores";
            this.btn_CadastroDoadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastroDoadores.UseVisualStyleBackColor = false;
            this.btn_CadastroDoadores.Click += new System.EventHandler(this.btn_CadastroDoadores_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(119)))), ((int)(((byte)(10)))));
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Location = new System.Drawing.Point(-20, -3);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(188, 43);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "Cadastros";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_CadastroAlimentos
            // 
            this.btn_CadastroAlimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_CadastroAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroAlimentos.Location = new System.Drawing.Point(-16, 156);
            this.btn_CadastroAlimentos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CadastroAlimentos.Name = "btn_CadastroAlimentos";
            this.btn_CadastroAlimentos.Size = new System.Drawing.Size(188, 32);
            this.btn_CadastroAlimentos.TabIndex = 6;
            this.btn_CadastroAlimentos.Text = "         Cadastro Alimentos";
            this.btn_CadastroAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastroAlimentos.UseVisualStyleBackColor = false;
            this.btn_CadastroAlimentos.Click += new System.EventHandler(this.btn_CadastroAlimentos_Click);
            // 
            // btn_CadastroEntregadora
            // 
            this.btn_CadastroEntregadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_CadastroEntregadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroEntregadora.Location = new System.Drawing.Point(-19, 98);
            this.btn_CadastroEntregadora.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CadastroEntregadora.Name = "btn_CadastroEntregadora";
            this.btn_CadastroEntregadora.Size = new System.Drawing.Size(188, 32);
            this.btn_CadastroEntregadora.TabIndex = 4;
            this.btn_CadastroEntregadora.Text = "           Cadastro Entregadora";
            this.btn_CadastroEntregadora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastroEntregadora.UseVisualStyleBackColor = false;
            this.btn_CadastroEntregadora.Click += new System.EventHandler(this.btn_CadastroEntregadora_Click);
            // 
            // btn_CadastroEmpresaFabricante
            // 
            this.btn_CadastroEmpresaFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_CadastroEmpresaFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroEmpresaFabricante.Location = new System.Drawing.Point(-19, 68);
            this.btn_CadastroEmpresaFabricante.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CadastroEmpresaFabricante.Name = "btn_CadastroEmpresaFabricante";
            this.btn_CadastroEmpresaFabricante.Size = new System.Drawing.Size(188, 32);
            this.btn_CadastroEmpresaFabricante.TabIndex = 3;
            this.btn_CadastroEmpresaFabricante.Text = "           Cadastro Fabricante";
            this.btn_CadastroEmpresaFabricante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastroEmpresaFabricante.UseVisualStyleBackColor = false;
            this.btn_CadastroEmpresaFabricante.Click += new System.EventHandler(this.btn_CadastroEmpresaFabricante_Click);
            // 
            // btn_CadastroFamiliar
            // 
            this.btn_CadastroFamiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_CadastroFamiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroFamiliar.Location = new System.Drawing.Point(-17, 38);
            this.btn_CadastroFamiliar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CadastroFamiliar.Name = "btn_CadastroFamiliar";
            this.btn_CadastroFamiliar.Size = new System.Drawing.Size(188, 32);
            this.btn_CadastroFamiliar.TabIndex = 2;
            this.btn_CadastroFamiliar.Text = "           Cadastro Familiar";
            this.btn_CadastroFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastroFamiliar.UseVisualStyleBackColor = false;
            this.btn_CadastroFamiliar.Click += new System.EventHandler(this.btn_CadastroFamiliar_Click);
            // 
            // EntregaPanel
            // 
            this.EntregaPanel.Controls.Add(this.btn_ConsultaEnt);
            this.EntregaPanel.Controls.Add(this.btn_Entrega);
            this.EntregaPanel.Controls.Add(this.btn_cadastroEnt);
            this.EntregaPanel.Location = new System.Drawing.Point(2, 131);
            this.EntregaPanel.Margin = new System.Windows.Forms.Padding(2);
            this.EntregaPanel.MaximumSize = new System.Drawing.Size(150, 104);
            this.EntregaPanel.MinimumSize = new System.Drawing.Size(150, 41);
            this.EntregaPanel.Name = "EntregaPanel";
            this.EntregaPanel.Size = new System.Drawing.Size(150, 41);
            this.EntregaPanel.TabIndex = 6;
            this.EntregaPanel.Click += new System.EventHandler(this.btn_Entrega_Click);
            // 
            // btn_ConsultaEnt
            // 
            this.btn_ConsultaEnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_ConsultaEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultaEnt.Location = new System.Drawing.Point(-20, 72);
            this.btn_ConsultaEnt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConsultaEnt.Name = "btn_ConsultaEnt";
            this.btn_ConsultaEnt.Size = new System.Drawing.Size(188, 32);
            this.btn_ConsultaEnt.TabIndex = 7;
            this.btn_ConsultaEnt.Text = "            Consulta Entrega";
            this.btn_ConsultaEnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConsultaEnt.UseVisualStyleBackColor = false;
            this.btn_ConsultaEnt.Click += new System.EventHandler(this.btn_ConsultaEnt_Click);
            // 
            // btn_Entrega
            // 
            this.btn_Entrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Entrega.FlatAppearance.BorderSize = 0;
            this.btn_Entrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrega.Location = new System.Drawing.Point(-2, -6);
            this.btn_Entrega.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Entrega.Name = "btn_Entrega";
            this.btn_Entrega.Size = new System.Drawing.Size(152, 53);
            this.btn_Entrega.TabIndex = 5;
            this.btn_Entrega.Text = "Entrega";
            this.btn_Entrega.UseVisualStyleBackColor = false;
            this.btn_Entrega.Click += new System.EventHandler(this.btn_Entrega_Click);
            // 
            // btn_cadastroEnt
            // 
            this.btn_cadastroEnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_cadastroEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastroEnt.Location = new System.Drawing.Point(-18, 42);
            this.btn_cadastroEnt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cadastroEnt.Name = "btn_cadastroEnt";
            this.btn_cadastroEnt.Size = new System.Drawing.Size(188, 32);
            this.btn_cadastroEnt.TabIndex = 6;
            this.btn_cadastroEnt.Text = "           Cadastro Entrega";
            this.btn_cadastroEnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastroEnt.UseVisualStyleBackColor = false;
            this.btn_cadastroEnt.Click += new System.EventHandler(this.btn_cadastroEnt_Click);
            // 
            // PedidoPanel
            // 
            this.PedidoPanel.Controls.Add(this.btn_ConsultaPed);
            this.PedidoPanel.Controls.Add(this.btn_Pedidos);
            this.PedidoPanel.Controls.Add(this.btn_CadastroPed);
            this.PedidoPanel.Location = new System.Drawing.Point(2, 176);
            this.PedidoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PedidoPanel.MaximumSize = new System.Drawing.Size(150, 106);
            this.PedidoPanel.MinimumSize = new System.Drawing.Size(150, 46);
            this.PedidoPanel.Name = "PedidoPanel";
            this.PedidoPanel.Size = new System.Drawing.Size(150, 46);
            this.PedidoPanel.TabIndex = 7;
            // 
            // btn_ConsultaPed
            // 
            this.btn_ConsultaPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_ConsultaPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultaPed.Location = new System.Drawing.Point(-20, 77);
            this.btn_ConsultaPed.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ConsultaPed.Name = "btn_ConsultaPed";
            this.btn_ConsultaPed.Size = new System.Drawing.Size(188, 29);
            this.btn_ConsultaPed.TabIndex = 9;
            this.btn_ConsultaPed.Text = "            Consulta Pedido";
            this.btn_ConsultaPed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConsultaPed.UseVisualStyleBackColor = false;
            this.btn_ConsultaPed.Click += new System.EventHandler(this.btn_ConsultaPed_Click);
            // 
            // btn_Pedidos
            // 
            this.btn_Pedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Pedidos.FlatAppearance.BorderSize = 0;
            this.btn_Pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pedidos.Location = new System.Drawing.Point(0, 0);
            this.btn_Pedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Pedidos.Name = "btn_Pedidos";
            this.btn_Pedidos.Size = new System.Drawing.Size(150, 48);
            this.btn_Pedidos.TabIndex = 4;
            this.btn_Pedidos.Text = "Pedidos";
            this.btn_Pedidos.UseVisualStyleBackColor = false;
            this.btn_Pedidos.Click += new System.EventHandler(this.btn_Pedidos_Click);
            // 
            // btn_CadastroPed
            // 
            this.btn_CadastroPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_CadastroPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroPed.Location = new System.Drawing.Point(-18, 46);
            this.btn_CadastroPed.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CadastroPed.Name = "btn_CadastroPed";
            this.btn_CadastroPed.Size = new System.Drawing.Size(188, 32);
            this.btn_CadastroPed.TabIndex = 8;
            this.btn_CadastroPed.Text = "           Cadastro Pedido";
            this.btn_CadastroPed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastroPed.UseVisualStyleBackColor = false;
            this.btn_CadastroPed.Click += new System.EventHandler(this.btn_CadastroPed_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Location = new System.Drawing.Point(2, 226);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(150, 41);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click_1);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(600, 367);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtom)).EndInit();
            this.HomeContainer.ResumeLayout(false);
            this.EntregaPanel.ResumeLayout(false);
            this.PedidoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Pedidos;
        private System.Windows.Forms.Button btn_Entrega;
        private System.Windows.Forms.PictureBox MenuButtom;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Button btn_CadastroFamiliar;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Button btn_CadastroEntregadora;
        private System.Windows.Forms.Button btn_CadastroEmpresaFabricante;
        private System.Windows.Forms.Button btn_CadastroAlimentos;
        private System.Windows.Forms.Button btn_CadastroDoadores;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel EntregaPanel;
        private System.Windows.Forms.Button btn_ConsultaEnt;
        private System.Windows.Forms.Button btn_cadastroEnt;
        private System.Windows.Forms.Panel PedidoPanel;
        private System.Windows.Forms.Button btn_ConsultaPed;
        private System.Windows.Forms.Button btn_CadastroPed;
        private System.Windows.Forms.Timer Entrega_Timer;
        private System.Windows.Forms.Timer PedidoTimer;
    }
}