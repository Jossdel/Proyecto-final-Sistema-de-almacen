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
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbNecesidad = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.nudMinima = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNecesidad = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(237, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(237, 143);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(164, 20);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(123, 50);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(110, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Producto:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(187, 257);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // txtITBIS
            // 
            this.txtITBIS.Location = new System.Drawing.Point(237, 188);
            this.txtITBIS.Margin = new System.Windows.Forms.Padding(1);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.Size = new System.Drawing.Size(164, 20);
            this.txtITBIS.TabIndex = 14;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(237, 82);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(1);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(164, 20);
            this.txtCategoria.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(235, 16);
            this.txtID.Margin = new System.Windows.Forms.Padding(1);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 20);
            this.txtID.TabIndex = 17;
            // 
            // cmbNecesidad
            // 
            this.cmbNecesidad.FormattingEnabled = true;
            this.cmbNecesidad.Location = new System.Drawing.Point(237, 113);
            this.cmbNecesidad.Margin = new System.Windows.Forms.Padding(1);
            this.cmbNecesidad.Name = "cmbNecesidad";
            this.cmbNecesidad.Size = new System.Drawing.Size(164, 21);
            this.cmbNecesidad.TabIndex = 18;
            this.cmbNecesidad.SelectedIndexChanged += new System.EventHandler(this.cmbNecesidad_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(237, 257);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(1);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(164, 20);
            this.txtEstado.TabIndex = 19;
            // 
            // nudMinima
            // 
            this.nudMinima.Location = new System.Drawing.Point(237, 223);
            this.nudMinima.Margin = new System.Windows.Forms.Padding(1);
            this.nudMinima.Name = "nudMinima";
            this.nudMinima.Size = new System.Drawing.Size(162, 20);
            this.nudMinima.TabIndex = 20;
            // 
            // lblID
            // 
            this.lblID.Image = global::Sistema_De_Almacen.Properties.Resources.id_del_paciente;
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.Location = new System.Drawing.Point(83, 8);
            this.lblID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(150, 34);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID del producto";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Image = global::Sistema_De_Almacen.Properties.Resources.multiple;
            this.lblCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategoria.Location = new System.Drawing.Point(75, 72);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(152, 30);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // lblNecesidad
            // 
            this.lblNecesidad.Image = global::Sistema_De_Almacen.Properties.Resources.demencia;
            this.lblNecesidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNecesidad.Location = new System.Drawing.Point(73, 110);
            this.lblNecesidad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNecesidad.Name = "lblNecesidad";
            this.lblNecesidad.Size = new System.Drawing.Size(165, 24);
            this.lblNecesidad.TabIndex = 11;
            this.lblNecesidad.Text = "Necesidad";
            this.lblNecesidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblITBIS
            // 
            this.lblITBIS.Image = global::Sistema_De_Almacen.Properties.Resources.blockchain_app;
            this.lblITBIS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblITBIS.Location = new System.Drawing.Point(75, 184);
            this.lblITBIS.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(163, 27);
            this.lblITBIS.TabIndex = 9;
            this.lblITBIS.Text = "ITBIS";
            this.lblITBIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Image = global::Sistema_De_Almacen.Properties.Resources.price_tag;
            this.lblPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrecio.Location = new System.Drawing.Point(70, 140);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(163, 24);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Khaki;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Sistema_De_Almacen.Properties.Resources.disk__1_;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(244, 322);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 38);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 392);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load_1);
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