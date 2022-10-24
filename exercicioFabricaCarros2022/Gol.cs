using Q1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Gol : CarroPopular
    {
        private string modelo = "Gol";
        private string numChassi = "99BW ZZZ377 VT 123456";
        private string fabrica = "Volkswagen";
        private string categoria = "Hatch";


        public override void exibirInfoPopular()
        {
            Console.WriteLine(" Modelo: " + this.modelo + "\n Número Chassis: " + this.numChassi + "\n Fabrica: " + this.fabrica + "\n Categoria: " + this.categoria);
        }
        public override string ToString()
        {
            return new StringBuilder()
                      .Append("Modelo: " + this.modelo)
                      .Append(" -- Número Chassi: " + this.numChassi)
                      .Append(" -- Fabrica: " + this.fabrica)
                      .Append(" -- Categoria: " + this.categoria)
                      .ToString();
        }
    }
}

