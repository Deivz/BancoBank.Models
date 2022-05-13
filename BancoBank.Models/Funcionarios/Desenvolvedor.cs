using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Models
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        protected internal override double GetBonificacao()
        {
            return Salario * 0.15;
        }
    }
}
