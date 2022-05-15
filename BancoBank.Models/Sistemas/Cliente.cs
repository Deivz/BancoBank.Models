using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }   
        public int Agencia { get; set; }
        public Cliente(string nome, string cpf, int agencia)
        {
            Nome = nome;
            CPF = cpf;
            Agencia = agencia;
        }
    }
}
