using System;

namespace Calculadora
{
    class Program
    {
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
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Exponenciação");
                Console.WriteLine("6. Radiciação");

                Console.Write("Opção escolhida: ");
                if (int.TryParse(Console.ReadLine(), out int escolha) && escolha >= 1 && escolha <= 6)
                {
                    return escolha;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 6.");
                }
            }
        }

        static double ExecutarOperacao(double primeiroNumero, double segundoNumero, int escolha)
        {
            switch (escolha)
            {
                case 1:
                    return primeiroNumero + segundoNumero;
                case 2:
                    return primeiroNumero - segundoNumero;
                case 3:
                    return primeiroNumero * segundoNumero;
                case 4:
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero. Por favor, tente novamente.");
                        return double.NaN;
                    }
                    else
                    {
                        return primeiroNumero / segundoNumero;
                    }
                case 5:
                    return Math.Pow(primeiroNumero, segundoNumero);
                case 6:
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possível calcular a raiz quadrada de zero.");
                        return double.NaN;
                    }
                    else if (segundoNumero % 2 == 0 && primeiroNumero < 0)
                    {
                        Console.WriteLine("Não é possível calcular a raiz quadrada par de um número negativo");
                        return double.NaN;
                    }
                    else
                    {
                        return Math.Pow(primeiroNumero, 1.0 / segundoNumero);
                    }
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