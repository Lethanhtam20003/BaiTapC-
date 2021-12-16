using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuuDoThuatToan
{
    /// <summary>
    /// sum
    /// </summary>
    public class ThuatToan
    {
        /// <summary>
        /// Bài 1: Tính S(n) = 1 + 2 + 3 + … + n 
        /// </summary>
        public void TinhSumN()
        {
        // code here
        nhaplai:
            Console.WriteLine(" Ban Da Chon Bai Toan :\n Tính S(n) = 1 + 2 + 3 + … + n  ");
            string nhapn;
            int i = 1,n;
            long s = 0;
            Console.Write("Moi Ban Nhap So Phan Tu n :");
            nhapn = Console.ReadLine();
            //đổi gái trị
            n = int.Parse(nhapn);
            if ((int.TryParse(nhapn, out n)==false) && n > 0)
            {
                Console.WriteLine(" ban nhap sai du lieu! \n Vui long Nhap Lai!");
                goto nhaplai;
            }
            else
            {
                while (i <= n)
                {
                    s = s + i;
                    i++;
                }
                Console.WriteLine("******************************************************");
                Console.WriteLine("****                                              ****");
                Console.WriteLine("****Ket Qua Cua Tong {0} So Lien Tiep Là: {1}     ****", n, s);
                Console.WriteLine("****                                              ****");
                Console.WriteLine("******************************************************");
            }
        }

        /// <summary>
        /// Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2
        /// </summary>
        public void TinhSumBinhPhuong()
        {

            Console.WriteLine(" Ban Da Chon Bai Toan :\n tinh s= 1*1+2*2+3*3+...+n*n :");
            long sum = 0;
            int i = 1;
            string strn;
            nhaplai:
            Console.Write("Hay Nhap Phan Tu n : ");
            strn = Console.ReadLine();
            int n = int.Parse(strn);
            if (int.TryParse(strn, out n) == false && n > 0)
            {
                Console.WriteLine(" ban nhap sai du lieu! \n Vui long Nhap Lai!");
                goto nhaplai;
            }
            else
            {
                while (i <= n)
                {
                    sum = sum + (i * i);
                    i++;
                }
                Console.WriteLine("*************************************");
                Console.WriteLine("***Ket Qua Cua Bai Toan là s ={0} ***", sum);
                Console.WriteLine("*************************************");
            }
        }
        /// <summary>
        /// Bài 3: Tính S(n) = 1 + ½ + 1/3 + … + 1/n
        /// </summary>
        public void SumPhanSo()
        {
            Console.WriteLine("Tinh Tong tu 1 + ½ + 1/3 + … + 1/n");
                float s = 1f;
                int i = 1;
                string nhapn;
            Console.WriteLine(" ");
            Console.Write("Moi Ban Nhap So Phan Tu n : ");
                nhapn = Console.ReadLine();
            Console.WriteLine();
            int n = int.Parse(nhapn);
            while(n<=0)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("***Ket Qua Cua Phep Tinh la 0 *******");
                Console.WriteLine("*************************************");
                Console.WriteLine("                                     ");
                Console.WriteLine("                                     ");
            }
            while (i <= n)
            {
                s = (float)(s +  (1.0 / i));
                i++;
            }
            Console.WriteLine("*************************************");
            Console.WriteLine("***Ket Qua Cua Phep Tinh la {0} *****", s);
            Console.WriteLine("*************************************");
        }
        /// <summary>
        /// Bài 4: Tính S(n) = ½ + ¼ + … + 1/2n
        /// </summary>
        public void SumPhanSoBinhPhuong()
        {
            Console.WriteLine(" Tính tong cac so tu  ½ + ¼ + … + 1/2n ");
            float s;
            s = 1f;
            int i, n;
            i = 1;
            string nhapn;
            nhaplai:
            Console.WriteLine("");
            Console.Write("Moi Ban Nhap So Phan Tu N ");
            nhapn = Console.ReadLine();
            Console.WriteLine("");
            n = int.Parse(nhapn);
            if (int.TryParse(nhapn, out n) == false && n>0 )
            {
                Console.WriteLine(" ban nhap sai du lieu! \n Vui long Nhap Lai!");
                goto nhaplai;
            }
            else
            {
                while (i <= n)
                {
                    s = (float)(s + 1.0 / 2.0 * i);
                    i++;
                }
                Console.WriteLine("******************************************");
                Console.WriteLine("****  Ket Qua Cua Phep Tinh La : {0}  ****", s);
                Console.WriteLine("******************************************");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Bài 5: Tính S(n) = 1 + 1/3 + 1/5 + … + 1/(2n + 1)
        /// </summary>
        public void SumBai5()
        {
            Console.WriteLine("");
            Console.WriteLine("Tính Tong Tu 1 + 1/3 + 1/5 + … + 1/(2n + 1)");
            Console.WriteLine("");
            string nhapn;
            int n, i;
            float s;
            s = 1f;
            i = 1;
            Console.WriteLine("");
            Console.Write("Moi Ban Nhap So Phan Tu N ");
            nhapn = Console.ReadLine();
            Console.WriteLine("");
            n = int.Parse(nhapn);
            while ( i <= n )
            {
                s = (float)( s + 1.0 / (2.0  * i + 1.0));
                i++ ;
            }
            Console.WriteLine("******************************************");
            Console.WriteLine("****  Ket Qua Cua Phep Tinh La : {0}  ****", s);
            Console.WriteLine("******************************************");
            Console.WriteLine("");

        }
        /// <summary>
        /// Bài 6: Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)
        /// </summary>
        public void SumBai6()
        {
            Console.WriteLine("");
            Console.WriteLine("Tính S(n) = 1/1×2 + 1/2×3 +…+ 1/n x (n + 1)");
            Console.WriteLine("");
            string nhapn;
            int n, i;
            float s;
            s = 0f;
            i = 1;
            Console.WriteLine("");
            Console.Write("Moi Ban Nhap So Phan Tu N ");
            nhapn = Console.ReadLine();
            Console.WriteLine("");
            n = int.Parse(nhapn);
            while (i <= n)
            {
                s = (float)(s + 1.0 / (i * ( i + 1.0 )));
                i++;
            }
            Console.WriteLine("******************************************");
            Console.WriteLine("****  Ket Qua Cua Phep Tinh La : {0}  ****", s);
            Console.WriteLine("******************************************");
            Console.WriteLine("");

        }
        /// <summary>
        /// Bài 7: Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1
        /// </summary>
        public void SumBai7()
        {
            Console.WriteLine("");
            Console.WriteLine("Bai Toan Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1");
            Console.WriteLine("");

            int i, n;
            i = 1;
            float s = 0f;
            Console.WriteLine("Moi Ban Nhap So Phan Tu n : ");
            Console.WriteLine("");
            string nhapn;
            nhapn = Console.ReadLine();
            if (int.TryParse(nhapn, out n )==false)
            {
                Console.WriteLine("");
                Console.WriteLine("Du Lieu Ban Nhap Sai ");
                Console.WriteLine("------------------------------------------------------------------------------------" +
                    "" +
                    "");
            }
            else
            {
                while (i <= n)
                    {
                    s = (float)(s + (i / i + 1.0));
                    i++;
                }
                Console.WriteLine("******************************************");
                Console.WriteLine("****  Ket Qua Cua Phep Tinh La : {0}  ****", s);
                Console.WriteLine("******************************************");
                Console.WriteLine("");
            }

        }
        /// <summary>
        /// Bài 8: Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2
        /// </summary>
        public void SumBai8()
        {
            Console.WriteLine("");
            Console.WriteLine("Bai Toan Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2");
            Console.WriteLine("");

            int i, n;
            i = 1;
            float s = 0f;
            Console.WriteLine("Moi Ban Nhap So Phan Tu n : ");
            Console.WriteLine("");
            string nhapn;
            nhapn = Console.ReadLine();
            if (int.TryParse(nhapn, out n) == false)
            {
                Console.WriteLine("");
                Console.WriteLine("Du Lieu Ban Nhap Sai ");
                Console.WriteLine("------------------------------------------------------------------------------------" +
                    "" +
                    "");
            }
            else
            {
                while (i <= n)
                {
                    s = (float)(s + ((2 * i + 2.0) / 2.0 * i + 2.0));
                    i++;
                }
                Console.WriteLine("******************************************");
                Console.WriteLine("****  Ket Qua Cua Phep Tinh La : {0}  ****", s);
                Console.WriteLine("******************************************");
                Console.WriteLine("");
            }
        }
    }

    /// <summary>
    /// multiplication problems
    /// </summary>
    public class ThuatToan2
    {
        /// <summary>
        /// Bài 9: Tính T(n) = 1 x 2 x 3…x N
        /// </summary>
        public void bai9()
        {
        nhaplai:
            long volume = 1;
            int count = 1, n;
            string inputN;
            Console.Write(" please enter the number of elements n "); inputN = Console.ReadLine();
            if (int.TryParse(inputN, out n) == false)
            {
                Console.WriteLine(" you entered the wrong data !");
                Console.WriteLine(" Please re-enter the data ! ");
                goto nhaplai;
            }
            else
            {
                while (count <= n)
                {
                    volume *= count;
                    count++;
                }
                Console.WriteLine("\n\n the result of the problem is : {0} \n\n ", volume);
            }

        }
        /// <summary>
        /// Bài 10: Tính T(x, n) = x^n
        /// </summary>
        public void bai10()
        {
            long volume = 1;
            int n, x;
            int i = 1;
            string inputn, inputx;
        nhaplai:

            Console.Write(" please enter radix x : ");
            inputx = Console.ReadLine();

            Console.Write(" please enter the exponent n : ");
            inputn = Console.ReadLine();
            x = int.Parse(inputx);
            if (int.TryParse(inputn, out n) == false && (int.TryParse(inputx, out x) == false))
            {
                Console.WriteLine(" you entered the wrong data !");
                Console.WriteLine(" Please re-enter the data ! \n\n");
                goto nhaplai;
            }
            else
            {
                while (i <= n)
                {
                    volume *= x;
                    i++;
                }
                Console.WriteLine("\n\n the result of the problem is : {0} \n\n ", volume);
            }
        }
        /// <summary>
        /// Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N
        /// </summary>
        public void bai11()
        { 
        }
        /// <summary>
        /// Bài 12: Tính S(n) = x + x^2 + x^3 + … + x^n
        /// </summary>
        public void bai12()
        { }
        /// <summary>
        /// Bài 13: Tính S(n) = x^2 + x^4 + … + x^2n
        /// </summary>
        public void bai13()
        { 
        }
        /// <summary>
        /// Bài 14: Tính S(n) = x + x^3 + x^5 + … + x^2n + 1
        /// </summary>
        public void bai14()
        {

        }
    }

    /// <summary>
    /// bai 20 -> 29 
    /// </summary>
    public class ThuatToan3
    {
        /// <summary>
        /// Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n
        /// </summary>
        public void bai20()
        {
            Console.WriteLine(" Ban Da chon Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n\n\n ");
            int n, count = 1;
            string nhapn;
        nhaplai:
            Console.Write(" Moi Ban Nhap So N (n> 0) :"); nhapn = Console.ReadLine();
            n = int.Parse(nhapn);
            if (int.TryParse(nhapn, out n) == false && n >= 0)
            {
                Console.WriteLine("Ban Nhap Sai Du lieu ");
                goto nhaplai;
            }
            else
            { Console.Write(" Cac Uoc Cua {0} la ", n);

                while (n % count == 0)
                {
                    Console.Write(", {0}", count);
                    count++;
                }
            }
        }
        /// <summary>
        /// Bài 21: Tính tổng tất cả các “ ước số” của số nguyên dương n
        /// </summary>
        public void bai21()
        {
            Console.WriteLine(" Ban Da chon Bài 21: Tính tổng tất cả các “ ước số” của số nguyên dương n \n\n ");
            int n, count = 1;
            string nhapn;
            long sum = 0;
        nhaplai:
            Console.Write(" Moi Ban Nhap So N (n> 0) :"); nhapn = Console.ReadLine();
            n = int.Parse(nhapn);
            if (int.TryParse(nhapn, out n) == false && n >= 0)
            {
                Console.WriteLine("Ban Nhap Sai Du lieu ");
                goto nhaplai;
            }
            else
            {
                Console.Write(" Cac Uoc Cua {0} la ", n);

                while (n % count == 0)
                {
                    Console.Write(", {0}", count);
                    sum += count;
                    count++;
                }
                Console.Write("\n\nTong Cua Cac Uoc Cua {0} la: {1}", n, sum);
            }
        }
        /// <summary>
        /// Bài 22:Tính tích tất cả các “ước số” của số nguyên dương n
        /// </summary>
        public void bai22()
        {
            Console.WriteLine(" Ban Da chon Bài 22:Tính tích tất cả các “ước số” của số nguyên dương n \n\n ");
            int n, count = 1;
            string nhapn;
            long volume = 0;
        nhaplai:
            Console.Write(" Moi Ban Nhap So N (n> 0) :"); nhapn = Console.ReadLine();
            n = int.Parse(nhapn);
            if (int.TryParse(nhapn, out n) == false && n >= 0)
            {
                Console.WriteLine("Ban Nhap Sai Du lieu ");
                goto nhaplai;
            }
            else
            {
                Console.Write(" Cac Uoc Cua {0} la ", n);

                while (n % count == 0)
                {
                    Console.Write(", {0}", count);
                    volume *= count;
                    count++;
                }
                Console.Write("\n\nTich Cua Cac Uoc Cua {0} la: {1}", n, volume);
            }
        }
        /// <summary>
        /// Bài 23: Đếm số lượng “ước số” của số nguyên dương n
        /// </summary>
        public void bai23()
        {
            Console.WriteLine(" Ban Da chon Bài 23: Đếm số lượng “ước số” của số nguyên dương n \n\n ");
            int n, count = 1;
            string nhapn;
            long volume = 0;
        nhaplai:
            Console.Write(" Moi Ban Nhap So N (n> 0) :"); nhapn = Console.ReadLine();
            n = int.Parse(nhapn);
            if (int.TryParse(nhapn, out n) == false && n >= 0)
            {
                Console.WriteLine("Ban Nhap Sai Du lieu ");
                goto nhaplai;
            }
            else
            {
                Console.Write(" Cac Uoc Cua {0} la ", n);

                while (n % count == 0)
                {
                    Console.Write(", {0}", count);
                    volume *= count;
                    count++;
                }
                Console.Write("\n\nTich Cua Cac Uoc Cua {0} la: {1}", n, volume);
            }
        }
        /// <summary>
        /// Bài 24: Liệt kê tất cả các “ước số lẻ” của số nguyên dương n
        /// </summary>
        public void bai24()
        { }
        /// <summary>
        /// Bài 25: Tính tổng tất cả các “ước số chẵn” của số nguyên dương n
        /// </summary>
        public void bai25()
        { }
        /// <summary>
        /// Bài 26: Tính tích tất cả các “ước số lẻ” của số nguyên dương n
        /// </summary>
        public void bai26()
        { }
        /// <summary>
        /// Bài 27: Đếm số lượng “ước số chẵn” của số nguyên dương n
        /// </summary>
        public void bai27()
        { }
        /// <summary>
        /// Bài 28: Cho số nguyên dương n. Tính tổng các ước số nhỏ hơn chính nó
        /// </summary>
        public void bai28()
        { }
        /// <summary>
        /// Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n. Ví dụ n = 100 ước lẻ lớn nhất là 25
        /// </summary>
        public void bai29()
        { }

    }
    public class ThuatToan4
    {
        int n = 10, m = 10;
        public int[,] Khoitaomatran(int n, int m)
        {
            int[,] matrix = new int[n, m];
            int i = 0, j = 0;
            Random rank = new Random();
            while (j < n)
            {
                i = 0;
                while (i < m)
                {
                    int vulue = rank.Next(0, 10);
                    Console.WriteLine(vulue);
                    i++;
                }
                j++;
            }
            return matrix;
        }
    }
}
