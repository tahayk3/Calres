using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtUsuarioLogin.Text && u.Clave == txtContraseniaLogin.Text).FirstOrDefault();

            if (ousuario != null)
            {
                FrmMenuPrincipalCalres form = new FrmMenuPrincipalCalres(ousuario);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se Encontró el Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
              

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }        
    }
}
