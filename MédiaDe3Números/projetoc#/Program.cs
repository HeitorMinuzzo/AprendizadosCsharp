using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoc_
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            double media;
            Console.WriteLine("Insira o numero 1");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero 2");
            num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero 3");
            num3 = Double.Parse(Console.ReadLine());
            media = (num1 + num2 + num3) / 3;
            Console.WriteLine("A média é: " + media);
            Console.ReadKey();

        }
    }
}
