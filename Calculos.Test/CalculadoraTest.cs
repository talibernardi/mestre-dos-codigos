using NUCalculos;
using NUnit.Framework;

namespace Calculos.Test
{
    public class Tests
    {
        [TestFixture]
        public class CalculadoraTest
        {
            [Test]
            public void Soma_DeveRetornarOValorCorreto()
            {
                Calculadora calculadora = new Calculadora();
                var resultado = calculadora.Soma(10, 20);
                //Verifica se o resultado é igual a 30
                Assert.AreEqual(30, resultado);
            }
            [Test]
            public void Subtracao_DeveRetornarOValorCorreto()
            {
                Calculadora calculadora = new Calculadora();
                var resultado = calculadora.Subtracao(20, 10);
                //Verifica se o resultado é igual a 30
                Assert.AreEqual(10, resultado);
            }
        }
    }
}