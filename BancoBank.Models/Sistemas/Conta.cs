using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Models
{
    public abstract class Conta
    {
        public int NumeroConta { get; set; }

        public double Saldo { get; protected set; }

        public Cliente Cliente { get; protected set; }

        public Conta(int numeroConta, Cliente cliente)
        {
            NumeroConta = numeroConta;
            Cliente = cliente;

            Saldo = 0;
        }

        public abstract double Depositar(double valor);

    }
}
