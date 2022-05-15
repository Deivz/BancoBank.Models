using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Models
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numeroConta, Cliente cliente) : base(numeroConta, cliente)
        {
        }

        public override double Depositar(double valor)
        {
            if (valor > 0)
            {
                return Saldo = valor;
            }
            Console.WriteLine("Não é possível depositar valores menores ou igual a 0!");
            return Saldo;
        }
    }
}
