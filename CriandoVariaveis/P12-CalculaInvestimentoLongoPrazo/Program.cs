using System;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for(int contAno = 1; contAno <= 5; contAno++)
            {
                for(int contMes = 1; contMes <= 12; contMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            
            Console.WriteLine("Ao término do investimento você terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
