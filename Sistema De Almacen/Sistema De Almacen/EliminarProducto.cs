using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class EliminarProducto : Form
    {
        private Producto productoSeleccionado;

        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();

            // Buscar producto por ID
            productoSeleccionado = btnActualizarProductos.listaProductos
                .FirstOrDefault(p => p.ID.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (productoSeleccionado != null)
            {
                txtNombre.Text = productoSeleccionado.Nombre;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Debe buscar un producto válido primero.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de eliminar el producto \"{productoSeleccionado.Nombre}\"?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                btnActualizarProductos.listaProductos.Remove(productoSeleccionado);
                MessageBox.Show("Producto eliminado correctamente.");
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            productoSeleccionado = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
