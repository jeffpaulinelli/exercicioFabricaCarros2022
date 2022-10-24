using Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    abstract class FabricaDeCarros
    {
        public abstract CarroPopular criarCarroPopular();
        public abstract CarroSedan criarCarroSedan();
        public abstract CarroPicape criarCarroPicape();
    }
}
