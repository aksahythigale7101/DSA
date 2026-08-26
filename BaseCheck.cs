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



        private void CollageInfo()//stash method get and push
        {
            Console.WriteLine("Collage Name:");
            Console.WriteLine("Collage Phone:");
            Console.WriteLine("Collage Email:");
            Console.WriteLine("Collage Address:");


        }
        //one method in stash and use >git stash list< then show it




        public void HeadCheck()//reset
        {
            Console.WriteLine("This is akshay");
            Console.WriteLine("This is aditya");
            Console.WriteLine("This is  arnav");
            Console.WriteLine("This is aarav");

        }

        public void Headcheck1()// reset on github
        {
            Console.WriteLine("This is Hyndai car");
            Console.WriteLine("This is Honda car");
            Console.WriteLine("This is BMW car");
        }





        public void RevretFunctionS()
        {
            Console.WriteLine("I like apple");
            Console.WriteLine("I like Mango");

          
            Console.WriteLine("I like cherry");

        }

    }
}
