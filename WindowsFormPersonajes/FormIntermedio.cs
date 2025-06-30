using DataAccess;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPersonajes
{
    public partial class FormIntermedio : Form
    {
        public FormIntermedio()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            FormPelea ventana = new FormPelea();
            ventana.NombreJugador = txtPj.Text;
            ventana.Show();
        }
    }
}
