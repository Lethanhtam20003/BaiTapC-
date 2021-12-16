using System;
using System.Collections.Generic;
using System.Text;

namespace cacPhepThu
{
    public class ThuatToanTest
    {
        public void VeMaTran()
        {
        nhaplai:
            int n, m;
            string nhapn, nhapm;

            Console.Write("hay nhap so dong cua ma tran:");
            nhapm = Console.ReadLine();
            Console.Write(" \n hay nhap so cot cua ma tran:");
            nhapn = Console.ReadLine();

            Console.WriteLine("");
            if ((int.TryParse(nhapn, out n) == false) && (int.TryParse(nhapm, out m) == false))
            {
                Console.WriteLine("Ban nhap sai du lieu !");
                goto nhaplai;
            }
            else
            {
                int min = 0;
                int max = 100;
                Random rank = new Random();
                n = int.Parse(nhapn);
                m = int.Parse(nhapm);
                int i = 0;
                int i2 = 1;
                Console.WriteLine("ma tran co m={0} dong va n={1} cot :", m, n);
                while (m >= i2)
                {
                    i = 1;
                    while (n >= i)
                    {
                        int showValue = rank.Next(min, max);
                        Console.Write(" {0}  ", showValue, "    ");
                        i++;
                    }
                    Console.WriteLine("\n");
                    i2++;
                }
            }
        }

        //public void SoSanhMaTran()
        //{
        //nhaplai:
        //    int m, n;
        //    string nhapn, nhapm;

        //    Console.Write("hay nhap so dong cua ma tran:");
        //    nhapn = Console.ReadLine();
        //    Console.Write(" \n hay nhap so cot cua ma tran:");
        //    nhapm = Console.ReadLine();

        //    Console.WriteLine("");
        //    if ((int.TryParse(nhapn, out n) == false) && (int.TryParse(nhapm, out m) == false))
        //    {
        //        Console.WriteLine("Ban nhap sai du lieu !");
        //        goto nhaplai;
        //    }

        //    else //phần code chinh của bài
        //    {
                


        //    }
        //}

        public int[,] KhoiTaoMatran(int n)
        {
            int[,] matrix = new int[n, n];
            int i = 0, j = 0;
            Random rank = new Random();
            while (i < n)
            {
                j = 0;
                while (j < n)
                {                   
                    int showValua = rank.Next(0, 1);
                    matrix[i, j] = showValua;
                    j++;                
                }
                i++;
            }

            return matrix;
        }

        public void Inmatrix(int[,] A)
        {
            int i = 0, j = 0;
            int n = (int)Math.Sqrt((double)A.Length);
            while (i < n)
            {
                j = 0;
                while (j < n)
                {
                    Console.Write("   {0}    ", A[i, j]);
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }

        public int[,] Nhan2Matrix(int[,] A, int[,] B)
        {
            int i = 0, j = 0;
            int n = (int)Math.Sqrt((double)A.Length);
            int[,] matrix = new int[n, n];
            while (i < n)
            {
                j = 0;
                while (j < n)
                {
                    matrix[i, j] = A[i, j] * B[i, j];
                    j++;
                }
                i++;
            }

            return matrix;
        }

        public void NhanHaiMatran()
        {
        nhaplai:
            string nhapn;
            int n;
            int[,] A = null;
            int[,] B = null;
            int[,] C = null;
            Console.Write("hay nhap cap ma tran:");
            nhapn = Console.ReadLine();

            Console.WriteLine("");
            if ((int.TryParse(nhapn, out n) == false))
            {
                Console.WriteLine("Ban nhap sai du lieu !");
                goto nhaplai;
            }
            else //phần code chinh của bài
            {
                //A = new int[n][];
                //B = new int[n][];
                //C = new int[n][];
                // khoi tao  matrix A
                A = KhoiTaoMatran(n);
                Console.WriteLine("ma tran 1");
                Inmatrix(A);
                // Khoi tao matrix B
                B = KhoiTaoMatran(n);
                Console.WriteLine("ma tran 2");
                Inmatrix(B);
                // xu ly: nhan 2 ma tran
                C = Nhan2Matrix(A, B);
                Console.WriteLine("ma tran ket qua");
                Inmatrix(C);
            }
        }


        public void sosanhmaxtrix(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            A = KhoiTaoMatran(n);
            B = KhoiTaoMatran(n);
            int i = 0, j = 0;
            while (i < n)
            {
                j = 0;
                while (j < n)
                {
                    if (A[i, j] != B[i, j])
                    {
                        goto thoatvonglapWhile;
                        j++;
                    }
                    i++;
                }
            }
            goto ketqua;
        thoatvonglapWhile:
            {
                Console.WriteLine("matran ko bang nha");
                
            }
            ketqua:
            {
                Console.WriteLine(" hai ma tran bang nhau");
            }
        }

        public void sosanhmatran()
        {
        nhaplai:
            string nhapn;
            int n;
            Console.Write("hay nhap cap ma tran:");
            nhapn = Console.ReadLine();
            

            Console.WriteLine("");
            if ((int.TryParse(nhapn, out n) == false))
            {
                Console.WriteLine("Ban nhap sai du lieu !");
                goto nhaplai;
            }
            else
            {
                int[,] A = null;
                int[,] B = null;

                A = KhoiTaoMatran(n);
                Console.WriteLine("ma tran 1");
                Inmatrix(A);

                B = KhoiTaoMatran(n);
                Console.WriteLine("ma tran 2");
                Inmatrix(B);

                sosanhmaxtrix(A, B);

            }
        }
    }
}
