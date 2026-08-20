using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class TwoPointer
    {
        // The two-pointer square algorithm works only when the input array is sorted:
        public static void CheckPalindrom()
        {
            //string str = "APPLE";
            string str = "LEVEL";

            int left = 0;
            int right = str.Length - 1;


            while (left < right)
            {
                if (str[left] != str[right])
                {
                    Console.WriteLine(str + " String is NOT Palindrome");


                    return;
                }

                left++;
                right--;

            }
            Console.WriteLine(str + " String is  Palindrome");
        }



        public static void revString()
        {

            char[] str = "ABCD".ToCharArray();

            int left = 0;
            int right = str.Length - 1;
            //Approch 1-------------------------Time--o(n) space o(1)


            //while (0 <= right)
            //{

            //    Console.WriteLine(str + " String is  Revrse--" + str[right]);
            //    right--;
            //}


            //Approch 2-------------------------Time--o(n) space o(1)

            while (left < right)
            {
                (str[left], str[right]) = (str[right], str[left]);
                left++; right--;
            }
            Console.WriteLine(" String is  Revrse--" + new string(str));
        }





        public static void SQUAREFSORTARRAY()
        {
            int[] arr = { -4, -1, 0, 3, 10 };
            int[] result = new int[arr.Length];
            Print(true, arr);
            int left = 0;
            int right = arr.Length - 1;
            int index = arr.Length - 1;
            while (left < right)
            {

                int leftsqure = arr[left] * arr[left];
                int rightsqure = arr[right] * arr[right];

                if (leftsqure > rightsqure)
                {
                    result[index] = leftsqure;
                    left++;

                }
                else
                {
                    result[index] = rightsqure;
                    right--;
                }

                index--;
            }


            Print(!true, result);
        }


        public static void PelindromeII()
        {
            string str = "radxar";

            int left = 0;
            int right = str.Length - 1;


            while (left < right)
            {
                if (str[left] != str[right])
                {

                    Console.WriteLine(IsPelindrome(str, left + 1, right) || IsPelindrome(str, left, right - 1));
                    return;
                }

                left++; right--;

            }
            Console.WriteLine(true);
            return;
        }



        public static bool IsPelindrome(string str, int left, int right)
        {
            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
            }
            left++;
            right--;

            return true;
        }



        public static void removeDuplicates()
        {
            int[] arr = [1, 1, 2, 2, 3, 4, 4, 5]; //output----1,2,3,4,5


            int slow = 0;

            for (int fast = 1; fast < arr.Length; fast++)
            {


                if (arr[slow] != arr[fast])
                {
                    slow++;
                    arr[slow] = arr[fast];
                }

            }

            for (int i = 0; i < slow + 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void removeElement()
        {
            int[] arr = [1, 2, 3, 4, 5];

            int element = 3;
            int slow = 0;

            for (int fast = 0; fast < arr.Length; fast++)
            {
                if (arr[fast] != element)
                {

                    arr[slow] = arr[fast];

                    slow++;
                }


            }

            for (int i = 0; i < slow; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }



        public static void ZeroAtLast()
        {
            int[] arr = [0, 1, 0, 3, 12];//op 1 3 12 0 0
            int slow = 0;

            for (int fast = 0; fast < arr.Length; fast++)
            {
                if (arr[fast] != 0)
                {
                    (arr[slow], arr[fast]) = (arr[fast], arr[slow]);
                    slow++;
                }

            }

            Print(!true, arr);
        }



        public static void MergerSortArray()
        {
            int[] arr1 = { 1, 3, 5, 0, 0, 0 };
            int[] arr2 = { 2, 4, 6 };



            int i = 2;//given this
            int j = 2;//given this
            int k = arr1.Length - 1;


            while (0 < k)
            {

                if (arr1[i] > arr2[j])
                {
                    arr1[k] = arr1[i];
                    i--;
                    k--;

                }
                if (arr2[i] > arr1[j])
                {
                    arr1[k] = arr2[i];
                    j--;
                    k--;

                }

            }
            Print(!true, arr1);
        }


        public static void Two_Sum_II()
        {
            int[] arr = [2, 7, 11, 15];
            int target = 9;

            int left = 0;
            int right = arr.Length - 1;

            int sum = 0;
            while (left < right)
            {
                sum = arr[left] + arr[right];
                if (sum == target)
                {
                    Console.WriteLine("Index Fount " + left + "," + right);
                    return;
                }
                else if (sum > target)
                    right--;
                else if (sum < target)
                    left++;
            }
        }

        public static void Container_With_Most_Water()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            int left = 0;
            int right = height.Length - 1;
            int MaxArea = 0;

            while (left < right)// Need two ends
            {
                int width = right - left;//Need Width

                int _height = Math.Min(height[left], height[right]);//Need Height

                int Area = width * _height;//Need Area

                if (Area > MaxArea)
                    MaxArea = Area;//Need Maximum

                if (height[left] < height[right])
                {
                    left++;//Move Smaller Height
                }
                else
                    right--; //larger Smaller Height
            }
            Console.WriteLine("Maximum Area:" + MaxArea);
        }







        public static void Trapping_Rain_Water()
        {
            int[] height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];


            int leftmax = 0;
            int rightmax = 0;
            int water = 0;


            int left = 0, right = height.Length - 1;


            while (left < right)
            {
                if (height[left] < height[right])////डावीकडे सर्वात उंच भिंत किती?
                {
                    if (height[left] >= leftmax)//यातील लहान भिंत किती?
                    {
                        leftmax = height[left];
                    }
                    else
                    {
                        water += leftmax - height[left];//त्यातून वर्तमान इमारतीची उंची वजा करा
                    }
                    left++;
                }

                else
                {
                    if (height[right] >= rightmax)////उजवीकडे सर्वात उंच भिंत किती?
                    {
                        rightmax = height[right]; //यातील लहान भिंत किती?
                    }
                    else
                    {
                        water += rightmax - height[right];//त्यातून वर्तमान इमारतीची उंची वजा करा.
                    }
                    right--;
                }
            }
            Console.WriteLine("Total Trapped Water: " + water);
        }


        public static void _3Sum()
        {
            int[] arr = { -1, 0, 1, 2, -1, -4 };//[-1,-1,2] [-1,0,1]


            Array.Sort(arr);

            int sum = 0;
            int left = 0;
            int right = arr.Length - 1;


            List<string> LIST3SUM = new List<string>();

            for (int i = 0; i < arr.Length - 1; i++)
            {

                left = i + 1;

                while (left < right)
                {
                    sum = arr[i] + arr[left] + arr[right];

                    if (sum == 0)
                    {

                        LIST3SUM.Add(arr[i] + "," + arr[left] + "," + arr[right]);
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else if (sum > 0)
                        right--;
                }
            }
            foreach (var item in LIST3SUM)
            {
                Console.WriteLine(item);
            }
        }





        //Don't think of sorting using Array.Sort(). Interviewers expect the Dutch National Flag Algorithm.
        public static void SORTCOLOURS()//0 = Red ,1 = White ,2 = Blue

        {
            int[] arr = [2, 0, 2, 1, 1, 0];//[0,0,1,1,2,2]


            int left = 0;
            int mid = 0;
            int right = arr.Length - 1;

            while (mid <= right)
            {
                if (arr[mid] == 2)
                {
                    (arr[right], arr[mid]) = (arr[mid], arr[right]);
                    right--;
                }
                else if (arr[mid] == 1)
                {

                    mid++;
                }
                else if (arr[mid] == 0)
                {
                    (arr[left], arr[mid]) = (arr[mid], arr[left]);
                    mid++;
                    left++;
                }

            }


            Print(!true, arr);


        }




        public static void Boats_to_Save_People()
        {
            int[] people = [3, 5, 3, 4];/*[1, 2]op-1  limit-->3*/;//[3, 2, 2, 1]--op ->3 limit ->3;
            int limit = 5/*3*/;

            int Lightest_person = 0;//left
            int Heaviest_person = people.Length - 1; //right //सर्वात जड माणूस निवडा.

            int boats = 0;
            while (Lightest_person < Heaviest_person) //त्याच्यासोबत सर्वात हलका माणूस बसू शकतो का ?
            {

                if (people[Lightest_person] > limit)//दोघांना एका Boat मध्ये बसवा. नाही

                {
                    Lightest_person++;

                }
                else
                    Heaviest_person--;//जड माणूस एकटाच जाईल.


                boats++;//Boat Count वाढवा.
            }
            Console.WriteLine("Total Boats = " + boats);
        }

















        public static void Print(bool b, int[] a)
        {
            if (b)
            {
                foreach (var item in a)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n-------------");
            }

            else
            {
                foreach (var item in a)
                {
                    Console.Write(item + " ");
                }
            }
        }


    }
}
