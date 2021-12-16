using System;

namespace BaiTapTrenKteam
{
    class ProgramBT
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;// sử dụng được tiếng việt uotput
            Console.InputEncoding = System.Text.Encoding.UTF8;// sử dụng được tiếng việt input
            ThuatToanBT cls = new ThuatToanBT();// khai báo để sử dụng các phương thức của class khác

            cls.exercice32();


            Console.ReadKey();

        
        }
    }
}
