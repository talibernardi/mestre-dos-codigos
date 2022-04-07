using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_12
{
    public abstract class ContaBancaria
    {
        public int NumeroDaConta { get; set; }
        public double Saldo { get; set; }

        protected ContaBancaria(int numeroDaConta, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
        }

        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);
    }
}
