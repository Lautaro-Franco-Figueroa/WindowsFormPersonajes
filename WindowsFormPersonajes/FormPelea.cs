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
using System.Xml.Linq;

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
        }

        private void BtFight_Click(object sender, EventArgs e)
        {
            
            Jugador jugador = new Jugador(lblNamePlayer.Text, Convert.ToInt32(LifePlayer.Text), Convert.ToInt32(DamPlayer.Text));
            Jugador enemigo = new Jugador(lblNameEnemy.Text, Convert.ToInt32(LifeEnemy.Text), Convert.ToInt32(DamEnemy.Text));
            if (jugador.p_Vida > 0 && enemigo.p_Vida > 0)
            {
                jugador.Atacar(enemigo.p_Vida, jugador.p_Daño);
                enemigo.Atacar(jugador.p_Vida, enemigo.p_Daño);
                LifePlayer.Text = jugador.p_Vida.ToString();
                LifeEnemy.Text = enemigo.p_Vida.ToString();
                if (jugador.p_Vida <= 0)
                {
                    MessageBox.Show("¡Has perdido la pelea!");

                    Partida partida = new Partida(lblNamePlayer.Text, "Perdiste");
                    HistorialDB.Crear(partida);
                    DGVHistorial.DataSource = HistorialDB.CargarDGV();

                }
                else if (enemigo.p_Vida <= 0)
                {
                    MessageBox.Show("¡Has ganado la pelea!");

                    Partida partida = new Partida(lblNamePlayer.Text, "Ganaste");
                    HistorialDB.Crear(partida);
                    DGVHistorial.DataSource = HistorialDB.CargarDGV();
                }
            }
            else
            {
                MessageBox.Show("No puedes pelear si ambos jugadores no tienen vida.");
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            JugadoresDB.Buscar(lblNamePlayer.Text);
            
        }
    }
}
