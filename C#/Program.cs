using System;
using System.ComponentModel.DataAnnotations;

namespace c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            char[] chars = pro.converStringToArrayChar("ahihi");
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
        }

        char[] converStringToArrayChar(String srt)
        {
            char[] result = new char[srt.Length];
            for (int i = 0;i<result.Length;i++) 
            {
                result[i] = srt[i];
            }
            return result;
        }


    }
     
}