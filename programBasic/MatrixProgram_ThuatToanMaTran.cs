
using System;
using System.Collections.Generic;
using System.Text;

namespace programBasic
{
    class MatrixProgram_ThuatToanMaTran
    {
        #region hàm hỗ trợ nhập xuất hay kiểm tra cho các bài toán 
        public int testInputINT(string ip)
        {
            TestAgain:
            int op;
            if (int.TryParse(ip, out op) == false)
            {
                Console.WriteLine("Enter wrong input !");
                goto nhaplai;
            }
            else
            {
                op = int.Parse(ip);
            }
            return op;
        nhaplai:
            Console.Write("Enter input Again : ");
            ip = Console.ReadLine();
            goto TestAgain;
        }

        public double testInputDouble(string ip)
        {
        TestAgain:
            double op;
            if (double.TryParse(ip, out op) == false)
            {
                Console.WriteLine("Enter wrong input !");
                goto nhaplai;
            }
            else
            {
                op = double.Parse(ip);
            }
            return op;
        nhaplai:
            Console.Write("Enter input Again : ");
            ip = Console.ReadLine();
            goto TestAgain;
        }

        public int[] khoiTaoMangRandom(int n,int min, int max)
        {
            int i = 0;
            int[] A = new int[n];
            Random value = new Random();

            while (i < n)
            {
                A[i] = value.Next(min,max);
                Console.WriteLine(" A[{0}] = {1}:", i, A[i]);
                i++;
            }
            return A;
        }

        public double[] khoiTaoMangRandomDOUBLE(int n, int min, int max)
        {
            int i = 0;
            double[] A = new double[n];
            Random value = new Random();

            while (i < n)
            {
                A[i] = value.Next(min, max);
                Console.WriteLine(" A[{0}] = {1}:", i, A[i]);
                i++;
            }
            return A;
        }
        /// <summary>
        /// kiểm tra có phải số nguyên tố hay ko 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Boolean songuyento(int n)
        {
            int i = 0;
            if (n <= 2)
            {
                return false;
            }
            else
            {
                if (n /2 ==0 )
                {
                    return false;
                }
                if (n % 2 != 0)
                {
                    for (i = 3; i < n; i += 2)
                    {
                        if (n % i == 0)
                        {
                            return true;
                        }
                    }
                }

            }
            return false;
        }
        /// <summary>
        /// sắp xếp mãng theo thứ tự từ thấp đến cao .
        /// </summary>
        /// <param name="A"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double [] sapxep(double [] A,int n)
        {
            double buffer = 0;
            int i = 0;
            for (int f = i + 1; f < n; f++)
            {
                if (A[i] > A[f])
                {
                    buffer = A[i];
                    A[i] = A[f];
                    A[f] = buffer;
                }
            }
            return A;
        }
        /// <summary>
        ///  khởi tạo mảng aray intialization cho kiểu dữ liệu int 
        /// </summary>
        /// <returns></returns>
        public int [] arrayInitializationInt(int n)
        {
            int[] A = new int[n];
            int i = 0;
            while (i<n)
            {
                Console.Write("              A[{0}] =  ", i);
                string ip = Console.ReadLine();
                A[i] = testInputINT(ip);
                Console.WriteLine();
            }
            return A;
        }
        /// <summary>
        /// array initialization khởi tạo dữ liệu cho kiểu double
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public double[] arrayInitializationDouble(int n)
        {
            double[] A = new double[n];
            int i = 0;
            while (i < n)
            {
                Console.Write("              A[{0}] =  ", i);
                string ip = Console.ReadLine();
                A[i] = testInputDouble(ip);
                Console.WriteLine();
            }
            return A;
        }
        #endregion

        #region bài toán về ma trận
        /// <summary>
        /// khoi tao ma tran bat ky
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[,] KhoiTaoMaxtrix(int m, int n)
        {
            int[,] maxtrix = new int[m,n];
            int i = 0, j = 0;// i,n vị trí tương ứng với hàng , j,m tương ứng với cột
            
                while (i < m)
                {
                    j = 0;
                    while (j < n)
                    {
                    nhaplaiphantu:
                        Console.Write("                      a[{0},{1}] =", i, j);
                        int a=0;
                        String nhapmang;
                        // ép kiểu sang dạng số đẻ sau này tính toán 
                         nhapmang = Console.ReadLine();
                        
                        if (int.TryParse(nhapmang,out a) == false)
                        {
                            goto nhaplaiphantu;
                        }
                        else
                        { 
                            maxtrix[i, j] = a;
                            j++;
                            Console.WriteLine();
                        }
                    }
                    i++;
                }
            
            return maxtrix;
        }

