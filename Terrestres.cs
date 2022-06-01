using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_de_clases
{
    internal class Terrestres 
    {
        private int Ruedas;
        private string Motor;
        private string Frenos;
        private int Luces;



        public Terrestres(int Ruedas,string Motor,string Frenos,int Luces)
        {
            this.Ruedas = Ruedas;
            this.Motor = Motor;
            this.Frenos = Frenos;
            this.Luces = Luces;
        }


        public int GetRuedas()
        { return Ruedas; }

        public void SetRuedas(int Ruedas)
        { this.Ruedas = Ruedas; }

        public String GetMotor()
        { return Motor; }

        public void SetMotor(string Motor)
        { this.Motor = Motor; }

        public string GetFrenos()
        { return Frenos; }

        public void SetFrenos(string Frenos)
        { this.Frenos = Frenos; }

        public int GetLuces()
        { return Luces; }

        public void SetLuces(int Luces)
        { this.Luces = Luces; }



        private bool Frenar()
        {
            Console.WriteLine("El vehiculo puede frenar");
            return true;
        }
        private bool acelerar()
        {
            Console.WriteLine("Se puede acelerar la velocidad del vehiculo");
            return true;
        }
        private bool desacelerar()
        {
            Console.WriteLine("Se puede desacelerar la velocidad del vehiculo");
            return true;
        }
    }
}
