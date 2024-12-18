using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int NroVenta { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public string ModalidadPago { get; set; }
        public string Descripcion { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
        public int NroRemito { get; set; } // solo para impresion
    }
}
