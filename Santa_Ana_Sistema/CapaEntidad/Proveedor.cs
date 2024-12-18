using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string CuilCuit { get; set; }
        public string NombreComercial { get; set; }
        public string RazonSocial { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Descripcion { get; set; }
        public string FechaRegistro { get; set; }
    }
}
