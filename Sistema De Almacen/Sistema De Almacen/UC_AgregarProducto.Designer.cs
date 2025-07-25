using System;

namespace Sistema_De_Almacen
{
    partial class UC_AgregarProducto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCantidadMin = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudMinima = new System.Windows.Forms.NumericUpDown();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cmbNecesidad = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNecesidad = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadMin
            // 
            this.lblCantidadMin.AutoSize = true;
            this.lblCantidadMin.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMin.ForeColor = System.Drawing.Color.White;
            this.lblCantidadMin.Location = new System.Drawing.Point(219, 349);
            this.lblCantidadMin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCantidadMin.Name = "lblCantidadMin";
            this.lblCantidadMin.Size = new System.Drawing.Size(138, 18);
            this.lblCantidadMin.TabIndex = 42;
            this.lblCantidadMin.Text = "Cantidad Minima:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(147, 348);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(1);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(60, 26);
            this.nudCantidad.TabIndex = 41;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(62, 349);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(86, 20);
            this.lblCantidad.TabIndex = 40;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // nudMinima
            // 
            this.nudMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinima.Location = new System.Drawing.Point(361, 347);
            this.nudMinima.Margin = new System.Windows.Forms.Padding(1);
            this.nudMinima.Name = "nudMinima";
            this.nudMinima.Size = new System.Drawing.Size(54, 26);
            this.nudMinima.TabIndex = 39;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Location = new System.Drawing.Point(610, 328);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(1);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(236, 38);
            this.txtEstado.TabIndex = 38;
            // 
            // cmbNecesidad
            // 
            this.cmbNecesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbNecesidad.FormattingEnabled = true;
            this.cmbNecesidad.Location = new System.Drawing.Point(610, 193);
            this.cmbNecesidad.Margin = new System.Windows.Forms.Padding(1);
            this.cmbNecesidad.Name = "cmbNecesidad";
            this.cmbNecesidad.Size = new System.Drawing.Size(235, 28);
            this.cmbNecesidad.TabIndex = 37;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(155, 101);
            this.txtID.Margin = new System.Windows.Forms.Padding(1);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(261, 35);
            this.txtID.TabIndex = 36;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Location = new System.Drawing.Point(610, 101);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(1);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(236, 35);
            this.txtCategoria.TabIndex = 35;
            // 
            // txtITBIS
            // 
            this.txtITBIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtITBIS.Location = new System.Drawing.Point(612, 261);
            this.txtITBIS.Margin = new System.Windows.Forms.Padding(1);
            this.txtITBIS.Multiline = true;
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.ReadOnly = true;
            this.txtITBIS.Size = new System.Drawing.Size(233, 36);
            this.txtITBIS.TabIndex = 34;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(507, 340);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 20);
            this.lblEstado.TabIndex = 29;
            this.lblEstado.Text = "Estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(154, 180);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 35);
            this.txtNombre.TabIndex = 25;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(155, 261);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(261, 40);
            this.txtPrecio.TabIndex = 27;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Image = global::Sistema_De_Almacen.Properties.Resources.id_del_paciente;
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.Location = new System.Drawing.Point(11, 101);
            this.lblID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(150, 34);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "              ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Image = global::Sistema_De_Almacen.Properties.Resources.multiple;
            this.lblCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategoria.Location = new System.Drawing.Point(458, 104);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(152, 30);
            this.lblCategoria.TabIndex = 32;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNecesidad
            // 
            this.lblNecesidad.BackColor = System.Drawing.Color.Transparent;
            this.lblNecesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNecesidad.ForeColor = System.Drawing.Color.White;
            this.lblNecesidad.Image = global::Sistema_De_Almacen.Properties.Resources.demencia;
            this.lblNecesidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNecesidad.Location = new System.Drawing.Point(459, 191);
            this.lblNecesidad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNecesidad.Name = "lblNecesidad";
            this.lblNecesidad.Size = new System.Drawing.Size(146, 24);
            this.lblNecesidad.TabIndex = 31;
            this.lblNecesidad.Text = "Necesidad:";
            this.lblNecesidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblITBIS
            // 
            this.lblITBIS.BackColor = System.Drawing.Color.Transparent;
            this.lblITBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblITBIS.ForeColor = System.Drawing.Color.White;
            this.lblITBIS.Image = global::Sistema_De_Almacen.Properties.Resources.blockchain_app;
            this.lblITBIS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblITBIS.Location = new System.Drawing.Point(451, 268);
            this.lblITBIS.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(146, 24);
            this.lblITBIS.TabIndex = 30;
            this.lblITBIS.Text = "        ITBIS:   ";
            this.lblITBIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Image = global::Sistema_De_Almacen.Properties.Resources.dar;
            this.lblNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombre.Location = new System.Drawing.Point(7, 180);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(143, 31);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = " Producto:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Image = global::Sistema_De_Almacen.Properties.Resources.price_tag;
            this.lblPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrecio.Location = new System.Drawing.Point(3, 268);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(147, 24);
            this.lblPrecio.TabIndex = 26;
            this.lblPrecio.Text = "         Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Sistema_De_Almacen.Properties.Resources.disk__1_;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(361, 455);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(166, 56);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "      Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // UC_AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_De_Almacen.Properties.Resources.Gemini_Generated_Image_1godj01godj01god;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblCantidadMin);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.nudMinima);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cmbNecesidad);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtITBIS);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNecesidad);
            this.Controls.Add(this.lblITBIS);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnGuardar);
            this.DoubleBuffered = true;
            this.Name = "UC_AgregarProducto";
            this.Size = new System.Drawing.Size(893, 558);
            this.Load += new System.EventHandler(this.UC_AgregarProducto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UC_AgregarProducto_Load_1(object sender, EventArgs e)
        {
            
        }



        #endregion

        private System.Windows.Forms.Label lblCantidadMin;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudMinima;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cmbNecesidad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNecesidad;
        private System.Windows.Forms.Label lblITBIS;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnGuardar;
    }
}
