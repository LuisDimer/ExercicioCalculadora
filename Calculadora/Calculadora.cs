using System;

namespace Calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número correspondente a operação");
            Console.WriteLine("Adição: 1");
            Console.WriteLine("Subtração: 2");
            Console.WriteLine("Multiplicação: 3");
            Console.WriteLine("Divisão: 4");

            string resposta = Console.ReadLine();


            if (resposta == "1")
            {
                Console.WriteLine("Adição");
                Console.WriteLine("Digite o primeiro valor");
                string primeiraParcela = Console.ReadLine();
                Console.WriteLine("Digite o segundo valor");
                string segundaParcela = Console.ReadLine();

                var soma = new Adicao();
                int resultado = soma.Calcular(primeiraParcela, segundaParcela);

                Console.WriteLine($"Resultado: {primeiraParcela} + {segundaParcela} = {resultado}");
            }

            if (resposta == "2")
            {
                Console.WriteLine("Subtração");
                Console.WriteLine("Digite o primeiro valor");
                string primeiraParcela = Console.ReadLine();
                Console.WriteLine("Digite o segundo valor");
                string segundaParcela = Console.ReadLine();

                var soma = new Subtracao();
                int resultado = soma.Calcular(primeiraParcela, segundaParcela);

                Console.WriteLine($"Resultado: {primeiraParcela} - {segundaParcela} = {resultado}");
            }

            if (resposta == "3")
            {
                Console.WriteLine("Multiplicação");
                Console.WriteLine("Digite o primeiro valor");
                string primeiraParcela = Console.ReadLine();
                Console.WriteLine("Digite o segundo valor");
                string segundaParcela = Console.ReadLine();

                var soma = new Multiplicacao();
                int resultado = soma.Calcular(primeiraParcela, segundaParcela);

                Console.WriteLine($"Resultado: {primeiraParcela} x {segundaParcela} = {resultado}");
            }

            if (resposta == "4")
            {
                Console.WriteLine("Divisão");
                Console.WriteLine("Digite o primeiro valor");
                string primeiraParcela = Console.ReadLine();
                Console.WriteLine("Digite o segundo valor");
                string segundaParcela = Console.ReadLine();

                var soma = new Divisao();
                int resultado = soma.Calcular(primeiraParcela, segundaParcela);

                Console.WriteLine($"Resultado: {primeiraParcela} / {segundaParcela} = {resultado}");
            }

                Console.WriteLine("Aperte ENTER para finalizar");
                Console.ReadLine();
        }
    }
}
