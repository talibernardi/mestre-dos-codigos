using NUnit.Framework;
using System;

namespace _1Utilitarios
{
    public class Tests
    {
        public double CalcularDesconto(double ValorVenda)
        {
            double ValorDesconto = 0.0;

            if (ValorVenda == 0 || ValorVenda < 0)
            {
                throw new ArgumentException("O Valor da venda não pode ser Zero ou Negativo");
            }
            else if (ValorVenda >= 1000 && ValorVenda < 2000)
            {
                //5% desconto
                ValorDesconto = ValorVenda - (ValorVenda * 0.05);
            }
            else if (ValorVenda >= 2000 && ValorVenda < 5000)
            {
                //10% desconto
                ValorDesconto = ValorVenda - (ValorVenda * 0.1);
            }
            else if (ValorVenda >= 5000 && ValorVenda < 20000)
            {
                //50% desconto
                ValorDesconto = ValorVenda - (ValorVenda * 0.5);
            }
            else
            {
                //Sem desconto
                ValorDesconto = ValorVenda - 0.0;
            }
            return ValorDesconto;
        }
    }
}