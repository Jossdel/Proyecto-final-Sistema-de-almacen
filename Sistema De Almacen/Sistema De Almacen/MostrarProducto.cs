using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class MostrarProducto : Form
    {
        List<Producto> productos;

        public MostrarProducto(List<Producto> lista)
        {
            InitializeComponent();
            productos = lista;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;

            if (!dataGridView1.Columns.Contains("btnEliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnEliminar);
            }

            if (!dataGridView1.Columns.Contains("btnEditar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                btnEditar.HeaderText = "Modificar";
                btnEditar.Text = "Modificar";
                btnEditar.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnEditar);
            }

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombreColumna = dataGridView1.Columns[e.ColumnIndex].HeaderText;

                if (nombreColumna == "Eliminar")
                {
                    productos.RemoveAt(e.RowIndex);
                    RefrescarGrid();
                }
                else if (nombreColumna == "Modificar")
                {
                    Producto productoSeleccionado = productos[e.RowIndex];
                    MessageBox.Show($"Modificar producto: {productoSeleccionado.Nombre}");
                }
            }
        }

        private void RefrescarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;
        }

        private void MostrarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
