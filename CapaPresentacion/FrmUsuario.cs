﻿using System;
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
    public partial class FrmUsuario : Form
    {
        private static Usuario usuarioActual;
        public FrmUsuario()
        {
            InitializeComponent();
        }        

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
