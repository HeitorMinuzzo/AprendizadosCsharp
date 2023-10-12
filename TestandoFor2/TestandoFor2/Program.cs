using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, final, num;
            Console.WriteLine("insira o numero inicial: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o numero final: ");
            final = int.Parse(Console.ReadLine());
            Console.WriteLine("Sequência: ");
            for (i = num; i <= final; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}