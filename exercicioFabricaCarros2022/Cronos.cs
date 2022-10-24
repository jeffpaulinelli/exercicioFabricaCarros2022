using Q1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Cronos : CarroSedan
    {
        private string modelo = "cronos";
        private string fabrica = "Fiat";
        private string numChassi = "99BW ZZZ377 VT 152400";
        private string categoria = "sedan";

        public override void exibirInfoSedan()
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
