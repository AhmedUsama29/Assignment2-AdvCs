using System.Collections;

namespace Assignment2_AdvC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //ArrayList nums = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //ArrayList reversed = Reverse(nums);

            //foreach (int n in reversed)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region Q2 : You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //List<int> evenNumbers = GetEvenNumbers(nums);

            //foreach (int n in evenNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region Q3 : implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.

            //FixedSizeList<int> list = new FixedSizeList<int>(3);

            //list.add(11);
            //list.add(22);
            //list.add(33);
            ////list.add(4); // throws an exception

            //Console.WriteLine(list.Get(0));
            //Console.WriteLine(list.Get(1));
            //Console.WriteLine(list.Get(2));

            ////Console.WriteLine(list.Get(3)); // throws an exception

            #endregion

            #region Q4 : Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1

            //string word = "testing this new feature";

            //int index = GetFirstNotRepeatedCharIndex(word);

            //Console.WriteLine(index);

            #endregion

            #region Q5 : Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            //Console.WriteLine("Number of queries is: ");

            //int Q = int.Parse(Console.ReadLine());

            //int[] Queries = new int[Q];

            //for (int i = 0; i < Q ; i++)
            //{
            //    Console.WriteLine("Enter the query number " + (i + 1));
            //    Queries[i] = int.Parse(Console.ReadLine());
            //}


            //foreach (int x in Queries)
            //{
            //    int count = 0;
            //    foreach (int num in arr)
            //    {
            //        if (num > x) count++;
            //    }
            //    Console.WriteLine(count);
            //}

            #endregion

            #region Q6 : Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //int[] array = { 1, 2, 3, 2, 1 };
            //int[] array2 = { 1, 2, 3, 4, 5 };
            //int[] array3 = { 5 };

            //Console.WriteLine(IsPalindrome(array));     //true
            //Console.WriteLine(IsPalindrome(array2));    //false
            //Console.WriteLine(IsPalindrome(array3));    //true

            #endregion

            #region Q7 : Given an array, implement a function to remove duplicate elements from an array.

            //int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6 };

            //foreach (int num in RemoveDuplicates(array))
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

        }

        #region Q1 : You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
        public static ArrayList Reverse(ArrayList list)
        {
            ArrayList reversedList = new ArrayList();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                reversedList.Add(list[i]);
            }
            return reversedList;
        }
        #endregion

        #region Q2 : You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    evenNumbers.Add(n);
                }
            }
            return evenNumbers;
        }

        #endregion

        #region Q4 : Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1

        //i don't know the dictionary yet
        public static int GetFirstNotRepeatedCharIndex(string word) {

            int[] charCount = new int[999];

            foreach (char c in word)
            {
                charCount[c]++;
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (charCount[word[i]] == 1)
                    return i;
            }

            return -1; //no char is repeated

        }
        #endregion

        #region Q5 : Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

        public int CountNumbersGreaterThanX(int[] array, int X)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num > X)
                {
                    count++;
                }
            }
            return count;
        }

        #endregion

        #region Q6 : Given a number N and an array of N numbers. Determine if it's palindrome or not.

        public static bool IsPalindrome(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                    return false;
            }
            return true;
        }

        #endregion

        #region Q7 : Given an array, implement a function to remove duplicate elements from an array.

        public static int[] RemoveDuplicates(int[] array)
        {
            int[] NewArr = (int[]) array.Clone();
            Array.Sort(NewArr);

            List<int> uniqueValues = new List<int>() { NewArr[0] };

            for (int i = 1; i < NewArr.Length; i++)
            {
                if (NewArr[i] != NewArr[i - 1])
                {
                    uniqueValues.Add(NewArr[i]);
                }
            }

            return uniqueValues.ToArray();
        }

        #endregion
    }
}
