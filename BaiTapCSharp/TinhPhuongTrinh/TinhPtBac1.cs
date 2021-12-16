using System;

namespace Bai_4
{
    public class TinhPtBac1
    {
        /// <summary>
        /// Constructor - hàm khỏi tạo
        /// </summary>
        public TinhPtBac1()
        {

        }

        public void GiaiPtBac1(int a = 0, int b = 0)
        {
            // code here
            if (a == 0 && b != 0)
            {
                Console.WriteLine("Phương trinh vo nghhiem!");
                return;
            }
            else if (a != 0 && b == 0)
            {
                Console.WriteLine("Phuong trinh co 1 nghiem: 0");
                return;
            }
            else if (a == 0 && b == 0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem!");
                return;
            }
            else
            {
                // giai pt 
                var result = -b / a;
                Console.WriteLine("Pt co nghiem: {0}", result);
            }

        }
    }
}
