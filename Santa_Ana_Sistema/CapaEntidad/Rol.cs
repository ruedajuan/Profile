using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Rol
    {
        int idRol;
        string descripcion;
        string fechaRegistro;

        public int IdRol { get => idRol; set => idRol = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
    }
}
