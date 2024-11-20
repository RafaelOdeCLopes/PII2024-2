namespace PII2024_2
{
    partial class CadastroEmpresasEntregadoras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNomeEmpresaEntregadora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereçoentregadora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelefoneentregadora = new System.Windows.Forms.TextBox();
            this.btnSalvarEntregadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(233, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar Empresa Entregadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(302, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // TbNomeEmpresaEntregadora
            // 
            this.TbNomeEmpresaEntregadora.Location = new System.Drawing.Point(306, 148);
            this.TbNomeEmpresaEntregadora.Margin = new System.Windows.Forms.Padding(4);
            this.TbNomeEmpresaEntregadora.Name = "TbNomeEmpresaEntregadora";
            this.TbNomeEmpresaEntregadora.Size = new System.Drawing.Size(204, 22);
            this.TbNomeEmpresaEntregadora.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(302, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Endereço:";
            // 
            // txtEndereçoentregadora
            // 
            this.txtEndereçoentregadora.Location = new System.Drawing.Point(306, 210);
            this.txtEndereçoentregadora.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereçoentregadora.Name = "txtEndereçoentregadora";
            this.txtEndereçoentregadora.Size = new System.Drawing.Size(204, 22);
            this.txtEndereçoentregadora.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(302, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefone:";
            // 
            // txttelefoneentregadora
            // 
            this.txttelefoneentregadora.Location = new System.Drawing.Point(306, 270);
            this.txttelefoneentregadora.Margin = new System.Windows.Forms.Padding(4);
            this.txttelefoneentregadora.Name = "txttelefoneentregadora";
            this.txttelefoneentregadora.Size = new System.Drawing.Size(204, 22);
            this.txttelefoneentregadora.TabIndex = 15;
            // 
            // btnSalvarEntregadora
            // 
            this.btnSalvarEntregadora.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnSalvarEntregadora.Location = new System.Drawing.Point(364, 329);
            this.btnSalvarEntregadora.Name = "btnSalvarEntregadora";
            this.btnSalvarEntregadora.Size = new System.Drawing.Size(95, 49);
            this.btnSalvarEntregadora.TabIndex = 16;
            this.btnSalvarEntregadora.Text = "Salvar";
            this.btnSalvarEntregadora.UseVisualStyleBackColor = true;
            this.btnSalvarEntregadora.Click += new System.EventHandler(this.btnSalvarEntregadora_Click);
            // 
            // CadastroEmpresasEntregadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvarEntregadora);
            this.Controls.Add(this.txttelefoneentregadora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndereçoentregadora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbNomeEmpresaEntregadora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroEmpresasEntregadoras";
            this.Text = "Empresa entregadoras";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TbNomeEmpresaEntregadora, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtEndereçoentregadora, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txttelefoneentregadora, 0);
            this.Controls.SetChildIndex(this.btnSalvarEntregadora, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNomeEmpresaEntregadora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndereçoentregadora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttelefoneentregadora;
        private System.Windows.Forms.Button btnSalvarEntregadora;
    }
}