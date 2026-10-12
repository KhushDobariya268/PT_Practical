using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PT_Practical
{
    class ContainerClass
    {
        public static void Main(string[] args)
        {
            //Creating an object of collection
            ArrayList obj = new ArrayList();
            //Adding elements into a collection
            obj.Add("RKU");
            obj.Add(121);
            obj.Add(123.88);
            obj.Add('x');
            obj.Add(true);
            //Fetching the no. of elements into a collection
            Console.WriteLine("Number of Elements:" + obj.Count);
            //Removing an element by value from a collection
            obj.Remove("RKU");
            //Traversing a collection element by element
            foreach (object str in obj)//Object
                Console.WriteLine(str + " ");
            Console.ReadKey();
        }
    }
}
