using System;

namespace sumN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tinh sum N");
            SumN cls = new SumN();// Declare instant of class
            cls.SumNInt();
            Console.ReadKey();
        }
    }
}
