using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class PrefixSum
    {
        public static void Running_Sum_of_1d_Array()
        {

            int[] arr = { 1, 2, 3, 4 }; // op --[1, 3, 6, 10]

            Print(true, arr);

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i];

            }

            Print(!true, arr);
        }

        public static void Range_Sum_Query_Immutable()//Original array मध्ये values बदलणार नाहीत.
        {
            int[] arr = { 10, 20, 30, 40, 50 };  // op- 10 30 60 100 150

            int[] prefix = new int[arr.Length];

            int sum = 0;
            Print(true, arr);
            //prefix[0] = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                prefix[i] = sum;
            }

            Print(!true, prefix);
            // Query
            int left = 2;
            int right = 4;
            int rangeSum = 0;

            if (left == 0)
            {
                rangeSum = prefix[right];
            }
            else
            {
                rangeSum = prefix[right] - prefix[left - 1];
            }
            Console.WriteLine();
            Console.WriteLine("RangeSum: " + rangeSum);

        }

        public static void Find_Pivot_Index()
        {

            int[] arr = { 1, 7, 3, 6, 5, 6 }; //op  3

            int leftSum = 0;
            int RightSum = 0;
            int Total = 0;

            Total = arr.Sum();


            for (int i = 0; i < arr.Length; i++)
            {
                RightSum = Total - leftSum - arr[i];


                if (leftSum == RightSum)
                {
                    Console.WriteLine("Index Is : " + i);
                    return;
                }

                leftSum += arr[i];
            }
        }


        public static void Subarray_Sum_Equals_K()
        {
            int[] arr = { 1, 2, 3 };
            int K = 3;

            int prfix = 0;
            int need = 0;
            int count = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                prfix += arr[i];

                need = prfix - K;

                if (map.ContainsKey(need))
                {
                    count += map[need];
                }


                if (map.ContainsKey(prfix))
                {
                    map[prfix]++;
                }
                else
                {
                    map[prfix] = 1;
                }


            }

            Console.WriteLine(count);
        }











        internal static void Contiguous_Array()
        {

            int[] arr = { 0, 1, 0, 1 }; //op-4

            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = -1;
            int prfix = 0;
            int maxlentgh = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == 0)//// 0 ला -1 आणि 1 ला +1
                {
                    prfix += -1;
                }
                else
                {
                    prfix += 1;
                }
                if (map.ContainsKey(prfix))// Same Prefix Sum आधी आला आहे का?

                {
                    int oldIndex = map[prfix];

                    int length = i - oldIndex;

                    maxlentgh = Math.Max(maxlentgh, length);
                }
                else
                {

                    map[prfix] = i; // First time आला तरच store करा
                }
            }
            Console.WriteLine("Maximum Length = " + maxlentgh);
        }

        internal static void Subarray_Sums_Divisible_by_K()
        {
            int[] arr = { 4, 5, 0, -2, -3, 1 };
            int k = 5;
            Dictionary<int, int> map = new Dictionary<int, int>();

            int count = 0;
            int prfix = 0;

            map[0] = 1;
            int reminder = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                prfix += arr[i];

                int remainder = ((prfix % k) + k) % k;

                if (map.ContainsKey(reminder))
                {
                    count += map[reminder];
                }



                if (map.ContainsKey(remainder))
                {
                    map[remainder]++;
                }
                else
                {
                    map[remainder] = 1;
                }





            }

            Console.WriteLine(count);
        }


        internal static void Continuous_Subarray_Sum()
        {
            int[] arr = [23, 2, 4, 6, 7]; //op-4
            int k = 6;
            Dictionary<int, int> map = new Dictionary<int, int>();

            int prfix = 0;

            map[0] = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                prfix += arr[i];

                int remainder = (prfix % k);


                if (map.ContainsKey(remainder))// Same Prefix Sum आधी आला आहे का?

                {
                    int oldIndex = map[remainder];

                    int length = i - oldIndex;

                    if (length > 2)
                    {
                        Console.WriteLine(true);
                        return;
                    }

                }
                else
                {

                    map[remainder] = i; // First time आला तरच store करा
                }
            }

        }


        internal static void Product_of_Array_Except_Self()
        {
            int[] nums = [1, 2, 3, 4]; //OP --[24,12,8,6]


            int[] Product = new int[nums.Length];

            Product[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                Product[i] = nums[i - 1] * Product[i - 1];
            }

            int suffix = 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Product[i] *= suffix;
                suffix *= nums[i];

            }
            Print(false, Product);
        }



        //-----------------------------------------------------------------------------------------------
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
