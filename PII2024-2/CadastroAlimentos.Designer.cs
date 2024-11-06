namespace PII2024_2
{
    partial class CadastroAlimentos
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
            this.btnSalvarcadastroalimentos = new System.Windows.Forms.Button();
            this.cmbDoacao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbdata = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrigem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSalvarcadastroalimentos
            // 
            this.btnSalvarcadastroalimentos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarcadastroalimentos.Location = new System.Drawing.Point(381, 372);
            this.btnSalvarcadastroalimentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarcadastroalimentos.Name = "btnSalvarcadastroalimentos";
            this.btnSalvarcadastroalimentos.Size = new System.Drawing.Size(128, 46);
            this.btnSalvarcadastroalimentos.TabIndex = 32;
            this.btnSalvarcadastroalimentos.Text = "SALVAR";
            this.btnSalvarcadastroalimentos.UseVisualStyleBackColor = true;
            this.btnSalvarcadastroalimentos.Click += new System.EventHandler(this.btnSalvarcadastroalimentos_Click);
            // 
            // cmbDoacao
            // 
            this.cmbDoacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoacao.FormattingEnabled = true;
            this.cmbDoacao.Location = new System.Drawing.Point(305, 316);
            this.cmbDoacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDoacao.Name = "cmbDoacao";
            this.cmbDoacao.Size = new System.Drawing.Size(287, 24);
            this.cmbDoacao.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 27);
            this.label8.TabIndex = 30;
            this.label8.Text = "Doação:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(416, 286);
            this.cmbEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(176, 24);
            this.cmbEmpresa.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "Empresa fabricante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 26;
            this.label6.Text = "Origem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 39);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cadastro de Alimentos";
            // 
            // mtbdata
            // 
            this.mtbdata.Location = new System.Drawing.Point(392, 185);
            this.mtbdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbdata.Mask = "00/00/0000";
            this.mtbdata.Name = "mtbdata";
            this.mtbdata.Size = new System.Drawing.Size(79, 22);
            this.mtbdata.TabIndex = 24;
            this.mtbdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(343, 222);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(249, 22);
            this.txtQuantidade.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Data de validade:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(324, 146);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(268, 22);
            this.txtDescricao.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(291, 103);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 22);
            this.txtNome.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome:";
            // 
            // cmbOrigem
            // 
            this.cmbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigem.FormattingEnabled = true;
            this.cmbOrigem.Items.AddRange(new object[] {
            "Compra",
            "Doação"});
            this.cmbOrigem.Location = new System.Drawing.Point(306, 254);
            this.cmbOrigem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrigem.Name = "cmbOrigem";
            this.cmbOrigem.Size = new System.Drawing.Size(287, 24);
            this.cmbOrigem.TabIndex = 33;
            // 
            // CadastroAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbOrigem);
            this.Controls.Add(this.btnSalvarcadastroalimentos);
            this.Controls.Add(this.cmbDoacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbdata);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "CadastroAlimentos";
            this.Text = "Alimento";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtQuantidade, 0);
            this.Controls.SetChildIndex(this.mtbdata, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbEmpresa, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbDoacao, 0);
            this.Controls.SetChildIndex(this.btnSalvarcadastroalimentos, 0);
            this.Controls.SetChildIndex(this.cmbOrigem, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarcadastroalimentos;
        private System.Windows.Forms.ComboBox cmbDoacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbdata;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrigem;
    }
}