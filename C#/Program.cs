using C_;
using System;
using System.ComponentModel.DataAnnotations;

namespace c
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Algorithm algorithm = new Algorithm();
            int[] arr = new int[] { 12, 5, 7, 4, 4, 9, 1, 0, 14, 78 };
            int[] result = new int[] { 0, 1, 4, 4, 5, 7, 9, 12, 14, 78 };
            int[] chek = algorithm.SelectionSort(arr);
            printArr(chek);
            printArr(result);
        }

        public static  void printArr(int[] result)
        {
          foreach (int i in result)
            {
                Console.Write(i+"   ");
            }
        }
    }
     
}