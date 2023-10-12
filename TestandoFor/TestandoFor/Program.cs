using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("insira o numero inicial: ");
            num = int.Parse(Console.ReadLine());
            for (i = num; i <= 500; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}