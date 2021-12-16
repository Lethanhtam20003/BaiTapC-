using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    class Ham
    {
        #region các ham co ban cần thiết
        public int testInputForInt(string input)
        {
            int output = 0;
            if (int.TryParse(input,out output) == false)
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

        #region Bài 115: Viết chương trình nhập họ tên, điểm toán, điểm văn của 1 học sinh. Tính điểm trung bình và xuất ra kết quả
        public double CalculateTheAverageScore(double math,double literature)
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
            double Math = testInputDouble(EnterMath);
            Console.Write("\n Enter your literature score:");
            string EnterLiterature = Console.ReadLine();
            double Literature = testInputDouble(EnterLiterature);
            double average = CalculateTheAverageScore(Math, Literature);
            Console.Write("\n  The Average Score of {0} is : {1} ", name,average) ;

            return;
        }
        #endregion

        #region 

        #endregion
    }
}
