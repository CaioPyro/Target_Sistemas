using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci;
            int entrada = 0;
            bool pertence = false;

            Console.WriteLine("Informe um valor:");
            entrada = int.Parse(Console.ReadLine());

            for (int i = 0; i < 100; i++)
            {
                fibonacci = numeroAnterior + numeroAtual;
                Console.WriteLine(fibonacci);
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;

                if(numeroAtual == entrada) 
                {
                    pertence = true;
                }   

            }

            if (pertence == true)
            {
                Console.WriteLine("O número informado pertence a sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("O número informado não pertence a sequência de Fibonacci.");
            }
        }
    }
}
