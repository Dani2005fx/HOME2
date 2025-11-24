namespace CrudEjemplo.Clases
{
    partial class DocVentas
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
            this.dgvTotalVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotalVentas
            // 
            this.dgvTotalVentas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTotalVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalVentas.Location = new System.Drawing.Point(-2, -2);
            this.dgvTotalVentas.Name = "dgvTotalVentas";
            this.dgvTotalVentas.RowHeadersWidth = 62;
            this.dgvTotalVentas.RowTemplate.Height = 28;
            this.dgvTotalVentas.Size = new System.Drawing.Size(801, 454);
            this.dgvTotalVentas.TabIndex = 0;
            this.dgvTotalVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DocVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTotalVentas);
            this.Name = "DocVentas";
            this.Text = "DocVentas";
            this.Load += new System.EventHandler(this.DocVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotalVentas;
    }
}