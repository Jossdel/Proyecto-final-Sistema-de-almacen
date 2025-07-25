using System;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public partial class Salir : Form
    {
        public Salir()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Para que aparezca centrado
        }

        private void Salir_Load(object sender, EventArgs e)
        {
            // Opcional: establecer título y tamaño si no lo hiciste en el diseñador
            this.Text = "¿Desea salir del sistema?";
        }

    

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
