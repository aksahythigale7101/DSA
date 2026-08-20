using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Loop
    {

        internal static void swapnNumbers(byte num1, byte num2)
        {
            byte NUM1 = num1;
            byte NUM2 = num2;
            byte temp;
            temp = num1;
            NUM1 = NUM2;
            NUM2 = temp;
            Console.WriteLine("first Numbera---" + NUM1);
            Console.WriteLine("second Numbera---" + NUM2);
        }

        internal static void evenORodd(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("odd--" + i);
                }
            }
        }



        internal static void largestNumbers(byte a, byte b, byte c)
        {
            byte largest;

            if (a >= b && a >= c)
            {
                largest = a;
            }
            else if (b >= c && c >= a)
            {
                largest = b;
            }
            else
            {
                largest = c;
            }
            Console.WriteLine(largest);
        }


        internal static void numberCheck(int num)
        {
            if (num > 1)
            {
                Console.WriteLine("Number is Postive");
            }
            else if (num < -1)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }


        internal static void FactrioalNumbers(int num)
        {
            int tempFactriol = 1;
            for (int i = num; i > 0; i--)
            {
                tempFactriol *= i;
            }
            Console.WriteLine(tempFactriol);
        }


        internal static void MultiplcationTable(int num)
        {
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine(num * i);
            }
        }

        internal static void SumDigitNUmbers(int num)
        {
            int NUM = num;
            //int len = 0;
            //while (num > 0)
            //{
            //    num = num / 10;
            //    len++;

            //}
            //Console.WriteLine(len);
            int sum = 0;
            //for (int i = 0; i < len; i++)
            //{

            //    sum += NUM % 10;
            //    NUM = NUM / 10;

            //}

            //Console.WriteLine(sum);


            while (NUM > 0)
            {
                sum += NUM % 10;
                NUM = NUM / 10;
            }
            Console.WriteLine(sum);
        }


       static bool b;
        internal static void RevreseNumber(int num)
        {

            Console.Write(num + " ");
            num--;
            if (num == 0)
            {
                b = true;
            }
            if (!b)
                RevreseNumber(num);
        }



        internal static void NumberISpelidrom(int num)
        {
            string finalNum = num.ToString();

            string temp = "";

            int n;

            while (num > 0)
            {

                n = num % 10;
                temp += n.ToString();
                num = num / 10;

            }



            if (temp.Equals(finalNum))
            {
                Console.WriteLine("This Number is Pelidrome");
            }
            else
                Console.WriteLine("This Number is NOT Pelidrome");





            //int num = 121;
            //int temp = num;
            //int reverse = 0;

            //while (temp > 0)
            //{
            //    int remainder = temp % 10;
            //    reverse = (reverse * 10) + remainder;
            //    temp /= 10;
            //}

            //bool isPalindrome = (num == reverse);
            //Console.WriteLine($"Is palindrome? {isPalindrome}");

        }





        internal static void Fabnocciseries(int num)
        {
            int a = 0; int b = 1; int temp = 0;

            for (int i = 0; i < num; i++)
            {

                Console.Write(a + " ");

                temp = a + b;
                a = b;
                b = temp;
            }
        }



        internal static void PrimeNumbers(int num)
        {


            for (int i = 2; i < num; i++)
            {
                bool isPrime = true;

                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write(" " + i);
                }
            }
        }


        internal static void HigestCommonFactor(int num1, int num2)
        {
            int hcf = 1;


            for (int i = 1; i <= num1 && i <= num2; i++)
            {

                if (num1 % i == 0 && num2 % i == 0)
                {
                    hcf = i;
                }
            }

            Console.WriteLine(hcf);

            //approch 2
            while (num2 != 0)
            {
                int remainder = num1 % num2;
                num1 = num2;
                num2 = remainder;
            }
            Console.WriteLine("GCD = " + num1);

        }







        internal static void LCM(int num1, int num2)
        {

            int hcf = 0;

            int a = num1, b = num2;

            while (num2 != 0)
            {
                hcf = num1 % num2;

                num1 = num2;
                num2 = hcf;
            }
            int LCM = (a * b) / num1;


            Console.WriteLine("HCF--" + num1);
            Console.WriteLine("LCM--" + LCM);



        }
        internal static  void caluclatePower(int Base, int power)
        {

            int result = 1;
            while (power != 0)
            {
                result = result * Base;

                power--;
            }

            Console.WriteLine(result); ;


        }



        internal static void ResvrseString(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);
            }
        }


        internal static void stringPalidrom(string str)
        {
            char[] result = new char[str.Length];

            string tempString = str;

            bool ISpalindrom = false; ;
            int j = 0;
            for (int i = str.Length - 1; i >= 0; i--, j++)
            {
                result[j] = str[i];


            }





            for (int i = 0; i < result.Length; i++)
            {
                ISpalindrom = false;
                if (result[i].Equals(tempString[i]))
                {
                    ISpalindrom = true;
                    continue;



                }

            }

            if (ISpalindrom)
            {
                Console.WriteLine(str + "  ---- this string is palindrome");
            }
            else
                Console.WriteLine(str + "  ---- this string is NOT palindrome");
        }

        internal static void CountVovles(string str)
        {
            int vovles = 0;
            int constants = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (checkoveles(str[i]))
                    vovles++;
                else
                    constants++;
            }


            Console.WriteLine("Vovles-- " + vovles);
            Console.WriteLine("character-- " + constants);

        }

       static bool  checkoveles(char ch)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                return true;
            }

            return false;


        }

        internal static void countWORDS(string str)
        {
            string[] sperateStrings = str.Split(' ', ',', '!', '?', '.');

            Console.WriteLine(sperateStrings.Length);


        }



       static Dictionary<char, int> checkDict = new Dictionary<char, int>();
        public static void RemoveDuplicate(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {

                if (checkDict.ContainsKey(str[i]))
                {
                    checkDict[str[i]]++;
                }
                else
                {
                    checkDict.Add(str[i], 1);
                }
            }

            foreach (var item in checkDict)
            {
                //if (item.Value == 1)
                //{
                //    Console.Write("['" + item.Key + "', " + item.Value + "], ");
                //    //  break;////this break is used when   Find the first non-repeated character.
                //}
                //else
                //   Console.Write("['" + item.Key + "', " + item.Value + "], "); ;//Find duplicate characters in a string.


                Console.Write("['" + item.Key + "', " + item.Value + "], ");
            }
        }


        public static void StringAngrams()
        {
            char[] s1 = "geeks".ToCharArray();

            char[] s2 = "kseeg".ToCharArray();


            Array.Sort(s1);
            Array.Sort(s2);

            if (new string(s1) == (new string(s2)))
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
        }




        public static void Ocuurance_firstNonRepetch_duplicate_unquie()//  occurance or firstnonrepeatingchar or remove duplicate charcter or unique string
        {



            char[] s1 = "akshay".ToCharArray();

            bool IsUnique = false;

            int count = 0;

            for (int i = 0; i < s1.Length; i++)
            {

                if (s1[i] == ' ')   // Skip already counted characters
                    continue;

                count = 1;
                char ch = s1[i];

                for (int j = i + 1; j < s1.Length; j++)
                {
                    if (s1[j] == ch)
                    {
                        count++;
                        s1[j] = ' ';
                        IsUnique = true;
                    }
                }


                //Console.Write(ch);////remove duplicate this strings akshay----akshy


                // Console.WriteLine($"character:{ch}   count:{count}");////// ocuurance of this string  with count



                //if (count == 1)//////in this code get first NON repeat character.
                //{
                //    Console.WriteLine($"character:{ch}   count:{count}");
                //    break;
                //}
            }




            if (IsUnique)/////unique string code means dose not reapeat any character in this string
                Console.WriteLine(" Is Not Unique");
            else
                Console.WriteLine(" Is  Unique");


        }


        public static void permutations(string s1)
        {

            Permute(s1.ToCharArray(), 0);
        }





        internal static void Permute(char[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                Console.WriteLine(new string(arr));
                return;
            }



            for (int i = index; i < arr.Length; i++)
            {
                char temp = arr[index];
                arr[index] = arr[i];
                arr[i] = temp;

                Permute(arr, index + 1);


                temp = arr[index];
                arr[index] = arr[i];
                arr[i] = temp;

            }


        }



        public static void LongestSubstringWitoutRepeatChar()/////can't get this code   
        {
            string s = "AKSHAY"/*"abcabcbb"*/;

            int left = 0, start = 0, maxLength = 0;

            HashSet<char> seen = new HashSet<char>();

            for (int right = 0; right < s.Length; right++)
            {

                while (seen.Contains(s[right]))
                {
                    seen.Remove(s[left]);
                    left++;

                }

                seen.Add(s[right]);


                if (right - left + 1 > maxLength)
                {
                    maxLength = right - left + 1;
                    start = left;
                }
            }
            Console.WriteLine("String : " + s);
            Console.WriteLine("Longest Substring : " + s.Substring(start, maxLength));
            Console.WriteLine("Length : " + maxLength);


            // Console.WriteLine("AKSHAY".Substring(1,6-1));


        }





        public static void LongesCommonPrefix()
        {
            string[] arr = /*{ "apple", "application", "app" }*//* ["dog", "racecar", "car"];*/{ "flower", "flow", "flight" };


            string prefix = arr[0];


            for (int i = 1; i < arr.Length; i++)
            {
                while (!arr[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }

            Console.WriteLine(prefix);
        }



        public static void OneSTRrotaionToanother()////////string concate the check seuqunace using contains
        {
            string str1 = "water";

            string str2 = "wtear";


            if (!str1.Length.Equals(str2.Length)) return;

            string tempString = String.Concat(str1, str1);

            if (tempString.Contains(str2))
                Console.WriteLine("STRING IS MATCH");
            else
                Console.WriteLine("STRING IS NOT MATCH");

        }



        public static void compressString()
        {
            string str = "aabcccccaaa";//------------- o/p-- "a2b1c5a3"

            int count = 1;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {

                char ch = str[i];


                if (i < str.Length - 1 && ch == str[i + 1])
                {
                    count++;

                }
                else
                {
                    sb.Append(ch);
                    sb.Append(count);

                    count = 1;
                }


            }
            Console.WriteLine(sb.ToString());
        }

        public static void RevrseWord()
        {
            string str = "AKSHAY KAILAS THIGALE";

            string[] s1 = str.Split(" ");

            for (int i = s1.Length - 1; i >= 0; i--)
            {
                Console.Write(s1[i] + " ");
            }

        }


        ///////Check if two strings are one edit distance apart (insert/delete/replace).

        static bool OneEditAway(string s1, string s2)
        {
            if (Math.Abs(s1.Length - s2.Length) > 1)
                return false;

            int i = 0;
            int j = 0;
            int edit = 0;

            while (i < s1.Length && j < s2.Length)
            {
                if (s1[i] == s2[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    edit++;

                    if (edit > 1)
                        return false;

                    if (s1.Length > s2.Length)
                    {
                        print(s1[i]);
                        i++;      // Delete
                    }
                    else if (s2.Length > s1.Length)
                    {
                        print(s2[j]);
                        j++;      // Insert
                    }
                    else
                    {
                        print(s2[j]);
                        i++;      // Replace
                        j++;
                    }
                }
            }

            // Remaining character
            if (i < s1.Length || j < s2.Length)
                edit++;

            return edit <= 1;
        }

        public static void print(char ch)
        {
            Console.WriteLine(ch);
        }
        public static void DistanceAprt()
        {
            Console.WriteLine(OneEditAway("cat", "cut"));   // True repalce
            Console.WriteLine(OneEditAway("cat", "cart"));  // True  insert
            Console.WriteLine(OneEditAway("cart", "cat"));  // True  delete
            Console.WriteLine(OneEditAway("cat", "dog"));   // False retun
        }





        ////Implement IndexOf / string search (naive + KMP if they push for optimization).
        ///

        public static void IndexOfstring()
        {
            string str = "Hello World";   ////o/p-----"SHA"---2
            string pattern = "World";

            /*Console.WriteLine(str.IndexOf("a"))*/
            ;

            //char ch = 'n';
            //int idx = -1;
            //for (int i = 0; i < str.Length - 1; i++)
            //{
            //    if (ch == str[i])
            //    {
            //        idx = i;
            //        break;
            //    }

            //}

            //Console.WriteLine(idx);


            for (int i = 0; i <= str.Length - pattern.Length; i++)
            {
                int j;
                for (j = 0; j < pattern.Length; j++)
                {
                    if (str[i + j] != pattern[j])
                    {
                        break;
                    }

                }


                if (j == pattern.Length)
                {
                    Console.WriteLine(i);
                    return;
                }
            }








        }


        static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            // Closing bracket -> Opening bracket
            Dictionary<char, char> brackets = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

            foreach (char ch in str)
            {
                // Opening bracket
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                // Closing bracket
                else if (brackets.ContainsKey(ch))
                {
                    //if (stack.Count == 0)
                    //    return false;

                    //char top = stack.Pop();

                    //if (top != brackets[ch])
                    //    return false;


                    if (stack.Count == 0 || stack.Pop() != brackets[ch])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        public static void Brackets()
        {
            Console.WriteLine(IsBalanced("()"));       // True
            Console.WriteLine(IsBalanced("()[]{}"));   // True
            Console.WriteLine(IsBalanced("([{}])"));   // True
            Console.WriteLine(IsBalanced("(]"));       // False
            Console.WriteLine(IsBalanced("([)]"));     // False
        }


        public static void StringToInt()
        {

            string str = "524";

            int result = 0;
            foreach (char item in str)
            {
                int digit = item - '0';

                result = (result * 10) + digit;


            }


            Console.WriteLine(result);

        }




    }


}
