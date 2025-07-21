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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(333, 127);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(518, 68);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(333, 248);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(518, 74);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(35, 135);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(270, 29);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Producto:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(1070, 375);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(94, 29);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado";
            // 
            // txtITBIS
            // 
            this.txtITBIS.Location = new System.Drawing.Point(1213, 287);
            this.txtITBIS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.Size = new System.Drawing.Size(377, 35);
            this.txtITBIS.TabIndex = 14;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(1213, 44);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(377, 35);
            this.txtCategoria.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(333, 27);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(518, 67);
            this.txtID.TabIndex = 17;
            // 
            // cmbNecesidad
            // 
            this.cmbNecesidad.FormattingEnabled = true;
            this.cmbNecesidad.Location = new System.Drawing.Point(1213, 145);
            this.cmbNecesidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNecesidad.Name = "cmbNecesidad";
            this.cmbNecesidad.Size = new System.Drawing.Size(377, 37);
            this.cmbNecesidad.TabIndex = 18;
            this.cmbNecesidad.SelectedIndexChanged += new System.EventHandler(this.cmbNecesidad_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(1187, 375);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(377, 35);
            this.txtEstado.TabIndex = 19;
            // 
            // nudMinima
            // 
            this.nudMinima.Location = new System.Drawing.Point(333, 351);
            this.nudMinima.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudMinima.Name = "nudMinima";
            this.nudMinima.Size = new System.Drawing.Size(121, 35);
            this.nudMinima.TabIndex = 20;
            this.nudMinima.ValueChanged += new System.EventHandler(this.nudMinima_ValueChanged);
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Image = global::Sistema_De_Almacen.Properties.Resources.id_del_paciente;
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.Location = new System.Drawing.Point(-21, 27);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(350, 76);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID del producto";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Image = global::Sistema_De_Almacen.Properties.Resources.multiple;
            this.lblCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategoria.Location = new System.Drawing.Point(878, 34);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(355, 67);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // lblNecesidad
            // 
            this.lblNecesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNecesidad.Image = global::Sistema_De_Almacen.Properties.Resources.demencia;
            this.lblNecesidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNecesidad.Location = new System.Drawing.Point(878, 135);
            this.lblNecesidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNecesidad.Name = "lblNecesidad";
            this.lblNecesidad.Size = new System.Drawing.Size(341, 54);
            this.lblNecesidad.TabIndex = 11;
            this.lblNecesidad.Text = "Necesidad";
            this.lblNecesidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblITBIS
            // 
            this.lblITBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITBIS.Image = global::Sistema_De_Almacen.Properties.Resources.blockchain_app;
            this.lblITBIS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblITBIS.Location = new System.Drawing.Point(909, 274);
            this.lblITBIS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(351, 60);
            this.lblITBIS.TabIndex = 9;
            this.lblITBIS.Text = "ITBIS";
            this.lblITBIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Image = global::Sistema_De_Almacen.Properties.Resources.price_tag;
            this.lblPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrecio.Location = new System.Drawing.Point(-14, 248);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(343, 54);
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
            this.btnGuardar.Location = new System.Drawing.Point(598, 664);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(366, 85);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cantidad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1928, 1062);
            this.Controls.Add(this.label1);
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
        private Label label1;
    }
}

 #endregion