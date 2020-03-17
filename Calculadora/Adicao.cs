using System;

namespace Calculadora
{
    class Adicao : IOperacaoMatematica
    {
        public int Calcular(string primeiraParcela, string segundaParcela)
        {
            int primeiraParcelaConvertido = Convert.ToInt32(primeiraParcela);
            int segundaParcelaConvertido = Convert.ToInt32(segundaParcela);

            int resultado = primeiraParcelaConvertido + segundaParcelaConvertido;
            return resultado;
        }
    }
}
