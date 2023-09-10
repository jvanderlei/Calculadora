using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { ValorA = 2, ValorB = 3, Operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 14, ValorB = 8, Operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 5, ValorB = 6, Operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 2147483647, ValorB = 2, Operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { ValorA = 18, ValorB = 3, Operador = '/' }); //Implemente o calculo de divisao
            Stack<Operacoes> filaResultadoOperacoes = new Stack<Operacoes>();


            Calculadora calculadora = new();

            
            
            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.Calcular(operacao);
                filaResultadoOperacoes.Push(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.ValorA, operacao.Operador, operacao.ValorB, operacao.Resultado);
                if (!filaOperacoes.Count.Equals(0))
                {
                    Console.WriteLine($"\nCalculos a serem processados:");
                    printEnumerables(filaOperacoes);
                }
            }
            Console.WriteLine($"\nCalculos feitos:");
            printEnumerables(filaResultadoOperacoes);



            Console.WriteLine();

            void printEnumerables(IEnumerable<Operacoes> enumerable)
            {
                foreach (Operacoes operacao in enumerable)
                {
                    Console.Write($"{operacao.ValorA} {operacao.Operador} {operacao.ValorB}");
                    if (!operacao.Resultado.Equals(0))
                        Console.Write($" = {operacao.Resultado}");
                    Console.WriteLine();
                        
                }
                Console.WriteLine();
            }

        }

      
    }
}
