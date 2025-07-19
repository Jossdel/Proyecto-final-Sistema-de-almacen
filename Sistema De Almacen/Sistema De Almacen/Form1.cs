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

        public static List<Producto> listaProductos = new List<Producto>();

        int contadorId = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            AgregarProducto form = new AgregarProducto();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized; // Muy importante
            form.Show();
        }


        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarProducto frm = new ActualizarProducto();
            frm.MdiParent = this; // Lo hace hijo del MDI
            frm.WindowState = FormWindowState.Maximized; // Muy importante
            frm.Show();

        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarProducto frm = new EliminarProducto();
            frm.MdiParent = this; // Lo hace hijo del MDI
            frm.WindowState = FormWindowState.Maximized; // Muy importante
            frm.Show();

        }

        private void mostrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarProducto frm = new MostrarProducto();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized; // Muy importante
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir salirForm = new Salir();
            salirForm.ShowDialog(); // Se abre el formulario "Salir" como emergente (modal)
        }
    }
}
