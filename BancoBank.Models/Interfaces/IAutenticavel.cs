﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBank.Models
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
