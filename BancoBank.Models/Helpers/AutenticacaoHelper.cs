using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Models.Helpers
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaDigitada)
        {
            return senhaVerdadeira == senhaDigitada;
        }
    }
}
