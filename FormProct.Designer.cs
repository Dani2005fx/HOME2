namespace CrudEjemplo.Clases
{
    partial class FormProct
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtExistenciasProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTotalProductos = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.txtCodCategoria = new System.Windows.Forms.TextBox();
            this.btnVerCategoria = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnVerCategoria);
            this.groupBox1.Controls.Add(this.txtCodCategoria);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtExistenciasProducto);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.txtIdProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PRODUCTO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(81, 144);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(300, 26);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.Location = new System.Drawing.Point(221, 388);
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
            this.btnModificar.Location = new System.Drawing.Point(22, 388);
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
            this.btnGuardar.Location = new System.Drawing.Point(59, 352);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(296, 30);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtExistenciasProducto
            // 
            this.txtExistenciasProducto.Location = new System.Drawing.Point(81, 208);
            this.txtExistenciasProducto.Name = "txtExistenciasProducto";
            this.txtExistenciasProducto.Size = new System.Drawing.Size(300, 26);
            this.txtExistenciasProducto.TabIndex = 9;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(81, 85);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(300, 26);
            this.txtNombreProducto.TabIndex = 8;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(81, 33);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(300, 26);
            this.txtIdProducto.TabIndex = 7;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cod_Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Existencias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // dgvTotalProductos
            // 
            this.dgvTotalProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTotalProductos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTotalProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalProductos.Location = new System.Drawing.Point(440, 12);
            this.dgvTotalProductos.Name = "dgvTotalProductos";
            this.dgvTotalProductos.RowHeadersWidth = 62;
            this.dgvTotalProductos.RowTemplate.Height = 28;
            this.dgvTotalProductos.Size = new System.Drawing.Size(436, 426);
            this.dgvTotalProductos.TabIndex = 1;
            this.dgvTotalProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTotalUsuarios_CellMouseClick);
            this.dgvTotalProductos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTotalUsuarios_CellMouseDoubleClick);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // txtCodCategoria
            // 
            this.txtCodCategoria.Location = new System.Drawing.Point(81, 280);
            this.txtCodCategoria.Name = "txtCodCategoria";
            this.txtCodCategoria.Size = new System.Drawing.Size(300, 26);
            this.txtCodCategoria.TabIndex = 18;
            // 
            // btnVerCategoria
            // 
            this.btnVerCategoria.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerCategoria.Location = new System.Drawing.Point(59, 312);
            this.btnVerCategoria.Name = "btnVerCategoria";
            this.btnVerCategoria.Size = new System.Drawing.Size(296, 30);
            this.btnVerCategoria.TabIndex = 19;
            this.btnVerCategoria.Text = "Ver  Lista de Categorias";
            this.btnVerCategoria.UseVisualStyleBackColor = false;
            this.btnVerCategoria.Click += new System.EventHandler(this.btnVerCategoria_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.dgvTotalProductos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProducto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExistenciasProducto;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvTotalProductos;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodCategoria;
        private System.Windows.Forms.Button btnVerCategoria;
    }
}

