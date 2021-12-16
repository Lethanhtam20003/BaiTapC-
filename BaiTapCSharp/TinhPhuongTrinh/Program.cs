using System;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            baitoan:
            Console.WriteLine("----- Menu ---------");
            Console.WriteLine("1.Giai pt bac 1");
            Console.WriteLine("2.Giai pt bac 2");
            Console.WriteLine("3.giai pt bac 3");

            Console.Write("Hay chon bai toan: ");            
            var baitoan = Console.ReadLine();
            if (baitoan.Equals("1"))
            {
                TinhPtBac1 cls = new TinhPtBac1();
                cls.GiaiPtBac1(1, -2);
                goto baitoan;
            }
            else if (baitoan.Equals("2"))
            {

            }
            else if (baitoan.Equals("3"))
            {

            }
            Console.ReadKey();
        }
    }
}
