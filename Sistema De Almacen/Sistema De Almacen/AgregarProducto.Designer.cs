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
        private Label lblNombre;
        private Label lblPrecio;

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblNecesidad = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbNecesidad = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.nudMinima = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).BeginInit();
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
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
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
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(436, 489);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(88, 29);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // lblITBIS
            // 
            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Location = new System.Drawing.Point(398, 377);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(73, 29);
            this.lblITBIS.TabIndex = 9;
            this.lblITBIS.Text = "ITBIS";
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
            // txtITBIS
            // 
            this.txtITBIS.Location = new System.Drawing.Point(575, 371);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.Size = new System.Drawing.Size(378, 35);
            this.txtITBIS.TabIndex = 14;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(575, 173);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(378, 35);
            this.txtCategoria.TabIndex = 16;
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
            this.cmbNecesidad.SelectedIndexChanged += new System.EventHandler(this.cmbNecesidad_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(575, 489);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(378, 35);
            this.txtEstado.TabIndex = 19;
            // 
            // nudMinima
            // 
            this.nudMinima.Location = new System.Drawing.Point(575, 433);
            this.nudMinima.Name = "nudMinima";
            this.nudMinima.Size = new System.Drawing.Size(378, 35);
            this.nudMinima.TabIndex = 20;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 1008);
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
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label lblEstado;
        private Label lblITBIS;
        private Label lblNecesidad;
        private Label lblCategoria;
        private Label lblID;
        private TextBox txtITBIS;
        private TextBox txtCategoria;
        private TextBox txtID;
        private ComboBox cmbNecesidad;
        private TextBox txtEstado;
        private NumericUpDown nudMinima;
    }
}

 #endregion