using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Caucula Poupança");

            double valorInvestido = 1000;
            int contMes = 1;

            // 0.36% = 0.0036
            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Após 1 mês, você terá R$" + valorInvestido);
            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Após 2 mêses, você terá R$" + valorInvestido);

            // Implementando laço de repetição WHILE
            while (contMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "+contMes+ " mês(es), você terá R$" + valorInvestido);
                contMes ++; // contMes +=1
            }

            Console.ReadLine();
        }
    }
}
