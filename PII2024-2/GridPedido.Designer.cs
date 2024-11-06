namespace PII2024_2
{
    partial class GridPedido
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
            this.DgvPedido = new System.Windows.Forms.DataGridView();
            this.CbPedido = new System.Windows.Forms.ComboBox();
            this.lblPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPedido
            // 
            this.DgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedido.Location = new System.Drawing.Point(123, 126);
            this.DgvPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvPedido.Name = "DgvPedido";
            this.DgvPedido.RowHeadersWidth = 51;
            this.DgvPedido.Size = new System.Drawing.Size(489, 316);
            this.DgvPedido.TabIndex = 0;
            // 
            // CbPedido
            // 
            this.CbPedido.FormattingEnabled = true;
            this.CbPedido.Location = new System.Drawing.Point(123, 70);
            this.CbPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbPedido.Name = "CbPedido";
            this.CbPedido.Size = new System.Drawing.Size(488, 24);
            this.CbPedido.TabIndex = 1;
            this.CbPedido.SelectedIndexChanged += new System.EventHandler(this.CbPedido_SelectedIndexChanged);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(195, 11);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(315, 31);
            this.lblPedido.TabIndex = 3;
            this.lblPedido.Text = "Faça a consulta de pedido :";
            // 
            // GridPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(219)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.CbPedido);
            this.Controls.Add(this.DgvPedido);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GridPedido";
            this.Text = "Consulta de pedidos";
            this.Load += new System.EventHandler(this.GridPedido_Load_1);
            this.Controls.SetChildIndex(this.DgvPedido, 0);
            this.Controls.SetChildIndex(this.CbPedido, 0);
            this.Controls.SetChildIndex(this.lblPedido, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPedido;
        private System.Windows.Forms.ComboBox CbPedido;
        private System.Windows.Forms.Label lblPedido;
    }
}