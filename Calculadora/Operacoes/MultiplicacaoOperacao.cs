using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operacoes
{
    internal class MultiplicacaoOperacao : IOperacao
    {
        public decimal Execute(long ValorA, long ValorB)
        {
            return ValorA * ValorB;
        }
    }
}
