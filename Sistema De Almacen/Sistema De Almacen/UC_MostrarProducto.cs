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
    public partial class UC_MostrarProducto : UserControl
    {
        public UC_MostrarProducto()
        {
            InitializeComponent();
            // Asegúrate de que el evento Load de este UserControl esté conectado
            this.Load += new EventHandler(this.UC_MostrarProducto_Load);
        }

        // Método para cargar/refrescar los datos en el DataGridView
        public void CargarDatosProductos()
        {
            // Vincula la lista estática de productos al DataGridView
            // Si tu clase Producto tiene propiedades (ID, Nombre, Precio, etc.), se mostrarán automáticamente.
            dgvProductos.DataSource = null; // Limpiar DataSource actual
            dgvProductos.DataSource = btnActualizarProductos.listaProductos;

            // Opcional: Autoajustar columnas
            dgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvProductos.Refresh(); // Asegurarse de que el DataGridView se refresque
        }

        private void UC_MostrarProducto_Load(object sender, EventArgs e)
        {
            CargarDatosProductos(); 
        }

    }
}


