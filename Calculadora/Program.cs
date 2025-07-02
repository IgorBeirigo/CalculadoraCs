using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculadora
{
    class Program
    {
        enum Menu { soma = 1, subtracao, multiplicacao, divisao, potencia, raiz, sair };

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) // enquanto o usuario não (!) escolher sair exiba o menu
            {
                Console.WriteLine("Seja bem vindo ao CALC, Selecione uma das opções:");
                Console.WriteLine("1-soma\n2-subtração\n3-multiplicação\n4-divisão\n5-potência\n6-raiz\n7-sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.soma:
                        Soma();
                        break;
                    case Menu.subtracao:
                        Sub();
                        break;
                    case Menu.divisao:
                        Div();
                        break;
                    case Menu.multiplicacao:
                        Mult();
                        break;
                    case Menu.potencia:
                        Pot();
                        break;
                    case Menu.raiz:
                        Raiz();
                        break;
                    case Menu.sair:
                        escolheuSair = true;
                        Console.WriteLine("Obrigado por usar o CALC!");
                        break;

                }

                Console.WriteLine(opcao);

                Console.Clear();


            }




        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros:");
            Console.Write("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de dois numeros:");
            Console.Write("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado da Subtração é: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois numeros:");
            Console.Write("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado da Divisão é: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("Multiplicação de dois numeros:");
            Console.Write("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado da Multiplicação é: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potencia de um numero:");
            Console.Write("Digite a Base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o Expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado da Potencia é: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um numero:");
            Console.Write("Digite o Numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado da Raiz é: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }
    }
}
