using System;

namespace Calculadora_Simples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double resposta;
            string opr;

            Console.WriteLine("Calculadora\n");

            Console.WriteLine("Digite o primeiro numero:\n");
            numero1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:\n");
            numero2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual Operação matematica?\n");
            opr = Console.ReadLine();

            if (opr == "+")
            {
                resposta = numero1 + numero2;
                Console.WriteLine("\n" + resposta);
            }
            if (opr == "-")
            {
                resposta = numero1 + numero2;
                Console.WriteLine("\n" + resposta);
            }
            if (opr == "*")
            {
                resposta = numero1 + numero2;
                Console.WriteLine("\n" + resposta);
            }
            if (opr == "/")
            {
                resposta = numero1 + numero2;
                Console.WriteLine("\n" + resposta);
            }
           
        }
    }
}
