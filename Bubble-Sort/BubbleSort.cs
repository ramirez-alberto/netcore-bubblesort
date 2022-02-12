using System;

namespace Bubble_Sort
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 4, 3, 78, 2, 0, 2 };
            BubbleSort bubble_sort = new BubbleSort();
            foreach (var item in bubble_sort.Bubble_Sort(array))
            {
                Console.WriteLine(item);
            }

        }
    }

    class BubbleSort
    {
        public int[] Bubble_Sort(int[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int newn = 0;
                for (int i = 1; i <= n - 1; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        (array[i - 1], array[i]) = (array[i], array[i - 1]);
                        newn = i;
                    }
                }
                n = newn;
            }
            return array;
        }
    }
}
