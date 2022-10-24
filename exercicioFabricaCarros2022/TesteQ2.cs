using Q1;
using Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class TesteQ2
    {
        public static void Teste()
        {
            FabricaDeCarros fabrica = new FabricaFiat();
            CarroPopular popular;
            popular = fabrica.criarCarroPopular();
            Mobi MOBI001 = new Mobi();
            MOBI001.exibirInfoPopular();
            CarroSedan sedan;
            sedan = fabrica.criarCarroSedan();
            Cronos CRONOS001 = new Cronos();
            CRONOS001.exibirInfoSedan();
            CarroPicape picape;
            picape = fabrica.criarCarroPicape();
            Strada Strada001 = new Strada();
            Strada001.exibirInfoPicape();
        }
    }
}
