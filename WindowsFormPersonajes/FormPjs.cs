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
            DGVPlayers.DataSource = JugadoresDB.CargarDGV();
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador(txtName.Text, Convert.ToInt32(txtLife.Text), Convert.ToInt32(txtDam.Text));
            {
                try
                {
                    JugadoresDB.Actualizar(jugador);
                    DGVPlayers.DataSource = JugadoresDB.CargarDGV();
                    MessageBox.Show("Jugador Actualizado");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar el jugador: " + ex.Message);
                }
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            JugadoresDB.Eliminar(txtName.Text); 
            DGVPlayers.DataSource = JugadoresDB.CargarDGV();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            FormIntermedio ventana = new FormIntermedio();
            ventana.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