        public void inmaxtrix(int[,] A)
        {
            
            int i = 0, j = 0;
            int n = A.GetLength(1);// Lấy chiều ngang ( từ trái qua phải) so cot
            int m = A.GetLength(0);// lấy triều dọc ( từ trên xuông ) so dong 
            while (i < m)
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

        public void SuDungMaTran()
        {
            int n, m;

            int[,] A = null;// khởi tạo mạng 
            int[,] B = null;
        string nhapn, nhapm;
    nhaplai:
        Console.Write(" moi ban nhap so dong :");
        nhapm = Console.ReadLine();
        Console.Write(" \n moi ban nhap so cot :");
        nhapn = Console.ReadLine();
        if ((int.TryParse(nhapm, out m) == false) && (int.TryParse(nhapn, out n) == false)&& (m!=0)&&(n!=0))// phép thử input
        {
            Console.WriteLine("ban nhap sai du lieu !");
            goto nhaplai;
        }
        else
        {
            n = int.Parse(nhapn);
            m = int.Parse(nhapm);
            A = KhoiTaoMaxtrix(n, m);
            Console.WriteLine("ma tran ");
            inmaxtrix(A);

        }

        }

        
        /// <summary>
        /// so sanh hai ma tran
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        public void sosanhmaxtrix(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            int n1 = A.GetLength(0);
            int m1 = A.GetLength(1);

            int i = 0, j = 0;
            if ((n!=n1) || (m!=m1))
            {
                goto thoatvonglapWhile;
            }
            else
            {
                while (i < m)
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
            }
            goto ketqua;
        thoatvonglapWhile:
            {
                Console.WriteLine(" ko bang nha");

            }
            return;
        ketqua:
            {
                Console.WriteLine(" bang nhau");
            }
        }

        public void sosanhmatran()
        {
        nhaplai:
            string nhapn,nhapm;
            int n,m;
            Console.Write("hay nhap cot ma tran:");
            nhapn = Console.ReadLine();
            Console.Write("hay nhap hang ma tran:");
            nhapm = Console.ReadLine();
            int[,] A = null;
            int[,] B = null;

            Console.WriteLine("");
            if ( (int.TryParse(nhapn, out n) == false) && (int.TryParse(nhapm, out m) == false) )
            {
                Console.WriteLine("Ban nhap sai du lieu !");
                goto nhaplai;
            }
            else
            {
                m = int.Parse(nhapm);
                n = int.Parse(nhapn);
                Console.WriteLine(" ma tran thu 1");
                A = KhoiTaoMaxtrix(n,m);
                Console.WriteLine("ma tran 1");
                inmaxtrix(A);

                Console.WriteLine(" ma tran thu 2 ");
                B = KhoiTaoMaxtrix(n, m);
                Console.WriteLine("ma tran 2");
                inmaxtrix(B);
                Console.Write("hai ma tram ");
                sosanhmaxtrix(A, B);
            }
        }


        /// <summary>
        /// nhan hai ma tran
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int[,] nhanhaimatrix(int[,] A,int[,] B)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            int n1 = B.GetLength(0);
            int m1 = B.GetLength(1);

            int i = 0, j = 0;

            int[,] maxtrix = new int[m1, n];
            int[,] C = new int[m,n1];
            while (i < m1)
            {
                j = 0;
                while (j < n)
                {
                    int i1 = 0;
                    // vong lap
                    while (i1 < m1)
                    {       
                        C[i, j] = A[i, i1] * B[i1, j];
                        maxtrix[i, j] = maxtrix[i, j] + C[i, j];
                        i1++;
                    }
                    j++;
                }
                i++;
            }
            
            return maxtrix;
        }

        public void nhanhaimatran()
        {
        nhaplai:
            string nhapn,nhapm, nhapn1, nhapm1;
            int n,m,n1,m1;
            int[,] A = null;
            int[,] B = null;
            int[,] c = null;
            int[,] maxtrix = null;
            Console.WriteLine("nhap ma tran thu nhat");
            Console.Write("hay nhap cot ma tran:");
            nhapn = Console.ReadLine();
            Console.Write("hay nhap dong ma tran:");
            nhapm = Console.ReadLine();

            Console.WriteLine("nhap ma tran thu hai");
            Console.Write("hay nhap cot ma tran:");
            nhapn1 = Console.ReadLine();
            Console.Write("hay nhap dong ma tran:");
            nhapm1 = Console.ReadLine();


            Console.WriteLine("");
            if ((int.TryParse(nhapn, out n) == false)||(int.TryParse(nhapm,out m)==false)||
                (int.TryParse(nhapn1, out n1) == false) || (int.TryParse(nhapm1, out m1) == false))
            {
                Console.WriteLine("Ban nhap sai du lieu !");
                goto nhaplai;
            }
            else //phần code chinh của bài
            {
                // tao ma tran A
                A = KhoiTaoMaxtrix(m,n);
                Console.WriteLine("ma tran 1");
                inmaxtrix(A);

                Console.WriteLine();
                // Khoi tao matrix B
                B = KhoiTaoMaxtrix(m1,n1);
                Console.WriteLine("ma tran 2");
                inmaxtrix(B);

                // ma tran c chi la bien dem de thuc hien phep tinh
                c = new int[m1, n];

                /*
                * sô cột của a phải = số dòng của b
                */
                if (n != m1)
                {
                    Console.WriteLine("hai ma tran ko the nhan nhau dc");
                    return;
                }
                else
                {
                    Console.WriteLine();
                    // xu ly: nhan 2 ma tran
                    maxtrix = nhanhaimatrix(A, B);
                    Console.WriteLine("ma tran ket qua");
                    inmaxtrix(maxtrix);
                }  
            }
        }
        #endregion

