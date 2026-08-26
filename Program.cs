using DSA;

class Program
{
    public static void Main(string[] args)
    {
        BaiscPorgram();

        //AllArrayProgram();


        //PatternProgram();
        //Linked_List();
        //TWOPINTERARRAY();
        //SLIDINGWINDOWARRAY();
        //HASHPROBLEMS();
        //PRFIXSUM();
        //BINERYSERCH();
    }

    public void calucaltor()
    {
        Console.WriteLine("This is my caluclator functions !");
    }



    private static void PatternProgram()
    {
        Pattern.SAQUAREPATTERN();

        Pattern.RIGHTTRANINGLE();


        Pattern.INVERTEDTRAINGLE();


        Pattern.NUMBERTRAINGLE();

        Pattern.SAMENUMBERTRAINGLE();

        Pattern.FLOYDSTRINGLE();


        Pattern.ALPHABETTRAINGLE();
        Pattern.REVERSENUMBERTRAINGLE();

        Pattern.PYRAMID();
        Pattern.INVERTEDPYRMID();

        Pattern.DIMOND();
        Pattern.HOLLOWSQUARE();

        Pattern.HOLOWTRAINGLE();
        Pattern.HOLLOWPYRMID();

        Pattern.BUTTERFLYPATTERN();

        Pattern.CROSS();

        Pattern.CROESSPATTERN();
        Pattern.ZEROPATTERN();
        Pattern.DECSENGINNUMBERPATTERN();
        Pattern.CHARPATERN();
    }

    private static void BaiscPorgram()
    {
        Loop app = new Loop();

        Loop.swapnNumbers(5, 6);

        Loop.evenORodd(50);

        Loop.largestNumbers(100, 50, 30);

        Loop.numberCheck(0);
        Loop.FactrioalNumbers(10);
        Loop.MultiplcationTable(8);
        Loop.SumDigitNUmbers(123456789);

        Loop.RevreseNumber(1000);

        Loop.NumberISpelidrom(223);

        Loop.Fabnocciseries(10);


        Loop.PrimeNumbers(100);

        Loop.HigestCommonFactor(12, 18);

        Loop.LCM(24, 36);

        Loop.caluclatePower(8, 5);


        Loop.ResvrseString("ABCDE");


        Loop.stringPalidrom("abba");

        Loop.CountVovles("abc de");


        Loop.countWORDS("My Name IS.Akshay,My sirname is?Thigale!Hi");

        Loop.RemoveDuplicate("geeksforgeeks");

        Loop.StringAngrams();


        Loop.Ocuurance_firstNonRepetch_duplicate_unquie();


        Loop.permutations("ABC");

        Loop.LongestSubstringWitoutRepeatChar();

        Loop.LongesCommonPrefix();

        Loop.OneSTRrotaionToanother();
        Loop.compressString();

        Loop.RevrseWord();

        Loop.DistanceAprt();
        Loop.IndexOfstring();

        Loop.Brackets();

        Loop.StringToInt();



    }



    private static void AllArrayProgram()
    {
        BasicArray cl1 = new BasicArray();

        BasicArray.LargestElement();

        BasicArray.smallestElemtn();


        BasicArray.SecondLargeElemenet();


        BasicArray.RevresAray();


        BasicArray.arraySort();

        BasicArray.removeDplicates();

        BasicArray.mergeTwoaray();

        BasicArray.MinandMax();

        BasicArray.arrayLEFTpostion();

        BasicArray.rightRotaion();


        BasicArray.InsertElement();


        BasicArray.DeleteElement();

        BasicArray.LinerSerch();
        BasicArray.ARMSTRONGnumber();

        BasicArray.FreqArrayElement();


        BasicArray.MissingNumberArray();
        BasicArray.ElmentSumTarget();
        BasicArray.MovingZeroLast();


        BasicArray.maximumsubarraySum();////interView Question

        BasicArray.MajorityElements();////interView Question
        BasicArray.SubarraySum();////interView Question

        BasicArray.Os1s2sarraySort();////interView Question
        BasicArray.LEADERarray();////interView Question
        BasicArray.TrappingRainWater();////interView Question
        BasicArray.EquilibriumIndex();////interView Question
        BasicArray.MERGERINTERVALS();////interView Question

        BasicArray.Longestconsecutive();//interView Question
        BasicArray.MaxSubarray();//interView Question

        BasicArray.BinerySerch();

        BasicArray.prefixSum();


        //Pratice

        BasicArray.SelectionSort();
        BasicArray.InsertionSort();
        BasicArray.BubbleShort();

        BasicArray.MsortCall();
        BasicArray.QickCall();

        BasicArray.ThreeSum();
        BasicArray.WordsAndgram();
        BasicArray.proudctArrayELement();
        BasicArray.TopKFrequentELemtn();

        BasicArray.NumberOfISaland();
    }



