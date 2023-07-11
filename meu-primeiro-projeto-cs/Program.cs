using System;
using Calculadora;

namespace Calculadora
{
    class Program
    {
        const int SOMA = 1;
        const int SUBTRACAO = 2;
        const int MULTIPLICACAO = 3;
        const int DIVISAO = 4;
        const int EXPONENCIACAO = 5;
        const int RADICIACAO = 6;
        const int PORCENTAGEM = 7;
        const int LOGARITMO = 8;

        static void Main(string[] args)
        {
            while (true)
            {
                double primeiroNumero = ObterNumero("Digite o primeiro número: ");
                double segundoNumero = ObterNumero("Digite o segundo número: ");

                int escolha = ObterEscolhaOperacao();

                double resultado = ExecutarOperacao(primeiroNumero, segundoNumero, escolha);

                if (!double.IsNaN(resultado))
                    Console.WriteLine($"Resultado: {resultado}");

                if (!Continuar())
                    break;
            }
        }

        static double ObterNumero(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                if (double.TryParse(Console.ReadLine(), out double numero) && numero >= 0)
                    return numero;
                else
                    Console.WriteLine("Número inválido. Por favor, tente novamente.");
            }
        }

        static int ObterEscolhaOperacao()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma operação matemática:");
                Console.WriteLine($"{SOMA}. Soma");
                Console.WriteLine($"{SUBTRACAO}. Subtração");
                Console.WriteLine($"{MULTIPLICACAO}. Multiplicação");
                Console.WriteLine($"{DIVISAO}. Divisão");
                Console.WriteLine($"{EXPONENCIACAO}. Exponenciação");
                Console.WriteLine($"{RADICIACAO}. Radiciação");
                Console.WriteLine($"{PORCENTAGEM}. Porcentagem");
                Console.WriteLine($"{LOGARITMO}. Logaritmo");

                Console.Write("Opção escolhida: ");
                if (int.TryParse(Console.ReadLine(), out int escolha) && escolha >= 1 && escolha <= 8)
                    return escolha;
                else
                    Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 8.");
            }
        }

        static double ExecutarOperacao(double primeiroNumero, double segundoNumero, int escolha)
        {
            switch (escolha)
            {
                case SOMA:
                    return Operacoes.Soma(primeiroNumero,segundoNumero);
                case SUBTRACAO:
                    return Operacoes.Subtracao(primeiroNumero,segundoNumero);
                case MULTIPLICACAO:
                    return Operacoes.Multiplicacao(primeiroNumero,segundoNumero);
                case DIVISAO:
                    return Operacoes.Divisao(primeiroNumero,segundoNumero);
                case EXPONENCIACAO:
                    return Operacoes.Exponenciacao(primeiroNumero,segundoNumero);
                case RADICIACAO:
                    return Operacoes.Radiciacao(primeiroNumero, segundoNumero);
                case PORCENTAGEM:
                    return Operacoes.Porcentagem(primeiroNumero, segundoNumero) ;
                case LOGARITMO:
                    return Operacoes.Logaritmo(primeiroNumero, segundoNumero);
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 6.");
                    return double.NaN;
            }
        }

        static bool Continuar()
        {
            while (true)
            {
                Console.Write("Deseja realizar outra operação? (S/N): ");
                string opcao = Console.ReadLine().ToUpper();
                if (opcao == "S")
                    return true;
                else if (opcao == "N")
                    return false;
            }
        }
    }
}
