using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_Ana_Sistema
{
    public partial class VentanaProductos : Form
    {
        public VentanaProductos()
        {
            InitializeComponent();
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            string dato = textBoxNombreBuscador.Text;
            cargarTabla(dato);
        }
        private void cargarTabla(string dato)
        {

            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarProductos(dato);

        }

        private void VentanaProductos_Load(object sender, EventArgs e)
        {
            cargarTabla(null);
        }
    }
}
