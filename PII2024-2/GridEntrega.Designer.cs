namespace PII2024_2
{
    partial class GridConsulta
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
            this.lblEntrega = new System.Windows.Forms.Label();
            this.CbEntrega = new System.Windows.Forms.ComboBox();
            this.DgvEntrega = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrega.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrega.Location = new System.Drawing.Point(205, 25);
            this.lblEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(322, 31);
            this.lblEntrega.TabIndex = 6;
            this.lblEntrega.Text = "Faça a consulta da entrega :";
            this.lblEntrega.Click += new System.EventHandler(this.lblPedido_Click);
            // 
            // CbEntrega
            // 
            this.CbEntrega.FormattingEnabled = true;
            this.CbEntrega.Location = new System.Drawing.Point(144, 89);
            this.CbEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.CbEntrega.Name = "CbEntrega";
            this.CbEntrega.Size = new System.Drawing.Size(488, 24);
            this.CbEntrega.TabIndex = 5;
            // 
            // DgvEntrega
            // 
            this.DgvEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEntrega.Location = new System.Drawing.Point(144, 121);
            this.DgvEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.DgvEntrega.Name = "DgvEntrega";
            this.DgvEntrega.RowHeadersWidth = 51;
            this.DgvEntrega.Size = new System.Drawing.Size(489, 316);
            this.DgvEntrega.TabIndex = 4;
            // 
            // GridConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PII2024_2.Properties.Resources.Design_sem_nome__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEntrega);
            this.Controls.Add(this.CbEntrega);
            this.Controls.Add(this.DgvEntrega);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GridConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de entrega";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.ComboBox CbEntrega;
        private System.Windows.Forms.DataGridView DgvEntrega;
    }
}