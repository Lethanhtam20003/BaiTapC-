using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CacPhepTinh;

namespace CacPhepTinh
{
    class ToanSo
    {
        public void TinhTong()
        {
            nhaplai:
            Console.WriteLine("Ban Da Chon Dang Bai Toan Tinh Tong :)) ");
            long sum = 0;
            int n;
            Console.Write("nhap n  : ");
            string nhapn;
            nhapn = Console.ReadLine();
            if (int.TryParse(nhapn, out n) == false)
            {
                Console.WriteLine("Ban Da nhap Sai Du lieu !");
                goto nhaplai;
            }
            {
                for (int i = 0; i <= n ; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
                Console.WriteLine("\n  Ket Qua Cua Bai Toan La : {0}", sum,"\n");
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            }

            Console.WriteLine("______________________________________________________________________________________________________");
        }
        public void TinhTich ()
        {
            Console.WriteLine("Tinh Tich Ne : ");
        nhaplai:
            Console.WriteLine("Tinh Tong Ne : ");
            long volume = 1;
            int n;
            Console.Write("nhap n  : ");
            string nhapn;
            nhapn = Console.ReadLine();
            if (int.TryParse(nhapn, out n) == false)
            {
                Console.WriteLine("Ban Da nhap Sai Du lieu ");
                goto nhaplai;
            }
            {
                for (int i = 0; i <= n; i++)
                {
                    volume = volume * i;
                }
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
                Console.WriteLine("\n  Ket Qua Cua Bai Toan La : {0}", volume,"\n");
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            }
            Console.WriteLine("______________________________________________________________________________________________________");
        }
    }
    class ToanHinh
    {
        public void HinhVuong()
        {
            Console.WriteLine("Hinh Vuong Ne \n");
            nhaplai:
            int length;
            string nhaplength;

            char drawchar = '*';
            char insidechar = ' ';

            Console.Write(" Moi Ban Nhap Chieu Dai : ");
            nhaplength = Console.ReadLine();

            if (int.TryParse(nhaplength, out length) == false)
            {
                Console.WriteLine("Ban nhap Sai Du Lieu!" +
                       "Vui Long Nhap Lai Du Lieu !");
                goto nhaplai;
            }
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {

                        if (i % (length - 1) == 0 || ((i % (length - 1) != 0) && (j % (length - 1) == 0)))
                        {
                            Console.Write(drawchar);
                        }
                        else
                        {
                            Console.Write(insidechar);
                        }
                    }
                    Console.WriteLine();
                }
                //for (int i = 0 ; i < length ; i++)
                //{
                //    for(int j = 0; j < length ; j++)
                //    {
                //        if (i % (length - 1) == 0 || (( i % (length - 1) != 0) && (j % (length - 1) == 0))) 
                //        {
                //            Console.Write(drawchar);
                //        }
                //        else
                //        {
                //            Console.Write(insidechar);
                //        }
                //    }
                //    Console.WriteLine();
                //}
            }
            Console.WriteLine("______________________________________________________________________________________________________");
        }
        public void HinhChuNhat()
        {
            Console.WriteLine("Hinh Chu Nhat ne \n");
            nhaplai:
            {
                int widths = 1;
                int length;
                string nhapwidths, nhaplength;
                Console.Write("Moi Ban Nhap Chieu Dai : "); nhaplength = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Moi Ban Nhap chieu rong  : "); nhapwidths = Console.ReadLine();
                if ((int.TryParse(nhaplength, out length) && int.TryParse(nhapwidths, out widths) ==false) && length > widths)
                {
                    Console.WriteLine("Ban nhap Sai Du Lieu!" +
                        "Vui Long Nhap Lai Du Lieu !");
                    goto nhaplai;
                }
                {
                    char drawChar = '*'  ;
                    char insideChar = ' ';

                    for (int i = 0; i < widths; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {

                            if (i % (widths - 1) == 0 || ((i % (widths - 1) != 0) && (j % (length - 1) == 0)))
                            {
                                Console.Write(drawChar);
                            }
                            else
                            {
                                Console.Write(insideChar);  
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("______________________________________________________________________________________________________");
        }
    }
}
