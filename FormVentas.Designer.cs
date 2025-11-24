namespace CrudEjemplo.Clases
{
    partial class FormVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerCategoria = new System.Windows.Forms.Button();
            this.txtPrecioUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtFecha_Venta = new System.Windows.Forms.TextBox();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTotalobjetoVentas = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalobjetoVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtIdProducto);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnVerCategoria);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtPrecioUnit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtFecha_Venta);
            this.groupBox1.Controls.Add(this.txtIdVenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PRODUCTO";
            // 
            // btnVerCategoria
            // 
            this.btnVerCategoria.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerCategoria.Location = new System.Drawing.Point(118, 223);
            this.btnVerCategoria.Name = "btnVerCategoria";
            this.btnVerCategoria.Size = new System.Drawing.Size(296, 30);
            this.btnVerCategoria.TabIndex = 19;
            this.btnVerCategoria.Text = "Info completa de las ventas";
            this.btnVerCategoria.UseVisualStyleBackColor = false;
            this.btnVerCategoria.Click += new System.EventHandler(this.btnVerCategoria_Click);
            // 
            // txtPrecioUnit
            // 
            this.txtPrecioUnit.Location = new System.Drawing.Point(602, 85);
            this.txtPrecioUnit.Name = "txtPrecioUnit";
            this.txtPrecioUnit.Size = new System.Drawing.Size(178, 26);
            this.txtPrecioUnit.TabIndex = 17;
            this.txtPrecioUnit.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio Unitario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.Location = new System.Drawing.Point(676, 206);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 30);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.Location = new System.Drawing.Point(477, 206);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 30);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(507, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(296, 30);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(602, 33);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(178, 26);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtFecha_Venta
            // 
            this.txtFecha_Venta.Location = new System.Drawing.Point(187, 191);
            this.txtFecha_Venta.Name = "txtFecha_Venta";
            this.txtFecha_Venta.Size = new System.Drawing.Size(178, 26);
            this.txtFecha_Venta.TabIndex = 8;
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Enabled = false;
            this.txtIdVenta.Location = new System.Drawing.Point(187, 42);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.ReadOnly = true;
            this.txtIdVenta.Size = new System.Drawing.Size(178, 26);
            this.txtIdVenta.TabIndex = 7;
            this.txtIdVenta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Venta";
            // 
            // dgvTotalobjetoVentas
            // 
            this.dgvTotalobjetoVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTotalobjetoVentas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTotalobjetoVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalobjetoVentas.Location = new System.Drawing.Point(12, 261);
            this.dgvTotalobjetoVentas.Name = "dgvTotalobjetoVentas";
            this.dgvTotalobjetoVentas.RowHeadersWidth = 62;
            this.dgvTotalobjetoVentas.RowTemplate.Height = 28;
            this.dgvTotalobjetoVentas.Size = new System.Drawing.Size(865, 177);
            this.dgvTotalobjetoVentas.TabIndex = 1;
            this.dgvTotalobjetoVentas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTotalUsuarios_CellMouseClick);
            this.dgvTotalobjetoVentas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTotalUsuarios_CellMouseDoubleClick);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(602, 138);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 26);
            this.txtTotal.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Id Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Id Producto";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(187, 88);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(178, 26);
            this.txtIdCliente.TabIndex = 24;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(187, 138);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(178, 26);
            this.txtIdProducto.TabIndex = 25;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.dgvTotalobjetoVentas);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProducto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalobjetoVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFecha_Venta;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvTotalobjetoVentas;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TextBox txtPrecioUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdProducto;
    }
}

