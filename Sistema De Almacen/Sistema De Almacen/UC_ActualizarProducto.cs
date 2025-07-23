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
    // Cambiamos la clase base de Form a UserControl
    public partial class UC_ActualizarProducto : UserControl
    {
        private Producto productoEncontrado; // Mantiene una referencia al producto encontrado

        public UC_ActualizarProducto()
        {
            InitializeComponent();

            // *** Conectar los eventos Click de los botones ***
            // Aunque el diseñador los conecte, es buena práctica asegurarlos.
            this.btnCerrar.Click += new EventHandler(this.btnCerrar_Click); // Renombrado a btnCerrar_Click para evitar confusión
            this.btnBuscar.Click += new EventHandler(this.btnBuscar_Click);
            this.btnActualizar.Click += new EventHandler(this.btnActualizar_Click);

            // *** Conectar el evento Load del UserControl ***
            this.Load += new EventHandler(this.UC_ActualizarProducto_Load);

            // Opcional: Centrar texto y aplicar fuente al cargar el UC
            txtID.TextAlign = HorizontalAlignment.Center;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtCategoria.TextAlign = HorizontalAlignment.Center;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            // Asegúrate de que txtITBIS y txtEstado existan si los vas a usar
            // txtITBIS.TextAlign = HorizontalAlignment.Center;
            // txtEstado.TextAlign = HorizontalAlignment.Center;

            Font fuenteGrande = new Font("Segoe UI", 14, FontStyle.Regular);
            txtID.Font = fuenteGrande;
            txtNombre.Font = fuenteGrande;
            txtCategoria.Font = fuenteGrande;
            txtPrecio.Font = fuenteGrande;
            // txtITBIS.Font = fuenteGrande;
            // txtEstado.Font = fuenteGrande;

            // Asegúrate de que estos eventos existan si quieres usar CalcularITBIS()
            // this.txtPrecio.TextChanged += new EventHandler(this.txtPrecio_TextChanged);
            // this.cmbNecesidad.SelectedIndexChanged += new EventHandler(this.cmbNecesidad_SelectedIndexChanged);
            // this.txtPrecio.KeyPress += new KeyPressEventHandler(this.txtPrecio_KeyPress); // Para permitir solo números y punto
        }

        // Este método se ejecuta cuando el UserControl se carga y se hace visible.
        private void UC_ActualizarProducto_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con las opciones al cargar el UserControl
            // Solo añadir si no están ya, para evitar duplicados en recargas.
            if (cmbNecesidad.Items.Count == 0)
            {
                cmbNecesidad.Items.AddRange(new string[] { "Primera", "Segunda", "Tercera" });
            }
            LimpiarCampos(); // Limpiar campos al cargar para una nueva operación
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();

            // Validar que el campo ID no esté vacío
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese el ID del producto a buscar.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos(); // Limpia y resetea el productoEncontrado
                return;
            }

            // Buscar producto por ID en la lista estática (compartida con btnActualizarProductos)
            productoEncontrado = btnActualizarProductos.listaProductos
                .FirstOrDefault(p => p.ID.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (productoEncontrado != null)
            {
                // Si el producto es encontrado, rellena los campos con sus datos
                txtNombre.Text = productoEncontrado.Nombre;
                txtCategoria.Text = productoEncontrado.Categoria;
                cmbNecesidad.SelectedItem = productoEncontrado.Necesidad; // Asegúrate de que el item exista
                txtPrecio.Text = productoEncontrado.PrecioUnidad.ToString("0.00");
                nudCantidad.Value = productoEncontrado.Cantidad;
                nudMinima.Value = productoEncontrado.CantidadMinima;
                // Si tienes un txtITBIS o txtEstado que mostrar, hazlo aquí
                // txtITBIS.Text = productoEncontrado.ITBIS.ToString("0.00");
                // txtEstado.Text = productoEncontrado.Estado;
            }
            else
            {
                // Si el producto no se encuentra
                MessageBox.Show($"Producto con ID '{id}' no encontrado.", "Búsqueda Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); // Limpia los campos y resetea productoEncontrado
            }
        }

        // Método para calcular el estado del producto basado en cantidad y mínima
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
            // Validar si hay un producto seleccionado para actualizar
            if (productoEncontrado == null)
            {
                MessageBox.Show("Primero debe buscar un producto para poder actualizarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones de campos (similar a UC_AgregarProducto)
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                cmbNecesidad.SelectedIndex == -1 ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor complete todos los campos correctamente antes de actualizar.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            int minima = (int)nudMinima.Value;

            if (minima < 0)
            {
                MessageBox.Show("La cantidad mínima no puede ser negativa.", "Cantidad Mínima Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cantidad < minima)
            {
                MessageBox.Show("La cantidad no puede ser menor que la cantidad mínima.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar las propiedades del objeto 'productoEncontrado'
            productoEncontrado.Nombre = txtNombre.Text.Trim();
            productoEncontrado.Categoria = txtCategoria.Text.Trim();
            productoEncontrado.Necesidad = cmbNecesidad.SelectedItem.ToString();
            productoEncontrado.PrecioUnidad = precio;
            productoEncontrado.Cantidad = cantidad;
            productoEncontrado.CantidadMinima = minima;
            productoEncontrado.Estado = CalcularEstado(cantidad, minima); // Recalcular el estado

            // Opcional: Recalcular ITBIS si tienes el campo txtITBIS
            // if (decimal.TryParse(txtITBIS.Text, out decimal itbis))
            // {
            //     productoEncontrado.ITBIS = itbis; // O recalcularlo si cmbNecesidad.SelectedIndexChanged no lo hace
            // }

            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos(); // Limpia los campos después de la actualización exitosa

            // Opcional: Si UC_MostrarProducto está visible, podrías querer refrescarlo
            // Esto es más complejo, ya que necesitas una referencia al UC_MostrarProducto.
            // Una forma simple es que el usuario haga clic en "Mostrar Productos" de nuevo.
        }

        // Método para limpiar los campos de texto y resetear el producto seleccionado
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            cmbNecesidad.SelectedIndex = -1; // Deselecciona el ComboBox
            txtPrecio.Clear();
            nudCantidad.Value = 0; // Reinicia el NumericUpDown
            nudMinima.Value = 0;   // Reinicia el NumericUpDown

            // Si tienes campos para ITBIS y Estado, límpialos también
            // txtITBIS.Clear();
            // txtEstado.Clear();

            productoEncontrado = null; // Importantísimo: Resetear la referencia al producto
            txtID.Focus(); // Pone el cursor en el campo ID para facilitar la siguiente búsqueda
        }

        // Este método maneja el botón "Cerrar" o "Volver" para el UserControl.
        // Un UserControl no tiene un método Close() como un Form.
        // Para "cerrarlo" (o más bien, quitarlo de la vista), lo remueves de su contenedor padre.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Verifica que el UserControl esté dentro de un Panel
            if (this.Parent is Panel parentPanel)
            {
                // Remueve este UserControl del panel
                parentPanel.Controls.Remove(this);

                // Opcional: Podrías cargar otro UserControl aquí para volver a una "pantalla de inicio"
                // Ejemplo: Asumiendo que tu MainForm es el padre del panel y tiene un método MostrarUserControl
                // if (parentPanel.Parent is Form mainForm && mainForm is btnActualizarProductos mainFormInstance)
                // {
                //     mainFormInstance.MostrarUserControl(new UC_HomeDashboard()); // Reemplaza UC_HomeDashboard con tu UC de inicio
                // }
            }
            // Elimina la definición de un método Close() vacío que podría estar causando problemas:
            // private void Close() { throw new NotImplementedException(); }
            // No necesitas un método 'Close()' personalizado para un UserControl.
        }

        // Eliminamos el método 'Close()' que estaba causando NotImplementedException
        // Ya que un UserControl no se "cierra" de esa manera.
        // private void Close()
        // {
        //     throw new NotImplementedException();
        // }
    }
}
