using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class UC_AgregarProducto : UserControl
    {
        private System.Windows.Forms.Timer pulsarTimer;
        private float escalaActual = 1.0f;
        private bool aumentando = true;
        private Size tamañoOriginal;

        public UC_AgregarProducto()
        {
            InitializeComponent();

            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            pulsarTimer = new System.Windows.Forms.Timer { Interval = 50 };
            pulsarTimer.Tick += PulsarTimer_Tick;
            tamañoOriginal = btnGuardar.Size;

            txtNombre.TextChanged += TextBox_TextChanged;
            txtCategoria.TextChanged += TextBox_TextChanged;
            txtPrecio.TextChanged += TextBox_TextChanged;

            cmbNecesidad.Items.AddRange(new string[] { "Primera", "Segunda", "Tercera" });

            // Esta línea asegura que el método UC_AgregarProducto_Load se ejecuta al cargar el control.
            this.Load += new EventHandler(this.UC_AgregarProducto_Load);
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

        private string GenerarID()
        {
            Random rnd = new Random();
            int numero = rnd.Next(1000, 9999);
            return $"ID-{numero}";
        }

        // Este método se ejecuta cuando el UserControl se carga y se hace visible.
        private void UC_AgregarProducto_Load(object sender, EventArgs e)
        {
            // Asigna un ID al TextBox txtID al cargar.
            txtID.Text = GenerarID();

            // Centra el texto en los TextBoxes.
            txtID.TextAlign = HorizontalAlignment.Center;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtCategoria.TextAlign = HorizontalAlignment.Center;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            txtITBIS.TextAlign = HorizontalAlignment.Center;
            txtEstado.TextAlign = HorizontalAlignment.Center;

            // Aumenta el tamaño de la fuente.
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
                MessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Sistema_De_Almacen.btnActualizarProductos.listaProductos.Any(p => p.ID == txtID.Text))
            {
                MessageBox.Show("El ID ya existe. Se generará otro automáticamente.", "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("La cantidad no puede ser menor a la cantidad mínima.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            Sistema_De_Almacen.btnActualizarProductos.listaProductos.Add(producto);
            MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtEstado.Text = estado;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtID.Text = GenerarID(); // Genera nuevo ID al limpiar
            txtNombre.Clear();
            txtCategoria.Clear();
            cmbNecesidad.SelectedIndex = -1;
            nudMinima.Value = 0;
            // nudCantidad.Value = 0; // Descomenta si tienes nudCantidad y quieres resetearlo
            txtPrecio.Clear();
            txtITBIS.Clear();
            txtEstado.Clear();
        }

        // --- Eventos vacíos, puedes eliminarlos si no se usan en tu diseño ---
        private void label2_Click(object sender, EventArgs e) { }
        private void lblNecesidad_Click(object sender, EventArgs e) { }
        private void lblITBIS_Click(object sender, EventArgs e) { }
        private void txtID_TextChanged(object sender, EventArgs e) { }
        private void txtEstado_TextChanged(object sender, EventArgs e) { }
        private void lblCantidad_Click(object sender, EventArgs e) { }
        private void lblEstado_Click(object sender, EventArgs e) { }
        private void lblCategoria_Click(object sender, EventArgs e) { }
        private void lblID_Click(object sender, EventArgs e) { }
        private void lblNombre_Click(object sender, EventArgs e) { }
        private void lblPrecio_Click(object sender, EventArgs e) { }
        private void nudMinima_ValueChanged(object sender, EventArgs e) { }
    }
}
