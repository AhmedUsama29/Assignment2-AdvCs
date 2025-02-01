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
    
    
    
    }
}
