namespace PII2024_2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Cadastro = new System.Windows.Forms.Button();
            this.btn_Entrega = new System.Windows.Forms.Button();
            this.btn_Pedidos = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtom)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackgroundImage = global::PII2024_2.Properties.Resources.Degrade_Laranjaclaro;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.btn_Cadastro);
            this.sidebar.Controls.Add(this.btn_Entrega);
            this.sidebar.Controls.Add(this.btn_Pedidos);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 450);
            this.sidebar.MinimumSize = new System.Drawing.Size(73, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 450);
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
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.btn_Menu);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 63);
            this.panel2.TabIndex = 2;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Location = new System.Drawing.Point(-26, -6);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(251, 76);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "Home";
            this.btn_Menu.UseVisualStyleBackColor = false;
            // 
            // btn_Cadastro
            // 
            this.btn_Cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Cadastro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Cadastro.FlatAppearance.BorderSize = 0;
            this.btn_Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastro.Location = new System.Drawing.Point(3, 178);
            this.btn_Cadastro.Name = "btn_Cadastro";
            this.btn_Cadastro.Size = new System.Drawing.Size(200, 76);
            this.btn_Cadastro.TabIndex = 3;
            this.btn_Cadastro.Text = "Cadastros";
            this.btn_Cadastro.UseVisualStyleBackColor = false;
            // 
            // btn_Entrega
            // 
            this.btn_Entrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Entrega.FlatAppearance.BorderSize = 0;
            this.btn_Entrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrega.Location = new System.Drawing.Point(3, 260);
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
            this.btn_Pedidos.Location = new System.Drawing.Point(3, 342);
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
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Cadastro;
        private System.Windows.Forms.Button btn_Pedidos;
        private System.Windows.Forms.Button btn_Entrega;
        private System.Windows.Forms.PictureBox MenuButtom;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}