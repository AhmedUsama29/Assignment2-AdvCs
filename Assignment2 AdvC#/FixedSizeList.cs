using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_AdvC_
{
    internal class FixedSizeList<T>
    {
        private int Capacity;
        private T[] items;
        private int count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero");
            }

            Capacity = capacity;
            items = new T[capacity];
            count = 0;
        }

        public void add(T item)
        {
            if (count < Capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {
                throw new IndexOutOfRangeException("List is full");
            }
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Capacity)
                throw new IndexOutOfRangeException("There is no index like you inserted");

            return items[index];
        }

    }
}
