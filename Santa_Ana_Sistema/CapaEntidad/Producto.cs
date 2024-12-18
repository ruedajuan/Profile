using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public string Descripcion { get; set; }
        public int? IdCategoria { get; set; }
        public int? Stock { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioVenta { get; set; }
        public string FechaRegistro { get; set; }
    }
}
