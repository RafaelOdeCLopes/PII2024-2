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
            this.TbContato = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(334, 138);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(55, 16);
            this.lblContato.TabIndex = 17;
            this.lblContato.Text = "Telefone :";
            // 
            // TbContato
            // 
            this.TbContato.Location = new System.Drawing.Point(337, 167);
            this.TbContato.Name = "TbContato";
            this.TbContato.Size = new System.Drawing.Size(154, 20);
            this.TbContato.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(102, 138);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 16);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome do Doador:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(99, 67);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(257, 25);
            this.lblCadastro.TabIndex = 11;
            this.lblCadastro.Text = "Faça o cadastro do Doador:";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(104, 170);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(154, 20);
            this.TbNome.TabIndex = 10;
            // 
            // CadastroDoadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PII2024_2.Properties.Resources.Design_sem_nome__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 330);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.TbContato);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.TbNome);
            this.DoubleBuffered = true;
            this.Name = "CadastroDoadores";
            this.Text = "CadastroDoadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox TbContato;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox TbNome;
    }
}