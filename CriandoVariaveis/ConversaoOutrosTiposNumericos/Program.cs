using System;

namespace ConversaoOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");
            double salario;
            salario = 1500.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // Conversao de Double para inteiro (cast)
            Console.WriteLine(salarioEmInteiro);


            long idade = 130000000000000; // Funciona como um tipo int que admite valores maiores (64bits)
            Console.WriteLine(idade);
            short qntdProdutos = 150; // Funciona como um tipo int que admite apenas valores pequenos
            Console.WriteLine(qntdProdutos);

            float altura = 1.80f; // Precisão mais curta em relação ao tipo Double, coloca-se "f" para dizer que se trata mesmo de um tipo float
            Console.WriteLine("%.2f" + altura);




            Console.ReadLine();
        }
    }
}
