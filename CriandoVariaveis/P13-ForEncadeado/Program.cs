using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13");

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********

            // Escrevendo asteriscos com o BREAK
            for (int contLinha = 0; contLinha < 10; contLinha++) // For para pular linha 10x
            {
                for (int contColuna = 0; contColuna < 10; contColuna++)
                {
                    Console.Write("*");
                    if (contColuna >= contLinha) // Se valor coluna for maior ou igual ao valor linha
                        break;
                }
                Console.WriteLine();
            }

            // Forma diferente de fazer o desenho de asteriscos
            for (int contLinha = 0; contLinha < 10; contLinha++) // For para pular linha 10x
            {
                for (int contColuna = 0; contColuna <= contLinha; contColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if ( coluna > linha)
                    {
                        break;
                    }
                    Console.Write(coluna+1);
                }
                Console.WriteLine("\n");
            }
            
            // Imprimir múltiplos de 3 de 1 ao 100
            for(int i = 1; i < 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.Write(i+" ");
                }
            }

            Console.WriteLine();

            // Imprimir múltiplos de 3 de 1 ao 100 (Segunda opção)
            for(int i = 3; i < 100; i+=3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // Imprimir fatorial do 1 ao 10
            int fatorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
        }
    }
}
