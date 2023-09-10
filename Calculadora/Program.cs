using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Calculo> filaOperacoes = new Queue<Calculo>();
            filaOperacoes.Enqueue(new Calculo { ValorA = 2, ValorB = 3, Operador = '+' });
            filaOperacoes.Enqueue(new Calculo { ValorA = 14, ValorB = 8, Operador = '-' });
            filaOperacoes.Enqueue(new Calculo { ValorA = 5, ValorB = 6, Operador = '*' });
            filaOperacoes.Enqueue(new Calculo { ValorA = 2147483647, ValorB = 2, Operador = '+' });
            filaOperacoes.Enqueue(new Calculo { ValorA = 18, ValorB = 3, Operador = '/' }); //Implemente o calculo de divisao
            Stack<Calculo> filaResultadoOperacoes = new Stack<Calculo>();


            Calculadora calculadora = new();

            
            
            while (filaOperacoes.Count > 0)
            {
                Calculo operacao = filaOperacoes.Dequeue();
                calculadora.Calcular(operacao);
                filaResultadoOperacoes.Push(operacao);
                Console.WriteLine("{0} {1} {2} = {3}", operacao.ValorA, operacao.Operador, operacao.ValorB, operacao.Resultado);
                if (!filaOperacoes.Count.Equals(0))
                {
                    Console.WriteLine($"\nCalculos a serem processados:");
                    IterateQueue(filaOperacoes);
                }
            }
            Console.WriteLine($"\nCalculos feitos:");
            IterateQueue(filaResultadoOperacoes);



            Console.WriteLine();

            void IterateQueue(IEnumerable<Calculo> queue)
            {
                foreach (Calculo operacao in queue)
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
