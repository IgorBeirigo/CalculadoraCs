using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculadora
{
    class Program
    {
        enum Menu { soma = 1, subtracao , multiplicacao, divisao, potencia, raiz, sair };

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
    }   
}
