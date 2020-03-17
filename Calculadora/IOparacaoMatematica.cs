using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    interface IOperacaoMatematica
    {
        int Calcular(string primeiraParcela, string segundaParcela);
    }
}
