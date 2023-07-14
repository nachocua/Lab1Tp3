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
        /*public string Nombre { get; private set; }
        public int Edad { get; private set; }
        public string Club { get; private set; }*/
        public string Nombre { get;  set; }
        public int Edad { get;  set; }
        public string Club { get;  set; }
        public Competidor(string nombre, string club, int edad, int cantRondas) {
            Nombre = nombre;
            Club = club;
            Edad = edad;
            puntos = new int[cantRondas,3];
        }
        void AgregarPuntajes (int p1, int p2, int p3, int ronda)
        {
            puntos[ronda - 1, 0] = p1;
            puntos[ronda - 1, 1] = p2;
            puntos[ronda - 1, 2] = p3;
        }
    }
}
