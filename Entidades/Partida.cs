using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partida
    {
        private string Nombre;
        private DateTime Fecha;
        private string Resultado;

        #region Propiedades
        public string j_Nombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public string j_Resultado
        {
            set { Resultado = value; }
            get { return Resultado; }
        }
        #endregion

        public Partida()
        {
            Fecha = DateTime.Now;
        }
        public Partida(string nombre)
        {
            Nombre = nombre;
            Fecha = DateTime.Now;
            Resultado = "";
        }
    }
}
