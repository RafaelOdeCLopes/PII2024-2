namespace PII2024_2
{
    partial class frmExibicao
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
            this.dgvExibicao = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblTabela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExibicao
            // 
            this.dgvExibicao.AllowUserToAddRows = false;
            this.dgvExibicao.AllowUserToDeleteRows = false;
            this.dgvExibicao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExibicao.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExibicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibicao.Location = new System.Drawing.Point(12, 212);
            this.dgvExibicao.Name = "dgvExibicao";
            this.dgvExibicao.RowHeadersWidth = 51;
            this.dgvExibicao.RowTemplate.Height = 24;
            this.dgvExibicao.Size = new System.Drawing.Size(952, 447);
            this.dgvExibicao.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInserir.Location = new System.Drawing.Point(76, 121);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(161, 52);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditar.Location = new System.Drawing.Point(410, 121);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(161, 52);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluir.Location = new System.Drawing.Point(744, 121);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(161, 52);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblTabela
            // 
            this.lblTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.Location = new System.Drawing.Point(5, 9);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(952, 86);
            this.lblTabela.TabIndex = 4;
            this.lblTabela.Text = "Tabela: ";
            this.lblTabela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmExibicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 671);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dgvExibicao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmExibicao";
            this.Text = "Exibição de tabelas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibicao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExibicao;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblTabela;
    }
}