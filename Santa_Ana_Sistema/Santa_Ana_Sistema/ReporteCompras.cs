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
    public partial class ReporteCompras : Form
    {
        public ReporteCompras()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            //buscar compras
            DateTime fecha1 = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker2.Value;
            cargarTabla(fecha1, fecha2);
        }

        private void cargarTabla(DateTime dato1, DateTime dato2)
        {

            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarRegistroCompras(dato1, dato2);

        }
    }
}
