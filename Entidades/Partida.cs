using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        private int Tiempo;
        private int Rondas;
        private string Ganador;
        private string Perdedor;

        public Partida()
        { }
        public Partida(int time, int rounds)
        {
            Tiempo = time;
            Rondas = rounds;
            Ganador = "";
            Perdedor = "";
        }
    }
}
