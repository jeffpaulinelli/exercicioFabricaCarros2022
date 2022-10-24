using Q1;
using Q2;
using Q3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    public class TesteQ4
    {
        public static void teste()
        {
            FabricaDeCarros WV = new FabricaWV();
            FabricaDeCarros FIAT = new FabricaFiat();
            string[] vetor = new string[30];

            for (int i = 0; i <= 29; i++)
            {
                var aux = new Random().Next(0, 6);

                    switch (aux)
                    {
                        case 0:
                            vetor[i] = WV.criarCarroSedan().ToString();
                            break;
                        case 1:
                            vetor[i] = WV.criarCarroPicape().ToString();
                            break;
                        case 2:
                            vetor[i] = WV.criarCarroPopular().ToString();
                            break;
                        case 3:
                            vetor[i] = FIAT.criarCarroSedan().ToString();
                            break;
                        case 4:
                            vetor[i] = FIAT.criarCarroPicape().ToString();
                            break;
                        case 5:
                            vetor[i] = FIAT.criarCarroPopular().ToString();
                            break;
                    }
                
            }

            foreach (string carro in vetor)
            {
                Console.WriteLine(carro);
            }


        }
    }
}