        /// <summary>
        /// Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực
        /// input n Double
        /// output max 
        /// </summary>
        public void Exercise122()
        {
            Console.Write(" Enter the number N : " );
            int n = Convert.ToInt32(Console.ReadLine());
            int i=0,save=0;
            int min = 0, max = 100;
            int[] A = khoiTaoMangRandom(n,min,max);
            while (i<n)
            {
                if (A[i]>=save)
                {
                    save = A[i];
                }
                i++;
            }
            Console.WriteLine(" Max value of array : {0}", save);
            
        }

        /// <summary>
        /// Bài 123: Viết hàm tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số nguyên
        /// input n double => array n number
        /// output position or smallest number n
        /// </summary>
        public void Exercise123()
        {
            int min = 0, max = 100;
            Console.Write(" Enter the number N : " );
            string ip = Console.ReadLine();
            int n = testInputINT(ip);
            int[] A = khoiTaoMangRandom(n,min,max);
            int save = A[0],i =0,position = 0;
            while (i<n)
            {
                if (A[i] < save)
                {
                    save = A[i];
                    position = i;
                }
                i++;
            }
            Console.WriteLine("Min value of array is :{0} ", save);
            Console.WriteLine("position of smallest n is : {0} ", position);
        }

        /// <summary>
        ///Bài 124: Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị chẵn nhỏ hơn 2004 hay không
        ///Bài 125: Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng
        /// </summary>
        public void Exercise124_125()
        {
            Console.Write(" Enter the number N : ");
            string ip = Console.ReadLine();
            int n = testInputINT(ip);
            int min = 0, max = 2051;
            int[] A = khoiTaoMangRandom(n,min,max);
            for (int i = 0; i < n; i++)
            {
                if (A[i] < 2004)
                {
                    Console.WriteLine("find number small 2004");
                    goto next;
                }
            }
            Console.WriteLine("not find number small 2004");
        next:
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i]< 100 && songuyento(A[i])==true)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} primes less than 100 in the array",count);
            
        }

        /// <summary>
        /// Bài 126: Viết hàm tính tổng các giá trị âm trong mảng 1 chiều các số thực
        /// Bài 127: Viết hàm sắp xếp mảng 1 chiều các số thực tăng dần
        /// </summary>
        public void Exercise126_127()
        {
            int min = -100, max = 100;
            Console.Write(" Enter the number N : ");
            string ip = Console.ReadLine();
            int n = testInputINT(ip);
            double[] A = khoiTaoMangRandomDOUBLE(n, min, max);
            double sum = 0;
            int i = 0;

            while (i < n)
            {
                if (A[i] < 0)
                {
                sum = sum + A[i];
                }
                i++;
            }
            Console.WriteLine(" sum of array : {0} ", sum);
            A = sapxep(A, n);
            Console.Write(" array then sort is ");
            i = 0;
            while (i<n)
            {
                Console.Write("A[{0}]  = {1}  ;",i,A[i]);
                i++;
            }
        }

        /// <summary>
        /// Bài 128 + 130: Viết hàm nhập, xuất mảng 1 chiều các số thực
        ///Bài 129 + 131: Viết hàm nhập, xuất mảng 1 chiều các số nguyên
        ///Bài 132: Viết hàm liệt kê các giá trị chẵn trong mảng 1 chiều các số nguyên
        ///Bài 133: Viết hàm liệt kê các vị trí mà giá trị tại đó là giá trị âm trong mảng 1 chiều các số nguyen
        /// </summary>
        public void Exercise132_133()
        {
            Console.WriteLine("Enter The number N : ");
            String ip = Console.ReadLine();
            int n = testInputINT(ip);
            int[] A = khoiTaoMangRandom(n, -50, 100);
            Console.Write("The even value in the array are : ");
            for (int i = 0; i < n; i++)
            {
                if (A[i] % 2 == 0)
                {
                    Console.Write(" A[{0}] = {1} ", i, A[i]);
                }
                i++;
            }

            Console.Write("\n\n The negative value in the array are : ");
            for (int i = 0; i < n; i++)
            {
                if (A[i] < 0)
                {
                    Console.Write(" A[{0}] = {1} ", i, A[i]);
                }
            }
        }
        #region  các bài tập tư duy
        public void Exercise()
        {

        }

        #endregion

        #region
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


        public void sosanhmaxtrix2(int[,] A, int[,] B)
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

        public void sosanhmatran2()
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

                sosanhmaxtrix2(A, B);

            }
        }

        public void test()
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
            switch (baitoan)
            {
                case 1:
                    VeMaTran();
                    break;
                case 2:
                   sosanhmatran2();
                    break;
                case 3:
                    NhanHaiMatran();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
        #endregion
    }
    public class runForMatrixProgram_ThuatToanMaTran
    {
        public void runForThisClass()
        {
            MatrixProgram_ThuatToanMaTran cls = new MatrixProgram_ThuatToanMaTran();
            cls.arrayInitializationDouble(44);
        }
    }
}
