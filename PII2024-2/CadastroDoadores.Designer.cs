﻿namespace PII2024_2
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
            this.btnSalvar = new System.Windows.Forms.Button();
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
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(410, 260);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 35);
            this.btnSalvar.TabIndex = 33;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // CadastroDoadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 330);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.TbContato);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.TbNome);
            this.DoubleBuffered = true;
            this.Name = "CadastroDoadores";
            this.Text = "CadastroDoadores";
            this.Controls.SetChildIndex(this.TbNome, 0);
            this.Controls.SetChildIndex(this.lblCadastro, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.TbContato, 0);
            this.Controls.SetChildIndex(this.lblContato, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox TbContato;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Button btnSalvar;
    }
}