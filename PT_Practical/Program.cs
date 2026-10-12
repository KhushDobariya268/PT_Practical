
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PT_Practical
{


    //    abstract
    //   highlight imprtant features
    //   abstract keyword with class and method
    //  you can not create an object of abstract class
    //  you can put abstract methods and non-abstract methods,
    //  data members constructors within abstract class
    //  it is compulsory for all sub classes to implement
    //  abstract methods of its parent class
    //  all the abstract method are by default vitual

    // Abstract Class
    abstract class Emp
    {
        public string Name { get; set; }
        private int age;
        public string Dept { get; set; }
        private double Salary;

        // Constructor
        public Emp()
        {
            Console.WriteLine("Emp Constructor Called");
        }

        // Getter and Setter for Salary
        public double getSalary()
        {
            return Salary;
        }

        // Setter for Salary
        public void setSalary(double Salary)
        {
            this.Salary = Salary;
        }

        // Getter and Setter for Age
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18)
                    age = value;
                else
                    age = 0;
            }
        }

        // Abstract Method

        public virtual void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Dept);
            Console.WriteLine("Salary: " + Salary);
        }

        // Abstract Method
        public abstract void check();
    }

    // interface 
    // what a class must do but not how it does
    // it declares only abstract methods 
    // all mehtod in interface are
    // by default public and abstract

    interface ITest
    {
      // static int temp;

        void Testing();// abstract method

        //void Testing2()
        //{

        //}
    }

    interface ICalc
    {
        void CalculateSalary();

    }


    // Derived Class
    class RegularEmployee : Emp ,ITest, ICalc
    {
       public void Testing() 
        { 
        
        }

        public void CalculateSalary()
        {
            GrossSalary = Basic + HRA + DA;
            NetSalary  = GrossSalary - PF + PT;

        }

        private double Basic;
        private double HRA;
        private double DA;
        private double PF;
        private double PT;
        private double GrossSalary;

        private double NetSalary;

        // Constructor
        public RegularEmployee()
        {
            Console.WriteLine("RegularEmployee Constructor Called");
        }

        // abstract method implementation
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Basic: " + Basic);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("PF: " + PF);
            Console.WriteLine("PT: " + PT);
        }

        // abstract method implementation
        public override void check()
        {
            Console.WriteLine("Check method of RegularEmployee class");
        }

        // Non-abstract method

        public void Test()
        {
            Console.WriteLine("Test method of RegularEmployee class");
        }

        // Method to calculate salary components

        public static void Main(string[] args)
        {

            // Creating an object of RegularEmployee class
            RegularEmployee e1 = new RegularEmployee();

            e1.Name = "Khush";
            e1.Age = 20;
            e1.Dept = "CE";
            e1.setSalary(100000);

            e1.Display();
            e1.check();
            e1.Test();

            Console.WriteLine("================");

            Emp e2 = new RegularEmployee();

            e2.Name = "Viraj";
            e2.Age = 20;
            e2.Dept = "IT";
            e2.setSalary(50000);

            e2.Display();
            e2.check();

            Console.Read();
        }
    }
}
