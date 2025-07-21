using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class AgregarProducto : Form
    {
        private System.Windows.Forms.Timer pulsarTimer;
        private float escalaActual = 1.0f;
        private bool aumentando = true;
        private Size tamañoOriginal;
        public AgregarProducto()
        {
            InitializeComponent();

            // Inicializar Timer para animación
            pulsarTimer = new System.Windows.Forms.Timer { Interval = 50 };
            pulsarTimer.Tick += PulsarTimer_Tick;
            tamañoOriginal = btnGuardar.Size;

            // Eventos TextChanged para activar animación
            txtNombre.TextChanged += TextBox_TextChanged;
            txtCategoria.TextChanged += TextBox_TextChanged;
            txtPrecio.TextChanged += TextBox_TextChanged;

     




            // Cargar necesidades al combo
            cmbNecesidad.Items.AddRange(new string[] { "Primera", "Segunda", "Tercera" });

            // Eventos
            this.Load += new EventHandler(this.AgregarProducto_Load);
            this.txtPrecio.KeyPress += new KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.TextChanged += new EventHandler(this.txtPrecio_TextChanged);
            this.cmbNecesidad.SelectedIndexChanged += new EventHandler(this.cmbNecesidad_SelectedIndexChanged);
        }

        private void PulsarTimer_Tick(object sender, EventArgs e)
        {
            float paso = 0.05f;

            if (aumentando)
            {
                escalaActual += paso;
                if (escalaActual >= 1.2f)
                    aumentando = false;
            }
            else
            {
                escalaActual -= paso;
                if (escalaActual <= 1.0f)
                    aumentando = true;
            }

            btnGuardar.Size = new Size(
                (int)(tamañoOriginal.Width * escalaActual),
                (int)(tamañoOriginal.Height * escalaActual)
            );
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            if (HayTextoEnCamposObligatorios())
            {
                pulsarTimer.Start();
            }
            else
            {
                pulsarTimer.Stop();
                escalaActual = 1.0f;
                aumentando = true;
                btnGuardar.Size = tamañoOriginal;
            }
        }

        private bool HayTextoEnCamposObligatorios()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text) ||
                 !string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                 !string.IsNullOrWhiteSpace(txtPrecio.Text);
        }

        // Genera un ID como PRD-1234
        private string GenerarID()
        {
            Random rnd = new Random();
            int numero = rnd.Next(1000, 9999);
            return $"ID-{numero}";
        }

      private void AgregarProducto_Load(object sender, EventArgs e)
{
    txtID.Text = GenerarID();

    // CENTRAR texto en los TextBox
    txtID.TextAlign = HorizontalAlignment.Center;
    txtNombre.TextAlign = HorizontalAlignment.Center;
    txtCategoria.TextAlign = HorizontalAlignment.Center;
    txtPrecio.TextAlign = HorizontalAlignment.Center;
    txtITBIS.TextAlign = HorizontalAlignment.Center;
    txtEstado.TextAlign = HorizontalAlignment.Center;

    // AUMENTAR TAMAÑO de fuente
    Font fuenteGrande = new Font("Segoe UI", 14, FontStyle.Regular);

    txtID.Font = fuenteGrande;
    txtNombre.Font = fuenteGrande;
    txtCategoria.Font = fuenteGrande;
    txtPrecio.Font = fuenteGrande;
    txtITBIS.Font = fuenteGrande;
    txtEstado.Font = fuenteGrande;


  
}


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            CalcularITBIS();
        }

        private void cmbNecesidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularITBIS();
        }

        private void CalcularITBIS()
        {
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || cmbNecesidad.SelectedIndex == -1)
            {
                txtITBIS.Text = "";
                return;
            }

            decimal itbis = 0;

            switch (cmbNecesidad.SelectedItem.ToString())
            {
                case "Primera":
                    itbis = precio * 0.08m;
                    break;
                case "Segunda":
                    itbis = precio * 0.14m;
                    break;
                case "Tercera":
                    itbis = precio * 0.18m;
                    break;
            }

            txtITBIS.Text = itbis.ToString("0.00");
        }

        private string CalcularEstado(int cantidad, int minima)
        {
            if (cantidad <= 0)
                return "Sin existencia";
            else if (cantidad <= minima)
                return "Próximo a terminar";
            
            else
                return "Suficiente";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                cmbNecesidad.SelectedIndex == -1 ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.");
                return;
            }

            // Verificar que el ID no se repita
            if (FrmPrincipal.listaProductos.Any(p => p.ID == txtID.Text))
            {
                MessageBox.Show("El ID ya existe. Se generará otro automáticamente.");
                txtID.Text = GenerarID();
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            int minima = (int)nudMinima.Value;
            string estado = CalcularEstado(cantidad, minima);
            if (minima < 0)
            {
                MessageBox.Show("La cantidad mínima no puede ser negativa.", "Cantidad mínima inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cantidad < minima)
            {
                MessageBox.Show("La cantidad  no puede ser menor a las cantidad minima.", "Cantidad  inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var producto = new Producto
            {
                ID = txtID.Text,
                Nombre = txtNombre.Text,
                Categoria = txtCategoria.Text,
                Necesidad = cmbNecesidad.SelectedItem.ToString(),
                Cantidad = cantidad,
                PrecioUnidad = precio,
                ITBIS = decimal.Parse(txtITBIS.Text),
                CantidadMinima = minima,
                Estado = estado
            };

            FrmPrincipal.listaProductos.Add(producto);
            MessageBox.Show("Producto guardado correctamente.");

            txtEstado.Text = estado;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtID.Text = GenerarID();
            txtNombre.Clear();
            txtCategoria.Clear();
            cmbNecesidad.SelectedIndex = -1;
            nudMinima.Value = 0;
            txtPrecio.Clear();
            txtITBIS.Clear();
            txtEstado.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNecesidad_Click(object sender, EventArgs e)
        {

        }

        private void lblITBIS_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void nudMinima_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
