using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1Q2;

namespace Lab1Qu2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmaticOperations Ar = new ArithmaticOperations();

            Console.Write("Enter a number: a");
            Ar.a = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter another number:b ");
            Ar.b = Convert.ToInt64(Console.ReadLine());

            Ar.c = Ar.add(Ar.a, Ar.b);
            Console.WriteLine("sum of " + Ar.a + " and " + Ar.b + " is " + Ar.c);
            Ar.c = Ar.sub(Ar.a,Ar.b);
            Console.WriteLine("sub of " + Ar.a + " and " + Ar.b + " is " + Ar.c);
            Ar.c = Ar.product(Ar.a, Ar.b);
            Console.WriteLine("product of " + Ar.a + " and " + Ar.b + " is " + Ar.c);
            Ar.c = Ar.divide(Ar.a, Ar.b);
            Console.WriteLine("div of " + Ar.a + " and " + Ar.b + " is " + Ar.c);
            Ar.c = Ar.modulo(Ar.a, Ar.b);
            Console.WriteLine("modulo of " + Ar.a + " and " + Ar.b + " is " + Ar.c);
            Console.ReadKey();
        }
    }
}
