using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        int idPermiso;
        Rol oRol;
        string nombreMenu;
        string fechaRegistro;

        public int IdPermiso { get => idPermiso; set => idPermiso = value; }
        public Rol ORol { get => oRol; set => oRol = value; }
        public string NombreMenu { get => nombreMenu; set => nombreMenu = value; }
        public string FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
    }
}
