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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Santa_Ana_Sistema
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //eliminar usuario
            string dato = textBoxEliminar.Text;
            CapaDatos.Control control = new CapaDatos.Control();
            string respuesta = control.ctrlUsuarioEliminado(dato);
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
           



        private void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxCalve.Text == textBoxClave2.Text){
                Usuario usuarionuevo = new Usuario();
                usuarionuevo.Documento = textBoxDni.Text;
                usuarionuevo.NombreCompleto = textBoxNombreC.Text;
                usuarionuevo.Correo= textBoxCorreo.Text;
                usuarionuevo.NombreUsuario = textBoxNombreU.Text;
                usuarionuevo.Clave = textBoxCalve.Text;
                usuarionuevo.IdRol = int.Parse(((OpcionCombo)comboBoxRol.SelectedItem).Valor.ToString());
                CapaDatos.Control control = new CapaDatos.Control();
                string respuesta = control.ctrlUsuarioNuevo(usuarionuevo);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextBox();
                    cargarTabla(null);
                }
                
            }
            else
            {
                MessageBox.Show("No coinciden las contraseñas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            comboBoxRol.Items.Add(new OpcionCombo() { Texto = "Administrador" , Valor=1} );
            comboBoxRol.Items.Add(new OpcionCombo() { Texto = "Empleado", Valor = 2 });
            comboBoxRol.DisplayMember= "Texto";
            comboBoxRol.ValueMember = "Valor";
            comboBoxRol.SelectedIndex = 0;


            cargarTabla(null);
        }
        private void cargarTabla(string dato)
        {
            
            Modelo md = new Modelo();
            dataGridView1.DataSource = md.mostrarUsuarios(dato);

        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            string dato = textBoxDniBuscador.Text;
            cargarTabla(dato);
            LimpiarTextBox();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarTextBox()
        {
            // Recorre todos los controles del formulario

            textBoxCalve.Text = string.Empty;
            textBoxEliminar.Text = string.Empty;
            textBoxCorreo.Text = string.Empty;
            textBoxClave2.Text = string.Empty;
            textBoxDni.Text = string.Empty;
            textBoxDniBuscador.Text = string.Empty;
            textBoxNombreC.Text = string.Empty;
            textBoxNombreU.Text = string.Empty;



        }
    }
}
