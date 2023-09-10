using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes Calcular(Operacoes operacao)
        {
            switch(operacao.Operador)
            {
                case '+': operacao.Resultado= Soma(operacao);break;
                case '-': operacao.Resultado = Subtracao(operacao);break;
                case '*': operacao.Resultado = Multiplicacao(operacao);break;
                case '/': operacao.Resultado = Divisao(operacao); break;
                default: operacao.Resultado = 0; break;
            }
            return operacao;
        }
        public long Soma(Operacoes operacao)
        {
            return operacao.ValorA + operacao.ValorB;
        }
        public long Subtracao(Operacoes operacao)
        {
            return operacao.ValorA - operacao.ValorB;
        }
        public long Multiplicacao(Operacoes operacao)
        {
            return operacao.ValorA * operacao.ValorB;
        }
        public long Divisao(Operacoes operacao)
        {
            return operacao.ValorA / operacao.ValorB;
        }

    }
}
