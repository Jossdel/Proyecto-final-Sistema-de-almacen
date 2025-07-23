using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class ActualizarProducto : Form
    {
        private Producto productoEncontrado;

        public ActualizarProducto()
        {
            InitializeComponent();
            btnCerrar.Click += btnCerrar_Click;
        }

        private void ActualizarProducto_Load(object sender, EventArgs e)
        {
            cmbNecesidad.Items.AddRange(new string[] { "Primera", "Segunda", "Tercera" });
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();

            productoEncontrado = btnActualizarProductos.listaProductos
                .FirstOrDefault(p => p.ID.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (productoEncontrado != null)
            {
                txtNombre.Text = productoEncontrado.Nombre;
                txtCategoria.Text = productoEncontrado.Categoria;
                cmbNecesidad.SelectedItem = productoEncontrado.Necesidad;
                txtPrecio.Text = productoEncontrado.PrecioUnidad.ToString("0.00");
                nudCantidad.Value = productoEncontrado.Cantidad;
                nudMinima.Value = productoEncontrado.CantidadMinima;
             
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
                LimpiarCampos();
            }
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (productoEncontrado == null)
            {
                MessageBox.Show("Primero debe buscar un producto.");
                return;
            }

            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                cmbNecesidad.SelectedIndex == -1 ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor complete todos los campos correctamente.");
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            int minima = (int)nudMinima.Value;

            if (minima < 0)
            {
                MessageBox.Show("La cantidad mínima no puede ser negativa.");
                return;
            }

            if (cantidad < minima)
            {
                MessageBox.Show("La cantidad no puede ser menor que la cantidad mínima.");
                return;
            }

            // Actualizar campos
            productoEncontrado.Nombre = txtNombre.Text.Trim();
            productoEncontrado.Categoria = txtCategoria.Text.Trim();
            productoEncontrado.Necesidad = cmbNecesidad.SelectedItem.ToString();
            productoEncontrado.PrecioUnidad = precio;
            productoEncontrado.Cantidad = cantidad;
            productoEncontrado.CantidadMinima = minima;
            productoEncontrado.Estado = CalcularEstado(cantidad, minima);

          

            MessageBox.Show("Producto actualizado correctamente.");
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            cmbNecesidad.SelectedIndex = -1;
            txtPrecio.Clear();
            nudCantidad.Value = 0;
            nudMinima.Value = 0;
           
            productoEncontrado = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
