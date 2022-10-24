using Q1;
using Q2;
using Q3;
using Q4;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("--- BEM VINDO(A)!\nQUAL QUESTÃO DESEJA TESTAR? ---\n");
        int x;
        x = int.Parse(Console.ReadLine());
        switch (x)
        {
            case 1://PRIMEIRA QUESTÃO 
                Console.WriteLine("!!! --- Teste primeira questão --- !!!");
                TesteQ1.Teste();
                break;
                case 2://SEGUNDA QUESTÃO 
                Console.WriteLine("!!! --- Teste segunda questão --- !!!");
                TesteQ2.Teste();
                break;
            case 3:        //TERCEIRA QUESTÃO 
                Console.WriteLine("!!! --- Teste terceira questão --- !!!");
                TesteQ3.teste();
                break;
            case 4:         //QUARTA QUESTÃO 
                Console.WriteLine("!!! --- Teste quarta questão --- !!!");
                TesteQ4.teste();
                break;
                default: Console.WriteLine("Número incorreto");
                break;
        }
        /*
        //PRIMEIRA QUESTÃO 
        Console.WriteLine("!!! --- Teste primeira questão --- !!!");
        TesteQ1.Teste();
        //SEGUNDA QUESTÃO 
        Console.WriteLine("!!! --- Teste segunda questão --- !!!");
        TesteQ2.Teste();
        //TERCEIRA QUESTÃO 
        Console.WriteLine("!!! --- Teste terceira questão --- !!!");
        TesteQ3.teste();
        //QUARTA QUESTÃO 
        Console.WriteLine("!!! --- Teste quarta questão --- !!!");
        TesteQ4.teste();
    */
        }
}