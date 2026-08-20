using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class BasicArray
    {
        public static int[] arr = { 5, 17, 7, 9, 3, 8 };
        public static void LargestElement()
        {

            int largest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                    largest = arr[i];
            }
            Console.WriteLine(largest);
        }


        public static void smallestElemtn()
        {


            int samllest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < samllest)
                {
                    samllest = arr[i];
                }

            }

            Console.WriteLine(samllest);
        }


        public static void SecondLargeElemenet()
        {
            int largest = arr[0];

            int secondLarge = 0;


            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > largest)
                {
                    secondLarge = largest;
                    largest = arr[i];

                }
                else if (arr[i] < largest && arr[i] > secondLarge)
                {
                    secondLarge = arr[i];
                }
            }
            Console.WriteLine(secondLarge);
        }


        public static void RevresAray()
        {
            //for (int i = arr.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            int count = arr.Length - 1;
            while (count != -1)
            {
                Console.WriteLine(arr[count]);
                count--;
            }

        }




        public static void arraySort()
        {


            /*
            Summery below this code Selection Sort type


             * Find Smallest         process start
                    ↓
                   Swap
                    ↓
              Move to Next Position
                    ↓
                  Repeat             process end
            */

            int[] arr = [20, 70, 50, 30, 40];
            //int mainIdx = 0;

            //Print(true, arr);

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    mainIdx = i;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[mainIdx])
            //        {
            //            mainIdx = j;
            //        }
            //    }
            //    int temp = arr[i];
            //    arr[i] = arr[mainIdx];
            //    arr[mainIdx] = temp;
            //}
            //Print(!true, arr);


            //Console.WriteLine("------------------------------");
            /*
                 Summery below this code BUBBLE sort type

              Compare   process start
                   ↓
               Wrong Order?
                   ↓
               Yes → Swap
               No  → Continue
               Repeat    process end
            */



            //Print(true, arr);
            //bool IsSwapp = false;
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    IsSwapp = false;
            //    for (int j = 0; j < arr.Length - 1 - i; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            int temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //            IsSwapp = true;

            //            if (!IsSwapp)
            //                break;
            //        }
            //    }

            //}
            //Print(!true, arr);


            //Console.WriteLine("------------------------------");


            /*
            Summery below this code INSERTION sort type

                  Pick
                    ↓
                  Shift
                    ↓
                  Insert

          */
            //Print(true, arr);
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    int key = arr[i];
            //    int j = i - 1;

            //    while (j >= 0 && arr[j] > key)
            //    {
            //        arr[j + 1] = arr[j];
            //        j--;
            //    }

            //    arr[j + 1] = key;
            //}
            //Print(!true, arr);




            /*   Summery below this code MERGE sort type

             Divide
               ↓ 
              Sort
               ↓
             Merge
            */
            int[] arr1 = { 8, 3, 5, 1 };
            Print(true, arr1);
            MergeSort(arr1, 0, arr1.Length - 1);

            Print(!true, arr1);
        }


        static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }




        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }

            while (i <= mid)
                temp[k++] = arr[i++];

            while (j <= right)
                temp[k++] = arr[j++];

            for (int x = 0; x < temp.Length; x++)
                arr[left + x] = temp[x];
        }






        public static void removeDplicates()
        {

            int[] arr1 = [1, 1, 2, 3, 3, 4, 4, 5];
            //{ 50, 20, 40, 30, 20, 50, 10, 20 };

            // int count= 1;

            // int[] temparr = new int[arr1.Length];


            for (int i = 0; i < arr1.Length; i++)
            {
                int elment = arr1[i];
                // count = 1;

                for (int j = i + 1; j < arr1.Length; j++)
                {

                    if (elment == arr1[j])
                    {
                        //count++;

                        arr1[i] = -1;
                        arr1[j] = -1;

                    }

                }

                //   temparr[i] = count;



            }




            foreach (var item in arr1)
            {
                if (item != -1)
                {
                    Console.WriteLine(item);
                }
            }

        }


        public static void mergeTwoaray()
        {
            Print(true, arr);
            int[] Mergearr = { 12, 25, 500 };

            int index = 0;

            Array.Resize(ref arr, arr.Length + Mergearr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = Mergearr[index];
                    index++;


                }
            }
            Print(!true, arr);


        }


        public static void MinandMax()
        {
            //arr = { 5, 17, 7, 9, 3, 8 };
            int MAX = arr[0];

            int MIN = arr[0];

            Print(true, arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > MAX)
                {
                    MAX = arr[i];
                }
                else if (arr[i] < MIN)
                {
                    MIN = arr[i];
                }

            }


            Console.WriteLine("MAX--" + MAX);
            Console.WriteLine("MIN--" + MIN);



        }


        public static void arrayLEFTpostion()
        {
            Print(true, arr);



            int temp = arr[0];

            //Console.WriteLine(temp) ;




            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[arr.Length - 1] = temp;

            Print(false, arr);
        }




        public static void rightRotaion()
        {
            Print(true, arr);

            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];


            }
            arr[0] = last;

            Print(false, arr);
        }




        public static void InsertElement()
        {

            int[] newArr = new int[arr.Length + 1];

            int index = 4;

            int element = 100;

            int temp = arr[index];

            for (int i = 0; i <= newArr.Length - 1; i++)
            {
                if (i < index)
                {
                    newArr[i] = arr[i];
                }
                else if (i == index)
                {
                    newArr[i] = element;
                }
                else
                {
                    newArr[i] = arr[i - 1];
                }



            }


            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }


        }



        public static void DeleteElement()
        {
            Print(true, arr);

            int element = 5;


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    arr[i] = -1;
                }
            }

            foreach (var item in arr)
            {
                if (item != -1)
                {
                    Console.Write(item + " ");
                }
            }
        }




        public static void LinerSerch()///unsroted array then used linear serch 
        {

            Print(true, arr);

            int element = 9;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                index = 0;
                if (arr[i] == element)
                {
                    index = i;
                    break;
                }


            }
            Console.WriteLine("Index Of This " + element + " is--" + index);


        }






        public static void ARMSTRONGnumber()
        {

            int number = 9474;
            int result = 9474;
            double sum = 0;

            while (number != 0)
            {
                int rem = number % 10;
                number = number / 10;


                sum += Math.Pow(rem, 4);



            }

            if (sum == result)
                Console.WriteLine("ARMSTRONG NUMBER");
            else
                Console.WriteLine("NOT ARAMSTRONG NUMBER");
        }



        public static void FreqArrayElement()
        {
            int[] arr1 = { 30, 20, 30, 200, 50, 60, 70, 30, 90, 60, 50, 50, 30, 100 };
            Print(true, arr1);


            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == -1) continue;
                count = 1;
                int items = arr1[i];
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (items == arr1[j])
                    {

                        //arr1[i] = count + 1;
                        count++;
                        arr1[j] = -1;

                        //count = arr1[i];

                    }


                }
                //Console.Write(items+" ");////remove duplicate this strings akshay----akshy
                Console.WriteLine($"Numbers:{items}   count:{count}");


                //if (count == 1)//////in this code get first NON repeat character.
                //{
                //    Console.WriteLine($"character:{items}   count:{count}");
                //   // break; ///first number whos non repated
                //}
            }


            //foreach (var item in arr1)
            //{
            //    if (item != -1)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}

        }




        public static void MissingNumberArray()
        {
            //int[] digits = { 1, 2, 5, 7, 9, 8, 10, 4 };//3,6 missing

            int[] digits =
           {
            1, 2, 5, 7, 9, 8, 10, 4,
            11, 12, 14, 15, 16, 18, 20
        };


            Print(true, digits);
            int IDX = 0;
            for (int i = 0; i < digits.Length - 1; i++)
            {
                IDX = i;

                for (int j = i + 1; j < digits.Length; j++)
                {
                    if (digits[j] < digits[IDX])
                    {
                        IDX = j;
                    }
                }


                int temp = digits[i];
                digits[i] = digits[IDX];
                digits[IDX] = temp;

            }

            //Array.Sort(digits);



            int expectedNum = 1;

            for (int i = 0; i < digits.Length; i++)
            {
                while (expectedNum < digits[i])
                {
                    Console.WriteLine("This Number Is Missing--" + expectedNum);
                    expectedNum++;
                }

                expectedNum++;
            }


            // Print(!true, digits);

        }



        public static void ElmentSumTarget()
        {
            //int[] digits = { 2, 7, 4, 5, 1, 3, 6, 8 };
            //int Target = 9;



            int[] digits = { 3, 4, 7, 2, -3, 1, 4, 2 };
            int Target = 7;



            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = i + 1; j < digits.Length; j++)
                {

                    if (digits[i] + digits[j] == Target)
                    {
                        Console.WriteLine(i + " " + j);
                        // Console.WriteLine($"Target is {Target} -- {digits[i]} + {digits[j]}");
                    }

                }


            }

            Console.WriteLine("====================================================");

        }


        public static void MovingZeroLast()
        {
            //int[] digits = { 2, 0, 4, 0, 0, 5, 6, 9, 0,10 };

            //int index = 0;
            //Print(true, digits);

            //for (int i = 0; i < digits.Length; i++)
            //{
            //    if (digits[i] != 0)
            //    {
            //        digits[index] = digits[i];
            //        index++;

            //    }
            //}

            //while (index < digits.Length)
            //{
            //    digits[index] = 0; index++;

            //}
            //Print(!true, digits);


        }








        /// <summary>
        /// Kadane's Algorithm — find the maximum subarray sum.
        /// </summary>
        public static void maximumsubarraySum()//////interview question
        {
            int[] aray = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            int currentSum = 0;

            int maxSum = aray[0];



            foreach (int num in aray)
            {
                currentSum += num;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                }


            }

            Console.WriteLine($"Maximum Subarray Sum = {maxSum}");


        }


        /// <summary>
        /// Find the majority element (appears more than n/2 times) — Boyer-Moore Voting.
        /// </summary>

        public static void MajorityElements() //interview Question
        {
            int[] aray = { 2, 2, 1, 1, 1, 2, 2, 3 };


            int candidate = 0;

            int count = 0;

            foreach (var item in aray)
            {
                if (count == 0)
                {
                    candidate = item;
                }

                if (candidate == item)
                    count++;
                else
                    count--;

            }



            Console.WriteLine($"MajorityElements-  {candidate}");
        }





        /// <summary>
        /// Find all subarrays with a given sum (positive and negative numbers).
        /// </summary>

        public static void SubarraySum()//interview Question
        {
            //int []aray = { 1, 2, 3, 4, 5 };

            //int TARGET = 5;



            int[] aray = { 3, 4, 7, 2, -3, 1, 4, 2 };
            int TARGET = 7;

            int sum = 0;


            for (int i = 0; i < aray.Length; i++)
            {

                sum = 0;

                for (int j = i; j < aray.Length; j++)
                {
                    sum += aray[j];

                    if (sum == TARGET)
                    {
                        Console.WriteLine(i + " to " + j);
                        //break;
                    }
                }

            }
        }



        /// <summary>
        /// Sort an array of 0s, 1s, and 2s without using a sort function (Dutch National Flag).
        /// </summary>



        public static void Os1s2sarraySort()
        {
            int[] arr = { 2, 0, 1, 2, 1, 0, 2, 0 };
            int low = 0;
            int mid = 0;

            int high = arr.Length - 1;

            Print(true, arr);


            while (mid <= high)
            {
                if (arr[mid] == 0)
                {
                    SWAP(arr, low, mid);
                    low++;
                    mid++;
                }

                else if (arr[mid] == 1)
                {
                    mid++;
                }

                else
                {
                    SWAP(arr, mid, high);
                    high--;
                }

            }




            Print(!true, arr);


        }

        public static void SWAP(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }







        /// <summary>
        /// Find the leaders in an array (element greater than all elements to its right).
        /// </summary>


        public static void LEADERarray()
        {
            int[] arr = { 16, 17, 4, 3, 5, 2 };


            Print(true, arr);

            int LEADER = arr[arr.Length - 1];


            List<int> leder = new List<int>();

            leder.Add(LEADER);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] > LEADER)
                {
                    LEADER = arr[i];
                    leder.Add(LEADER);
                }


            }

            leder.Reverse();

            Print(true, leder.ToArray());

        }




        public static void TrappingRainWater()
        {
            int[] height = { 4, 2, 0, 6, 3, 2, 5 };/////4 6 6 6 

            int n = height.Length;

            int[] leftMax = new int[n];
            int[] rightMax = new int[n];

            leftMax[0] = height[0];

            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            rightMax[n - 1] = height[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            int water = 0;

            for (int i = 0; i < n; i++)
            {
                water += Math.Min(leftMax[i], rightMax[i]) - height[i];
            }

            Console.WriteLine("Total Water = " + water);
        }
        /// <summary>
        /// Find the equilibrium index of an array (left sum == right sum).
        /// </summary>

        public static void EquilibriumIndex()
        {
            int[] arr = { 1, 3, 5, 2, 2 };

            int totalSum = 0;


            foreach (int item in arr)
            {
                totalSum += item;
            }

            int leftSum = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                totalSum -= arr[i];

                if (leftSum == totalSum)
                {
                    Console.WriteLine("Equilibrum Index---" + i);
                    return;
                }
                leftSum += arr[i];
            }
        }



        public static void MERGERINTERVALS()
        {
            int[][] intervals =
            {
            new int[]{1,3},
            new int[]{2,6},
            new int[]{15,18},
            new int[]{8,10}
        };

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));



            List<int[]> result = new List<int[]>();

            result.Add(intervals[0]);

            for (int i = 1; i < intervals.Length; i++)
            {
                int[] last = result[result.Count - 1];

                if (intervals[i][0] <= last[1])
                {
                    last[1] = Math.Max(last[1], intervals[i][1]);


                }
                else
                {
                    result.Add(intervals[i]);
                }

            }

            foreach (int[] interval in result)
            {
                Console.WriteLine($"[{interval[0]}, {interval[1]}]");
            }


        }



        /// <summary>
        /// Find the longest consecutive sequence in an unsorted array.
        /// </summary>
        public static void Longestconsecutive()
        {
            int[] arr = { 100, 4, 200, 1, 3, 2, 7, 8, 9, 10, 11 };  // longest sequnace===7,8,9,10,11-----5

            HashSet<int> set = new HashSet<int>(arr);

            int longest = 0;


            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int current = num;
                    int length = 1;

                    while (set.Contains(current + 1))
                    {
                        current++;
                        length++;
                    }

                    longest = Math.Max(longest, length);
                }



            }

            Console.WriteLine("Longest Consecutive Length = " + longest);

        }


        /// <summary>
        /// Find the maximum product subarray.
        /// </summary>

        public static void MaxSubarray()
        {

            int[] arr = { 2, 3, -2, 4 };


            int MaxProudct = arr[0];
            int MinProudct = arr[0];
            int answer = arr[0];


            for (int i = 1; i < arr.Length; i++)
            {

                int current = arr[i];

                if (current < 0)
                {
                    int temp = MaxProudct;
                    MaxProudct = MinProudct;
                    MinProudct = temp;

                }

                MaxProudct = Math.Max(current, MaxProudct * current);
                MinProudct = Math.Min(current, MinProudct * current);

                answer = Math.Max(answer, MaxProudct);




            }

            Console.WriteLine(answer);
        }


        /// <summary>
        ///Prefix SUM------input--[30, 10, 10, 5, 50]   output-------- [30, 40, 50, 55, 105] 
        /// </summary>



        public static void prefixSum()
        {
            int[] arr = { 30, 10, 10, 5, 50 };
            Print(true, arr);
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {

                    sum = arr[i] + arr[j];
                    arr[j] = sum;
                    break;

                }

            }
            Print(!true, arr);

        }






        public static void BinerySerch()/////sroted array then used binery serch 
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 15, 13 };

            //  Array.Sort(arr, 0, arr.Length);
            int target = 15;

            int left = 0;
            int right = arr.Length - 1;


            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    Console.WriteLine("Index Found: " + mid);
                    return;
                }
                else if (target > arr[mid])
                {
                    left = mid + 1;
                }
                else
                    right = mid - 1;

            }

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




        public static void SelectionSort()
        {
            /*
            Summery below this code Selection Sort type


             * Find Smallest         process start
                    ↓
                   Swap
                    ↓
              Move to Next Position
                    ↓
                  Repeat             process end
            */




            int[] arr = { 30, 80, 10, 5, 50 };

            Print(true, arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                (arr[i], arr[min]) = (arr[min], arr[i]);
            }
            Print(!true, arr);
        }


        public static void InsertionSort()
        {
            int[] arr = { 30, 80, 10, 5, 50 };
            Print(true, arr);

            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];

                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            Print(!true, arr);
        }



        public static void BubbleShort()
        {           /*
             Summery below this code BUBBLE sort type

          Compare   process start
               ↓
           Wrong Order?
               ↓
           Yes → Swap
           No  → Continue
           Repeat    process end
        */


            int[] arr = { 30, 80, 10, 5, 50 };
            Print(true, arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }

            }
            Print(!true, arr);
        }




        public static void MsortCall()
        {
            int[] arr1 = { 30, 10, 5, 50, 40 };
            Print(true, arr1);
            mergeSort(arr1, 0, arr1.Length - 1);

            Print(!true, arr1.ToArray());
        }

        public static void mergeSort(int[] arr, int lb, int ub)
        {
            if (lb < ub)
            {
                int mid = (lb + ub) / 2;
                mergeSort(arr, lb, mid);
                mergeSort(arr, mid + 1, ub);
                _merge(arr, lb, mid, ub);
            }
        }



        private static void _merge(int[] arr, int lb, int mid, int ub)
        {
            int i = lb;
            int j = mid + 1;
            int k = lb;

            int[] b = new int[arr.Length];


            while (i <= mid && j <= ub)
            {
                if (arr[i] < arr[j])
                {
                    b[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    b[k] = arr[j];
                    k++;
                    j++;
                }
            }
            if (i > mid)
            {
                while (j <= ub)
                {
                    b[k] = arr[j];
                    k++;
                    j++;
                }
            }
            else
            {
                while (i <= mid)
                {
                    b[k] = arr[i];
                    i++; k++;
                }
            }


            for (int m = lb; m <= ub; m++)
            {
                arr[m] = b[m];
            }
        }



        public static void QickCall()
        {
            int[] arr1 = { 30, 10, 5, 50, 40 };
            Print(true, arr1);
            QickSort(arr1, 0, arr1.Length - 1);

            Print(!true, arr1.ToArray());
        }

        public static void QickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int loc = Partition(arr, low, high);
                QickSort(arr, low, loc - 1);
                QickSort(arr, loc + 1, high);

            }
        }



        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int start = low;
            int end = high;


            while (start < end)
            {
                while (start <= high && arr[start] <= pivot)
                    start++;



                while (arr[end] > pivot)
                    end--;


                if (start < end)
                    (arr[start], arr[end]) = (arr[end], arr[start]);


            }



            (arr[low], arr[end]) = (arr[end], arr[low]);




            return end;
        }





        //leet codes
        public static void ThreeSum()//3Sum
        {
            int[] arr = { -1, 0, 1, 2, -1, -4 };///------Output-----[[-1,-1,2],[-1,0,1]] ---------example---- [-2, 0, 1, 1, 2]

            Array.Sort(arr);

            Print(true, arr);

            List<string> result = new List<string>();

            int sum = 0;

            int left = 0;
            int right = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (i > 0 && arr[i] == arr[i - 1])
                    continue;

                left = i + 1;
                right = arr.Length - 1;


                while (left < right)
                {
                    sum = arr[i] + arr[left] + arr[right];

                    if (sum == 0)
                    {
                        result.Add(arr[i] + " " + arr[left] + " " + arr[right]);
                        left++;
                        right--;

                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else if (sum > 0)
                    {
                        right--;
                    }

                    //while ((left < right) && arr[left] == arr[left - 1])
                    //{
                    //    left += 1;
                    //}
                    //while ((left < right) && arr[right] == arr[right - 1])
                    //{
                    //    right--;
                    //}
                }


            }

            foreach (var item in result)
            {
                Console.Write($"[ {item}] ");

            }
        }

        public static void WordsAndgram()
        {
            string[] arr = { "eat", "tea", "tan", "ate", "nat", "bat" };
            /*
            output-
              ["eat","tea","ate"]
              ["tan","nat"]
              ["bat"]
            */

            //Array.Sort(arr);

            HashSet<string> hashset = new HashSet<string>();

            char[] str1 = new char[arr[0].Length];
            char[] str2 = new char[arr[0].Length];

            for (int i = 0; i < arr.Length; i++)
            {
                string s = "";
                str1 = arr[i].ToCharArray();
                Array.Sort(str1);

                for (int j = 0; j < arr.Length; j++)
                {
                    str2 = arr[j].ToCharArray();
                    Array.Sort(str2);

                    if (new string(str1) == (new string(str2)))
                    {
                        if (hashset.Contains(s))
                            continue;
                        s += arr[j] + ",";

                    }



                }


                hashset.Add(s);
            }

            foreach (var item in hashset)
            {
                Console.Write($"[{item}]");
                Console.WriteLine();
            }
        }



        //Product of array expect element
        public static void proudctArrayELement()
        {

            int[] arr = { 1, 2, 3, 4 };  ////output=[24,12,8,6]  //{ 2, 2, 3, 4 }-------------24 24 16 12

            int multiply = 1;
            int c = 0;
            int index = 0;

            int[] result = new int[arr.Length];



            result[0] = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                result[i] = result[i - 1] * arr[i - 1];
            }

            int suffix = 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result[i] *= suffix;
                suffix *= arr[i];
            }


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    multiply = 1;
            //    index = 0;
            //    c = 0;
            //    while (c <= arr.Length - 1)
            //    {

            //        if (index != i)
            //        {
            //            multiply *= arr[index];
            //        }
            //        c++;
            //        ++index;
            //    }



            //    Console.Write(multiply + " , ");

            //}

            Print(!true, result);
        }


        public static void TopKFrequentELemtn()
        {

            int[] arr = { 1, 1, 1, 2, 2, 3 };/// output---1,2 is most k=2
            //example2----[4,4,4,5,5,6]-- k=1 output----4
            int k = 2;
            Dictionary<int, int> myDict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                // int Element = arr[i];

                if (myDict.ContainsKey(arr[i]))
                {

                    myDict[arr[i]]++;

                }
                else
                {
                    myDict.Add(arr[i], 1);
                }

            }


            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
            // list.Sort((a, b) => b.Value.CompareTo(a.Value)); using linq get decending order

            foreach (var item in myDict)
            {
                list.Add(item);
            }

            for (int i = 0; i < list.Count - 1; i++)///this is for decending order list by values
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].Value < list[j + 1].Value)
                    {
                        (list[j], list[j + 1]) = (list[j + 1], list[j]);
                    }
                }

            }


            for (int i = 0; i < k; i++)
            {
                var item = list[i];
                Console.WriteLine(item.Key);
            }

        }



        public static void NumberOfISaland() ////0 water and number is 1
        {
            //     char[,] grid =
            //      { /*c=0*/
            ///*R-0*/  { '1','1','0','0','0' },
            //         { '1','1','0','0','0' },
            //         { '0','0','1','0','0' },
            //         { '0','0','0','1','1' }
            //     };
            char[,] grid =
                  { /*c=0*/
   /*R-0*/  { '1','1', },
            { '0','1', },

        };


            int answer = numberofIsalnd(grid);
            Console.WriteLine(answer);

        }

        private static int numberofIsalnd(char[,] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {

                    if (grid[i, j] == '1')
                    {
                        //Console.WriteLine(i +" "+j);
                        count++;
                        DFS(grid, i, j);

                    }
                }
            }


            return count;
        }
        static void DFS(char[,] grid, int row, int col)
        {// Matrix च्या बाहेर गेलो का?
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);


            // पाणी आहे का?
            if (row < 0 || col < 0 || row >= rows || col >= cols || grid[row, col] == '0')
                return;

            // जमीन मिळाली, आता ती Visit झाली म्हणून Mark करा
            grid[row, col] = '0';

            // आता चारही दिशांना जा
            DFS(grid, row - 1, col); // Up
            DFS(grid, row + 1, col); // Down
            DFS(grid, row, col - 1); // Left
            DFS(grid, row, col + 1); // Right
        }
    }
}