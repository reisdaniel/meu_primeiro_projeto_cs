using System;

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
                {
                    Console.WriteLine($"Resultado: {resultado}");
                }

                if (!Continuar())
                {
                    break;
                }
            }
        }

        static double ObterNumero(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                if (double.TryParse(Console.ReadLine(), out double numero) && numero >= 0)
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Número inválido. Por favor, tente novamente.");
                }
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
                {
                    return escolha;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 8.");
                }
            }
        }

        static double Soma(double a, double b)
        {
            return a + b;
        }

        static double Subtracao(double a, double b)
        {
            return a - b;
        }

        static double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        static double Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return double.NaN;
            }
            else
            {
                return a / b;
            }
        }

        static double Exponenciacao(double a, double b)
        {
            return Math.Pow(a, b);
        }

        static double Radiciacao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada de zero.");
                return double.NaN;
            }
            else if (b % 2 == 0 && a < 0)
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada par de um número negativo.");
                return double.NaN;
            }
            else
            {
                return Math.Pow(a, 1.0 / b);
            }
        }

        static double Porcentagem(double a, double b)
        {
            return a * b / 100;
        }

        static double Logaritmo(double a, double b)
        {
            if (a <= 0 ||  b <= 0)
            {
                Console.WriteLine("Não é possível calcular o logaritmo de um número negativo.");
                return double.NaN;
            }
            else
            {
                return Math.Log(a, b);
            }
        }

        static double ExecutarOperacao(double primeiroNumero, double segundoNumero, int escolha)
        {
            switch (escolha)
            {
                case SOMA:
                    return Soma(primeiroNumero,segundoNumero);
                case SUBTRACAO:
                    return Subtracao(primeiroNumero,segundoNumero);
                case MULTIPLICACAO:
                    return Multiplicacao(primeiroNumero,segundoNumero);
                case DIVISAO:
                    return Divisao(primeiroNumero,segundoNumero);
                case EXPONENCIACAO:
                    return Exponenciacao(primeiroNumero,segundoNumero);
                case RADICIACAO:
                    return Radiciacao(primeiroNumero, segundoNumero);
                case PORCENTAGEM:
                    return Porcentagem(primeiroNumero, segundoNumero) ;
                case LOGARITMO:
                    return Logaritmo(primeiroNumero, segundoNumero);
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
                {
                    return true;
                }
                else if (opcao == "N")
                {
                    return false;
                }
            }
        }
    }
}