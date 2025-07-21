using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class MostrarProducto : Form
    {
        public MostrarProducto()
        {
            InitializeComponent();
        }


        private void MostrarProducto_Load(object sender, EventArgs e)
        {
            // Carga la lista de productos al DataGri
            // dView
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = FrmPrincipal.listaProductos;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
