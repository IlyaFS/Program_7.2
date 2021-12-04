using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;


            CalcS(a, out S, out V);
            Console.WriteLine();
            Console.WriteLine("Площадь повержности куба: {0}", S);
            Console.WriteLine("Объем куба: {0}", V);
            Console.ReadKey();
        }
        static void CalcS(int a, out double S, out double V)
        {
            S = 6 * Math.Pow(a, 2);
            V = Math.Pow(a, 3);
        }

    }
}
