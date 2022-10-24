using Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class FabricaFiat : FabricaDeCarros
    {
        public override CarroSedan criarCarroSedan() => (new Cronos());
        public override CarroPopular criarCarroPopular() => (new Mobi());
        public override CarroPicape criarCarroPicape() => (new Strada());
    }
}
