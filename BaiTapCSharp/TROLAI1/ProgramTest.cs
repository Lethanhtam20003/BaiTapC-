using cacPhepThu;
using System;
namespace TROLAI1
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            trolai:
            Console.WriteLine(" CHUONG TRINH GIAI CAC MA TRAN \n \n");
            Console.WriteLine("Bai Toan 1 : hinh thanh 1 ma tran \n");
            Console.WriteLine("BAi Toan 2 : so Sanh Ma Tran");
            Console.WriteLine("Bai Toan 3 : Nhan Hai Ma Tran");
            Console.WriteLine("*********************************************************************************************************");

            Console.Write(" hay chon bai toan va ma tran ma ban muon : ");
            var baitoan1 = Console.ReadLine();
            int baitoan = int.Parse(baitoan1);
            ThuatToanTest cls = new ThuatToanTest();
            //if (baitoan.Equals("1"))
            //{
            //    cls.VeMaTran();
            //    goto trolai;
            //}
            //else if (baitoan.Equals("2"))
            //{
            //    cls.SoSanhMaTran();
            //    goto trolai;
            //}
            //else if (baitoan.Equals("3"))
            //{
            //    cls.NhanHaiMatran();
            //    goto trolai;
            //}
            //else
            //{
            //    Console.WriteLine("nhap sai du lieu ");
            //    Console.ReadLine();
            //    return;
            //}
            switch(baitoan)
            {
                case 1:
                    cls.VeMaTran();
                    break;
                case 2:
                    cls.sosanhmatran();
                    break;
                case 3:
                    cls.NhanHaiMatran();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}