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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            cargarTabla(null);
        }
        private void cargarTabla(string dato)
        {

            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarClientes(dato);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //guardar
            try
            {
                Cliente clie = new Cliente();

                clie.NombreCompleto = textBoxNombre.Text;
                clie.Documento = textBoxDocumento.Text;
                clie.CuilCuit = textBoxCuil.Text;
                clie.Telefono = textBoxTelefono.Text;
                clie.Correo = textBoxCorreo.Text;
                clie.Descripcion = textBoxDescripcion.Text;
                clie.Domicilio = textBox1.Text;
                clie.Localidad = textBox2.Text;

                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlClienteNuevo(clie);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextBox();
                    cargarTabla(null);
                }
            }
            catch (FormatException ex)
            {
                // Este bloque capturará errores de formato, como cuando el usuario ingresa un valor no numérico en un campo que espera un número
                MessageBox.Show("Error: uno o más campos tienen un formato incorrecto. Por favor, verifique que ha ingresado números en los campos correspondientes.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButtonActualizar_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            string dato = textBoxNombreBuscador.Text;
            cargarTabla(dato);
            LimpiarTextBox();
        }

        private void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            //eliminar

            string datoid = textBoxEliminar.Text;
            CapaDatos.Control control = new CapaDatos.Control();
            string respuesta = control.ctrlClienteEliminado(datoid);
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cliente eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox();
                cargarTabla(null);

            }
        }

        private void LimpiarTextBox()
        {
            // Recorre todos los controles del formulario
            
            textBoxDescripcion.Text = string.Empty;
            textBoxEliminar.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxNombreBuscador.Text = string.Empty;
            textBoxDocumento.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
            textBoxCuil.Text = string.Empty;
            textBoxCorreo.Text = string.Empty;
            


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
