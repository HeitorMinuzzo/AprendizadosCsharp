using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaSubMultiEDivisão
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            double num1, num2, soma, sub, mult, div;
            Console.WriteLine("insira primeiro número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("insira segundo número");
            num2 = double.Parse(Console.ReadLine());
            soma = num1 + num2;
            sub = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            Console.WriteLine("insira 1 para soma, 2 para subtração, 3 para multiplicação e 4 para divisão");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.WriteLine("A soma é: " + soma);
            }
            else if (escolha == 2)
            {
                Console.WriteLine("A Subtração é: " + sub);
            }
            else if (escolha == 3)
            {
                Console.WriteLine("A Multiplicação é: " + mult);
            }
            else if (escolha == 4)
            {
                Console.WriteLine("A divisão é: " + div);
            }
            Console.ReadKey();
        }
    }
}