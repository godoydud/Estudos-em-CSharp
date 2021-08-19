using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.agencia = 863;
            conta.numero = 8635621;

            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numero = 8635621;

            Console.WriteLine(conta == contaGabrielaCosta);

        }
    }
}
