using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace V2
{
    public class Competidor
    {
        private int[,] puntos = null;
        public string Nombre { get; private set; }
        public int Edad { get; private set; }
        public string Club { get; private set; }
        public int PuntosTotales { get; private set; }
        public int CantidadCentros { get; private set; }
        public Competidor(string nombre, string club, int edad, int cantRondas) 
        {
            Nombre = nombre;
            Club = club;
            Edad = edad;
            puntos = new int[cantRondas,3];
            PuntosTotales = 0;
        }
        public void AgregarPuntaje (int ronda, int pos, int puntaje)
        {
            puntos[ronda - 1, pos] = puntaje;
            calcularPuntaje(ronda);
        }
        public string GetPuntaje(int ronda, int pos)
        {
            string aux = puntos[ronda, pos].ToString();
            if (aux=="11")
            {
                aux = "10x";
            }
            return aux;
        }
        private void calcularPuntaje(int rondasActuales)
        {
            PuntosTotales = 0;
            CantidadCentros = 0;
            int i, j;
            for(i = 0; i < rondasActuales; i++) 
            {
                for(j = 0; j < 3; j++)
                {
                    if (puntos[i,j] ==11)
                    {
                        PuntosTotales += 10;
                        CantidadCentros++;
                    }
                    else
                    {
                        PuntosTotales += puntos[i, j];
                    }    
                }
            }
        }
    }
}
