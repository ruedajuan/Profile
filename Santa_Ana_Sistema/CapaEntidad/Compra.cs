using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int NroCompra { get; set; }
        public int IdUsuario { get; set; }
        public int IdProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string ModalidadPago { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
