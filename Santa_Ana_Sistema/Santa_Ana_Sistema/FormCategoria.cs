using CapaDatos;
using CapaEntidad;
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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void iconButtonGuardar_Click(object sender, EventArgs e)
        {
                Categoria categorianueva = new Categoria();

                categorianueva.Nombre = textBoxNombre.Text;
 
                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlCategoriaNueva(categorianueva);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Categoria guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextBox();
                    cargarTabla(null);

                }

            
  
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            cargarTabla(null);
        }
        private void cargarTabla(string dato)
        {

            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarCategorias(dato);

        }

        private void iconButtonActualizar_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            string dato = textBoxNombreBuscador.Text;
            cargarTabla(dato);
            LimpiarTextBox();
        }

        private void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            string datoid = textBoxEliminar.Text;
            CapaDatos.Control control = new CapaDatos.Control();
            string respuesta = control.ctrlCategoriaEliminada(datoid);
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Categoria eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox();
            }
        }
        private void LimpiarTextBox()
        {
            textBoxEliminar.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxNombreBuscador.Text= string.Empty;
        }
    }
}
