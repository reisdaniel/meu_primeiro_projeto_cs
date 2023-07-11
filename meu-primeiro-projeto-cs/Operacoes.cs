using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacoes
    {
        public static double Soma(double a, double b)
            return a + b;
        
        public static double Subtracao(double a, double b)
            return a - b;

        public static double Multiplicacao(double a, double b)
            return a * b;

        public static double Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return double.NaN;
            }
            else
                return a / b;
        }

        public static double Exponenciacao(double a, double b)
            return Math.Pow(a, b);

        public static double Radiciacao(double a, double b)
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
                return Math.Pow(a, 1.0 / b);
        }

        public static double Porcentagem(double a, double b)
            return a * b / 100;

        public static double Logaritmo(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Não é possível calcular o logaritmo de um número negativo.");
                return double.NaN;
            }
            else
                return Math.Log(a, b);
        }
    }
}
