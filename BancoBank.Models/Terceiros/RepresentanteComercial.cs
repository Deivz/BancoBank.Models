using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Modelos.Terceiros
{
    internal class RepresentanteComercial
    {
        public string Nome { get; private set; }

        public string CPF { get; set; }

        public string Senha { get; set; }

        public RepresentanteComercial(string nome, string cpf, string senha)
        {
            Nome = nome;
            CPF = cpf;
            Senha = senha;
        }
    }
}
