using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestDemo
{
    internal class BaiTapJava
    {
        /*
         * viết hàm làm tròn
         * intput double
         * return int
         * request : if sau dáu phẩy bé hơn 5 làm tròn xuống else ngược lại 
         * chỉ có 1 số sau dấu phẩy
         */
        public int round(double n)
        {
            int result = 0;
            int i = (int)(n % 1)*10;
            if (i < 5)
            {
                result = (int)(n);
            }
            else
            {
                result = (int)(n+1);
            }
            return result;
        }
   

        
    }
}
