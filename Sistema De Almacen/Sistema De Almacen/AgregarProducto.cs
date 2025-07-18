using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();

            // Eventos adicionales
            this.txtPrecio.KeyPress += new KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.TextChanged += new EventHandler(this.txtPrecio_TextChanged);
            this.cmbNecesidad.SelectedIndexChanged += new EventHandler(this.cmbNecesidad_SelectedIndexChanged);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números, backspace y punto decimal
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
                return "Disponible";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                cmbNecesidad.SelectedIndex == -1 ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.");
                return;
            }

            // Verificar ID único
            if (FrmPrincipal.listaProductos.Any(p => p.ID == txtID.Text))
            {
                MessageBox.Show("El ID ya existe. Use uno diferente.");
                return;
            }

            int cantidad = (int)nudMinima.Value;
            int minima = (int)nudMinima.Value;
            string estado = CalcularEstado(cantidad, minima);

            // Crear producto
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
            txtID.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            cmbNecesidad.SelectedIndex = -1;
            nudMinima.Value = 0;
            nudMinima.Value = 0;
            txtPrecio.Clear();
            txtITBIS.Clear();
            txtEstado.Clear();
        }
    }
}
