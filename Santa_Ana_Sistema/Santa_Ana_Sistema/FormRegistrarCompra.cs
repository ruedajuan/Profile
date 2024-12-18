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
    public partial class FormRegistrarCompra : Form
    {
        public FormRegistrarCompra()
        {
            InitializeComponent();
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormRegistrarCompra_Load(object sender, EventArgs e)
        {
            cargarTabla(null);
        }

        private void cargarTabla(string dato)
        {

            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarCompras(dato);

        }

        private void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            //nueva compra

            try
            {
                Compra comp = new Compra();
                comp.IdProveedor = int.Parse(textBoxIdCliente.Text);
                comp.IdUsuario = Sesion.IdUsuario;
                comp.ModalidadPago = textBoxModalidadPago.Text;
                comp.TipoDocumento = textBoxDescripcion.Text;

                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlCompraNueva(comp);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nueva compra registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void LimpiarTextBox()
        {
            // Recorre todos los controles del formulario

            textBoxEliminar.Text = string.Empty;
            textBoxDniBuscador.Text = string.Empty;
            textBoxCantidad.Text = string.Empty;
            textBoxDescripcion.Text = string.Empty; //tipo dni
            textBoxIdCliente.Text = string.Empty;   //proveedor
            textBoxIdProducto.Text = string.Empty;
            textBoxNroVenta.Text = string.Empty; //compra
            textBoxModalidadPago.Text = string.Empty;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //CARGAR PRODUCTO

            if (String.IsNullOrEmpty(textBoxNroVenta.Text) || String.IsNullOrEmpty(textBoxIdProducto.Text) || String.IsNullOrEmpty(textBoxCantidad.Text))
            {
                string respuesta1 = "Complete todos los campos";
                MessageBox.Show(respuesta1, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {

                    Detalle_Compra dcomp = new Detalle_Compra();
                    dcomp.NroCompra = int.Parse(textBoxNroVenta.Text);
                    dcomp.IdProducto = int.Parse(textBoxIdProducto.Text);
                    dcomp.Cantidad = int.Parse(textBoxCantidad.Text);
                    Modelo mod = new Modelo();
                    dcomp.SubTotal = dcomp.Cantidad * mod.obtenerPrecioCompraProducto(textBoxIdProducto.Text);

                    CapaDatos.Control control = new CapaDatos.Control();
                    string respuesta = control.ctrlCargarProductosDCompra(dcomp);
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Producto Cargado en NroCompra: " + dcomp.NroCompra, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            VentanaProductos vp1 = new VentanaProductos();
            vp1.WindowState = FormWindowState.Maximized;
            vp1.Show();
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            //buscar por NroCompra
            cargarTabla(textBoxDniBuscador.Text);
        }

        private void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            //eliminiar

            try
            {

                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlBuscarNroCompra(int.Parse(textBoxEliminar.Text));
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Compra eliminada. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
