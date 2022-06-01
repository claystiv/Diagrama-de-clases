using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_de_clases
{
    internal class Carros
    {
        private string Traccion;
        private int Puertas;
        private int Ventanas;

        public Carros(string Traccion, int Puertas,int Ventanas)
        {

            this.Traccion = Traccion;
            this.Puertas = Puertas;
            this.Ventanas = Ventanas;
        }

        public string GetTraccion()
        { return Traccion; }

        public void SetTraccion(string Traccion)
        { this.Traccion = Traccion; }

        public int GetPuertas()
        { return Puertas; }

        public void SetPuertas(int Puertas)
        { this.Puertas = Puertas; }

        public int GetVentanas()
        { return Ventanas; }

        public void SetVentanas(int Ventanas)
        { this.Ventanas = Ventanas; }



    }
}
