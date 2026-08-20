using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Pattern
    {

        public static void SAQUAREPATTERN()
        {

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {

                    Console.Write("*");

                }
                Console.Write("\n");
            }
        }


        public static void RIGHTTRANINGLE()
        {

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.Write("\n");

            }



        }


        public static void INVERTEDTRAINGLE()
        {
            for (int i = 5; i >= 0; i--)
            {

                for (int j = 0; j <= i; j++)
                {

                    Console.Write("*");
                }
                Console.Write("\n");
            }


        }



        public static void NUMBERTRAINGLE()
        {
            for (int i = 1; i < 10; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                }
                Console.Write("\n");

            }
        }


        public static void SAMENUMBERTRAINGLE()
        {
            for (int i = 1; i < 10; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);

                }
                Console.Write("\n");

            }
        }


        public static void FLOYDSTRINGLE()
        {
            int count = 1;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;

                }
                Console.Write("\n");

            }
        }


        public static void ALPHABETTRAINGLE()
        {
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Convert.ToChar(65 + j) + " ");

                }
                Console.Write("\n");

            }

        }


        public static void REVERSENUMBERTRAINGLE()
        {
            for (int i = 10; i >= 0; i--)
            {

                for (int j = 1; j <= i; j++)
                {

                    Console.Write(j + " ");
                }
                Console.Write("\n");
            }

        }


        public static void PYRAMID()
        {
            for (int i = 1; i < 6; i++)
            {

                for (int j = 0; j < 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {

                    Console.Write("*");

                }
                Console.Write("\n");

            }
        }



        public static void INVERTEDPYRMID()
        {
            for (int i = 6; i > 0; i--)
            {
                for (int j = 0; j < 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");

                }
                Console.Write("\n");

            }
        }






        public static void DIMOND()
        {
            PYRAMID();
            INVERTEDPYRMID();
        }



        public static void HOLLOWSQUARE()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (i == 0 || i == 5 || j == 0 || j == 5)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }


        public static void HOLOWTRAINGLE()
        {

            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (i == 5 || j == 0 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }

        }

        public static void HOLLOWPYRMID()
        {
            for (int i = 1; i < 6; i++)
            {

                for (int j = 0; j < 6 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i - 1); k++)
                {
                    if (k == 0 || k == (2 * i - 1) - 1 || i == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.Write("\n");

            }

        }





        public static void BUTTERFLYPATTERN()
        {


            /// right traingle and left tranigle code merge it
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }

                for (int s = 0; s < 9 - (i * 2); s++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            //step2
            for (int i = 5; i >= 0; i--)
            {

                for (int j = 0; j <= i; j++)
                {

                    Console.Write("*");
                }

                for (int j = 0; j < 10 - i * 2 - 1; j++)
                {
                    Console.Write(" ");

                }

                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");


            }

        }





        public static void CROSS()
        {
            int size = 5;   // Use an odd number

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == i || j == size - i - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }



        public static void CROESSPATTERN()
        {
            int row = 5;

            int mid = row / 2;


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (mid == i || j == row - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

        }


        public static void ZEROPATTERN()
        {
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write((i + j) % 2 == 0 ? "1 " : "0 ");

                }
                Console.Write("\n");

            }
        }

        public static void DECSENGINNUMBERPATTERN()
        {
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(6 - j + " ");

                }
                Console.Write("\n");

            }
        }

        public static void CHARPATERN()
        {
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(Convert.ToChar(i + 64) + " ");

                }
                Console.Write("\n");

            }
        }

    }
}
