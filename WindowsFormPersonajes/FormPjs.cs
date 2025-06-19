using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using DataAccess;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace WindowsFormPersonajes
{
    public partial class FormPjs : Form
    {
        public FormPjs()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador(txtName.Text, Convert.ToInt32(txtLife.Text), Convert.ToInt32(txtDam.Text));
            JugadoresDB.Crear(jugador);
            DGVPlayers.DataSource = JugadoresDB.CargaDGV();
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            Jugador jugadorNuevo;
            jugadorNuevo = new Jugador(txtName.Text, int.Parse(txtLife.Text), int.Parse(txtDam.Text));

            MessageBox.Show("Jugador Creado");
        }
    }
}
