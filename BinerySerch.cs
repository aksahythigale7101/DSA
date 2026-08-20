using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class BinerySerch
    {
        public static void Binary_Serch()
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 15, 13 };
            int target = 15;

            int mid = 0;
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                mid = (left + right) / 2;


                if (arr[mid] == target)
                {
                    Console.WriteLine("Index: " + mid);
                    return;
                }
                else if (target > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }


            }

        }


        public static void FirstBadVersion()
        {
            /*  this is questionss
             Version: 1   2   3   4   5   6   7
            ✅  ✅  ✅  ❌  ❌  ❌  ❌ ❌  ❌
            */

            int n = 7;
            int left = 1;
            int right = n;

            int version = 4;

            while (left < right)
            {
                int mid = left + (right - left) / 2;



                if (mid < version)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }


            }
            Console.WriteLine("Bad Version: " + left);


        }


        public static void Search_Insert_Position()
        {
            int[] arr = [1, 3, 5, 6];
            int Target = 2;

            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {

                // int mid = left + (right - left) / 2;
                int mid = (left + right) / 2;
                if (arr[mid] == Target)
                {
                    Console.WriteLine("Index: " + mid);
                    return;
                }
                else if (Target > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }


            }



            Console.WriteLine("Index: " + left);
        }

        public static void Find_First_and_Last_Position_of_Elemen()
        {
            int[] arr = [5, 7, 7, 8, 8, 8, 10];
            int Target = 8;

            int FirstAns = 0;
            int SecondAns = 0;

            int left = 0;
            int right = arr.Length - 1;


            while (left <= right)
            {

                // int mid = left + (right - left) / 2;
                int mid = (left + right) / 2;
                if (arr[mid] == Target)
                {
                    FirstAns = mid;
                    right = mid - 1;
                }
                else if (Target > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }


            }
            Console.WriteLine("First Occurance: " + FirstAns);

            Console.WriteLine("-------------------");




            left = 0;
            right = arr.Length - 1;
            while (left <= right)
            {

                // int mid = left + (right - left) / 2;//stander formaula insted of left/right/2
                int mid = (left + right) / 2;
                if (arr[mid] == Target)
                {
                    SecondAns = mid;
                    left = mid + 1;
                }
                else if (Target > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }


            }
            Console.WriteLine("Second Occurance: " + SecondAns);
        }

        public static void Search_in_Rotated_Sorted_Array()//duplicates नाहीत

        {
            int[] arr = [5, 6, 7, 1, 2, 3, 4];

            int left = 0;

            int right = arr.Length - 1;

            int target = 2;

            while (left <= right)
            {
                int mid = (left + right) / 2; /// mid काढ

                if (target == arr[mid])                    //nums[mid] == target ?
                {                                             //↓ Yes
                    Console.WriteLine(mid);                   //return mid
                    return;
                }                                                 //  ↓ No





                if (arr[left] < arr[mid])// Left side sorted आहे?
                {
                    if (arr[left] <= target && target < arr[mid])// target left range मध्ये?
                    {
                        right = mid - 1;  // Yes → right = mid - 1

                    }
                    else
                    {
                        left = mid + 1;// No  → left = mid + 1
                    }
                }
                else
                {
                    if (arr[mid] < target && target <= arr[right])//Right side sorted आहे &&  target right range मध्ये?
                    {
                        left = mid + 1;//   Yes → left = mid + 1
                    }
                    else
                    {
                        right = mid - 1;//  No  → right = mid - 1
                    }

                }

            }


            Console.WriteLine("Target Not Found");


        }

        public static void Rotated_Sorted_Array_II()// duplicates आहेत
        {
            int[] arr = { 2, 5, 6, 0, 0, 1, 2 };

            int target = 0;


            int left = 0;

            int right = arr.Length - 1;


            while (left <= right)
            {
                int mid = (left + right) / 2; /// mid काढ

                if (target == arr[mid])                    //nums[mid] == target ?
                {                                             //↓ Yes
                    Console.WriteLine("Target Found: " + mid);                   //return mid
                    return;
                }                                                 //  ↓ No




                if (arr[left] == arr[mid] && arr[mid] == arr[right]) // Duplicate values:
                {                                                       // We cannot decide which side is sorted
                    left++;
                    left--;
                }




                if (arr[left] < arr[mid])// Left side sorted आहे?
                {
                    if (arr[left] <= target && target < arr[mid])// target left range मध्ये?
                    {
                        right = mid - 1;  // Yes → right = mid - 1

                    }
                    else
                    {
                        left = mid + 1;// No  → left = mid + 1
                    }
                }
                else
                {
                    if (arr[mid] < target && target <= arr[right])//Right side sorted आहे &&  target right range मध्ये?
                    {
                        left = mid + 1;//   Yes → left = mid + 1
                    }
                    else
                    {
                        right = mid - 1;//  No  → right = mid - 1
                    }

                }

            }


            Console.WriteLine("Target Not Found");


        }
        public static void Find_Minimum_in_Rotated_Sorted_Array()
        {

            int[] nums = [4, 5, 6, 7, 8, 1, 2];


            int left = 0;
            int right = nums.Length - 1;


            while (left < right)
            {

                int mid = (left + right) / 2;

                if (nums[mid] > nums[right])//  // Minimum is on the left side or mid itself
                {
                    left = mid + 1;
                }
                else//  // Minimum is on the left side or mid itself
                {
                    right = mid;
                }


            }
            Console.WriteLine("Result id: " + nums[left]);

        }

        public static void FindPeakElement()
        {
            int[] nums = { 1, 2, 3, 1, 4 };

            int left = 0;
            int right = nums.Length - 1;


            while (left < right)
            {

                int mid = (left + right) / 2;

                if (nums[left] < nums[mid + 1])//  //Peak is on the right side
                {
                    left = mid + 1;
                }
                else//   // Peak is at mid or on the left side
                {
                    right = mid;
                }

            }
            Console.WriteLine("Result id: " + nums[left]);

        }
        public static void SingleNonDuplicate()
        {
            int[] nums = { 1, 1, 2, 3, 3, 4, 4 };

            int left = 0;
            int right = nums.Length - 1;


            while (left < right)
            {

                int mid = (left + right) / 2;


                if (mid % 2 == 1)//Make mid even
                {
                    mid--;
                }

                if (nums[left] == nums[mid + 1])//   Single element is on the right
                {
                    left = mid + 2;
                }
                else//   Single element is on the left or at mid
                {
                    right = mid;
                }

            }
            Console.WriteLine("Single Element : " + nums[left]);

        }

        internal static void Sqrt()//असा सर्वात मोठा integer शोधा ज्याचा square x पेक्षा मोठा नाही.
        {

            int x = 9;


            if (x < 2)
            {
                Console.WriteLine(x);
                return;
            }


            int left = 1;
            int right = x;
            int answare = 0;

            while (left <= right)
            {

                int mid = (left + right) / 2;


                if (mid <= x / mid) //Check mid *mid
                {
                    answare = mid;// mid is a possible answer
                    left = mid + 1;
                }
                else//     // Try to find a bigger answer
                {
                    right = mid - 1;    // mid is too big
                }

            }
            Console.WriteLine("Sqrt: " + answare);

        }

        internal static void Koko_Eating_Bananas()
        {

            int[] piles = [3, 6, 7, 11];
            int speed = 8;


            int left = 1, right = piles[piles.Length - 1];

            int ans = right;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int hours = 0;

                foreach (int pile in piles)   // Calculate total hours for this speed
                {
                    hours += (pile + mid - 1) / mid;
                }


                if (hours <= speed)  // Can Koko finish within h hours?
                {
                    ans = mid;

                    right = mid - 1; // Try a smaller speed
                }
                else
                {
                    left = mid + 1;  // Speed is too slow
                }



            }

            Console.WriteLine("Minimum Eating Speed = " + ans);








        }
        public int y = 0;
        public static int z = 0;

        internal static void Smallest_Divisor_Given_a_Threshold()
        {

            int[] nums = [1, 2, 5, 9];
            int threshold = 6;



            int left = 1, right = nums[nums.Length - 1];

            int ans = right;

            while (left <= right)
            {
                int divisor = left + (right - left) / 2;
                int sum = 0;

                foreach (int pile in nums)
                {
                    sum += (pile + divisor - 1) / divisor;
                }


                if (sum <= threshold)
                {
                    ans = divisor;

                    right = divisor - 1; // Try a smaller speed
                }
                else
                {
                    left = divisor + 1;  // Speed is too slow
                }



            }
            Console.WriteLine("Smallest Divisor = " + ans);
        }


        //Cycli short

        static void CyclicSort(int[] arr)
        {
            int i = 0;

            while (i < arr.Length)
            {
                int correctIndex = arr[i] - 1;

                if (arr[i] != arr[correctIndex])
                {
                    // Swap
                    int temp = arr[i];
                    arr[i] = arr[correctIndex];
                    arr[correctIndex] = temp;
                }
                else
                {
                    i++;
                }
            }
        }
        public static void MainFunctions()
        {
            int[] arr = { 3, 1, 5, 4, 2 };

            CyclicSort(arr);

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
