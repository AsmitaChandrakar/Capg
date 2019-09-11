

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Lab1Q2
{
    public class ArithmaticOperations
    {
        public double a;
        public double b;
        public double c;

        public double add(double a,double b)
        {
            c = a + b;
            return c;
        }
        public double sub(double a ,double b)
        {
            if (a > b)
            {
                c = a - b;
                return c;
            }
            else
            {
                c = b - a;
                return c;
            }
        }
        public double product(double a ,double b)
        {
            c = a * b;
            return c;
        }
        public double divide(double a,double b)
        {
            c = a / b;
            return c;
        }
        public double modulo(double a ,double b)
        {
            c = a % b;
            return c;
        }



    }
}






