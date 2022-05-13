using BancoBank.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Models
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; private set; }

        public FuncionarioAutenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario) 
        {
            Senha = senha;
        }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
