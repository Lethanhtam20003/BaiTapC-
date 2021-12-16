using System;

/// <summary>
/// Refer: https://nguyenvanhieu.vn/1000-bai-tap-lap-trinh-c-cua-thay-khang/#de-bai-1000-bai-tap-lap-trinh-cua-thay-khang
/// </summary>
namespace LuuDoThuatToan
{
    /// <summary>
    /// Nhung bai toan ve luu do thuat toan
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        #region MENU
        baitoan:
            Console.ReadKey();
            Console.WriteLine("*****************************************");
            Console.WriteLine("********------- Menu ---------***********");
            Console.WriteLine("****  1. Tinh Sum n So Phan Tu       ****");
            Console.WriteLine("****  2. Tinh Sum Binh phuong        ****");
            Console.WriteLine("****  3. Tinh Sum Phan So            ****");
            Console.WriteLine("****  4. Tinh SumPhan So Binh Phuong ****");
            Console.WriteLine("****  5. Sum Cua 1 Phan N+1          ****");
            Console.WriteLine("****  6. Sum Cua 1 Phan N(N+1)       ****");
            Console.WriteLine("****  7. Sum Cua n Phan N+1          ****");
            Console.WriteLine("****  8. Sum Cua 2N+2 Phan 2N+1      ****");
            Console.WriteLine("****  0. Chuyen Sang Bai Toan 2      ****");
            Console.WriteLine("****  Q. Thoat Khoi Bai Toan         ****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("");
            #endregion

        #region contruction 
            Console.Write("Hay chon bai toan: ");
            var baitoan = Console.ReadLine();
            ThuatToan cls = new ThuatToan();// Declare instant of class
            if (baitoan.Equals("1"))
            {
                cls.TinhSumN();
                goto baitoan;
            }
            else if (baitoan.Equals("2"))
            {
                cls.TinhSumBinhPhuong();
                goto baitoan;
            }
            else if (baitoan.Equals("3"))
            {
                cls.SumPhanSo();
                goto baitoan;
            }
            else if (baitoan.Equals("4"))
            {
                cls.SumPhanSoBinhPhuong();
                goto baitoan;
            }
            else if (baitoan.Equals("5"))
            {
                cls.SumBai5();
                goto baitoan;
            }
            else if (baitoan.Equals("6"))
            {
                cls.SumBai6();
                goto baitoan;
            }
            else if (baitoan.Equals("7"))
            {
                cls.SumBai7();
                goto baitoan;
            }
            else if (baitoan.Equals("8"))
            {
                cls.SumBai8();
                goto baitoan;
            }
            else if (baitoan.Equals("0"))
            {
                goto baitoan2;
            }
            else if(baitoan.ToLower().Equals("q"))
            {
                return;
            }
        #endregion

        #region leson2
        baitoan2:
                Console.WriteLine("\n\n MENU Bai Toan 2 ( Bai Toan Phep nhan )\n");
                Console.WriteLine("***********************************************");
                Console.WriteLine("***   1. Tính T(n) = 1 x 2 x 3…x N          ***");
                Console.WriteLine("***   2. Tính T(n) = x^n                    ***");
                Console.WriteLine("***   0. qua trang tiep theo                ***");
                Console.WriteLine("***********************************************\n\n");

            nhaplai:
                Console.Write(" please enter the data :");
                var baitoan2 = Console.ReadLine();
                ThuatToan2 cls1 = new ThuatToan2();
            if (baitoan2.Equals("1"))
            {
                cls1.bai9();
                goto baitoan;
            }
            else if (baitoan2.Equals("2"))
            {
                cls1.bai10();
                goto baitoan;
            }
            else if (baitoan2.Equals("3"))
            {
                cls1.bai11();
                goto baitoan;
            }
            else if (baitoan2.Equals("4"))
            {
                cls1.bai12();
                goto baitoan;
            }
            else if (baitoan2.Equals("5"))
            {
                cls1.bai13();
                goto baitoan;
            }
            else if (baitoan2.Equals("6"))
            {
                cls1.bai14();
                goto baitoan;
            }
            else if (baitoan2.Equals("0"))
            {
                goto leson3;
            }
            else
            {
                Console.WriteLine(" you entered the wrong data !");
                Console.WriteLine(" Please re-enter the data ! ");
                goto nhaplai;
            }
            #endregion

        #region leson3
                leson3:
            Console.WriteLine("\n\n MENU Bai Toan 2 ( Bai Toan Phep nhan )\n");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("***   1. Tính Liệt kê tất cả các “ước số” của số nguyên dương n          ***");
            Console.WriteLine("***   2. Tính                                                            ***");
            Console.WriteLine("****************************************************************************\n\n");
            Console.Write(" Moi Ban Chon Bai Toan : ");
            var baitoan3 = Console.ReadLine();
            ThuatToan3 cls3 = new ThuatToan3();
            int the;
            the = int.Parse(baitoan3);
            switch ( the)
            {
                case 1 :
                    {
                        cls3.bai20();
                        goto baitoan;
                    }
                    break;
                case 2:
                    {
                        cls3.bai20();
                        goto baitoan;
                    }
            }

            #endregion

        }
    }
}
