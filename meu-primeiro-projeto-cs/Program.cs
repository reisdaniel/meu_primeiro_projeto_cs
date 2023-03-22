using System;

namespace meu_primeiro_projeto_cs
{
    class Operacoes_matematicas
    {
        static void Main(string[] args) 
        {
            while (true)
            {
                Console.WriteLine("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Escolha uma operação matemática:");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");

                int escolha = int.Parse(Console.ReadLine());

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
                        resultado = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Resultado: " +  resultado);

                Console.WriteLine("Deseja realizar outra operação? (S/N)");
                string opcao = Console.ReadLine();

                if (opcao.ToUpper() == "N")
                {
                    break;
                }
            }
        }
    }
}
