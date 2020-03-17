using System;

namespace Calculadora
{
    class Subtracao : IOperacaoMatematica
    {
        public int Calcular(string primeiraParcela, string segundaParcela)
        {
            int primeiraParcelaConvertido = Convert.ToInt32(primeiraParcela);
            int segundaParcelaConvertido = Convert.ToInt32(segundaParcela);

            int resultado = primeiraParcelaConvertido - segundaParcelaConvertido;
            return resultado;
        }
    }
}
