using System;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class Agregar_Producto : Form
    {
        public Producto ProductoNuevo { get; private set; }

        public Agregar_Producto()
        {
            InitializeComponent();
            this.txtPrecio.KeyPress += new KeyPressEventHandler(this.txtPrecio_KeyPress);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números, backspace y punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            ProductoNuevo = new Producto
            {
                Nombre = nombre,
                Precio = precio
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            MessageBox.Show($"Producto agregado:\nNombre: {nombre}\nPrecio: {precio:C}");
        }

        private void Agregar_Producto_Load(object sender, EventArgs e)
        {
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
