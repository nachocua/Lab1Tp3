using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tp3_Prog
{
    public class Vehiculo
    {
        private int[] CantPaquetes = null;
        private int CapacidadCargada;
        public string Tipo { get; private set; }
        public string CapacidadTotal { get; private set; }
        public Vehiculo()
        {
            CantPaquetes = new int[3];
            CantPaquetes[0] = Convert.ToInt32("54");
            CapacidadCargada = 0;
        }
        public void AgregarPaquete(char tipo)
        {
            switch(tipo) 
            {
                case 'a':
                case 'A':
                    CantPaquetes[0]++;
                    CapacidadCargada += 5;
                break;
                case 'b':
                case 'B':
                    CantPaquetes[1]++;
                    CapacidadCargada += 15;
                    break;
                case 'c':
                case 'C':
                    CantPaquetes[2]++;
                    CapacidadCargada += 30;
                    break;
            }
        }
    }
}
