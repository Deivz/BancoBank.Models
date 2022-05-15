using BancoBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cliente1 = new Cliente("Davi", "15151515", 5050);
            var conta1 = new ContaCorrente(1515, cliente1);

            Console.WriteLine("Bem vindo, " + conta1.Cliente.Nome);
            Console.WriteLine("Sua conta foi criada na agência " + conta1.Cliente.Agencia);
            Console.WriteLine("O número de sua conta é " + conta1.NumeroConta);
            Console.WriteLine("Seu saldo atual é de: " + conta1.Saldo);

            Console.ReadLine();
        }
    }
}
