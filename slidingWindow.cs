using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class slidingWindow
    {

        public static void MaxSumOfSubarray()//Maximum Average Subarray I
        {
            int[] arr = [3, -435, 335, 10, -50, 100, 20];
            int size = 3;///it ia  a window

            int Sum = 0;

            for (int i = 0; i < size; i++)
            {
                Sum += arr[i];
            }


            int Max = Sum;

            for (int i = size; i < arr.Length; i++)
            {
                Sum = (Sum + arr[i]) - arr[i - size];


                if (Sum >= Max)
                {
                    Max = Sum;
                }
            }

            Console.WriteLine($"Maximum Sum of Subarray: {Max}");
            Console.WriteLine($"Maximum Average of Subarray: {Max / size}");
        }



        public static void Minimum_Size_Subarray_Sum()
        {
            int[] arr = [1, 2, 3, 4, 5];// [2, 3, 1, 2, 4, 3]
            int target = 11;//7

            int sum = 0;
            int left = 0;
            int right = 0;

            int min = int.MaxValue; ;
            for (right = 0; right < arr.Length; right++)
            {
                sum += arr[right];////Sum target पेक्षा कमी असेल → Right वाढवा

                while (sum >= target)//हीच Variable Sliding Window ची मुख्य idea आहे.
                {

                    min = Math.Min(min, right - left + 1);

                    sum -= arr[left];
                    left++;//Sum target पेक्षा जास्त/समान असेल → Left वाढवा

                }

            }
            Console.WriteLine($"Minmum Sum of Subarray: {min}");

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




        public static void Longest_Substring_with_At_Most_K_Distinct_Characters()
        {
            char[] str = "eceba".ToCharArray();//eceba
            int k = 2;
            Dictionary<char, int> map = new Dictionary<char, int>();
            int maxLen = 0;

            int left = 0;

            for (int right = 0; right < str.Length; right++)
            {
                char c = str[right];

                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map.Add(c, 1);
                }


                while (map.Count > k)
                {
                    map[c]--;

                    if (map[c] == 0)
                    {
                        map.Remove(c);

                    }
                    left++;
                }


                maxLen = Math.Max(maxLen, right - left + 1);

            }
            Console.WriteLine($"Longest Substring with At Most K Distinct Characters: {maxLen}");

        }

        public static void Longest_Repeating_Character_Replacement()
        {
            char[] str = "AABABBA".ToCharArray();//eceba
            int k = 1;
            Dictionary<char, int> map = new Dictionary<char, int>();
            int maxLen = 0;
            int maxFreq = 0;
            int left = 0;

            for (int right = 0; right < str.Length; right++)
            {
                char c = str[right];

                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map.Add(c, 1);
                }

                maxFreq = Math.Max(maxFreq, map[c]);
                while (right - left + 1 - maxFreq > k)
                {
                    map[str[left]]--;


                    left++;
                }


                maxLen = Math.Max(maxLen, right - left + 1);

            }
            Console.WriteLine($"Longest Substring with At Most K Distinct Characters: {maxLen}");
        }


        public static void Combantion()
        {
            Console.WriteLine(Permutation_in_String1());
        }








        public static bool Permutation_in_String1()
        {
            string s1 = "abc";//"mn"//"ab"
            string s2 = "cbaebabacd";//"xvnmbc"//"eidbaooo"

            if (s1.Length > s2.Length) return false;

            int[] str1 = new int[26];

            int[] windowCheck = new int[26];


            for (int i = 0; i < s1.Length; i++)
            {
                str1[s1[i] - 'a']++;
            }


            for (int i = 0; i < s1.Length; i++)
            {
                windowCheck[s2[i] - 'a']++;
            }

            if (AreSame(str1, windowCheck)) return true;


            for (int right = s1.Length; right < s2.Length; right++)
            {

                windowCheck[s2[right] - 'a']++;//   Add new character

                int left = right - s1.Length;

                windowCheck[s2[left] - 'a']--;// Remove old character


                if (AreSame(str1, windowCheck)) return true;
            }






            return false;
        }


        public static void Find_All_Anagrams_in_a_String()
        {
            string s1 = "abc";//"mn"//"ab"
            string s2 = "cbaebabacd";//"xvnmbc"//"eidbaooo"

            StringBuilder sb = new StringBuilder();


            if (s1.Length > s2.Length) return;

            int[] str1 = new int[26];

            int[] windowCheck = new int[26];


            for (int i = 0; i < s1.Length; i++)
            {
                str1[s1[i] - 'a']++;
            }


            int left = 0;


            for (int right = 0; right < s2.Length; right++)
            {

                windowCheck[s2[right] - 'a']++;//   Add new character



                if (right - left + 1 > s1.Length)
                {
                    windowCheck[s2[left] - 'a']--;
                    left++;
                }



                // Check current window
                if (right - left + 1 == s1.Length)
                {
                    if (AreSame(str1, windowCheck))
                    {
                        sb.Append(left + ",");
                    }
                }


            }

            Console.WriteLine(sb.ToString());
        }

        public static bool AreSame(int[] a, int[] b)
        {
            for (int i = 0; i < 26; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }




        public static void MinimumWindowSubstring()
        {
            string s = "ADOBECODEBANC";
            string t = "ABC";

            int left = 0;

            int minLength = int.MaxValue;
            int minStart = 0;


            Dictionary<char, int> required = new Dictionary<char, int>();


            foreach (var item in t)
            {
                if (required.ContainsKey(item))
                {
                    required[item]++;
                }
                else
                    required.Add(item, 1);
            }


            int fromed = 0;

            Dictionary<char, int> Window = new Dictionary<char, int>();

            for (int right = 0; right < s.Length; right++)
            {
                //"ADOBECODEBANC";
                char current = s[right];

                if (Window.ContainsKey(current))
                {
                    Window[current]++;
                }
                else
                {
                    Window.Add(current, 1);
                }

                if (required.ContainsKey(current) && Window[current] == required[current])
                {
                    fromed++;
                }


                while (fromed == required.Count)    // Try to make window smaller
                {
                    int currentLentgh = right - left + 1;

                    if (currentLentgh < minLength)  // Save minimum window
                    {
                        minLength = currentLentgh;
                        minStart = left;
                    }


                    Window[s[left]]--;    // Remove left character

                    if (required.ContainsKey(s[left]) && Window[s[left]] < required[s[left]])
                    {
                        fromed--;
                    }
                    left++;
                }



            }



            Console.WriteLine(s.Substring(minStart, minLength));


        }



        public static void FruitInBasket()
        {
            int[] fruits = { 1, 2, 3, 2, 2 };

            Dictionary<int, int> count = new Dictionary<int, int>();

            int left = 0;
            int maxLength = 0;



            for (int right = 0; right < fruits.Length; right++)
            {

                if (count.ContainsKey(fruits[right]))
                {
                    count[fruits[right]]++;
                }
                else
                {
                    count.Add(fruits[right], 1);
                    // count[fruits[right]] = 1;
                }


                while (count.Count > 2)//More than 2 different fruits
                {
                    count[fruits[left]]--;


                    if (count[fruits[left]] == 0)  // If fruit count becomes 0, remove it
                    {
                        count.Remove(fruits[left]);
                    }
                    left++;
                }


                maxLength = Math.Max(maxLength, right - left + 1);

            }



            Console.WriteLine(maxLength);
        }

    }
}
