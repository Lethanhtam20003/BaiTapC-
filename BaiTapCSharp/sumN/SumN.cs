using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumN
{
    class SumN
    {
        public void SumNInt()
        {
            int i = 1;
            string n;
            long s = 0;
            Console.Write("nhap so phan tu n :");
            n = Console.ReadLine();
            //đổi gái trị
            int t = int.Parse(n);
            while (i <= t)
            {
                s = s + i;
                i++;
            }
            Console.WriteLine("ket qua cua tong  {0} so lien tiep là s : {1}", n, s);
            return;
            
        }
    }
}
