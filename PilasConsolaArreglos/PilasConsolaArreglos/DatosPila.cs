using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasConsolaArreglos
{
    class DatosPila
    {
        private int numero;
        private string dato;

        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public DatosPila()
        {
            numero = 0;
            dato = "";
            
        }
        public DatosPila(int num, string nomb)
        {
            numero = num;
            dato = nomb;
        }

        public override string ToString()
        {
            return numero + " - " + dato;
        }

    }
}
