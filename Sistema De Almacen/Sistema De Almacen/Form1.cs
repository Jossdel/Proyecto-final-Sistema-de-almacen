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
    public partial class btnActualizarProductos : Form
    {
        public btnActualizarProductos()
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
        private void MostrarUserControl(UserControl userControl)
        {
            pnlContenedor.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(userControl);
        }
        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UC_MostrarProducto());
        }

        private void btnAgregarproductos_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UC_AgregarProducto());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExportarDatos_Click(object sender, EventArgs e)
        {
            // Lógica de exportación directa aquí
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*";
                sfd.FileName = "Productos_Exportados_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Aquí iría el código real para tomar btnActualizarProductos.listaProductos
                        // y escribirlo en el archivo sfd.FileName
                        // Por ejemplo:
                        // ExcelExporter.ExportarListaAExcel(btnActualizarProductos.listaProductos, sfd.FileName);

                        MessageBox.Show("Datos exportados correctamente a:\n" + sfd.FileName, "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar los datos: " + ex.Message, "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UC_ActualizarProducto());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir salirForm = new Salir();
            salirForm.ShowDialog();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UC_EliminarProducto());
        }
    }
}
