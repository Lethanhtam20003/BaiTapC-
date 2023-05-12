 namespace programBasic
{
    public class CShapeBasic
    {
    }
   

    class controlIO
    {
        public subMethod sub = new subMethod();
        /// <summary>
        /// xuất ra màn hình  "the first Console Application program "
        /// </summary>
        public void exercise1()
        {
            Console.WriteLine(" exercise 1");
            Console.WriteLine("\n the first Console Application program !");
        }

        /// <summary>
        /// nhập vào một chuổi bất kỳ và xuất ra màn hình
        /// </summary>
        public void exercise2()
        {
            Console.WriteLine(" exercise 2");
            Console.Write(" enter any String valua :");
            string any = Console.ReadLine();

            Console.WriteLine("the string just entered is :{0} ", any);
            Console.ReadKey();

        }

        /// <summary>
        /// Viết chương trình nhập vào lần lượt 3 giá trị a b và c. 
        /// Xuất ra ba giá trị đó theo định dạng như sau và phải sử dụng tham số của hàm Write hoặc WriteLine của Console:
        /// </summary>
        public void exercise3()
        {
            Console.WriteLine(" exercise 3");
            Console.Write("input number a :");
            String a = Console.ReadLine();
            Console.Write("input number b :");
            String b = Console.ReadLine();
            Console.Write("input number c :");
            String c = Console.ReadLine();
            Console.WriteLine(" number a : {0} number b : {1} number c : {2} ", a, b, c);
        }

        /// <summary>
        /// Viết chương trình cho phép nhập vào một số n và in ra màn hình giá trị [-n..n]
        /// </summary>
        public void exercice22()
        {
            Console.Write("nhap so tu nhien n ");
            string ip1 = Console.ReadLine();
            int n = sub.testIntInPut(ip1);
            int[] A = new int[n];
            for (int i1 = 0; i1 < n; i1++)
            {
                A[i1] = i1;
                Console.Write(" {0} ", A[i1]);
            }
            Console.WriteLine();
            int i = 0;
            while (i < n)
            {
                A[i] = i;
                Console.Write(" {0} ", A[i]);
                i++;
            }
            i = 0;
            Console.WriteLine();
            do
            {
                A[i] = i;
                Console.Write(" {0} ", A[i]);
                i++;
            } while (i < n);
        }
        /// <summary>
        /// 22. Viết chương trình cho phép nhập vào một số n và in ra màn hình số chẵn từ [-n..n]
        /// 23. Viết chương trình cho phép nhập vào một số n và in ra màn hình số lẻ từ [-n..n]
        /// </summary>
        public void exercice23()
        {
            Console.Write("nhap so tu nhien n ");
            string ip1 = Console.ReadLine();
            int n = sub.testIntInPut(ip1);
            int[] A = new int[n];
            for (int i1 = 0; i1 < n; i1++)
            {
                if (i1 % 2 == 0)
                {
                    A[i1] = i1;
                    Console.Write(" {0} ", A[i1]);
                }
            }
            Console.WriteLine();
            int i = 0;
            while (i < n)
            {
                if (i % 2 == 0)
                {
                    A[i] = i;
                    Console.Write(" {0} ", A[i]);
                }
                i++;
            }
            i = 0;
            Console.WriteLine();
            do
            {
                if (i % 2 == 0)
                {
                    A[i] = i;
                    Console.Write(" {0} ", A[i]);
                }
                i++;
            } while (i < n);
            ///
            Console.WriteLine();
            for (int i1 = 0; i1 < n; i1++)
            {
                if (i1 % 2 != 0)
                {
                    A[i1] = i1;
                    Console.Write(" {0} ", A[i1]);
                }
            }
            Console.WriteLine();
            i = 0;
            while (i < n)
            {
                if (i % 2 != 0)
                {
                    A[i] = i;
                    Console.Write(" {0} ", A[i]);
                }
                i++;
            }
            i = 0;
            Console.WriteLine();
            do
            {
                if (i % 2 != 0)
                {
                    A[i] = i;
                    Console.Write(" {0} ", A[i]);
                }
                i++;
            } while (i < n);
        }
        /// <summary>
        /// Viết chương trình nhập vào số n và kiểm tra xem n có phải số nguyên tố hay không?
        /// </summary>
        public void exercice24()
        {
            /**
             * input n ;
             * if ?
             * 
             */
            Console.Write("nhap vao so n :");
            string ip = Console.ReadLine();
            int n = sub.testIntInPut(ip);
            if (n < 2)
            {
                Console.WriteLine(" n = {0} ko phai la so nguyen ", n);
            }
            else if (n == 2)
            {
                Console.WriteLine(" n = {0} la so nguyen to va la so nguyen chan duy nhat ", n);
            }
            else
            {
                if (n % 2 != 0)
                {
                    for (int i = 3; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            Console.WriteLine(" n = {0} ko phai la so nguyen to ", n);
                            return;
                        }
                    }
                    Console.WriteLine(" n = {0} la so nguyen to ", n);
                }
                else
                {
                    Console.WriteLine(" n = {0} ko phai la so nguyen to ", n);
                }
            }
        }

    }

    class variable
    {
        public subMethod sub = new subMethod();
        /// <summary>
        /// Tạo một biến kiểu dữ liệu int khởi tạo giá trị bằng 90
        /// Tạo một biến kiểu dữ liệu int khởi tạo giá trị bằng 90.
        ///Sau đó, tạo một biến kiểu dữ liệu int và gán giá trị khởi tạo bằng giá trị của biến được tạo ở ý trên.
        /// </summary>
        public void exercise4and6()
        {
            Console.WriteLine(" exercise 4");
            int a = 90;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(String.Format("Value1 = {0} | Value2 = {1}", a, b)); // String.format : Nó có thể giúp bạn tạo ra một chuỗi kết hợp với các giá trị được chèn vào trong chuỗi đó, tạo ra một chuỗi định dạng.

        }
        /// <summary>
        /// Tạo một biến kiểu dữ liệu bool không khởi tạo dữ liệu
        /// </summary>
        public void exercise5and7()
        {
            Console.WriteLine(" exercise 5");
            int a = 5, b = a;
            bool A = b > a;
            Console.WriteLine(A);

        }



    }

    class operater
    {
        public subMethod sub = new subMethod();
        /// <summary>
        /// bài 9 10
        /// có pháp tính
        /// bài 11
        /// Nhập vào 2 số a và b từ bàn phím. Kiểm tra nếu a >  b thì xuất ra
        /// “a lớn hơn b” nếu a < b thì xuất ra “a nhỏ hơn b” ngược lại thì xuất ra “a bằng b”.
        /// </summary>
        public void exercise9and10and11()
        {
            Console.WriteLine("nhập số a :");
            string ip = Console.ReadLine();
            int a = testIntInPut(ip);
            Console.WriteLine("nhập số a :");
            string ip2 = Console.ReadLine();
            int b = testIntInPut(ip2);
            // toán tử tính toán 
            Console.WriteLine("toán tử tính toán");
            Console.WriteLine(" {0} + {1} = {2}", a, b, a + b);
            Console.WriteLine(" {0} - {1} = {2}", a, b, a - b);
            Console.WriteLine(" {0} * {1} = {2}", a, b, a * b);
            Console.WriteLine(" {0} / {1} = {2}", a, b, a / (1.0 * b));
            Console.WriteLine(" {0} % {1} = {2}", a, b, a % b);
            Console.WriteLine("giá trị phần nguyên của {0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("giá trị thập phân của {0} / {1} = {2}", a, b, a * 1.0 / b - (a / b));
            //toán tửu logic
            Console.WriteLine("toán tửu logic");
            Console.WriteLine("{0} > {1} = {2}", a, b, a > b);
            Console.WriteLine("{0} < {1} = {2}", a, b, a < b);
            Console.WriteLine("{0} >= {1} = {2}", a, b, a >= b);
            Console.WriteLine("{0} <= {1} = {2}", a, b, a <= b);
            Console.WriteLine("{0} == {1} = {2}", a, b, a == b);
            Console.WriteLine("{0} != {1} = {2}", a, b, a != b);
            // toán tử sánh trên bit
            Console.WriteLine("toán tử sánh trên bit");
            Console.WriteLine("{0} ^ {1} = {2}", a, b, a ^ b);
            Console.WriteLine("{0} >> {1}= {2}", a, b, a >> b);
            Console.WriteLine("{0} << {1}= {2}", a, b, a << b);
            Console.WriteLine("{0} & {1}= {2}", a, b, a & b);
            Console.WriteLine("{0} | {1}= {2}", a, b, a | b);

            if (a > b)
            {
                Console.WriteLine("{0} Lớn hơn {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} nhỏ hơn {1}", a, b);
            }

            switch (a > b)
            {
                case true:
                    Console.WriteLine("{0} Lớn hơn {1}", a, b);
                    break;
                default:
                    Console.WriteLine("{0} nhỏ hơn {1}", a, b);
                    break;
            }
        }

        /// <summary>
        /// Enter a parameter with data type integer
        /// nhập vào tham số có kiểu dữ liệu là integer 
        /// </summary>
        public int testIntInPut(string iP)
        {
            int a;
            if (Int32.TryParse(iP, out a) == false && Convert.ToInt32(iP) < 0)
            {
                Console.WriteLine("Nhâp sai dữ liệu");
                goto Retype;
            }
            else
            {
                a = Convert.ToInt32(iP);
            }
            return a;
        Retype:
            Console.Write("nhập lại dư liệu : ");
            iP = Console.ReadLine();
            if (Int32.TryParse(iP, out a) == false)
            {
                Console.WriteLine("Nhâp sai dữ liệu");
                goto Retype;
            }
            else
            {
                a = Convert.ToInt32(iP);
            }
            return a;

        }


    }

    class conditions
    {
        public subMethod sub = new subMethod();
        /// <summary>
        /// Viết chương trình giải phương trình bậc nhất có dạng ax + b = 0.
        ///Yêu cầu: Viết chương trình với mỗi trường hợp sử dụng IF – ELSE và SWITCH CASE.
        /// </summary>
        public void exercice12()
        {
            /**
             *  ax +b = 0
             * int a,b;
             * X? có 1 nghiệm
             * x=-b/a
             * nếu a = 0 thì pt có vô số nghiệm
             * nêu a>0 và B==0 thì n0 = 0
             */
            string ip1, ip2;
            int a, b;
            double c;
            Console.Write(" nhập vào a : ");
            ip1 = Console.ReadLine();
            Console.Write(" nhập vào b : ");
            ip2 = Console.ReadLine();
            Console.WriteLine("phương trình vừa nhập là : {0}x + {1} = 0", ip1, ip2);
            a =  sub.testIntInPut(ip1); b = sub.testIntInPut(ip2);
            if (a == 0)
            {
                Console.WriteLine(" phương trình có vô nghiệm : ");
            }
            else if (a > 0 && b == 0)
            {
                Console.WriteLine(" phương trình có nghiệm là : 0 ");
            }
            else
            {
                c = -b * 1.0 / a;
                Console.WriteLine(" phương trình có  nghiệm là :{0} ", c);
            }

            switch (a == 0)
            {
                case true:
                    Console.WriteLine(" phương trình có vô nghiệm : ");
                    break;
                default:
                    switch (b == 0)
                    {
                        case true:
                            Console.WriteLine(" phương trình có nghiệm là : 0 ");
                            break;
                        default:
                            c = -b * 1.0 / a;
                            Console.WriteLine(" phương trình có  nghiệm là :{0} ", c);
                            break;
                    }
                    break;
            }
        }
        /// <summary>
        /// Viết chương trình giải phương trình bậc hai:  Ax2 + Bx +C = 0
        ///Yêu cầu: Viết chương trình với mỗi trường hợp sử dụng IF – ELSE và SWITCH CA
        /// </summary>
        public void exercice13()
        {
            /*
             * int a,b,c;
             * double denta;
             * + denta < 0 pt vo n0
             * +denta = 0 có 1 n0 = -b/2a
             * +denta > 0 có 2 n0 x1 = -b-căn denta / 2a và x2 = -b+căn denta /2a
             */
            string ip1, ip2, ip3;
            int a, b, c;
            double denta, x1, x2;
            Console.Write(" nhập vào a : ");
            ip1 = Console.ReadLine();
            Console.Write(" nhập vào b : ");
            ip2 = Console.ReadLine();
            Console.Write(" nhập vào c : ");
            ip3 = Console.ReadLine();
            Console.WriteLine("phương trình vừa nhập là : {0}x^2 + {1}X + {2}= 0", ip1, ip2, ip3);
            a = sub.testIntInPut(ip1); b = sub.testIntInPut(ip2); c = sub.testIntInPut(ip3);
            denta = b * 1.0 * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine(" phương trình có 1 nghiệm là : x = {0} ", -c / b * 1.0);
            }
            else if (true)
            {


                if (denta < 0)
                {
                    Console.WriteLine(" phương trình có vô nghiệm : ");
                }
                else if (denta == 0)
                {
                    Console.WriteLine(" phương trình có 1 nghiệm là : x = {0} ", -b / 2 * a * 1.0);

                }
                else
                {
                    x1 = (-b - denta) / (2 * a);
                    x2 = (-b + denta) / (2 * a);
                    Console.WriteLine("phương trình có 2 nghiệm x1 = {0} và X2 = {1}", x1, x2);
                }
            }
            switch (a == 0)
            {
                case true:
                    Console.WriteLine(" phương trình có 1 nghiệm là : x = {0} ", -c / b * 1.0);
                    break;
                default:

                    switch (denta < 0)
                    {
                        case true:
                            Console.WriteLine(" phương trình có vô nghiệm : ");
                            break;
                        default:
                            switch (denta == 0)
                            {
                                case true:
                                    Console.WriteLine(" phương trình có 1 nghiệm là : x = {0} ", -b / 2 * a * 1.0);
                                    break;
                                default:
                                    switch (denta > 0)
                                    {
                                        case true:
                                            x1 = (-b - denta) / (2 * a);
                                            x2 = (-b + denta) / (2 * a);
                                            Console.WriteLine("phương trình có 2 nghiệm x1 = {0} và X2 = {1}", x1, x2);
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
        /// <summary>
        /// Nhập vào 3 số rồi tìm ra giá trị lớn nhất trong 3 số đó
        ///Yêu cầu: Viết chương trình với mỗi trường hợp sử dụng IF – ELSE và SWITCH CASE.
        /// </summary>
        public void exercice14()
        {
            /*
             * int a,b,c;
             * min ? max ?
             */
            string ip1, ip2, ip3;
            int a, b, c, min, max;
            Console.Write("Nhập vào số a :");
            ip1 = Console.ReadLine();
            Console.Write("\n Nhập vào số b :");
            ip2 = Console.ReadLine();
            Console.Write("\n Nhập vào số c :");
            ip3 = Console.ReadLine();
            a = sub.testIntInPut(ip1); b = sub.testIntInPut(ip2); c = sub.testIntInPut(ip3);
            if (a > b)
            {
                max = a;
                min = b;
                if (a > c && c > b)
                {
                    min = b;
                    max = a;
                }
                else if (a > c && b > c)
                {
                    min = c;
                    max = a;
                }
                else
                {
                    max = c;
                    min = b;
                }
            }
            else
            {
                max = b;
                min = a;
                if (b > c && c > a)
                {
                    min = a;
                    max = b;
                }
                else if (b > c && a > c)
                {
                    min = c;
                    max = b;
                }
                else
                {
                    max = c;
                    min = a;
                }
            }
            Console.WriteLine("theo cách 1");
            Console.WriteLine(" giá trị lớn nhất là {0}", max);
            Console.WriteLine(" giá trị nhỏ nhất là {0}", min);
            max = a;
            min = a;
            switch (max < b)
            {
                case true:
                    max = b;
                    switch (max < c)
                    {
                        case true:
                            max = c;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    switch (max < c)
                    {
                        case true:
                            max = c;
                            break;
                        default:
                            break;
                    }
                    break;

            }
            switch (min > b)
            {
                case true:
                    min = b;
                    switch (min > c)
                    {
                        case true:
                            min = c;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    switch (min > c)
                    {
                        case true:
                            min = c;
                            break;
                        default:
                            break;
                    }
                    break;
            }
            Console.WriteLine("theo cách 2");
            Console.WriteLine(" giá trị lớn nhất là {0}", max);
            Console.WriteLine(" giá trị nhỏ nhất là {0}", min);
            min = a < b ? a < c ? a : c : b;
            max = a > b ? a > c ? a : c : b;

            Console.WriteLine("theo cách 3");
            Console.WriteLine(" giá trị lớn nhất là {0}", max);
            Console.WriteLine(" giá trị nhỏ nhất là {0}", min);
        }
        ///// <summary>
        ///// Enter a parameter with data type integer
        ///// nhập vào tham số có kiểu dữ liệu là integer 
        ///// </summary>
        //public int testIntInPut(string iP)
        //{
        //    int a;
        //    if (Int32.TryParse(iP, out a) == false && Convert.ToInt32(iP) < 0)
        //    {
        //        Console.WriteLine("Nhâp sai dữ liệu");
        //        goto Retype;
        //    }
        //    else
        //    {
        //        a = Convert.ToInt32(iP);
        //    }
        //    return a;
        //Retype:
        //    Console.Write("nhập lại dư liệu : ");
        //    iP = Console.ReadLine();
        //    if (Int32.TryParse(iP, out a) == false)
        //    {
        //        Console.WriteLine("Nhâp sai dữ liệu");
        //        goto Retype;
        //    }
        //    else
        //    {
        //        a = Convert.ToInt32(iP);
        //    }
        //    return a;

        //}
    }

    class dayMonthYear
    {
        public subMethod sub = new subMethod();
        /// <summary>
        /// Nhập vào tuần tự ngày, tháng , năm và xuất ra thứ của ngày đó trong tuần
        /// </summary>
        public void exercice15()
        {
            string ip1, ip2, ip3;
            Console.Write("ngày");
            ip1 = Console.ReadLine();
            Console.Write("tháng");
            ip2 = Console.ReadLine();
            Console.Write("năm");
            ip3 = Console.ReadLine();
        nhaplai:
            int day = sub.testIntInPut(ip1);
            int month = sub.testIntInPut(ip2);
            int years = sub.testIntInPut(ip3);
            if (day <= 31 && month <= 12)
            {
                DateTime date = new DateTime(years, month, day);
                Console.WriteLine(date.DayOfWeek);
            }
            else
            {
                Console.WriteLine("nhap sai ngày h ");
                goto nhaplai;
            }

        }
        /// <summary>
        /// Nhập vào năm, kiểm tra xem năm đó có phải năm nhuận hay không?
        /// </summary>
        public void exercice16()
        {
            Console.Write("Xin mời nhập vào năm : ");
            string ip = Console.ReadLine();
            int year = sub.testIntInPut(ip);
            DateTime date = new DateTime(year);
            if (date.DayOfYear == 366)
            {
                Console.WriteLine(" năm {0} là năm nhuận ", year);
            }
            else
            {
                Console.WriteLine(" năm {0} không phải là năm nhuận", year);
            }
        }
    }

    class appConsileBasic
    {
        public subMethod sub = new subMethod();
        /// <summary>
        /// Lập trình game kéo – búa – bao
        /// </summary>
        public void exercice19()
        {
        /*1. keo - 2. búa - 3. bao
         * random 
         * 
         */
        choilai:
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("    trò chơi kéo búa bao              @ ");
            Console.WriteLine("    chon 1. búa                       @     ");
            Console.WriteLine("    chọn 2.bao                        @ ");
            Console.WriteLine("    chọn 3. kéo                       @");
            Console.WriteLine("    hay nhập vào 1,2,3 để chọn        @ ");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n\n\n\n");
        nhaplai:
            Console.Write("    lựa chọn của bạn là : số ");

            string ip1 = Console.ReadLine();
            int a = sub.testIntInPut(ip1);
            if (a == 1)
            {
                Console.WriteLine("      lựa chọn của bạn là  búa           ");

            }
            else if (a == 2)
            {
                Console.WriteLine("      lựa chọn của bạn là  bao         ");

            }
            else if (a == 3)
            {
                Console.WriteLine("      lựa chọn của bạn là  kéo           ");

            }
            else
            {
                Console.WriteLine("\n lựa chon không chính xác! vui là chon các số 1. búa ,2. bao hoặc 3. kéo để tiếp tục\n");
                goto nhaplai;
            }

            Random rank = new Random();
            int v = rank.Next(1, 3);
            if (v == 1)
            {
                Console.WriteLine("    lựa chọn của đối thủ là  búa         \n  ");

            }
            else if (v == 2)
            {
                Console.WriteLine("    lựa chọn của đối thủ là  bao         \n  ");

            }
            else if (v == 3)
            {
                Console.WriteLine("    lựa chọn của đối thủ là  kéo          \n ");
            }

            sub.keobuabao(a, v);
            Console.Write(" \n \n bạn muốn kết thúc nhấn enter muôn chơi tiếp nhấn n  .....");
            string ip2 = Console.ReadLine();
            if (ip2 == "n")
            {
                goto choilai;
            }
            return;
        }
        /// <summary>
        /// Lập trình chương trình Máy tính bỏ túi.
        ///        Hiển thị menu cho phép lựa chọn phép toán.
        ///        Nhập vào số tương ứng để bắt đầu tính toán:
        ///Cộng 2 số
        ///Trừ 2 số
        ///Chia nguyên 2 số
        ///Chia dư 2 số
        ///Nhân 2 số  
        ///Chia 2 số
        ///Thoát
        ///Khi nhấn chọn giá trị tương ứng sẽ vào cho người dùng nhập vào 2 số và hiển thị kết quả tương ứng.
        /// </summary>
        public void exercice20()
        {
            /**
             * 
             * input : loại chương trình 1, 2 số đẻ tính toán 3,
             * thuật toán : các phép tính yêu cầu 
             * output : kết quả 
             * trình bày : tạo menu cho bài 
             * các bài 
             * phím kết thúc
             * kiểm tra tham số nhập vào 
             */
            Console.WriteLine("menumenumenumenumenumenumenumenumenumenumenu");
            Console.WriteLine("menu             Menu                   menu");
            Console.WriteLine("menu     1. Cộng hai số ");
            Console.WriteLine("menu     2. Trừ hai số ");
            Console.WriteLine("menu     3. Chia nguyên hai số ");
            Console.WriteLine("menu     4. chia dư hai số");
            Console.WriteLine("menu     5. nhân hai số");
            Console.WriteLine("menu     6. Chia hai số");
            Console.WriteLine("menu     Q. thoát ");
            Console.WriteLine("menumenumenumenumenumenumenumenumenumenumenu\n");

            Console.WriteLine("mời bạn chọn phép tính :");
            string ipmenu = Console.ReadLine();
            //int a = testIntInPut(ipmenu);
            string ip1, ip2;
            int a, b;
            double resultMath;
            if (ipmenu.Equals("1"))
            {
                Console.WriteLine("Bài toán bạn chọn là  1. Cộng hai số ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a + b;
                Console.Write(" kết quả quả bài toán là {0}", resultMath);

            }
            else if (ipmenu.Equals("2"))
            {
                Console.WriteLine("Bài toán bạn chọn là 2. Trừ hai số ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a - b;
                Console.Write(" kết quả quả bài toán là {0}", resultMath);
            }
            else if (ipmenu.Equals("3"))
            {
                Console.WriteLine("Bài toán bạn chọn là 3. Chia nguyên hai số  ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a / b;
                Console.Write(" kết quả quả bài toán là {0}", resultMath);
            }
            else if (ipmenu.Equals("4"))
            {
                Console.WriteLine("Bài toán bạn chọn là 4. chia dư hai số ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a % b;
                Console.Write(" kết quả quả bài toán là {0}", resultMath);
            }
            else if (ipmenu.Equals("5"))
            {
                Console.WriteLine("Bài toán bạn chọn là 5. nhân hai số");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a * b;
                Console.Write(" kết quả quả bài toán là {0}", resultMath);
            }
            else if (ipmenu.Equals("6"))
            {
                Console.WriteLine("Bài toán bạn chọn là 6. Chia hai số ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a * 1.0 / b;
                Console.Write(" kết quả quả bài toán là {0}", resultMath);
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// Tiếp tục chương trình LẬP TRÌNH MÁY TÍNH BỎ TÚI. Nhưng tinh chỉnh tốt hơn đó là
        /// : Có thể tiếp tục cộng trừ nhân chia từ kết quả vừa tính.
        /// </summary>
        public void exercice21()
        {
            Console.WriteLine("menumenumenumenumenumenumenumenumenumenumenu");
            Console.WriteLine("menu             Menu                   menu");
            Console.WriteLine("menu     +. Cộng hai số                 menu");
            Console.WriteLine("menu     -. Trừ hai số                  menu");
            Console.WriteLine("menu     1/. Chia nguyên hai số         menu");
            Console.WriteLine("menu     %. chia dư hai số              menu");
            Console.WriteLine("menu     *. nhân hai số                 menu");
            Console.WriteLine("menu     2/. Chia hai số                menu");
            Console.WriteLine("menu     Q. thoát                       menu");
            Console.WriteLine("menumenumenumenumenumenumenumenumenumenumenu\n");
        nhaplai:
            Console.Write("mời bạn chọn phép tính :");
            string ipmenu = Console.ReadLine();
            //int a = testIntInPut(ipmenu);
            string ip1, ip2;
            int a, b;
            double resultMath;
            if (ipmenu.Equals("+"))
            {
                Console.WriteLine("Bài toán bạn chọn là  +. Cộng hai số ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a + b;
                Console.WriteLine(" kết quả quả bài toán {0} + {1} là {2}", a, b, resultMath);

            }
            else if (ipmenu.Equals("-"))
            {
                Console.WriteLine("Bài toán bạn chọn là -. Trừ hai số ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a - b;
                Console.WriteLine(" kết quả quả bài toán {0} - {1} là {2}", a, b, resultMath);
            }
            else if (ipmenu.Equals("1/"))
            {
                Console.WriteLine("Bài toán bạn chọn là 1/. Chia nguyên hai số  ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a / b;
                Console.WriteLine(" kết quả quả bài toán {0} / {1} là {2}", a, b, resultMath);
            }
            else if (ipmenu.Equals("%"))
            {
                Console.WriteLine("Bài toán bạn chọn là %. chia dư hai số ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a % b;
                Console.WriteLine(" kết quả quả bài toán {0} % {1} là {2}", a, b, resultMath);
            }
            else if (ipmenu.Equals("*"))
            {
                Console.WriteLine("Bài toán bạn chọn là *. nhân hai số");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a * b;
                Console.WriteLine(" kết quả quả bài toán {0} * {1} là {2}", a, b, resultMath);
            }
            else if (ipmenu.Equals("2/"))
            {
                Console.WriteLine("Bài toán bạn chọn là 2/. Chia hai số ");
                Console.Write("mời bạn nhập số thứ nhất :");
                ip1 = Console.ReadLine();
                Console.Write("mời bạn nhập số thứ hai :");
                ip2 = Console.ReadLine();
                a = sub.testIntInPut(ip1);
                b = sub.testIntInPut(ip2);
                resultMath = a * 1.0 / b;
                Console.WriteLine(" kết quả quả bài toán {0} / {1} là {2}", a, b, resultMath);
            }
            else if (ipmenu.Equals("Q") || ipmenu.Equals("q"))
            {
                return;
            }
            else
            {
                Console.WriteLine(" nhap sai du lieu !");
                goto nhaplai;
            }
            sub.nextCasio(resultMath);

        }
    }

    class algorithm
    {
        public subMethod sub = new subMethod();
        /// <summary>
        /// Kiểm tra số n có phải số chính phương hay không
        /// </summary>
        public void exercice25()
        {
            Console.Write("nhap vao so n :");
            string ip = Console.ReadLine();
            int n = sub.testIntInPut(ip);
            for (int i = 0; i < n; i++)
            {
                if (i * i == n)
                {
                    Console.WriteLine(" n = {0} la so chinh phuong va binh phuong tu so {1}", n, i);
                    return;
                }
            }
            Console.WriteLine("  n = {0} ko phai la so chinh phuong", n);
        }
        /// <summary>
        /// Kiểm tra số n có phải số hoàn hảo hay không?
        /// </summary>
        public void exercice26()
        {
            Console.Write("nhap vao so n :");
            string ip = Console.ReadLine();
            int n = sub.testIntInPut(ip);
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(" n = {0} la so hoan hao", n);
            }
            else
            {
                Console.WriteLine(" n = {0} ko la so hoan hao", n);
            }
        }
        /// <summary>
        /// Kiểm tra xem số n có phải số đối xứng hay không?
        /// </summary>
        public void exercice27()
        {
            /**
             * Số nguyên n gọi là số đối xứng nếu đọc từ trái qua phải, hay từ phải qua trái đều được số giống nhau.
             * Ví dụ: 11,121,101 là các số đối xứng.
             * 
             */
            Console.Write("nhap vao so n :");
            string ip = Console.ReadLine();
            int n = sub.testIntInPut(ip);
            int sodadao = sub.sodao(n);
            if (n == sodadao)
            {
                Console.WriteLine("n = {0} la so doi xung ", n);
            }
            else
            {
                Console.WriteLine("n = {0} ko phai la so doi xung ", n);
            }
        }
        /// <summary>
        /// Nhập vào 1 số và xuất ra số phần tử của số đó.
        ///Lưu ý: Không dùng.ToString().Lenght chỉ dùng toán tử và so sánh.
        /// </summary>
        public void exercice28()
        {
            Console.Write("nhap vao so n :");
            string ip = Console.ReadLine();
            int n = sub.testIntInPut(ip);
            int countN = 0;
            while (n != 0)
            {
                n = n / 10;
                countN++;
            }
            Console.WriteLine(" so ky tu so da nhap vao la {0}", countN);
        }
        /// <summary>
        /// Cho người dùng nhập vào 2 số và kiểm tra xem có số nào là số con của số còn lại không?
        ///Gợi ý:
        /// Số con là số mà xuất hiện trong dãy số của số còn lại.ví dụ:
        ///Int a = 123456;
        ///Int b = 345;
        ///Thì b là số con của a.
        ///
        /// 
        /// </summary>
        public void exercice29()
        {
            Console.Write(" nhap vao so me :");
            string ip = Console.ReadLine();
            int mom = sub.testIntInPut(ip);
            Console.Write("\n nhap so con : ");
            string ip2 = Console.ReadLine();
            int son = sub.testIntInPut(ip2);
            if (mom == son)
            {
                Console.WriteLine("so {0} ko phai la con cua {1} ", son, mom);
            }
            else
            {
                int[] A = sub.numberseparation(mom, son);
                int count = sub.countN(mom);
                int i = 0;
                while (count > i)
                {
                    if (A[i] == son)
                    {
                        Console.WriteLine(" so {0} la con cua so {1} .", son, mom);
                        return;
                    }
                    i++;
                }
                Console.WriteLine(" so {0} ko phai la con cua so {1} .", son, mom);
            }
        }
        /// <summary>
        /// Nhập vào một số và tìm phần tử chia hết cho 3 trong số đó.
        ///Ví dụ:
        ///Int a = 987654;
        ///Các phần tử chia hết cho 3:
        ///9
        ///6
        /// </summary>
        public void exercice32()
        {
            Console.Write("nhap vao so n :");
            string ip = Console.ReadLine();
            int n = sub.testIntInPut(ip);
            int[] A = sub.tachso(n);
            int[] op = sub.timSoChiaHetCho3(A, n);
            int number = sub.counttimSoChiaHetCho3(A, n);
            int i = 0;
            Console.Write("cac so chia het choi ba la");
            while (i < number)
            {
                Console.Write(" {0} ", op[i]);
                i++;
            }
        }

        #region Bài 115: Viết chương trình nhập họ tên, điểm toán, điểm văn của 1 học sinh. Tính điểm trung bình và xuất ra kết quả
        public double CalculateTheAverageScore(double math, double literature)
        {
            double average = 0;
            average = (math + literature) / 2;
            return average;
        }
        public void intPutInternationforStudent()
        {
            Console.Write(" Enter Student name: ");
            string name = Console.ReadLine();
            Console.Write("\n Enter your math score:");
            string EnterMath = Console.ReadLine();
            double Math = sub.testInputDouble(EnterMath);
            Console.Write("\n Enter your literature score:");
            string EnterLiterature = Console.ReadLine();
            double Literature = sub.testInputDouble(EnterLiterature);
            double average = CalculateTheAverageScore(Math, Literature);
            Console.Write("\n  The Average Score of {0} is : {1} ", name, average);

            return;
        }
        #endregion
    }




    class test
    {

        
    }

    public class subMethod
    {
        public subMethod()
        {

        }
        /// <summary>
        /// Enter a parameter with data type integer
        /// nhập vào tham số có kiểu dữ liệu là integer 
        /// </summary>
        public int testIntInPut(string iP)
        {
            int a;
            if (Int32.TryParse(iP, out a) == false && Convert.ToInt32(iP) < 0)
            {
                Console.WriteLine("Nhâp sai dữ liệu");
                goto Retype;
            }
            else
            {
                a = Convert.ToInt32(iP);
            }
            return a;
        Retype:
            Console.Write("nhập lại dư liệu : ");
            iP = Console.ReadLine();
            if (Int32.TryParse(iP, out a) == false)
            {
                Console.WriteLine("Nhâp sai dữ liệu");
                goto Retype;
            }
            else
            {
                a = Convert.ToInt32(iP);
            }
            return a;

        }
        #region INPUT test
        // <summary>
        // Enter a parameter of any data type
        // nhập vào tham số có kiểu dữ liệu là bất kỳ 
        // </summary>
        //public void inputAnyDataTyte()
        //{
        //    String Ip;
        //    Ip = Console.ReadLine();
        //}
        #endregion
        /// <summary>
        /// tạo ra một class biểu thị ngày tháng năm
        /// </summary>
        public void ngayThangNam()
        {

        }
        /// <summary>
        /// keo bua bao
        /// </summary>
        /// <param name="a"></param>
        /// <param name="v"></param>
        public void keobuabao(int a, int v)
        {
            if (v == a)
            {
                Console.WriteLine("          #################    bạn và đối thủ hòa nhau             ");
            }
            else if (a == 3 && v == 1)
            {
                Console.WriteLine("      ####################         bạn thua");
            }
            else if (a > v)
            {
                Console.WriteLine("             ###############   bạn thắng");
            }
            else
            {
                Console.WriteLine("            ###############      bạn thua");
            }
        }
        /// <summary>
        ///  bai 21
        /// </summary>
        /// <param name="a"></param>
        /// <param name="ipmenu2"></param>
        /// <returns></returns>
        public double casio(double a, string ipmenu2)
        {
            if (ipmenu2.Equals("+"))
            {
                string ip4;
                Console.WriteLine(a);
                Console.WriteLine("    +");
                Console.WriteLine(ip4 = Console.ReadLine());
                int c = testIntInPut(ip4);
                Console.WriteLine("{0} + {1} = {2}", a, c, a = a + c);
            }
            else if (ipmenu2.Equals("-"))
            {
                string ip4;
                Console.WriteLine(a);
                Console.WriteLine("    -");
                Console.WriteLine(ip4 = Console.ReadLine());
                int c = testIntInPut(ip4);
                Console.WriteLine("{0} - {1} = {2}", a, c, a = a - c);
            }
            else if (ipmenu2.Equals("1/"))
            {
                string ip4;
                Console.WriteLine(a);
                Console.WriteLine("    /");
                Console.WriteLine(ip4 = Console.ReadLine());
                int c = testIntInPut(ip4);
                Console.WriteLine("{0} / {1} = {2}", a, c, a = (int)(a / c));
            }
            else if (ipmenu2.Equals("%"))
            {
                string ip4;
                Console.WriteLine(a);
                Console.WriteLine("    %");
                Console.WriteLine(ip4 = Console.ReadLine());
                int c = testIntInPut(ip4);
                Console.WriteLine("{0} % {1} = {2}", a, c, a = a % c);
            }
            else if (ipmenu2.Equals("*"))
            {
                string ip4;
                Console.WriteLine(a);
                Console.WriteLine("    *");
                Console.WriteLine(ip4 = Console.ReadLine());
                int c = testIntInPut(ip4);
                Console.WriteLine("{0} * {1} = {2}", a, c, a = a * c);
            }
            else if (ipmenu2.Equals("2/"))
            {
                string ip4;
                Console.WriteLine(a);
                Console.WriteLine("    /");
                Console.WriteLine(ip4 = Console.ReadLine());
                int c = testIntInPut(ip4);
                Console.WriteLine("{0} / {1} = {2}", a, c, a = a * 1.0 / c);
            }
            return a;
        }
        /// <summary>
        ///  bai 21
        /// </summary>
        /// <param name="resultMath"></param>
        public void nextCasio(double resultMath)
        {
        trolai:
            Console.WriteLine("menumenumenumenumenumenumenumenumenumenumenu");
            Console.WriteLine("menu             Menu                   menu");
            Console.WriteLine("menu     +. Cộng hai số                 menu");
            Console.WriteLine("menu     -. Trừ hai số                  menu");
            Console.WriteLine("menu     1/. Chia nguyên hai số         menu");
            Console.WriteLine("menu     %. chia dư hai số              menu");
            Console.WriteLine("menu     *. nhân hai số                 menu");
            Console.WriteLine("menu     2/. Chia hai số                menu");
            Console.WriteLine("menu     Q. thoát                       menu");
            Console.WriteLine("menumenumenumenumenumenumenumenumenumenumenu\n");
            Console.WriteLine("mời bạn chọn phép tính :");
            string ipmenu2 = Console.ReadLine();
            if (ipmenu2.Equals("q"))
            {
                return;
            }
            casio(resultMath, ipmenu2);
            goto trolai;
        }
        /// <summary>
        ///  Exercice 27
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int sodao(int n)
        {
            int sodao = 0, lua;
            while (n != 0)
            {
                // lay chu so cuoi
                lua = n % 10;
                // nhan so dao voi 10 , cong so vua tach
                sodao = sodao * 10 + lua;
                //xoa dong cuoi
                n /= 10;
            }
            return sodao;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] tachso(int n)
        {
            int i = 0, saveN = 0, count = countN(n);
            int[] A = new int[count];
            while (n != 0)
            {
                saveN = n % 10;
                A[i] = saveN;
                n = n / 10;
                i++;
            }
            return A;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ip"></param> lấy từ tách số
        /// <param name="n"></param> là tham sô n nhập vào
        /// <returns></returns>
        public int[] timSoChiaHetCho3(int[] ip, int n)
        {
            int count = countN(n);
            int[] A = new int[count];
            int i = 0, j = 0;
            while (i < count)
            {
                if (ip[i] % 3 == 0)
                {
                    A[j] = ip[i];
                    j++;
                }
                i++;
            }
            return A;
        }

        public int counttimSoChiaHetCho3(int[] ip, int n)
        {
            int number = 0;
            int count = countN(n);
            int[] A = new int[count];
            int i = 0, s = 0;
            while (i < count)
            {
                if (ip[i] % 3 == 0)
                {
                    ip[i] = s;
                    s = A[number];
                    number++;
                }
                i++;
            }
            return number;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int countN(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n /= 10;
            }
            return count;
        }
        #region phan ho tro bai 29

        /// <summary>
        /// ham mu
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int power(int n)
        {
            int a = 1;
            for (int i = 0; i < n; i++)
            {
                a *= 10;
            }
            return a;
        }
        /// <summary>
        /// tách nhiều số mỗi số có độ dài bằng chuổi con 
        /// </summary>
        /// <param name="son"></param>
        /// <returns></returns>
        public int[] numberseparation(int mom, int son)
        {
            int i = 0, saveN = 0, count = countN(mom), count2 = countN(son);
            int[] A = new int[count];
            int mu = power(count2);
            while (mom != 0)
            {
                saveN = mom % mu;
                A[i] = saveN;
                mom /= 10;
                i++;
            }


            return A;
        }
        #endregion

        #region các ham co ban cần thiết 105
        public int testInputForInt(string input)
        {
            int output = 0;
            if (int.TryParse(input, out output) == false)
            {
                Console.WriteLine(" Input data is incorrest !");
                goto retype;
            }
            else
            {
                output = int.Parse(input);
            }
            return output;
        retype:
            Console.Write("nhập lại dư liệu : ");
            input = Console.ReadLine();
            if (Int32.TryParse(input, out output) == false)
            {
                Console.WriteLine("Nhâp sai dữ liệu");
                goto retype;
            }
            else
            {
                output = Convert.ToInt32(input);
            }
            return output;


        }
        public double testInputDouble(string input)
        {
            double output = 0;
            if (double.TryParse(input, out output) == false)
            {
                Console.WriteLine(" Input data is incorrest !");
                goto retype;
            }
            else
            {
                output = double.Parse(input);
            }
            return output;
        retype:
            Console.Write("nhập lại dư liệu : ");
            input = Console.ReadLine();
            if (double.TryParse(input, out output) == false)
            {
                Console.WriteLine("Nhâp sai dữ liệu");
                goto retype;
            }
            else
            {
                output = Convert.ToDouble(input);
            }
            return output;


        }

        #endregion
    }



}