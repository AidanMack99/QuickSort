using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {

            string input1;
            
            List<int> myInts = new List<int>();

            Console.WriteLine("Enter number of elements to be sorted(maximum of 10)");
            input1 = Console.ReadLine();
            int nElements = Convert.ToInt32(input1);

            //Elements added to List (myInts)
            int i;
            for (i = 1; i <= nElements; i++)
            {
                Console.WriteLine("Element" + i + " = ");
                myInts.Add(Convert.ToInt32(Console.ReadLine()));
            }

            
            //contents of list into array for printing and sorting
            var array = myInts.ToArray();

            //Print elements in inputted order
            Console.Write("Elements in inputted order: ");
            for (i= 0;i<=nElements-1;i++)
            {
                Console.Write(array[i]+ " ");
            }

            Console.WriteLine("\n");

            //print elements in sorted order
            Console.Write("Elements in sorted order: ");
            
            for (i = 0; i <= nElements-1; i++)
            {
                QuickSortDD2(array, 0, array.Length - 1);
                Console.Write(" {0} ", array[i]);
            }


                Console.ReadKey();
        }


       
        static void swap<T>(ref T x, ref T y)
        {

            //swapcount++;
            T temp = x;
            x = y;
            y = temp;
        }



        static void QuickSortDD2<T>(T[] items, int left, int right) where T : IComparable
        {
            int i, j;
            i = left; j = right;
            IComparable pivot = items[left];

            while (i <= j)
            {
                //for (; (items[i] < pivot) && (i < right); i++) ;
                //for (; (pivot < items[j]) && (j > left); j--) ;
                for (; (items[i].CompareTo(pivot) < 0) && (i.CompareTo(right) < 0); i++) ;
                for (; (pivot.CompareTo(items[j]) < 0) && (j.CompareTo(left) > 0); j--) ;

                if (i <= j)
                    swap(ref items[i++], ref items[j--]);
            }

            if (left < j) QuickSortDD2<T>(items, left, j);
            if (i < right) QuickSortDD2<T>(items, i, right);
        }

       
    }
}
