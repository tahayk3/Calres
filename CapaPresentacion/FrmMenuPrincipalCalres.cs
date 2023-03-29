using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipalCalres : Form
    {
        private static Usuario usuarioActual;
        private static ToolStripMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public FrmMenuPrincipalCalres(Usuario objusuario)
        {
            usuarioActual = objusuario;

            InitializeComponent();
        }

        private void FrmMenuPrincipalCalres_Load(object sender, EventArgs e)
        {
            lblUsuarioLogiado.Text = usuarioActual.Nombres;
        }    
        
        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            panContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void iNFORMACIONGENERALDELSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new Modales.MdAcercaDe());
        }

        private void cONDICIONESDEPRIVACIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new Modales.MdPrivacidad());
        }

        private void cREARNUEVOUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new FrmUsuario());
        }
        private void cAMBIARCONTRASEÑAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eVALUACIONAGENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pLANEMPRESARIALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eVALUACIONAGENCIASToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pLANEMPRESARIALToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
