using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int qntdPessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }
            else
            {
                if (qntdPessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, porém está acompanhado e pode entrar.");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar.");
                }
            }
        }
    }
}
