using System;
/// <summary>
///  nghiên cứu cú pháp
/// </summary>
namespace SynctaxStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            XinChao("tron");
            IfConditions();
            Console.ReadKey(); // dừng màn hình lại đẻ xem
        }

        internal static void XinChao(string user = "")
        {
            Console.WriteLine($"Xin chao {user}!");
            Console.WriteLine("Hello World!");
            Console.Write("kieu chu \n"); // xuất ra màn hình hình kiểu ký tự dạng chũ là hahah
            Console.WriteLine("kieu so" + 10); // xuất ra dữ liệu kiểu số là 10
            Console.WriteLine("ko xuong hang voi  Write  "); // xuất ra mafn hình những ko xuống hàng 
            Console.Write("ky tu dac biet   \n"); // ký tự "\n' dùng đẻ xuống dòng
            Console.WriteLine("Xuong dong voi  WiteLine "); // xuất ra màn hình và xuống dồng
            Console.Write(Environment.NewLine);
            // bôi den và nhấn ctrl + k + c để comment toan bộ
            // bôi đen và nhấn ctrl + k + U để xóa comment đó
            Console.Write("{0} {1}", 1, 2); //gán gá trị thú tự và bắt đàu với cú pháp ("{0} {1} ....: , giá trị đầu , giá trị tiếp theo ...
            Console.Write("nhap 1 ky tu :");
            Console.WriteLine(Console.Read());//thực hiện theo thứu tự từ trông ngoặc trước 
            //console.Read() chỉ đọc 1 ký tự từ bàn phím 
            // câu lệnh trên chỉ đọc 1 ký tự từ bàn phím và xuất ra màn hình theo bản mã anki
            Console.Write("nhap ky tu : ");
            Console.WriteLine(Console.ReadLine());
        }
        internal static void IfConditions()
        {
            // code here
        }
        //

    }
}
