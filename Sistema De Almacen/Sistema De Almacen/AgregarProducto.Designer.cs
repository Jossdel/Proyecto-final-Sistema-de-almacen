using System;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class AgregarProducto : Form
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



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #region Windows Form Designer generated code


        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Button btnGuardar;
        private Button btnAgregarProducto;
        private Label lblNombre;
        private Label lblPrecio;

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNecesidad = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbNecesidad = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(575, 112);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(378, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(575, 302);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(378, 35);
            this.txtPrecio.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(282, 112);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(250, 29);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Producto:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(382, 292);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(89, 29);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Sistema_De_Almacen.Properties.Resources.disk__1_;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(441, 877);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(355, 80);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 3;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Image = global::Sistema_De_Almacen.Properties.Resources.add;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(930, 868);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(352, 80);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.Text = "     Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 885);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 893);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(436, 437);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(88, 29);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(398, 377);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 29);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "ITBIS";
            // 
            // lblNecesidad
            // 
            this.lblNecesidad.AutoSize = true;
            this.lblNecesidad.Location = new System.Drawing.Point(341, 238);
            this.lblNecesidad.Name = "lblNecesidad";
            this.lblNecesidad.Size = new System.Drawing.Size(130, 29);
            this.lblNecesidad.TabIndex = 11;
            this.lblNecesidad.Text = "Necesidad";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(341, 179);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(118, 29);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(282, 59);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(177, 29);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID del producto";
            // 
            // lblITBIS
            // 
            this.lblITBIS.Location = new System.Drawing.Point(575, 371);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(378, 35);
            this.lblITBIS.TabIndex = 14;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(575, 173);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(378, 35);
            this.txtCategoria.TabIndex = 16;
            this.txtCategoria.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(575, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(378, 35);
            this.txtID.TabIndex = 17;
            // 
            // cmbNecesidad
            // 
            this.cmbNecesidad.FormattingEnabled = true;
            this.cmbNecesidad.Location = new System.Drawing.Point(575, 238);
            this.cmbNecesidad.Name = "cmbNecesidad";
            this.cmbNecesidad.Size = new System.Drawing.Size(378, 37);
            this.cmbNecesidad.TabIndex = 18;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(589, 437);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(364, 35);
            this.txtEstado.TabIndex = 19;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 1008);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cmbNecesidad);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblITBIS);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNecesidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregarProducto);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.Agregar_Producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private Label lblEstado;
        private Label lblCantidad;
        private Label lblNecesidad;
        private Label lblCategoria;
        private Label lblID;
        private TextBox lblITBIS;
        private TextBox txtCategoria;
        private TextBox txtID;
        private ComboBox cmbNecesidad;
        private TextBox txtEstado;
    }
}

 #endregion