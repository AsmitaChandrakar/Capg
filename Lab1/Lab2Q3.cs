using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Q3
{
    class Program
    {
        static void Main()
        {
            string[] arr = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the name of city");
                arr[i] = Console.ReadLine();
            }

            foreach (string i in arr)
            {
                Console.WriteLine(i);

            }




            Console.ReadKey();
        }
    }
}