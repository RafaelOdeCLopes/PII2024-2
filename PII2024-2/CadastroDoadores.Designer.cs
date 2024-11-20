namespace PII2024_2
{
    partial class CadastroDoadores
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
            this.lblContato = new System.Windows.Forms.Label();
            this.txt_Contato = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(445, 170);
            this.lblContato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(72, 20);
            this.lblContato.TabIndex = 17;
            this.lblContato.Text = "Telefone :";
            // 
            // txt_Contato
            // 
            this.txt_Contato.Location = new System.Drawing.Point(449, 206);
            this.txt_Contato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Contato.Name = "txt_Contato";
            this.txt_Contato.Size = new System.Drawing.Size(204, 22);
            this.txt_Contato.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(136, 170);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(125, 20);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome do Doador:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(132, 82);
            this.lblCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(322, 31);
            this.lblCadastro.TabIndex = 11;
            this.lblCadastro.Text = "Faça o cadastro do Doador:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(139, 209);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(204, 22);
            this.txt_Nome.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(547, 320);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 43);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroDoadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 406);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txt_Contato);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.txt_Nome);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "CadastroDoadores";
            this.Text = "CadastroDoadores";
            this.Controls.SetChildIndex(this.txt_Nome, 0);
            this.Controls.SetChildIndex(this.lblCadastro, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txt_Contato, 0);
            this.Controls.SetChildIndex(this.lblContato, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txt_Contato;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btnSalvar;
    }
}