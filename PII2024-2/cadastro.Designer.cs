namespace PII2024_2
{
    partial class FrmCadastro
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
            this.TbNome = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.TbTelefone = new System.Windows.Forms.TextBox();
            this.TbEndereco = new System.Windows.Forms.TextBox();
            this.TbMembros = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblMembros = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(105, 148);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(154, 20);
            this.TbNome.TabIndex = 0;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(100, 45);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(160, 25);
            this.lblCadastro.TabIndex = 2;
            this.lblCadastro.Text = "Faça o cadastro :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(103, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome Responsável :";
            // 
            // TbTelefone
            // 
            this.TbTelefone.Location = new System.Drawing.Point(105, 290);
            this.TbTelefone.Name = "TbTelefone";
            this.TbTelefone.Size = new System.Drawing.Size(154, 20);
            this.TbTelefone.TabIndex = 4;
            // 
            // TbEndereco
            // 
            this.TbEndereco.Location = new System.Drawing.Point(105, 221);
            this.TbEndereco.Name = "TbEndereco";
            this.TbEndereco.Size = new System.Drawing.Size(154, 20);
            this.TbEndereco.TabIndex = 5;
            // 
            // TbMembros
            // 
            this.TbMembros.Location = new System.Drawing.Point(105, 357);
            this.TbMembros.Name = "TbMembros";
            this.TbMembros.Size = new System.Drawing.Size(154, 20);
            this.TbMembros.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(102, 193);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(60, 16);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço :";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(103, 261);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 16);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone :";
            // 
            // lblMembros
            // 
            this.lblMembros.AutoSize = true;
            this.lblMembros.BackColor = System.Drawing.Color.Transparent;
            this.lblMembros.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembros.Location = new System.Drawing.Point(102, 329);
            this.lblMembros.Name = "lblMembros";
            this.lblMembros.Size = new System.Drawing.Size(94, 16);
            this.lblMembros.TabIndex = 9;
            this.lblMembros.Text = "N° de membros :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PII2024_2.Properties.Resources.Design_sem_nome__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMembros);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.TbMembros);
            this.Controls.Add(this.TbEndereco);
            this.Controls.Add(this.TbTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.TbNome);
            this.DoubleBuffered = true;
            this.Name = "FrmCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox TbTelefone;
        private System.Windows.Forms.TextBox TbEndereco;
        private System.Windows.Forms.TextBox TbMembros;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMembros;
        private System.Windows.Forms.Button button1;
    }
}