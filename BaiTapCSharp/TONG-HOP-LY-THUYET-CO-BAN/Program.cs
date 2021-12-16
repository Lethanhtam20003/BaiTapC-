using System;

namespace TONG_HOP_LY_THUYET_CO_BAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" LY THUYET CO BAN");
        }
        class caccaulenhnhapxuat
        {
            static void Main(string[] args)
            {
                //Console.WriteLine($"Xin chao ");
                //Console.WriteLine("Hello World!");
                //Console.Write("kieu chu \n"); // xuất ra màn hình hình kiểu ký tự dạng chũ là hahah
                //Console.WriteLine("kieu so" + 10); // xuất ra dữ liệu kiểu số là 10
                //Console.WriteLine("ko xuong hang voi  Write  "); // xuất ra mafn hình những ko xuống hàng 
                //Console.Write("ky tu dac biet   \n"); // ký tự "\n' dùng đẻ xuống dòng
                //Console.WriteLine("Xuong dong voi  WiteLine "); // xuất ra màn hình và xuống dồng
                //Console.Write(Environment.NewLine);
                // //bôi den và nhấn ctrl + k + c để comment toan bộ
                // //bôi đen và nhấn ctrl + k + U để xóa comment đó
                //Console.Write("{0} {1}", 1, 2); //gán gá trị thú tự và bắt đàu với cú pháp ("{0} {1} ....: , giá trị đầu , giá trị tiếp theo ...
                //Console.Write("nhap 1 ky tu :");
                //Console.WriteLine(Console.Read());//thực hiện theo thứu tự từ trông ngoặc trước 
                //Console.Read(); //chỉ đọc 1 ký tự từ bàn phím câu lệnh trên chỉ đọc 1 ký tự từ bàn phím và xuất ra màn hình theo bản mã anki
                //Console.Write("nhap ky tu : ");
                //Console.WriteLine(Console.ReadLine());
                //Console.ReadKey;
            }
          }
        class bien
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Bien la gi ?");
                /* 
                * biến 
                * - là 1 giá trị có thể thay đổi dc
                * - là tên gọi tham chiéu đến 1 vùng nào đó trông bộ nhớ
                * - là thành phần cốt lõi của 11 ngôn ngữ lập trình 
                * 
                * * cách dùng
                * -lưu trữ dữ liệu và tái sử dụng
                * -thao tác với bộ  nhớ 1 cách dẽ dàng
                * *cách khai báo 
                * -<kiểu dũ liệu > <tên biến >;
                * 
                * * một số kiểu dữ liẹu cơ bản 
                * - int kiểu số nguyên 
                * - float biến kiểu số thực 
                * - string bién kiểu chuỗi 
                * - bool biến kiểu luận lý true - floas
                * - char biến kiểu ký tự
                * 
                */
                int a = 5;
                Console.WriteLine("tên biến a= {0}", a);
                Console.ReadKey();
                /*
                 * một số qui tắc đặc tên biến 
                 * tên biên là 1 chuỗi ký tự liên tiếp
                 * ko chứ ký tự đặc biệt
                 * ko dc dặc bằng tiếng việt có giấu
                 * ko dược bắt đầu bằng số 
                 * tên biến ko dc trùng nhau 
                 * tên biến ko dc trùng với từ khóa
                 * 
                 * qui tắc lạc đà 
                 * viết thường chữ cái đầu tiên và viết hoa cách chữ cái sau
                 * thường dùng cho private, protected 
                 * 
                 * qui tắc passcal 
                 * viết hao mỗi chữ cái đầu của mỗi từ
                 *dùng với những thứ còn lại
                 *
                 *chú y 
                 *nên dặt tên ngắn gọn dẽ hiểu
                 *visostudio có phân biệt chữ hoa và chữ thường
                 */

                Console.ReadKey(); // dừng màn hình lại đẻ xem
            }
        }
        class kieudulieu
            {
                static void Main(string[] args)
                {
                //    Console.WriteLine("Hello World!");
                //    /* 
                //    * KIỂU DỮ LIỆU 
                //    * - là tập hợi các nhóm dữ liệu có cùng đặc tính 
                //    * - cùng cách lưa trữ và thao tác xử lý trên trường dữ liệu dó 
                //    * - là 1 tính hiệu đẻ trình biên dịch nhận biêt kích thước của một biến và khả năng của nó 
                //    *  
                //    *  gồm hai loại 
                //    *    => định sẳn 
                //    *    -là kiểu giá trị 
                //    *    => tự định nghia 
                //    *    -kiểu thanm chiếu 
                //    */
                //    Console.ReadKey(); // dừng màn hình lại đẻ xem
                }
            }
        class epkieu 
        {
            private static void  Main(string[] args) 
            {
                /*
                 * có 4 loại ép kiểu
                 * -ép kiểu ngầm định
                 * -ép kiểu tường minh 
                 * -sử dụng phương thức lớp hổ trợ sẳn 
                 *  +dung phương thức parse(),tryparse()
                 *      *parse():
                 *      *tryparrse():
                 *  +dùng phương thức convert
                 *      *convert:
                 */
                #region ép kiẻu ngầm định
                int k = 10;
                long tt = k;
                float d = 11.3f;
                double j = d;
                Console.WriteLine("gia tri cua biet tt là {0} , j la {1}" + tt, j);
                #endregion
                #region ép kiểu tường minh
                /* 
                 * cú pháp 
                 * (<kiểu dữ liệu>)<biến cần ép kiểu>
                 * ta có thể ép kiểu dũ liệu lớn hơn về kiểu dữ liệu nhỏ hơn mà ko báo lỗi
                 * nếu dữ liệu cần ép vượt quá miền giá trị của kiểu dữ liệu muốn ép về thì chương trình sẽ tự cắt bit cho phù hợp với khả năng chứa biến dữ liệu đó (cắt từ bên trái qua )
                 */
                int a = 300;
                byte s = (byte)g;
                #endregion
                #region sử dụng phương thức lớp hỗ trợ sẳn
                #region parse()
                /*
                 * cú pháp
                 *          <kiểu dữ liệu>.parse(<dữ liệu cần chuyển đổi>)
                 * ý nghĩa
                 *        -chuyển đổi mọt chuổi sang 1 kiểu dữ liệu tương ứng
                 *        -phương thức trả về giá trị kết quả chuyển kiểu nếu chuyển kiểu thành công nếu sai báo lỗi chương trình 
                 */
                // ví dụ

                #endregion
                #endregion

            }
        }
    }
}

 