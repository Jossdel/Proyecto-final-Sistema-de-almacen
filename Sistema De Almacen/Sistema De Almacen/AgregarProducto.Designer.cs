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
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbNecesidad = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.nudMinima = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadMin = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNecesidad = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(142, 102);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 35);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(143, 183);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(261, 40);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(495, 262);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 20);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // txtITBIS
            // 
            this.txtITBIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtITBIS.Location = new System.Drawing.Point(600, 183);
            this.txtITBIS.Margin = new System.Windows.Forms.Padding(1);
            this.txtITBIS.Multiline = true;
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.ReadOnly = true;
            this.txtITBIS.Size = new System.Drawing.Size(233, 36);
            this.txtITBIS.TabIndex = 14;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Location = new System.Drawing.Point(598, 23);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(1);
            this.txtCategoria.Multiline = true;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(236, 35);
            this.txtCategoria.TabIndex = 16;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(143, 23);
            this.txtID.Margin = new System.Windows.Forms.Padding(1);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(261, 35);
            this.txtID.TabIndex = 17;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // cmbNecesidad
            // 
            this.cmbNecesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbNecesidad.FormattingEnabled = true;
            this.cmbNecesidad.Location = new System.Drawing.Point(598, 115);
            this.cmbNecesidad.Margin = new System.Windows.Forms.Padding(1);
            this.cmbNecesidad.Name = "cmbNecesidad";
            this.cmbNecesidad.Size = new System.Drawing.Size(235, 28);
            this.cmbNecesidad.TabIndex = 18;
            this.cmbNecesidad.SelectedIndexChanged += new System.EventHandler(this.cmbNecesidad_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Location = new System.Drawing.Point(598, 250);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(1);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(236, 38);
            this.txtEstado.TabIndex = 19;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // nudMinima
            // 
            this.nudMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinima.Location = new System.Drawing.Point(349, 269);
            this.nudMinima.Margin = new System.Windows.Forms.Padding(1);
            this.nudMinima.Name = "nudMinima";
            this.nudMinima.Size = new System.Drawing.Size(54, 26);
            this.nudMinima.TabIndex = 20;
            this.nudMinima.ValueChanged += new System.EventHandler(this.nudMinima_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(50, 271);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(86, 20);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(135, 270);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(1);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(60, 26);
            this.nudCantidad.TabIndex = 22;
            // 
            // lblCantidadMin
            // 
            this.lblCantidadMin.AutoSize = true;
            this.lblCantidadMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMin.Location = new System.Drawing.Point(207, 271);
            this.lblCantidadMin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCantidadMin.Name = "lblCantidadMin";
            this.lblCantidadMin.Size = new System.Drawing.Size(138, 18);
            this.lblCantidadMin.TabIndex = 23;
            this.lblCantidadMin.Text = "Cantidad Minima:";
            this.lblCantidadMin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Image = global::Sistema_De_Almacen.Properties.Resources.id_del_paciente;
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.Location = new System.Drawing.Point(-1, 23);
            this.lblID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(150, 34);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "              ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Image = global::Sistema_De_Almacen.Properties.Resources.multiple;
            this.lblCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategoria.Location = new System.Drawing.Point(446, 26);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(152, 30);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // lblNecesidad
            // 
            this.lblNecesidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNecesidad.Image = global::Sistema_De_Almacen.Properties.Resources.demencia;
            this.lblNecesidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNecesidad.Location = new System.Drawing.Point(447, 113);
            this.lblNecesidad.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNecesidad.Name = "lblNecesidad";
            this.lblNecesidad.Size = new System.Drawing.Size(146, 24);
            this.lblNecesidad.TabIndex = 11;
            this.lblNecesidad.Text = "Necesidad:";
            this.lblNecesidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNecesidad.Click += new System.EventHandler(this.lblNecesidad_Click);
            // 
            // lblITBIS
            // 
            this.lblITBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblITBIS.Image = global::Sistema_De_Almacen.Properties.Resources.blockchain_app;
            this.lblITBIS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblITBIS.Location = new System.Drawing.Point(439, 190);
            this.lblITBIS.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(146, 24);
            this.lblITBIS.TabIndex = 9;
            this.lblITBIS.Text = "        ITBIS:   ";
            this.lblITBIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblITBIS.Click += new System.EventHandler(this.lblITBIS_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Image = global::Sistema_De_Almacen.Properties.Resources.dar;
            this.lblNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombre.Location = new System.Drawing.Point(-5, 102);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(143, 31);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = " Producto:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Image = global::Sistema_De_Almacen.Properties.Resources.price_tag;
            this.lblPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrecio.Location = new System.Drawing.Point(-9, 190);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(147, 24);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "         Precio:";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Khaki;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = global::Sistema_De_Almacen.Properties.Resources.disk__1_;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(349, 377);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(166, 56);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "      Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(940, 475);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
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
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private Label lblCantidadMin;
    }
}

 #endregion