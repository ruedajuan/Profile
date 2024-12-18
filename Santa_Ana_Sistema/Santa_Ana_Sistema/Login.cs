using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace Santa_Ana_Sistema
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textUsuario.Text;
            string password = textClave.Text;
            CapaDatos.Control ctrl = new CapaDatos.Control();
            string respuesta = ctrl.ctrlAcceso(usuario, password);
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                Inicio fa1 = new Inicio();
                fa1.StartPosition = FormStartPosition.CenterScreen;
                fa1.WindowState = FormWindowState.Maximized;
                fa1.Show();



            }


        }
        public void limpiar_texto()
        {
            textUsuario.Text = "";
            textClave.Text = "";
        }

        private void iconButtoncontra_Click(object sender, EventArgs e)
        {
            if (textClave.PasswordChar == '*')
            {
                textClave.PasswordChar = '\0'; // Muestra la contraseña
                iconButtoncontra.Text = "Ocultar contraseña";
            }
            else
            {
                textClave.PasswordChar = '*'; // Oculta la contraseña
                iconButtoncontra.Text = "Mostrar contraseña";
            }
        }
    }

}
