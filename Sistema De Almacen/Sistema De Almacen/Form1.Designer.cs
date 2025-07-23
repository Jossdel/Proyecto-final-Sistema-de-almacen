namespace Sistema_De_Almacen
{
    partial class btnActualizarProductos
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.btnAgregarproductos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportarDatos = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSidebar.Controls.Add(this.btnEliminarProducto);
            this.panelSidebar.Controls.Add(this.btnMostrarProductos);
            this.panelSidebar.Controls.Add(this.btnAgregarproductos);
            this.panelSidebar.Controls.Add(this.btnSalir);
            this.panelSidebar.Controls.Add(this.btnExportarDatos);
            this.panelSidebar.Controls.Add(this.btnActualizarProducto);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.MaximumSize = new System.Drawing.Size(200, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(128, 622);
            this.panelSidebar.TabIndex = 3;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackgroundImage = global::Sistema_De_Almacen.Properties.Resources.Gemini_Generated_Image_kdndzqkdndzqkdnd1;
            this.pnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(128, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(915, 622);
            this.pnlContenedor.TabIndex = 4;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Image = global::Sistema_De_Almacen.Properties.Resources.agotado;
            this.btnEliminarProducto.Location = new System.Drawing.Point(0, 359);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(128, 104);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarProductos.FlatAppearance.BorderSize = 0;
            this.btnMostrarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarProductos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarProductos.Image = global::Sistema_De_Almacen.Properties.Resources.package__1_;
            this.btnMostrarProductos.Location = new System.Drawing.Point(0, 122);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(128, 111);
            this.btnMostrarProductos.TabIndex = 0;
            this.btnMostrarProductos.Text = "Mostrar Productos";
            this.btnMostrarProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // btnAgregarproductos
            // 
            this.btnAgregarproductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarproductos.FlatAppearance.BorderSize = 0;
            this.btnAgregarproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarproductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarproductos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarproductos.Image = global::Sistema_De_Almacen.Properties.Resources.add_product;
            this.btnAgregarproductos.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarproductos.Name = "btnAgregarproductos";
            this.btnAgregarproductos.Size = new System.Drawing.Size(128, 122);
            this.btnAgregarproductos.TabIndex = 1;
            this.btnAgregarproductos.Text = "Agregar Productos";
            this.btnAgregarproductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarproductos.UseVisualStyleBackColor = true;
            this.btnAgregarproductos.Click += new System.EventHandler(this.btnAgregarproductos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Sistema_De_Almacen.Properties.Resources.cerrar_sesion;
            this.btnSalir.Location = new System.Drawing.Point(-6, 551);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 71);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportarDatos
            // 
            this.btnExportarDatos.FlatAppearance.BorderSize = 0;
            this.btnExportarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarDatos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarDatos.ForeColor = System.Drawing.Color.White;
            this.btnExportarDatos.Image = global::Sistema_De_Almacen.Properties.Resources.subir;
            this.btnExportarDatos.Location = new System.Drawing.Point(0, 469);
            this.btnExportarDatos.Name = "btnExportarDatos";
            this.btnExportarDatos.Size = new System.Drawing.Size(128, 74);
            this.btnExportarDatos.TabIndex = 4;
            this.btnExportarDatos.Text = "Exportar Datos";
            this.btnExportarDatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportarDatos.UseVisualStyleBackColor = true;
            this.btnExportarDatos.Click += new System.EventHandler(this.btnExportarDatos_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.FlatAppearance.BorderSize = 0;
            this.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProducto.ForeColor = System.Drawing.Color.White;
            this.btnActualizarProducto.Image = global::Sistema_De_Almacen.Properties.Resources.lifecycle;
            this.btnActualizarProducto.Location = new System.Drawing.Point(0, 239);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(128, 114);
            this.btnActualizarProducto.TabIndex = 2;
            this.btnActualizarProducto.Text = "Actualizar Producto";
            this.btnActualizarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnActualizarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 622);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panelSidebar);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "btnActualizarProductos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnAgregarproductos;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportarDatos;
    }
}

