using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Models
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario, senha)
        {
        }
        
        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        protected internal override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
