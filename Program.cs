using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            do
            {
                Console.Write("Digite um valor positivo: ");
                a = int.Parse(Console.ReadLine());
            }
            while (a <= 0);
        }
    }
}
