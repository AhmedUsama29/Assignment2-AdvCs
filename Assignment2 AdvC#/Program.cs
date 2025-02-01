using System.Collections;

namespace Assignment2_AdvC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            ArrayList nums = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ArrayList reversed = Reverse(nums);

            foreach (int n in reversed)
            {
                Console.WriteLine(n);
            }

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

    }
}
