﻿namespace PII2024_2
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
            this.lblEntrega.Location = new System.Drawing.Point(222, 42);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(255, 25);
            this.lblEntrega.TabIndex = 6;
            this.lblEntrega.Text = "Faça a consulta da entrega :";
            // 
            // CbEntrega
            // 
            this.CbEntrega.FormattingEnabled = true;
            this.CbEntrega.Location = new System.Drawing.Point(157, 70);
            this.CbEntrega.Name = "CbEntrega";
            this.CbEntrega.Size = new System.Drawing.Size(367, 21);
            this.CbEntrega.TabIndex = 5;
            this.CbEntrega.SelectedIndexChanged += new System.EventHandler(this.CbEntrega_SelectedIndexChanged);
            // 
            // DgvEntrega
            // 
            this.DgvEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEntrega.Location = new System.Drawing.Point(99, 97);
            this.DgvEntrega.Name = "DgvEntrega";
            this.DgvEntrega.RowHeadersWidth = 51;
            this.DgvEntrega.Size = new System.Drawing.Size(462, 257);
            this.DgvEntrega.TabIndex = 4;
            // 
            // GridConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblEntrega);
            this.Controls.Add(this.CbEntrega);
            this.Controls.Add(this.DgvEntrega);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GridConsulta";
            this.Text = "Consulta de entrega";
            this.Load += new System.EventHandler(this.GridConsulta_Load);
            this.Controls.SetChildIndex(this.DgvEntrega, 0);
            this.Controls.SetChildIndex(this.CbEntrega, 0);
            this.Controls.SetChildIndex(this.lblEntrega, 0);
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