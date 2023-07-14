using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2
{
    internal class Torneo
    {
        private Competidor[] listaCompetidores = null;
        public int Participantes {  get; private set; }
        public int Rondas { get; private set; }
        public int RondaActual { get; private set; }
        public Torneo(int cantRondas)
        {
            RondaActual = 1;
            listaCompetidores = new Competidor[100];
            Participantes = 0;
            Rondas = cantRondas;
        }
        public void CargarCompetidor(string nombre, string club, int edad)
        {
            Competidor unCompetidor = new Competidor(nombre, club, edad, Rondas);
            listaCompetidores[Participantes] = unCompetidor;
            Participantes++;
        }
        public Competidor getCompetidor(int indx)
        {
            return listaCompetidores[indx];
        }
    }
}
