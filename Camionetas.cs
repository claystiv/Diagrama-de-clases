using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_de_clases
{
    internal class Camionetas 
    {
        private string Parachoques;
        private int Cilindraje;
        private string Remolque;

        public Camionetas(string Parachoques, int Cilindraje,string Remolque)
        {
            this.Parachoques = Parachoques;
            this.Cilindraje = Cilindraje;
            this.Remolque = Remolque;

        }


        public string GetParachoque()
        { return Parachoques; }

        public void SetParachoque(string Parachoque)
        { this.Parachoques = Parachoque; }

        public int GetCilindraje()
        { return Cilindraje; }

        public void SetCilindraje(int Cilindraje)
        { this.Cilindraje = Cilindraje; }

        public string GetRemolque()
        { return Remolque; }

        public void SetRemolque(string Remolque)
        { this.Remolque = Remolque; }



    }
}
