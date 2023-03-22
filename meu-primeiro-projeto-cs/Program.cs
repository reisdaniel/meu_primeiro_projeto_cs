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
                double num1 = 0, num2 = 0;
                bool numValido = false;

                while (!numValido)
                {
                    Console.WriteLine("Digite o primeiro número: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
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
                    if (!double.TryParse(Console.ReadLine(), out num2))
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

                int escolha = 0;
                bool escolhaValida = false;

                while (!escolhaValida)
                {
                    Console.WriteLine("Opção escolhida: ");
                    if (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 4)
                    {
                        Console.WriteLine("Opção inválida. Por favor, escolha um número de 1 a 4.");
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
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero. Por favor, tente novamente.");
                        }
                        else
                        {
                            resultado = num1 / num2;
                        }
                        break;
                }

                if (escolha == 4 && num2 == 0) 
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
                        Console.WriteLine("Opção inválida. Por favor, digite S ou N.");
                    }
                }
            }
        }
    }
}
