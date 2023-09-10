using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operacoes
{
    internal class DivisaoOperacao : IOperacao
    {
        public decimal Execute(long ValorA, long ValorB)
        {
            if (ValorB.Equals(0)) throw new ArgumentException("Impossivel dividir por 0");
            return ValorA / ValorB;
        }
    }
}
