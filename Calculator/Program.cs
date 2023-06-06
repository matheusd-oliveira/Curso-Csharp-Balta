using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo a Calculator. O que deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma(10, 20, 30);
                    break;
                case 2:
                    Subtracao(10, 50, 25);
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao(10, 2, 10);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Soma(params float[] list)
        {
            Console.Clear();

            float resultado = list.Sum();

            Console.WriteLine("O resultado da soma é " + resultado);
            Console.ReadKey();
            Menu();

        }

        static void Subtracao(params float[] list)
        {
            Console.Clear();

            Console.WriteLine("");

            float resultado = 0;
            foreach (var num in list)
            {
                resultado -= num;
                if (resultado < 0)
                {
                    resultado = -resultado;
                }
            }

            Console.WriteLine("O resultado da subtração é " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(params int[] list)
        {
            Console.Clear();



            Console.WriteLine("");

            int resultado = 1;

            foreach (var num in list)
            {
                resultado *= num;
            }
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }

    }
}

// v1.0 : perguntava dois numeros para o usuario
// v2.0 : atual - o usuario passa a quantidade de números que ele quiser por parametro nas funções de Soma, Subtração e Multiplicação.