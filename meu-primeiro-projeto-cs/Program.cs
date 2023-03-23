using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args) 
        {
            bool sair = false;

            while (!sair)
            {
                double primeiroNumero = 0, segundoNumero = 0;
                bool numValido = false;

                while (!numValido)
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    if (!double.TryParse(Console.ReadLine(), out primeiroNumero) || primeiroNumero < 0)
                    {
                        Console.WriteLine("Número inválido. Por favor, tente novamente.");
                    }
                    else
                    {
                        numValido = true;
                    }
                }

                numValido = false;

                while (!numValido)
                {
                    Console.WriteLine("Digite o segundo número: ");
                    if (!double.TryParse(Console.ReadLine(), out segundoNumero) || segundoNumero < 0)
                    {
                        Console.WriteLine("Número inválido. Por favor, tente novamente");
                    }
                    else
                    {
                        numValido = true;
                    }
                }

                Console.WriteLine("Escolha uma operação matemática:");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Exponenciação");
                Console.WriteLine("6. Radiciação");

                int escolha = 0;
                bool escolhaValida = false;

                while (!escolhaValida)
                {
                    Console.WriteLine("Opção escolhida: ");
                    if (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 6)
                    {
                        Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 6.");
                    }
                    else
                    {
                        escolhaValida = true;
                    }
                }

                double resultado = 0;

                switch (escolha)
                {
                    case 1:
                        resultado = primeiroNumero + segundoNumero;
                        break;
                    case 2:
                        resultado = primeiroNumero - segundoNumero;
                        break;
                    case 3:
                        resultado = primeiroNumero * segundoNumero;
                        break;
                    case 4:
                        if (segundoNumero == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero. Por favor, tente novamente.");
                        }
                        else
                        {
                            resultado = primeiroNumero / segundoNumero;
                        }
                        break;
                    case 5:
                        resultado = Math.Pow(primeiroNumero, segundoNumero);
                        break;
                    case 6:
                        if (segundoNumero == 0)
                        {
                            Console.WriteLine("Não é possível calcular a raiz quadrada de zero.");
                        }
                        else if (segundoNumero % 2 == 0 && primeiroNumero < 0) 
                        {
                            Console.WriteLine("Não é possível calcular a raiz quadrada par de um número negativo");
                        }
                        else
                        {
                            resultado = Math.Pow(primeiroNumero, 1.0 / segundoNumero);
                        }
                        break;
                }

                if (escolha == 4 && segundoNumero == 0) 
                {
                    //não faz nada
                }
                else
                {
                    Console.WriteLine("Resultado: " + resultado);
                }

                bool opcaoValida = false;

                while (!opcaoValida) 
                {
                    Console.WriteLine("Deseja realizar outra operação? (S/N): ");
                    string opcao = Console.ReadLine().ToUpper();

                    if (opcao == "N")
                    {
                        sair = true;
                        opcaoValida = true;
                    }
                    else if (opcao == "S") 
                    {
                        opcaoValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Por favor, digite S ou N");
                    }
                }
            }
        }
    }
}
