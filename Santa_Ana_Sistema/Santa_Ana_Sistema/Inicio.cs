using CapaDatos;
using FontAwesome.Sharp;
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
    public partial class Inicio : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio()
        {
            InitializeComponent();
            // Suscribirse al evento FormClosed
            this.FormClosed += InicioForm_FormClosed;
            usuarioNombre.Text= Sesion.NombreUsuario.ToString();
            label3.Text = Sesion.IdUsuario.ToString();
            MenuRol(Sesion.IdRol);
            this.FormClosed += new FormClosedEventHandler(FormEmergente_FormClosed);
        }
        private void FormEmergente_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cierra toda la aplicación al cerrar la ventana emergente
            Application.Exit();
        }



        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void InicioForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Obtener la instancia de la ventana Login
            Login loginForm = (Login)Application.OpenForms["Login"];

            // Llamar al método para limpiar los TextBox
            loginForm?.limpiar_texto();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void abrirFormulario(IconMenuItem menu, Form formulario) 
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.PapayaWhip;
            }
            menu.BackColor = Color.DarkSeaGreen;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock= DockStyle.Fill;
            formulario.BackColor= Color.NavajoWhite;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void menuusuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormUsuario());
        }

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(menumantenedor, new FormCategoria());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            abrirFormulario(menumantenedor, new FormProductos());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuventas, new FormRegistrarVenta());
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
           
        }

        private void subMenuRegistarCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menucompras, new FormRegistrarCompra());
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(menucompras, new FormCompras());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new FormProveedores());
        }
        public void MenuRol(int idRol)
        {
            if (idRol == 2)
            {
                menuusuarios.Visible=false;
                menumantenedor.Visible=false;
            }

        }

        private void menuventas_Click(object sender, EventArgs e)
        {
            abrirFormulario(menuventas, new FormRegistrarVenta());
        }

        private void menucompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(menucompras, new FormRegistrarCompra());
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Source\r\n\r\nEste sistema se publica bajo los términos de la licencia MIT.\r\n\r\nEL SOFTWARE SE PROPORCIONA \"TAL CUAL\", SIN GARANTÍA DE NINGÚN TIPO, EXPRESA O IMPLÍCITA. EN NINGÚN CASO EL CREADOR DEL SOFTWARE SERÁ RESPONSABLE DE CUALQUIER RECLAMO, DAÑO U OTRA RESPONSABILIDAD, YA SEA EN UNA ACCIÓN DE CONTRATO, AGRAVIO O DE OTRO MODO, QUE SURJA DE, FUERA DE O EN RELACIÓN CON EL SOFTWARE O EL USO U OTRAS NEGOCIACIONES EN EL SOFTWARE.\r\n\r\nDesarrollado por: Juan Ignacio Rueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            abrirFormulario(menureportes, new FormReportes());
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menureportes, new ReporteCompras());
        }

        private void menumantenedor_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(menureportes, new FormReportes());

        }
    }
}
