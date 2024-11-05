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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.MenuButtom = new System.Windows.Forms.PictureBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Entrega = new System.Windows.Forms.Button();
            this.btn_Pedidos = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.btn_CadastroFamiliar = new System.Windows.Forms.Button();
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_CadastroEmpresaFabricante = new System.Windows.Forms.Button();
            this.btn_CadastroEntregadora = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtom)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackgroundImage = global::PII2024_2.Properties.Resources.Degrade_Laranjaclaro;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.HomeContainer);
            this.sidebar.Controls.Add(this.btn_Entrega);
            this.sidebar.Controls.Add(this.btn_Pedidos);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 450);
            this.sidebar.MinimumSize = new System.Drawing.Size(73, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(73, 450);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl_Menu);
            this.panel1.Controls.Add(this.MenuButtom);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Location = new System.Drawing.Point(84, 32);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(40, 16);
            this.lbl_Menu.TabIndex = 1;
            this.lbl_Menu.Text = "Menu";
            this.lbl_Menu.Click += new System.EventHandler(this.lbl_Menu_Click);
            // 
            // MenuButtom
            // 
            this.MenuButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButtom.Image = global::PII2024_2.Properties.Resources.menu_png;
            this.MenuButtom.Location = new System.Drawing.Point(9, 9);
            this.MenuButtom.Name = "MenuButtom";
            this.MenuButtom.Size = new System.Drawing.Size(54, 55);
            this.MenuButtom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuButtom.TabIndex = 0;
            this.MenuButtom.TabStop = false;
            this.MenuButtom.Click += new System.EventHandler(this.MenuButtom_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(119)))), ((int)(((byte)(10)))));
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Location = new System.Drawing.Point(-25, -2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(251, 51);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "Cadastro";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Entrega
            // 
            this.btn_Entrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Entrega.FlatAppearance.BorderSize = 0;
            this.btn_Entrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrega.Location = new System.Drawing.Point(3, 162);
            this.btn_Entrega.Name = "btn_Entrega";
            this.btn_Entrega.Size = new System.Drawing.Size(200, 76);
            this.btn_Entrega.TabIndex = 5;
            this.btn_Entrega.Text = "Entrega";
            this.btn_Entrega.UseVisualStyleBackColor = false;
            // 
            // btn_Pedidos
            // 
            this.btn_Pedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Pedidos.FlatAppearance.BorderSize = 0;
            this.btn_Pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pedidos.Location = new System.Drawing.Point(3, 244);
            this.btn_Pedidos.Name = "btn_Pedidos";
            this.btn_Pedidos.Size = new System.Drawing.Size(200, 76);
            this.btn_Pedidos.TabIndex = 4;
            this.btn_Pedidos.Text = "Pedidos";
            this.btn_Pedidos.UseVisualStyleBackColor = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(689, 28);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 23);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Trick);
            // 
            // HomeContainer
            // 
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HomeContainer.Controls.Add(this.button2);
            this.HomeContainer.Controls.Add(this.button1);
            this.HomeContainer.Controls.Add(this.btn_CadastroEntregadora);
            this.HomeContainer.Controls.Add(this.btn_CadastroEmpresaFabricante);
            this.HomeContainer.Controls.Add(this.btn_CadastroFamiliar);
            this.HomeContainer.Controls.Add(this.btn_Menu);
            this.HomeContainer.Location = new System.Drawing.Point(3, 109);
            this.HomeContainer.MaximumSize = new System.Drawing.Size(200, 229);
            this.HomeContainer.MinimumSize = new System.Drawing.Size(200, 45);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(200, 47);
            this.HomeContainer.TabIndex = 6;
            // 
            // btn_CadastroFamiliar
            // 
            this.btn_CadastroFamiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_CadastroFamiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroFamiliar.Location = new System.Drawing.Point(-23, 47);
            this.btn_CadastroFamiliar.Name = "btn_CadastroFamiliar";
            this.btn_CadastroFamiliar.Size = new System.Drawing.Size(251, 40);
            this.btn_CadastroFamiliar.TabIndex = 2;
            this.btn_CadastroFamiliar.Text = "           Cadastro Familiar";
            this.btn_CadastroFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastroFamiliar.UseVisualStyleBackColor = false;
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 5;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // btn_CadastroEmpresaFabricante
            // 
            this.btn_CadastroEmpresaFabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_CadastroEmpresaFabricante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroEmpresaFabricante.Location = new System.Drawing.Point(-25, 84);
            this.btn_CadastroEmpresaFabricante.Name = "btn_CadastroEmpresaFabricante";
            this.btn_CadastroEmpresaFabricante.Size = new System.Drawing.Size(251, 40);
            this.btn_CadastroEmpresaFabricante.TabIndex = 3;
            this.btn_CadastroEmpresaFabricante.Text = "           Cadastro Fabricante";
            this.btn_CadastroEmpresaFabricante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastroEmpresaFabricante.UseVisualStyleBackColor = false;
            // 
            // btn_CadastroEntregadora
            // 
            this.btn_CadastroEntregadora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.btn_CadastroEntregadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroEntregadora.Location = new System.Drawing.Point(-25, 120);
            this.btn_CadastroEntregadora.Name = "btn_CadastroEntregadora";
            this.btn_CadastroEntregadora.Size = new System.Drawing.Size(251, 40);
            this.btn_CadastroEntregadora.TabIndex = 4;
            this.btn_CadastroEntregadora.Text = "           Cadastro Entregadora";
            this.btn_CadastroEntregadora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastroEntregadora.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-23, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "          Cadastro Doadores";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(68)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(-22, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "          Cadastro Alimentos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtom)).EndInit();
            this.HomeContainer.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Button btn_CadastroFamiliar;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Button btn_CadastroEntregadora;
        private System.Windows.Forms.Button btn_CadastroEmpresaFabricante;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}