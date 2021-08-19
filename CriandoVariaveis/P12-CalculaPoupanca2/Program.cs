using System;

namespace P12_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for(int contMes = 1; contMes <= 12; contMes++)
            {
                //valorInvestido = valorInvestido * 1.0036;
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contMes + " meses, você terá R$" + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
