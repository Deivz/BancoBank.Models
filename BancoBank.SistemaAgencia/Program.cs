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
            Diretor diretor = new Diretor("Davi", "1010101010", 25000, "deivz");

            ParceiroComercial parceiro = new ParceiroComercial("Diretor do Bancovo", "20202020", "bancovo");

            SistemaInterno usarSistema = new SistemaInterno();

            usarSistema.Logar(parceiro, "bancovo");

            Console.ReadLine();
        }
    }
}
