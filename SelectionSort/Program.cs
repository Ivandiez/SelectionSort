using System;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 6, 2, 10 };
            Console.WriteLine(SelectionSort(arr));
            Console.ReadKey();
        }

        static int findSmallest(int[] arr)
        {
            int smallest = arr[0];
            int smallest_index = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallest_index = i;
                }
            }
            return smallest_index;
        }

        static int[] SelectionSort(int[] arr)
        {
            int smallest = 0;
            int[] newArr = new int[] { };
            for (int i = 1; i < arr.Length; i++)
            {
                smallest = findSmallest(arr);
                newArr.Append(arr.Min(smallest));
            }
            return newArr;
        }
    }
}
