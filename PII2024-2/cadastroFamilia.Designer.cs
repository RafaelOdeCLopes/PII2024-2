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
            this.txt_NomeResponsavel = new System.Windows.Forms.TextBox();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblMembros = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.Nud_NumeroMembros = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_NumeroMembros)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NomeResponsavel
            // 
            this.txt_NomeResponsavel.Location = new System.Drawing.Point(140, 182);
            this.txt_NomeResponsavel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomeResponsavel.Name = "txt_NomeResponsavel";
            this.txt_NomeResponsavel.Size = new System.Drawing.Size(204, 22);
            this.txt_NomeResponsavel.TabIndex = 0;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(133, 55);
            this.lblCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(305, 31);
            this.lblCadastro.TabIndex = 2;
            this.lblCadastro.Text = "Faça o cadastro da família:";
            this.lblCadastro.Click += new System.EventHandler(this.lblCadastro_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(137, 143);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(138, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome Responsável :";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(450, 179);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(204, 22);
            this.txt_Telefone.TabIndex = 4;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(140, 272);
            this.txt_Endereco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(204, 22);
            this.txt_Endereco.TabIndex = 5;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(136, 238);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 20);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço :";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(447, 143);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(72, 20);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone :";
            // 
            // lblMembros
            // 
            this.lblMembros.AutoSize = true;
            this.lblMembros.BackColor = System.Drawing.Color.Transparent;
            this.lblMembros.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembros.Location = new System.Drawing.Point(447, 238);
            this.lblMembros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMembros.Name = "lblMembros";
            this.lblMembros.Size = new System.Drawing.Size(117, 20);
            this.lblMembros.TabIndex = 9;
            this.lblMembros.Text = "N° de membros :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 489);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(356, 363);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 11;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // Nud_NumeroMembros
            // 
            this.Nud_NumeroMembros.Location = new System.Drawing.Point(450, 272);
            this.Nud_NumeroMembros.Name = "Nud_NumeroMembros";
            this.Nud_NumeroMembros.Size = new System.Drawing.Size(204, 22);
            this.Nud_NumeroMembros.TabIndex = 12;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(219)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nud_NumeroMembros);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMembros);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.txt_NomeResponsavel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastro";
            this.Text = "Cadastro";
            this.Controls.SetChildIndex(this.txt_NomeResponsavel, 0);
            this.Controls.SetChildIndex(this.lblCadastro, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txt_Telefone, 0);
            this.Controls.SetChildIndex(this.txt_Endereco, 0);
            this.Controls.SetChildIndex(this.lblEndereco, 0);
            this.Controls.SetChildIndex(this.lblTelefone, 0);
            this.Controls.SetChildIndex(this.lblMembros, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btn_salvar, 0);
            this.Controls.SetChildIndex(this.Nud_NumeroMembros, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_NumeroMembros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomeResponsavel;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblMembros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.NumericUpDown Nud_NumeroMembros;
    }
}