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
    public partial class FormPelea : Form
    {
        public string NombreJugador
        {
            set { lblNamePlayer.Text = value; }
        }

        public FormPelea()
        {
            InitializeComponent();
            Jugador jugador = JugadoresDB.Buscar(lblNamePlayer.Text);
            LifePlayer.Text = jugador.p_Vida.ToString();
            DamPlayer.Text = jugador.p_Daño.ToString();
        }
    }
}
