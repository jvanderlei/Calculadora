using Calculadora.Interfaces;
using Calculadora.Operacoes;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    public class Calculadora
    {

        public void Calcular(Calculo calculo)
        {
            if(operadores.TryGetValue(calculo.Operador, out IOperacao operacao)){
                calculo.Resultado = operacao.Execute(calculo.ValorA, calculo.ValorB);
            } 
        }


        Dictionary<Char, IOperacao> operadores = new Dictionary<Char, IOperacao>
        {
            {'+', new SomaOperacao() },
            {'-', new SubtracaoOperacao() },
            {'*', new MultiplicacaoOperacao() },
            {'/', new DivisaoOperacao() }
        };

    }
}
