using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;
namespace Ejercicicio03
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioAcceso usuarioAcceso = new UsuarioAcceso();
            Usuario usuario = new Usuario();

            usuario = usuarioAcceso.Login(UsuarioTextBox.Text, ClaveTextBox.Text);
            if (usuario == null)
            {
                MessageBox.Show("Usuario NO Existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario NO Activo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("INGRESO");//quitar luegoooo
        }

   
    }
}
