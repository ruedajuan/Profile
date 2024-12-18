using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control = System.Windows.Forms.Control;

namespace Santa_Ana_Sistema
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            cargarTabla(null);

        }
        private void cargarTabla(string dato)
        {

            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarProductos(dato);

        }

        private void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto();

                prod.Nombre = textBoxNombre.Text;
                prod.Presentacion = textBoxPresentacion.Text;
                prod.Descripcion = textBoxDescripcion.Text;
                prod.IdCategoria = int.Parse(textBoxIdCategoria.Text);
                prod.Stock = int.Parse(textBoxStock.Text);
                prod.PrecioVenta = decimal.Parse(textBoxPrecioVenta.Text);
                prod.PrecioCompra = decimal.Parse(textBoxPrecioCompra.Text);

                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlProductoNuevo(prod);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarTabla(null);
                    LimpiarTextBox();
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
            //modificarProducto
            
            try
            {
                Producto prod = new Producto();

                prod.IdProducto = int.Parse(textBox1.Text);

                if (!String.IsNullOrEmpty(textBoxNombre.Text))
                prod.Nombre = textBoxNombre.Text;

                if (!String.IsNullOrEmpty(textBoxPresentacion.Text))
                prod.Presentacion = textBoxPresentacion.Text;
                if (!String.IsNullOrEmpty(textBoxDescripcion.Text))
                prod.Descripcion = textBoxDescripcion.Text;
                if (!String.IsNullOrEmpty(textBoxIdCategoria.Text))
                prod.IdCategoria = int.Parse(textBoxIdCategoria.Text);
                if (!String.IsNullOrEmpty(textBoxStock.Text))
                prod.Stock = int.Parse(textBoxStock.Text);
                if (!String.IsNullOrEmpty(textBoxPrecioVenta.Text))
                prod.PrecioVenta = decimal.Parse(textBoxPrecioVenta.Text);
                if (!String.IsNullOrEmpty(textBoxPrecioCompra.Text))
                prod.PrecioCompra = decimal.Parse(textBoxPrecioCompra.Text);


                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlProductoEditado(prod);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarTabla(null);
                    LimpiarTextBox();
                }
            }
            
            catch (FormatException ex)
            {
                // Este bloque capturará errores de formato, como cuando el usuario ingresa un valor no numérico en un campo que espera un número
                MessageBox.Show("Error: uno o más campos tienen un formato incorrecto. Por favor, verifique que ha ingresado números en los campos correspondientes.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            string dato = textBoxNombreBuscador.Text;
            cargarTabla(dato);
            LimpiarTextBox();
        }

        private void textBoxEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            string datoid = textBoxEliminar.Text;
            CapaDatos.Control control = new CapaDatos.Control();
            string respuesta = control.ctrlProductoEliminado(datoid);
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Producto eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTextBox();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para modificar un producto, coloque los datos que desea modificar en los campos de Cargar Producto. Luego escriba el IdProducto y aprete el botón de Modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el color del botón cuando el cursor está encima
            iconButton1.BackColor = Color.DarkSlateGray;

            // Cambiar el cursor a una mano
            iconButton1.Cursor = Cursors.Hand;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar el color original cuando el cursor se retire
            iconButton1.BackColor = Color.DarkSlateGray;

            // Restaurar el cursor predeterminado
            iconButton1.Cursor = Cursors.Default;
        }
        private void LimpiarTextBox()
        {
            // Recorre todos los controles del formulario
            textBox1.Text = string.Empty;
            textBoxDescripcion.Text= string.Empty;
            textBoxEliminar.Text = string.Empty;
            textBoxIdCategoria.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxNombreBuscador.Text = string.Empty;
            textBoxPrecioCompra.Text = string.Empty;
            textBoxPrecioVenta.Text = string.Empty;
            textBoxPresentacion.Text = string.Empty;
            textBoxStock.Text = string.Empty;


        }
    }
}
