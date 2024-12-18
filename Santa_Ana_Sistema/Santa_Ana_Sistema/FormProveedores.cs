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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //boton guardar
            try
            {
                Proveedor prove = new Proveedor();

                prove.NombreComercial = textBoxNombre.Text;
                prove.RazonSocial = textBoxDocumento.Text;
                prove.CuilCuit = textBoxCuil.Text;
                prove.Telefono = textBoxTelefono.Text;
                prove.Correo = textBoxCorreo.Text;
                prove.Descripcion = textBoxDescripcion.Text;

                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlProveedorNuevo(prove);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Proveedor guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void cargarTabla(string dato)
        {

            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarProveedores(dato);

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            cargarTabla(null);
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

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            cargarTabla(textBoxNombreBuscador.Text);
        }

        private void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            //eliminar.

            string datoid = textBoxEliminar.Text;
            CapaDatos.Control control = new CapaDatos.Control();
            string respuesta = control.ctrlProveedorEliminado(datoid);

            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Proveedor eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox();
                cargarTabla(null);
            }
        }
    }

}
