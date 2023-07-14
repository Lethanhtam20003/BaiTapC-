using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace C_
{
    internal class Algorithm
    {
        public Algorithm() { }  

        public int[] SelectionSort(int[] arr)
        {
            int[] result = new int[arr.Length]; 
            int _minValue ;  
            int _index ;

            for(int i = 0; i < arr.Length; i++)
            {
                _minValue = arr[i];
                _index = i;
                for(int j = i; j < arr.Length; j++)
                {
                    if (_minValue < arr[i])
                    {
                        _minValue = arr[j];
                        _index= j;
                    }
                }
                swap(arr,_index,i);

            }

            return result;
        }

        private void swap(int[] arr, int m, int i)
        {
            int temp = arr[m];
            arr[m] = arr[i];
            arr[i] = temp;

        }
    }

    [TestFixture]
    class test
    {
        Algorithm a;
        int[] arr;
        int[] result;
        [SetUp]
        public void SetUp()
        {
            a = new Algorithm();
            arr = new int[] { 12, 5, 7, 4, 4, 9, 1, 0, 14, 78 };
            result = new int[] { 0, 1, 4, 4, 5, 7, 9, 12, 14, 78 };
        }

        [Test]  
        public void Sort()
        {
            Assert.Equals(a.SelectionSort(arr), result);
        }
                

    }
}
