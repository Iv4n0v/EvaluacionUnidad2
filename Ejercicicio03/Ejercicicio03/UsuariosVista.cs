using Datos.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicicio03
{
    public partial class UsuariosVista : Form
    {
        public UsuariosVista()
        {
            InitializeComponent();
        }

        UsuarioAcceso usuarioAcceso = new UsuarioAcceso();

        private void UsuariosVista_Load(object sender, EventArgs e)
        {
            
          UsuariodataGridView.DataSource = usuarioAcceso.ListarUsuarios();
        }
    }
}
