using System;
using MatrixProgram;

namespace MatrixProgram
{
    class ProgramMaTran
    {
        static void Main(string[] args)
        {
            ThuatToanMaTran cls = new ThuatToanMaTran();
            cls.Exercise132_133();
            Console.ReadKey();
        }
    }
}
            #region corner text
            //nhaplai:
            //    Console.WriteLine("Hello World! Hello World! Hello World! Hello World!");
            //    Console.WriteLine("1. tao ma tran bat ky");
            //    Console.WriteLine("2. so sanh 2 ma tran");
            //    Console.WriteLine("3. nhan hai ma tran");
            //    Console.WriteLine("Hello World!");
            //    Console.WriteLine("Hello World!");
            //    Console.WriteLine("Hello World! Hello World! Hello World! Hello World!\n");


            //    Console.Write("Hay Nhap Bai Toan :");
            //    string nhapbaitoan = Console.ReadLine();
            //    int baitoan = int.Parse(nhapbaitoan);
            //    if (int.TryParse(nhapbaitoan,out baitoan)==false)
            //    {
            //        Console.WriteLine(" nhap sai du lieu !");
            //        goto nhaplai;
            //    }
            //    else
            //    {
            //        ThuatToanMaTran cls = new ThuatToanMaTran();
            //        switch (baitoan)
            //        {
            //            case 1:
            //                cls.SuDungMaTran();

            //                break;
            //            case 2:
            //                cls.sosanhmatran();
            //                break;
            //            case 3:
            //                cls.nhanhaimatran();
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            #endregion
