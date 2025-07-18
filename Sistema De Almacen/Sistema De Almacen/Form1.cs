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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
     
        List<Producto> productos = new List<Producto>();
        int contadorId = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            AgregarProducto form = new AgregarProducto();
            form.MdiParent = this;
            form.Show();
        }



   

        private void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            var form = new MostrarProducto(productos);
            form.ShowDialog();
        }

        private void mostrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarProducto form = new MostrarProducto(productos);
            form.MdiParent = this;
            form.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarProducto frm = new ActualizarProducto();
            frm.MdiParent = this; // Lo hace hijo del MDI
            frm.Show();

        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarProducto frm = new EliminarProducto();
            frm.MdiParent = this; // Lo hace hijo del MDI
            frm.Show();

        }
    }
}
