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
    public partial class FormRegistrarVenta : Form
    {
        public int nroRemito;
        public FormRegistrarVenta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
                    }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            //nueva venta, solo se ingresa el codigo del cliente
            
            try
            {
                Venta vent = new Venta();
                vent.IdCliente = int.Parse(textBoxIdCliente.Text);
                vent.IdUsuario = Sesion.IdUsuario;
                vent.ModalidadPago = textBoxModalidadPago.Text;
                vent.Descripcion = textBoxDescripcion.Text;
              

                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlVentaNueva(vent);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nueva venta registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextBox();
                    cargarTabla(null);
                }
            }
            catch (FormatException ex)
            {
                // Este bloque capturará errores de formato, como cuando el usuario ingresa un valor no numérico en un campo que espera un número
                MessageBox.Show("Error: uno o más campos tienen un formato incorrecto. Por favor, verifique que ha ingresado números en los campos correspondientes.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarTabla(null);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormRegistrarVenta_Load(object sender, EventArgs e)
        {
            cargarTabla(null);
        }
        private void cargarTabla(string dato)
        {

            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarVentas(dato);

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //verifico que esten llenos los campos
            if (String.IsNullOrEmpty(textBoxNroVenta.Text) || String.IsNullOrEmpty(textBoxIdProducto.Text) || String.IsNullOrEmpty(textBoxCantidad.Text))
            {
                string respuesta1 = "Complete todos los campos";
                MessageBox.Show(respuesta1, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else { 
            try
            {

                Detalle_Venta dvent = new Detalle_Venta();
                dvent.NroVenta = int.Parse(textBoxNroVenta.Text);
                dvent.IdProducto = int.Parse(textBoxIdProducto.Text);
                dvent.Cantidad = int.Parse(textBoxCantidad.Text);
                Modelo mod = new Modelo();
                dvent.SubTotal =dvent.Cantidad * mod.obtenerPrecioProducto(textBoxIdProducto.Text);

                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlCargarProductosDVenta(dvent);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto Cargado en NroVenta: " + dvent.NroVenta , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        private void textBoxNroVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            VentanaProductos vp1 = new VentanaProductos();
            vp1.WindowState = FormWindowState.Maximized;
            vp1.Show();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LimpiarTextBox()
        {
            // Recorre todos los controles del formulario


            textBoxEliminar.Text = string.Empty;
            textBoxDniBuscador.Text = string.Empty;
            textBoxCantidad.Text = string.Empty;
            textBoxDescripcion.Text = string.Empty;
            textBoxIdCliente.Text = string.Empty;
            textBoxIdProducto.Text = string.Empty;
            textBoxNroVenta.Text = string.Empty;
            textBoxModalidadPago.Text = string.Empty;
            textBox1.Text = string.Empty;



        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            //buscar por NroVenta
            cargarTabla(textBoxDniBuscador.Text);
        }

        private void iconButtonEliminar_Click(object sender, EventArgs e)
        {

            try
            {
               
                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlBuscarNroVenta(int.Parse(textBoxEliminar.Text));
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Venta eliminada. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void iconButton3_Click(object sender, EventArgs e)
        {
            try
            {

                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlNroVenta(int.Parse(textBox1.Text));
               
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //ver detalle
                    FormVentas vp1 = new FormVentas(int.Parse(textBox1.Text));
                    vp1.WindowState = FormWindowState.Maximized;
                    vp1.Show();
                }
                LimpiarTextBox();
            }
            catch (FormatException ex)
            {
                // Este bloque capturará errores de formato, como cuando el usuario ingresa un valor no numérico en un campo que espera un número
                MessageBox.Show("Error: uno o más campos tienen un formato incorrecto. Por favor, verifique que ha ingresado números en los campos correspondientes.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
    }
}
