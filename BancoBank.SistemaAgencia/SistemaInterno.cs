using BancoBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.SistemaAgencia
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Você está logado!");
                return true;
            }

            Console.WriteLine("Senha inválida!");
            return false;
        }
    }
}
