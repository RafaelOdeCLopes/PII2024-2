namespace PII2024_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTelaInicial1 = new System.Windows.Forms.Label();
            this.lblTelaInicial2 = new System.Windows.Forms.Label();
            this.mnsTelaInicial = new System.Windows.Forms.MenuStrip();
            this.doadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasEntregadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasFabricantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famíliasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTelaInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTelaInicial1
            // 
            this.lblTelaInicial1.BackColor = System.Drawing.Color.Transparent;
            this.lblTelaInicial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaInicial1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(98)))), ((int)(((byte)(57)))));
            this.lblTelaInicial1.Location = new System.Drawing.Point(12, 162);
            this.lblTelaInicial1.Name = "lblTelaInicial1";
            this.lblTelaInicial1.Size = new System.Drawing.Size(776, 49);
            this.lblTelaInicial1.TabIndex = 0;
            this.lblTelaInicial1.Text = "FOME ZERO";
            this.lblTelaInicial1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelaInicial2
            // 
            this.lblTelaInicial2.BackColor = System.Drawing.Color.Transparent;
            this.lblTelaInicial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblTelaInicial2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(98)))), ((int)(((byte)(57)))));
            this.lblTelaInicial2.Location = new System.Drawing.Point(12, 235);
            this.lblTelaInicial2.Name = "lblTelaInicial2";
            this.lblTelaInicial2.Size = new System.Drawing.Size(776, 49);
            this.lblTelaInicial2.TabIndex = 1;
            this.lblTelaInicial2.Text = "PII VIII";
            this.lblTelaInicial2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnsTelaInicial
            // 
            this.mnsTelaInicial.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsTelaInicial.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doadoresToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnsTelaInicial.Location = new System.Drawing.Point(0, 0);
            this.mnsTelaInicial.Name = "mnsTelaInicial";
            this.mnsTelaInicial.Size = new System.Drawing.Size(800, 28);
            this.mnsTelaInicial.TabIndex = 2;
            this.mnsTelaInicial.Text = "menuStrip1";
            // 
            // doadoresToolStripMenuItem
            // 
            this.doadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alimentosToolStripMenuItem,
            this.doaçõesToolStripMenuItem,
            this.doadoresToolStripMenuItem1,
            this.empresasEntregadorasToolStripMenuItem,
            this.empresasFabricantesToolStripMenuItem,
            this.entregasToolStripMenuItem,
            this.famíliasToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.doadoresToolStripMenuItem.Name = "doadoresToolStripMenuItem";
            this.doadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.doadoresToolStripMenuItem.Text = "Tabelas";
            // 
            // alimentosToolStripMenuItem
            // 
            this.alimentosToolStripMenuItem.Name = "alimentosToolStripMenuItem";
            this.alimentosToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.alimentosToolStripMenuItem.Text = "Alimentos";
            this.alimentosToolStripMenuItem.Click += new System.EventHandler(this.alimentosToolStripMenuItem_Click);
            // 
            // doaçõesToolStripMenuItem
            // 
            this.doaçõesToolStripMenuItem.Name = "doaçõesToolStripMenuItem";
            this.doaçõesToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.doaçõesToolStripMenuItem.Text = "Doações";
            this.doaçõesToolStripMenuItem.Click += new System.EventHandler(this.doaçõesToolStripMenuItem_Click);
            // 
            // doadoresToolStripMenuItem1
            // 
            this.doadoresToolStripMenuItem1.Name = "doadoresToolStripMenuItem1";
            this.doadoresToolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            this.doadoresToolStripMenuItem1.Text = "Doadores";
            // 
            // empresasEntregadorasToolStripMenuItem
            // 
            this.empresasEntregadorasToolStripMenuItem.Name = "empresasEntregadorasToolStripMenuItem";
            this.empresasEntregadorasToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.empresasEntregadorasToolStripMenuItem.Text = "EmpresasEntregadoras";
            this.empresasEntregadorasToolStripMenuItem.Click += new System.EventHandler(this.empresasEntregadorasToolStripMenuItem_Click);
            // 
            // empresasFabricantesToolStripMenuItem
            // 
            this.empresasFabricantesToolStripMenuItem.Name = "empresasFabricantesToolStripMenuItem";
            this.empresasFabricantesToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.empresasFabricantesToolStripMenuItem.Text = "EmpresasFabricantes";
            this.empresasFabricantesToolStripMenuItem.Click += new System.EventHandler(this.empresasFabricantesToolStripMenuItem_Click);
            // 
            // entregasToolStripMenuItem
            // 
            this.entregasToolStripMenuItem.Name = "entregasToolStripMenuItem";
            this.entregasToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.entregasToolStripMenuItem.Text = "Entregas";
            this.entregasToolStripMenuItem.Click += new System.EventHandler(this.entregasToolStripMenuItem_Click);
            // 
            // famíliasToolStripMenuItem
            // 
            this.famíliasToolStripMenuItem.Name = "famíliasToolStripMenuItem";
            this.famíliasToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.famíliasToolStripMenuItem.Text = "Famílias";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PII2024_2.Properties.Resources.FomeZero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTelaInicial2);
            this.Controls.Add(this.lblTelaInicial1);
            this.Controls.Add(this.mnsTelaInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnsTelaInicial;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tela inicial";
            this.mnsTelaInicial.ResumeLayout(false);
            this.mnsTelaInicial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelaInicial1;
        private System.Windows.Forms.Label lblTelaInicial2;
        private System.Windows.Forms.MenuStrip mnsTelaInicial;
        private System.Windows.Forms.ToolStripMenuItem doadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empresasEntregadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasFabricantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famíliasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

