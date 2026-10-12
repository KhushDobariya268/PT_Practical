using System;
using System.Collections.Generic;
using System.Text;

namespace PT_Practical
{

    // We use a constructor in an abstract class to initialize common variables that are shared by derived (child) classes.


    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog d = new Dog();
        }
    }
}
