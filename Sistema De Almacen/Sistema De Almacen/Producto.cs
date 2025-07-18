using System;
using System.Windows.Forms;

namespace Sistema_De_Almacen
{
    public class Producto
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Necesidad { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal ITBIS { get; set; }
        public int CantidadMinima { get; set; }
        public string Estado { get; set; }
    }

    }
