using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3, j = 4;
            Console.WriteLine("Product right move:");
            var a = Task1.RightMove(i, j);
            Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine("\n\n2 ============================================" +
                "\n================================================\n\n");
            (string def, long remainder, int quotient) = Task2.Devide(22, 6);
            Console.WriteLine($"Remeinder: {remainder}\nQuotient: {quotient}\n{def}");

            Console.WriteLine("\n\n3 ============================================" +
            "\n================================================\n\n");

            float a1 = 3.5f, b1 = 1f;
            Console.WriteLine("Floating number addition:");
            var (def3, bin, result) = Task3.Add(a1, b1);
            Console.WriteLine(def3);
            Console.WriteLine($"answ : {bin} = {result}");
        }
    }
}