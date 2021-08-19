using System;

namespace CriandoVariaveisDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variaveis ponto flutuante!");
            double salario;
            salario = 1200.70;
            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2.0;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);
            idade = 5.0 / 3;
            Console.WriteLine("5 / 3 = " + idade);



            Console.WriteLine("Fim da execução"); 
            Console.ReadLine(); // Para o CMD não fechar sozinho
        }
    }
}
