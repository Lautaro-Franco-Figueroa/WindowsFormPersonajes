using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private string Nombre;
        private int Vida;
        private int Daño;

        #region Propiedades
        public string p_Nombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }

        public int p_Vida
        {
            set { Vida = value; }
            get { return Vida; }
        }

        public int p_Daño
        {
            set { Daño = value; }
            get { return Daño; }
        }
        #endregion

        public Jugador()
        { }
        public Jugador(string name, int life, int dam)
        {
            Nombre = name;
            Vida = life;
            Daño = dam;
        }

        public void Atacar(int life, int dam)
        {
            p_Vida = life - dam;
        }
    }
}
