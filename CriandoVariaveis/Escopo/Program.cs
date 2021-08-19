using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 18;
            bool acompanhado = true;
            string msgAdicional;



            if (acompanhado == true)
            {
                msgAdicional = "João está acompanhado.";
            }
            else
            {
                msgAdicional = "João não está acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine(msgAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }
        }
    }
}
