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
        private int[] posiciónCompetidores = null;
        private bool[] cargadaRonda = null;
        public int Participantes {  get; private set; }
        public int Rondas { get; private set; }
        public int RondaActual { get; private set; }
        public Torneo(int cantRondas)
        {
            RondaActual = 1;
            listaCompetidores = new Competidor[100];
            posiciónCompetidores = new int[100];
            cargadaRonda= new bool[100];
            Participantes = 0;
            Rondas = cantRondas;
        }
        public void CargarCompetidor(string nombre, string club, int edad)
        {
            Competidor unCompetidor = new Competidor(nombre, club, edad, Rondas);
            listaCompetidores[Participantes] = unCompetidor;
            posiciónCompetidores[Participantes] = Participantes;
            Participantes++;
        }
        public Competidor getCompetidorOrdenado(int indx)
        {
            return listaCompetidores[posiciónCompetidores[indx]];
        }
        public Competidor getCompetidor(int indx)
        {
            return listaCompetidores[indx];
        }
        public void cargadoPuntaje(int idx)
        {
            cargadaRonda[idx] = true;
        }
        public bool rondaCompleta()
        {
            bool state = true;
            int i = 0;
            while (i < Participantes && state == true)
            {
                if(cargadaRonda[i] == false)
                {
                    state = false;
                }
                i++;
            }
            return state;
        }
        public void siguienteRonda()
        {
            RondaActual++;
            for (int i = 0; i < Participantes; i++)
            {
                cargadaRonda[i] = false;
            }
        }
        public void ordenar()
        {
            int i, j, aux;
            Competidor auxCompetidor = null;
            for(i = 0; i< Participantes-1; i++)
            {
                for(j = i; j < Participantes;  j++)
                {
                    if (listaCompetidores[i].PuntosTotales < listaCompetidores[j].PuntosTotales)
                    {
                        auxCompetidor = listaCompetidores[i];
                        listaCompetidores[i] = listaCompetidores[j];
                        listaCompetidores[j] = auxCompetidor;
                        aux = posiciónCompetidores[i];
                        posiciónCompetidores[i] = posiciónCompetidores[j];
                        posiciónCompetidores[j] = aux;
                    }
                    else
                    {
                        if(listaCompetidores[i].PuntosTotales == listaCompetidores[j].PuntosTotales)
                        {
                            if (listaCompetidores[i].CantidadCentros < listaCompetidores[j].CantidadCentros)
                            {
                                auxCompetidor = listaCompetidores[i];
                                listaCompetidores[i] = listaCompetidores[j];
                                listaCompetidores[j] = auxCompetidor;
                                aux = posiciónCompetidores[i];
                                posiciónCompetidores[i] = posiciónCompetidores[j];
                                posiciónCompetidores[j] = aux;
                            }
                        }
                    }
                }
            }
        }
    }
}
