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
                Saldo += valor;
                Console.WriteLine();
                Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
                Console.WriteLine($"Seu saldo atual é: R${Saldo}");
                return Saldo;
            }
            Console.WriteLine();
            Console.WriteLine("Não é possível depositar valores menores ou igual a R$0,00!");
            return Saldo;
        }

        public override double Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine();
                Console.WriteLine("Saldo insuficiente!");
                return Saldo;
            }
            Saldo -= valor;
            Console.WriteLine();
            Console.WriteLine($"Foi sacado um valor de R${valor}. Seu saldo agora é R${Saldo}");
            return Saldo;
        }

        public override double Transferir(double valor, Conta conta)
        {
            if (valor > Saldo)
            {
                Console.WriteLine();
                Console.WriteLine("Saldo insuficiente!");
                return Saldo;
            }
            Sacar(valor);
            conta.Depositar(valor);
            Console.WriteLine();
            Console.WriteLine($"Foi transferido um valor de R${valor} para a conta {conta.NumeroConta} do titular {conta.Cliente.Nome}. Seu saldo agora é R${Saldo}");
            return Saldo;
        }
    }
}
