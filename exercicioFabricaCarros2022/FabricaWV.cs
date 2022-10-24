using Q1;
using Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class FabricaWV : FabricaDeCarros
    {
        public override CarroSedan criarCarroSedan()
        {
            return (new Voyage());
        }
        public override CarroPopular criarCarroPopular()
        {
            return (new Gol());
        }
        public override CarroPicape criarCarroPicape()
        {
            return (new Saveiro());
        }
    }
}
