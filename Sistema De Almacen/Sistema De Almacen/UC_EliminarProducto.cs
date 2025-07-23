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
    public partial class UC_EliminarProducto : UserControl
    {
        private object btnCancelar;
        private Producto productoSeleccionado;

        public UC_EliminarProducto()
        {
            InitializeComponent();
            // *** Conectar los eventos Click de los botones ***
            // Aunque el diseñador los conecte, es buena práctica asegurarlos.
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
           

            // *** Conectar el evento Load del UserControl ***
            this.Load += new EventHandler(this.UC_EliminarProducto_Load);
        }

        private void UC_EliminarProducto_Load(object sender, EventArgs e)
        { // Aquí puedes establecer la apariencia inicial de los controles,
            // similar a cómo lo haces en UC_AgregarProducto.
            txtID.TextAlign = HorizontalAlignment.Center;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // Si tienes más campos para mostrar el producto, céntralos también

            // Aumenta el tamaño de la fuente para mejor visibilidad
            Font fuenteGrande = new Font("Segoe UI", 14, FontStyle.Regular);
            txtID.Font = fuenteGrande;
            txtNombre.Font = fuenteGrande;
            // Aplica la fuente a otros TextBoxes si los usas para mostrar el producto.

            LimpiarCampos(); // Limpiar campos al cargar el UC para una nueva operación
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese el ID del producto a buscar.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos(); 
                return;
            }

            
            productoSeleccionado = btnActualizarProductos.listaProductos
                .FirstOrDefault(p => p.ID.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (productoSeleccionado != null)
            {
                
                txtNombre.Text = productoSeleccionado.Nombre;
                
            }
            else
            {
                // Si el producto no se encuentra
                MessageBox.Show($"Producto con ID '{id}' no encontrado.", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpia los campos y resetea productoSeleccionado
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar si hay un producto seleccionado para eliminar
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Primero debe buscar un producto válido para poder eliminarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pedir confirmación al usuario antes de eliminar
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de eliminar el producto \"{productoSeleccionado.Nombre}\" (ID: {productoSeleccionado.ID})?\n" +
                "Esta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                // Eliminar el producto de la lista estática
                btnActualizarProductos.listaProductos.Remove(productoSeleccionado);
                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpia los campos después de la eliminación exitosa

            }
        }

        // Método para limpiar los campos de texto y resetear el producto seleccionado
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
           
            productoSeleccionado = null;
            txtID.Focus(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
          
            if (this.Parent is Panel parentPanel)
            {
               
                parentPanel.Controls.Remove(this);

              
            }
          
        }

        // Puedes eliminar estos métodos si no los estás usando en tu diseñador o código
        private void label3_Click(object sender, EventArgs e) { }
        private void txtNombre_TextChanged(object sender, EventArgs e) { }
    }

}
    
