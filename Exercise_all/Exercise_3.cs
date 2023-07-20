using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeTutoriol
{
    internal class Exercise_3
    {

        // Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực
        public int Exercise122(int[] arr)
        {
            int result;
            if (arr.Length == 0)
            {
                result = -1;
            }
            result = arr[0];
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                if (result < arr[i])
                {
                    result = arr[i];
                }
            }

            return result;

        }

        // Bài 123: Viết hàm tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số nguyên
        public int Exercise123(int[] arr)
        {
            int result;
            if (arr.Length == 0)
            {
                result = -1;
            }
            result = arr[0];
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                if (result > arr[i])
                {
                    result = i;
                }
            }

            return result;

        }

        //Bài 124: Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị chẵn nhỏ hơn 2004 hay không
        public bool Exercise124(int[] arr)
        {
            bool result = false;
            foreach (int i in arr)
            {
                if (i < 2004 || i % 2 == 0)
                {
                    return result = true;
                }
            }

            return result;
        }

        //Bài 125: Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng
        public int Exercise125(int[] arr)
        {
            int result = 0;
            foreach (int i in arr)
            {
                if (i < 100)
                {
                    if (isPrime(i))
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        // kiểm tra có phải số nguyên tố hay ko 
        public Boolean isPrime(int n)
        {

            if (n <= 2)
            {
                return false;
            }

            int count = 1;
            for (int j = 3; j < n; j++)
            {
                if (n % j == 0)
                {
                    count++;
                }
            }
            if (count == 1)
            {
                return true;
            }

            return false;
        }

        // Bài 126: Viết hàm tính tổng các giá trị âm trong mảng 1 chiều 
        public int Exercise126(int[] arr)
        {
            int result = 0;
            foreach (int i in arr)
            {
                if (i < 0)
                {
                    result += i;
                }
            }

            return result;
        }

        //  Bài 127: Viết hàm sắp xếp mảng 1 chiều các số  tăng dần
        public int[] Exercise127(int[] arr)
        {
            int length = arr.Length;
            int minValue = arr[0];
            int minindex = 0, replaceindex = 0;
            for (int i = 0; i < length; i++)
            {
                replaceindex = i;
                for (int j = i; j < length; j++)
                {
                    if (minValue > arr[j])
                    {
                        minValue = arr[j];
                        minindex = j;
                    }
                }
                swap(arr, minindex, replaceindex);
            }
            return arr;
        }

        // đổi vị trí 
        private void swap(int[] arr, int minindex, int replaceindex)
        {
            int temp = arr[minindex];
            arr[minindex] = arr[replaceindex];
            arr[replaceindex] = temp;

        }

        // mã hóa chuổi 
        // khoảng cách từ ký tự tới 'a' là khoản cách từ ký tự cũ đên ký tự mới 
        // bảng chữ cái tạo thành vồng lặp  a -> z rồi vồng lại a 
        public string encryption(String encryption)
        {
            String result = "";
            foreach (char c in encryption)
            {
                int distance = c - 'a';
                if (c + distance > 122)
                {
                    distance = 25 - distance;
                }
                int newChar = c + distance;

                char a = (char)newChar;

                result = result + a;

            }

            return result;
        }


    }
}
