
using System;
using System.Collections.Generic;
using System.Text;

namespace PT_Practical
{
    delegate void MyDelegate(int x, int y); //Declaration

    class DelegateDemo_C
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public static void Multi(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public static void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public static void Main(string[] args)
        {
            MyDelegate obj = new MyDelegate(Add); //Instatiation
            obj += new MyDelegate(Sub);
            obj += Multi;
            obj += Div;
            // Add(15,5);
            obj(15, 5); //Invocation (calling Add,Sub,Multi,Div Methods )

            Console.Read();
        }
    }
}
