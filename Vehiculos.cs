using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama_de_clases
{
    internal class Vehiculos
    {

        private string Nombre;
        private string Marca;
        private string Color;
        private double Alto;
        private double Largo;
        private double Ancho;
        private string Modelo;
        private char Uso;
        private double Velocidad;
        private int Asientos;

        public Vehiculos(string Nombre, string Marca, string Color, double Alto, double Largo, double Ancho, string Modelo, char Uso, double Velocidad,int Asientos)
        {

            this.Nombre = Nombre;
            this.Marca = Marca;
            this.Color = Color;
            this.Alto = Alto;
            this.Largo = Largo;
            this.Ancho = Ancho;
            this.Modelo = Modelo;
            this.Uso = Uso;
            this.Velocidad = Velocidad;
            this.Asientos = Asientos;


        }


        public String GetNombre()
        {return Nombre;}

        public void SetNombre(string Nombre)
        {this.Nombre = Nombre;}

        public String GetMarca()
            { return Marca; }

        public void SetMarca(string Marca)
        {this.Marca = Marca;}

        public String GetColor()
        { return Color; }

        public void SetColor(string Color)
        { this.Color = Color; }

        public double GetAlto()
        { return Alto; }

        public void SetAlto(double Alto)
        { this.Alto = Alto; }


        public double GetLargo()
        { return Largo; }

        public void SetLargo(double Largo)
        { this.Largo = Largo; }


        public String GetModelo()
        { return Modelo; }

        public void SetModelo(string Modelo)
        { this.Modelo = Modelo; }

        public char GetUso()
        { return Uso; }

        public void SetUso(char Uso)
        { this.Uso = Uso; }

        public double GetVelocidad()
        { return Velocidad; }

        public void SetVelocidad(double Velocidad)
        { this.Velocidad = Velocidad; }

        public int GetAsientos()
        { return Asientos; }

        public void SetAsientos(int Asientos)
        { this.Asientos = Asientos; }

        public bool Transportar()
        {
            return true;
        }
        public bool Avanzar()
        {
            return true;
        }
        public bool Retroceder()
        { return true; }
        public bool Girar()
        { return true; }
    }

}


