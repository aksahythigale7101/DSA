using System;

namespace DSA
{
    internal class BaseCheck
    {

        public void Show()
        {
            Console.WriteLine("BaseCheck Show method called.");

            Console.WriteLine("this show method is from BaseCheck");

        }


        public void Display()
        {
            Console.WriteLine("This is akshay kailas thigale");
        }
        public void Method()
        {
            Console.WriteLine("This is method calling function");
        }


        public void Add()
        {
            int c = 10 + 20;
            Console.WriteLine("This is additon program" + c);
        }

        public void Subtraction()
        {
            int c = 20 - 10;
            Console.WriteLine("This is substraction program " + c);
        }

        public void Multiplication()
        {
            int c = 10 * 20;
            Console.WriteLine($"This is multiplication program {c}");
        }

        private void StudenInfo()
        {
            Console.WriteLine("Studen Name:");
            Console.WriteLine("Studen Age:");
            Console.WriteLine("Studen Phone:");
            Console.WriteLine("Studen Email:");
            Console.WriteLine("Studen Blodgroup:");
        }


        //one method in stash and use >git stash list< then show it




        public void HeadCheck()//reset
        {
            Console.WriteLine("This is akshay");
            Console.WriteLine("This is aditya");
            Console.WriteLine("This is  arnav");
            Console.WriteLine("This is aarav");

        }
        
        public void Headcheck1()// revret
        {
            Console.WriteLine("This is Hyndai car");
            Console.WriteLine("This is Honda car");
            Console.WriteLine("This is BMW car");
        }


    }
}
