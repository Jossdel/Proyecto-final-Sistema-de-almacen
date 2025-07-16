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
    public partial class Form1 : Form
    {
        public Form1()
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
         

            Agregar_Producto form = new Agregar_Producto();
            form.MdiParent = this;
            form.Show();
        }

        private void mostrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
      

            MostrarProducto form = new MostrarProducto(productos);
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
    }
}