    public static void Linked_List()
    {
        //linkedList._mainMethod();

        StudentData s = new StudentData();
        s.SetData();
    }



    public static void TWOPINTERARRAY()
    {
        TwoPointer.CheckPalindrom();
        TwoPointer.revString();
        TwoPointer.SQUAREFSORTARRAY();
        TwoPointer.PelindromeII();
        TwoPointer.removeDuplicates();
        TwoPointer.removeElement();
        TwoPointer.ZeroAtLast();
        TwoPointer.MergerSortArray();
        TwoPointer.Two_Sum_II();
        TwoPointer.Container_With_Most_Water();
        TwoPointer.Trapping_Rain_Water();
        TwoPointer._3Sum();
        TwoPointer.SORTCOLOURS();
        TwoPointer.Boats_to_Save_People();
    }


    public static void SLIDINGWINDOWARRAY()
    {
        slidingWindow.MaxSumOfSubarray();//Maximum Average Subarray I
        slidingWindow.Minimum_Size_Subarray_Sum();
        slidingWindow.Longest_Substring_Without_Repeating_Characters();
        slidingWindow.Longest_Substring_with_At_Most_K_Distinct_Characters();
        slidingWindow.Longest_Repeating_Character_Replacement();

        slidingWindow.Combantion();
        slidingWindow.Find_All_Anagrams_in_a_String();
        slidingWindow.MinimumWindowSubstring();
        slidingWindow.FruitInBasket();
    }


    public static void HASHPROBLEMS()
    {
        Hashing.ContainsDuplicates();
        Hashing.Valid_Anagram();
        Hashing.Two_Sum();

        Hashing.FirstUniqueChar();
        Hashing.GROUPANGRAM();
        Hashing.LONGESTCONSECUTIVE();
        Hashing.Top_K_Frequent_Elements();
        Hashing.Subarray_Sum_Equals_K();
        Hashing.Longest_Substring_Without_Repeating_Characters();
    }

    public static void PRFIXSUM()
    {
        PrefixSum.Running_Sum_of_1d_Array();
        PrefixSum.Range_Sum_Query_Immutable();
        PrefixSum.Find_Pivot_Index();
        PrefixSum.Subarray_Sum_Equals_K();
        PrefixSum.Contiguous_Array();
        PrefixSum.Subarray_Sums_Divisible_by_K();
        PrefixSum.Continuous_Subarray_Sum();
        PrefixSum.Product_of_Array_Except_Self();

    }




    public static void BINERYSERCH()
    {
        BinerySerch.Binary_Serch();
        BinerySerch.FirstBadVersion();
        BinerySerch.Search_Insert_Position();
        BinerySerch.Find_First_and_Last_Position_of_Elemen();
        BinerySerch.Search_in_Rotated_Sorted_Array();
        BinerySerch.Rotated_Sorted_Array_II();
        BinerySerch.Find_Minimum_in_Rotated_Sorted_Array();
        BinerySerch.FindPeakElement();
        BinerySerch.SingleNonDuplicate();
        BinerySerch.Sqrt();

        BinerySerch.Koko_Eating_Bananas();
        BinerySerch.Smallest_Divisor_Given_a_Threshold();


    }

}