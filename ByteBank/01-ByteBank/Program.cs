using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 421124;
            contaGabriela.saldo = 100;

            Console.WriteLine("Titular: " + contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);


            Console.ReadLine();
        }
    }
}
