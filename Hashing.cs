using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Hashing
    {
        public static void ContainsDuplicates()
        {
            int[] arr = { 10, 20, 30, 40, 20, 10, 50 };


            //Dictionary<int, int> Dupicates = new Dictionary<int, int>();
            HashSet<int> Dupicate = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!Dupicate.Contains(arr[i]))
                {
                    Dupicate.Add(arr[i]);
                }
                else
                    Console.WriteLine("Duplicate found: " + arr[i]);
            }


            Print(!true, Dupicate.ToArray());


        }


        public static void Valid_Anagram()
        {
            string s = "anagram";
            string t = "nagaram";

            if (s.Length != t.Length)
            {
                Console.WriteLine("strings Are Not Anagram");
                return;
            }

            Dictionary<char, int> ChcekAngram = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (ChcekAngram.ContainsKey(s[i]))
                {
                    ChcekAngram[s[i]]++;
                }
                else
                {
                    ChcekAngram.Add(s[i], 1);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!ChcekAngram.ContainsKey(t[i]))
                {
                    Console.WriteLine("Strings Are Not Anagram");
                    return;
                }
                ChcekAngram[t[i]]--;
            }

            bool allZero = ChcekAngram.Values.All(v => v == 0);

            if (allZero)
                Console.WriteLine("strings Are Angram");
            else
                Console.WriteLine("strings Are Not Angram");

        }


        public static void Two_Sum()
        {

            int[] arr = { 2, 7, 11, 15 };

            int target = 9;


            Dictionary<int, int> checkIndex = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int required = target - arr[i];

                if (checkIndex.ContainsKey(required))
                {
                    Console.WriteLine($"[{checkIndex[required]}, {i}]");
                    break;
                }
                checkIndex[arr[i]] = i;
            }
        }



        public static void FirstUniqueChar()
        {

            string str = "AKSHAY";


            Dictionary<char, int> Dict = new Dictionary<char, int>();


            for (int i = 0; i < str.Length; i++)
            {
                if (Dict.ContainsKey(str[i]))
                {
                    Dict[str[i]]++;
                }
                else
                {
                    Dict.Add(str[i], 1);
                }
            }


            foreach (var item in Dict)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine($"This Is Unique Character {item.Key}, Index: {item.Value}");
                    break;
                }
            }




        }

        public static void GROUPANGRAM()
        {
            string[] arr = { "eat", "tea", "tan", "ate", "nat", "bat" };


            // Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            Dictionary<string, string> groups = new Dictionary<string, string>();

            for (int i = 0; i < arr.Length; i++)
            {
                char[] sort = arr[i].ToCharArray();

                Array.Sort(sort);
                string key = new string(sort);

                if (!groups.ContainsKey(key))
                {
                    //groups[key] = new List<string>();
                    groups[key] = "";
                }

                //groups[key].Add(arr[i]);
                groups[key] += arr[i] + ",";
            }
            //foreach (var group in groups)
            //{
            //    Console.WriteLine(
            //        "[" + string.Join(", ", group.Value) + "]"
            //    );
            //}

            foreach (var item in groups)
            {
                var items = item;

                Console.WriteLine(items.Value.Replace(',', ' '));
            }
        }


        public static void LONGESTCONSECUTIVE()
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            HashSet<int> SET = new HashSet<int>(arr);
            int longest = 0;



            foreach (int num in SET)
            {
                if (!SET.Contains(num - 1))
                {
                    int current = num;
                    int lenthg = 1;


                    while (SET.Contains(current + 1))
                    {
                        current++;
                        lenthg++;

                    }

                    longest = Math.Max(longest, lenthg);
                }


            }

            Console.WriteLine(longest);


        }




        public static void Top_K_Frequent_Elements()
        {
            int[] arr = { 1, 2, 2, 3, 3, 4, 3, 4, 4 };
            int k = 2;

            Dictionary<int, int> myDict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {

                if (myDict.ContainsKey(arr[i]))
                {
                    myDict[arr[i]]++;
                }
                else
                {
                    myDict.Add(arr[i], 1);
                }
            }

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            foreach (var item in myDict)
            {
                pq.Enqueue(item.Key, item.Value);

                if (pq.Count > k)
                {
                    pq.Dequeue();
                }

            }
            List<int> result = new List<int>();


            while (pq.Count > 0)
            {
                result.Add(pq.Dequeue());
            }
            result.Reverse();

            Console.WriteLine("Top K Frequent Elements:");

            foreach (var item in result)
            {


                Console.WriteLine($"Element: {item}");

            }
        }




        public static void Subarray_Sum_Equals_K()
        {
            int[] arr = { 1, 2, 3 };
            int k = 3;

            Dictionary<int, int> prefix =
                new Dictionary<int, int>();

            // Empty prefix sum
            prefix[0] = 1;

            int prefixSum = 0;
            int count = 0;

            foreach (int num in arr)
            {
                // Step 1: Add current number
                prefixSum += num;

                // Step 2: Find required prefix
                int required = prefixSum - k;

                // Step 3: Check if required prefix exists
                if (prefix.ContainsKey(required))
                {
                    count += prefix[required];
                }

                // Step 4: Store/update current prefix sum
                if (prefix.ContainsKey(prefixSum))
                {
                    prefix[prefixSum]++;
                }
                else
                {
                    prefix[prefixSum] = 1;
                }
            }

            Console.WriteLine("Number of Subarrays: " + count);
        }

        public static void Longest_Substring_Without_Repeating_Characters()
        {

            char[] str = "abcabcbb".ToCharArray();// , bbbbb,pwwkew

            HashSet<char> set = new HashSet<char>();

            int left = 0;
            int maxLen = 0;
            for (int right = 0; right < str.Length; right++)
            {
                while (set.Contains(str[right]))
                {
                    set.Remove(str[left]);
                    left++;
                }


                set.Add(str[right]);

                maxLen = Math.Max(maxLen, right - left + 1);

            }
            Console.WriteLine($" Longest Substring Without Repeating Characters: {maxLen}");
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
