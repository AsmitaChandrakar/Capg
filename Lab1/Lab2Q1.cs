﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Q1
{
    struct Qwerty
    {
        public int Number;

        public int Square(int n)
        {
            return n * n;
        }
        public int Cube(int n)
        {
            return n * n * n;
        }





    }
    class Program
    {
        static void Main()

        {
            Qwerty q = new Qwerty();
            Console.WriteLine("enter a no.");
            q.Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("square is " + q.Square(q.Number));
            Console.WriteLine("cube is " + q.Cube(q.Number));
            Console.ReadKey();





        }
    }
}