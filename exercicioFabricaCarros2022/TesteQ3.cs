using Q1;
using Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    public class TesteQ3
    {
        public static void teste()
        {
            FabricaDeCarros fabrica = new FabricaWV();

            CarroSedan sedan;
            sedan = fabrica.criarCarroSedan();
            Voyage Voyage001 = new Voyage();
            Voyage001.exibirInfoSedan();

            CarroPopular popular;
            popular = fabrica.criarCarroPopular();
            Gol Gol001 = new Gol();
            Gol001.exibirInfoPopular();

            CarroPicape picape;
            picape = fabrica.criarCarroPicape();
            Saveiro Saveiro001 = new Saveiro();
            Saveiro001.exibirInfoPicape();

        }
    }
}