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
            Console.WriteLine("Seja bem vindo ao CALC, Selecione uma das opções:");
            Console.WriteLine("1-soma\n2-subtração\n3-multiplicação\n4-divisão\n5-potência\n6-raiz\n7-sair");

            Menu opcao = (Menu)int.Parse(Console.ReadLine());

            Console.WriteLine(opcao);



            Console.ReadLine();
        }
    }
}
