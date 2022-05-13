using BancoBank.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Models
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Nome { get; private set; }

        public string CPF { get; }

        public string Senha { get; private set; }

        public ParceiroComercial(string nome, string cpf, string senha)
        {
            Nome = nome;
            CPF = cpf;
            Senha = senha;
        }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
