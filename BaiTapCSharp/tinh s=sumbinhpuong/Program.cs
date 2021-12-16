using System;

namespace ChuongTrinhGiaiToan
{
    class Program
    {
        static void Main(string[] args)
        {
        dangbai:

            Console.ReadKey();
            Console.WriteLine(" CHUONG TRINH GIAI CAC DANG BAI TOAN \n");
            Console.WriteLine("*******************************");
            Console.WriteLine("*            MENU             *");       
            Console.WriteLine("*      1. Toan So             *");
            Console.WriteLine("*      2. Toan Hinh           *");
            Console.WriteLine("*                             *");
            Console.WriteLine("*******************************");
            Console.WriteLine("");
            Console.Write(" Moi Ban Chon Dang Bai Toan : ");
            var dangbai = Console.ReadLine();
            Console.WriteLine("");

            if (dangbai.Equals("1"))
            {
                baitoanso:
                Console.WriteLine(" Ban Da Chon Dang Bai Toan So {1} ",dangbai);
                Console.WriteLine("");
                Console.WriteLine("*******************************");
                Console.WriteLine("*            MENU             *");
                Console.WriteLine("*      1.  Tinh tong          *");
                Console.WriteLine("*      2.  Tinh Tich          *");
                Console.WriteLine("*                             *");
                Console.WriteLine("*******************************");
                Console.WriteLine("");
                Console.Write(" Moi Ban Chon Dang  Bai Toan : ");
                var baitoanso = Console.ReadLine();
                Console.WriteLine("");
                CacPhepTinh.ToanSo cls = new CacPhepTinh.ToanSo();
                if(baitoanso.Equals("1"))
                {
                    cls.TinhTong();
                    goto dangbai;
                }
                else if (baitoanso.Equals("2"))
                {
                    cls.TinhTich();
                    goto dangbai;
                }
                {
                    Console.WriteLine(" Ban Da nhap Du Lieu Sai !" +
                        "Vui Long nhap lai ");
                    goto baitoanso;
                }
            }
            else if (dangbai.Equals("2"))
            {
                baitoanhinh:
                Console.WriteLine(" Ban Da Chon Dang Bai Toan hinh  ");
                Console.WriteLine("");
                Console.WriteLine("*******************************");
                Console.WriteLine("*            MENU             *");
                Console.WriteLine("*      1.  Hinh Vuong         *");
                Console.WriteLine("*      2.  Hinh Chu Nhat      *");
                Console.WriteLine("*                             *");
                Console.WriteLine("*******************************");
                Console.WriteLine("");
                Console.Write(" Moi Ban Chon  Bai Toan : ");
                var baitoanhinh = Console.ReadLine();
                Console.WriteLine("");
                CacPhepTinh.ToanHinh cls = new CacPhepTinh.ToanHinh();
                if (baitoanhinh.Equals("1"))
                {
                    cls.HinhVuong();
                    goto dangbai;
                }
                else if (baitoanhinh.Equals("2"))
                {
                    cls.HinhChuNhat();
                    goto dangbai;
                }
                {//wrong data input
                    Console.WriteLine(" Ban Da nhap Du Lieu Sai !" +
                        "Vui Long nhap lai ");
                    goto baitoanhinh;
                }

            }
            Console.ReadKey();
        }
    }
}
