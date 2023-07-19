
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CShapeTutoriol
{
// using <tên Thư Viên.  chỉ cho trình biên dịch biết những thư viện dc sử dụng trong chương trình
// thư viện là 1 tập các phương kiểu dữ liệu nào đó tạo ra nhằm hổ trợ cho việc lập trình nhanh chống hiệu quả hơn
    public class Syngtax //chỉ tên của chương trình
    //khối qoặc nhọn bên dưới phụ thuộc vào namespacse. namespace có thể chứa nhiều lớp 
    {
        // qui tắc lập trình và phím tắt
        class QUITAC
        {
            // khối câu lệnh lớp (class)
            class Example
            {
                // hàm main là hàm dc tạo săn và là hàm chính của chương trình nó sẽ chạy đầu tiên khi program run 
                public static void main(string[] args)
                { 

                }
            }
            /// <summary>
            /// khái niệm hàm và phương thức
            /// hàm : sẽ trả về kiểu dữ liệu z đó
            /// phương thức : ko trả về kiểu dữ liệu z đó 
            /// 
            /// phím tắp của comment
            ///  ctrl +k +c : TẠO COMMENT 
            ///  ctrl +K +U : ĐỐNG COMMENT 
            ///  </summary>
          
            #region vùng có thể ẩn đi
            // tạo ra 1 vùng có thẻ đống lại
            // câu trúc
            //#region <các câu lệnh > #endregion

            #endregion

        }

        //co ban
        class COBAN
        {
            static int i = 5;
             
            public void study()
            {

                #region Các câu lệnh nhập xuât
                if (i == 6)
                {


                    Console.Write("ky tu");// in giá trị ra màn hình các ký tự trong giấu ngoạc kép 
                    Console.Write("ky tu /n"); // ký tự /n dùng dể xuống dòng
                    Console.WriteLine("Hello World!");// in giá trị ra màn hình các ký tự trong giấu ngoạc kép và xuống dòng
                    Console.Read(); // nhập giá trị vào chương trình và dc trả về kiêu số nguyên theo bảng mã ASKI
                    Console.ReadLine(); // đợi người dùng nhấn phím enter 
                    Console.ReadKey(); // dừng màn hình khi chạy chương trình


                    int a = 5; // khợi tạo biến a có giá trị = 5 có kiêu dữ liệu là interger
                    long b = 5; //  khợi tạo biến a có giá trị = 5 có kiêu dữ liệu là long
                    Console.WriteLine("gia tri a = ", a); // giá trị a là biến đã dc khợi tạo, khi in ra màn hình với giá trị của biên a
                    Console.WriteLine(" {0} {1] {2} ", a, b, "tam");//các {n} ở trong dấu "" là các phép gán cho lần lượt các giá trị ở sau dấu "" 
                                                                    //và được bắt đầu từ số 0 , phải có dấu phảy ngan cách
                }
                Console.WriteLine(Console.Read());// nhập gái trị và in ra màn hình chỉ 1 ký tự 
                Console.WriteLine(Console.ReadLine());// nhập gái trị vào bàn phím cho tới khi nhấn phím enter mới dừng
                Console.ReadKey();// nhập 1 ký tự từ bàn phím và kiểu dữ liệu trả về là true hoạc false 
                                  //nếu true thì ko ghi ra màn hinh <=> false thì hiện thị ra màn hình
                #endregion

                #region Biến
                /* 
                    * biến 
                    * - là 1 giá trị có thể thay đổi dc
                    * - là tên gọi tham chiéu đến 1 vùng nào đó trông bộ nhớ
                    * - là thành phần cốt lõi của 11 ngôn ngữ lập trình 
                    * 
                    * * cách dùng
                    * -lưu trữ dữ liệu và tái sử dụng
                    * -thao tác với bộ  nhớ 1 cách dẽ dàng
                 */
                if (i == 6)
                {


                    int bienA;//khai báo "biếnA" với kiểu dữ liệu integer 
                    int bienB = 10;//khai báo "biếnA" với kiểu dữ liệu integer với giá trị =10
                    string a = "chuoi";
                    float b = 1.2f;
                    char d = 'g';
                    Console.WriteLine(a, b, d, bienA=2);
                    Console.WriteLine("bienB= ", bienB);//xuất giá trị biênb ra màn hình với giá trị = 10
                    bienA = bienB;
                    bienB=bienA;
                }
                /* cấu trúc
                 *  <kiểu dữ liệu> <tên biến>
                 *  chú ý khi khởi tạo giá trị cho biên 
                 *  biến kiểu chuổi có dấu ngoặc kéo ""
                 *  biên kiểu  số thục phải có chữ f ở cuối (vd float sothuc=7.8f )
                 *  biến kiểu ký tự phải có dấu ngoặc đơn ''
                 *  
                 *  
                 *  *Một số quy tắc khi đặt tên biến cũng như là các định danh khác:

                   -Tên biến là một chuỗi ký tự liên kết (không có khoảng trắng) và không chứa ký tự đặc biệt.
                   -Tên biến không được đặt bằng tiếng việt có dấu.
                   -Tên không được bắt đầu bằng số.
                   -Tên biến không được trùng nhau.
                   -Tên biến không được trùng với từ khóa
                   - Tên biến phân biệt chữ hoa chư thường 

                 */


                #endregion

                #region kiểu dữ liệu

                /*kiểu dữ liệu
                     *-là tập hợi các nhóm dữ liệu có cùng đặc tính
                     *-cùng cách lưa trữ và thao tác xử lý trên trường dữ liệu dó
                   * -là 1 tính hiệu đẻ trình biên dịch nhận biêt kích thước của một biến và khả năng của nó
                     *
                     *gồm hai loại
                     *    => định sẳn
                     * -là kiểu giá trị
                  *    => tự định nghia
                     *-kiểu thanm chiếu
                    */


                /*
                 * biến có vùng giá trị lớn hơn có thẻ chứa biến có vùng giá trị nhỏ hơn
                 * 
                 * kiểu số nguyên:
                 * byte < sbyte <  short < ushort < int < uint < long < ulong
                 * 
                 * kiểu số thực :
                 * float < double < decimal 
                 *  * chú ý : float có f of F là hậu tố
                 *  *         decimal có m ỏ M là hậu tố
                 * 
                 * kiểu ký tự : char
                 * 
                 * kiểu logic : bool  ( có miên giá trị là true hoạc false )
                 * 
                 */
               

                #endregion

                #region toán tử trông c#
                if (i == 6)
                {
                    int a = 10, b = 8, c;
                    bool d;
                    c = a % b;//chia lấy phần dư
                    a++;// tăng a thêm 1 ( sử dụng a rồi mới tăng )
                    ++a;// tang a thêm 1 ( tang a rồi mới sử dụng
                    d = a == b; //== là phép bằng trả về giá trị là kiểu bool true or false
                    d = a != b;// là phép toán khác

                    // toán tự logic
                    // && là và cả a và b
                    // || là hoặc chỉ cần 1 cái đúng => đúng
                    // ! là đảo ngược từ true => false

                    // toán tử khởi tạo và gán
                    c = a; // là phép gáng giá trị của c qua cho a
                    a += 1;// có nghĩa là a = a+1

                    // toán tử so sánh trên bit
                    // & 

                    // toán tử khác 
                    c = sizeof(int);// trả về kích cỡ của 1 kiểu dữ liệu
                                    //typeof() trả về kiểu của một lớp 
                                    // new  : cấp phát vùng nhớ mới, áp dụng cho kiệu dữ liệu tham chiếu 
                                    // is = xác định đối tượng có phải là một kiểu cụ thể nào đó hay ko . nếu đúng => true ! false
                                    // as ép kiểu mà ko gây ra lỗi nếu ko dc sẽ trả về null
                                    // ?: được gọi là toán tử 3 ngôi tương đương câu điều kiện if
                                    // cú pháp : (toan hạng 1 ) ?: (toán hạng 2) : ( toán hạng 3)
                                    // ý nghĩa : nếu hạng 1 true thì thực hiện hạng 2 ngược lại thực hiện hạng 3
                                    // , sử dụng dấu phẩy để kết nối hai biểu thức 
                                    // cú pháp (biểu thức 1 , biểu thức 2) 
                                    // ý nghĩa : duyệt qua biểu thức 1 sau đó duyệt qua biểu thức 2 trả về giá trị của biểu thức2

                }


                #endregion

                #region hằng
                /* hằng
                 *  Là một biến những giá trị không thay đổi trong suốt chương trình.
                    Bắt buộc phải khởi tạo giá trị khi khai báo.
                 */


                // cú pháp
                // const <kiểu dữ liệu> <tên biến> = <giá trị hằng>;
                if (i == 6)
                {
                    const int con = 13;
                    Console.Write(con);

                }

                #endregion

                #region ép kiểu

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

                #region  1. ép kiẻu ngầm định
                if (true)
                {
                    int k = 10;
                    long tt = k;
                    float d = 11.3f;
                    double j = d;
                    Console.WriteLine("gia tri cua biet tt là {0} , j la {1}" + tt, j);
                }
                #endregion

                #region 2. ép kiểu tường minh
                /* 
                 * cú pháp 
                 * (<kiểu dữ liệu>)<biến cần ép kiểu>
                 * ta có thể ép kiểu dũ liệu lớn hơn về kiểu dữ liệu nhỏ hơn mà ko báo lỗi
                 * nếu dữ liệu cần ép vượt quá miền giá trị của kiểu dữ liệu muốn ép về thì chương trình sẽ tự cắt bit cho phù hợp với khả năng chứa biến dữ liệu đó (cắt từ bên trái qua )
                 */
                if (i == 6)
                {
                    int q = 300;
                    byte e = 0;
                    q = (byte)e;
                }
                #endregion

                #region 3 . sử dụng phương thức lớp hỗ trợ sẳn

                #region parse()
                /*
                 * cú pháp
                 *          <kiểu dữ liệu>.parse(<dữ liệu cần chuyển đổi>)
                 * ý nghĩa
                 *        -chuyển đổi mọt chuổi sang 1 kiểu dữ liệu tương ứng
                 *        -phương thức trả về giá trị kết quả chuyển kiểu nếu chuyển kiểu thành công nếu sai báo lỗi chương trình 
                 */
                if (true)
                {
                    string a ="2"; 
                    a = Console.ReadLine();
                    Int16 b;
                    b = Int16.Parse(a);
                }
                #endregion

                #region tryparse
                //cú pháp
                //   < kiểu dữ liệu>.tryparse(<dữ liệu cần chuyển đổi>, out <biến chứa kết quả trả về>)            
                // ví dụ : i = int.tryparse(s, out k);
                //Console.WriteLine(i == true? "thanhcong" : "thatbai");

                /*
                 * i là biến kiểm tra việc ép kiểu có thành công hay ko 
                 * s là biến dữ liệu cần chuyển đổi 
                 * k biến chứa kết quả trả về 
                 */
                if (i == 6)
                {
                    string a = Console.ReadLine();
                    int b = 0;
                    bool i;
                    i = int.TryParse(a, out b);
                }
                #endregion
                #endregion

                #region 4. convert
                //cú pháp
                // <kiểu dữ liệu> <tên biến> = convert.<1 trong những hàm hỗ trợ săn>(<giá trị truyền vào>);
                if (i == 6)
                {
                    long b = 444;

                    int a = Convert.ToByte(b);
                }
                #endregion
                #endregion

                #region cấu trúc điều kiện
                #region cau truc if

                // Cú pháp: câu điều kiện dạng thiếu 
                // If([Biểu thức điều kiện]) <Câu lệnh thực hiện>

                // cú pháp: câu điệu kiện dạng đủ 
                //If <Biểu thức điều kiện> <Câu lệnh thực hiện 1> else <Câu lệnh thực hiện 2>
                // nếu phần câu lệnh thục hiện nhiều hơn nhiều hơn 1 câu lệnh thì ohair dc đặt trông dấu ngoặc nhọn
                if (i == 67)
                {

                }
                else { }
                #endregion

                #region cau truc swith case
                //Cú pháp:cấu trúc swith case dạng thiếu 
                //switch (<biểu thức>)

                //{

                //case <giá trị thứ 1>: <câu lệnh thứ 1>;

                //                            break;

                //case <giá trị thứ 2>: <câu lệnh thứ 2>;

                //                            break;

                //. . .

                //case <giá trị thứ n>: <câu lệnh thứ n>;

                //                            break;

                //}
                int switchphay = 4;
                switch (switchphay)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                }



                // cấu trúc swith case dạng đủ 
                //switch (<biểu thức>)

                //{

                //case <giá trị thứ 1>: <câu lệnh thứ 1>;

                //                            break;

                //case <giá trị thứ 2>: <câu lệnh thứ 2>;

                //                            break;

                //. . .

                //case <giá trị thứ n>: <câu lệnh thứ n>;

                //                            break;

                //default: <câu lệnh mặc định>;

                //                break;

                // }
                switch (switchphay)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            #endregion
            #endregion

                #region câu trúc vòng lặp

                #region câu lệnh goto
                // goto <label>;
                diemdengoto:
                    if (i == 6)
                    {
                        goto diemdengoto;
                    }
                    //Trong đó label là một nhãn đích đến trong code. Nơi mà code sẽ tiếp tục được thực thi từ đó.
                    //Cấu trúc của một label: <Tên label>:
                    //goto là từ khóa thông báo cho trình biên dịch biết sẽ đi đến nhãn ngay sau để tiếp tục thực thi code.
                    #endregion

                    #region câu lệnh for
                    // cú pháp
                    //for ([Khởi tạo]; [Điều kiện lặp]; [Bước lặp lại])

                    //  {

                    // Khối lệnh được lặp lại. Có thể bỏ trống

                    //  }
                    //Các phần [Khởi tạo]; [Điều kiện lặp]; [Bước lặp lại] hoàn toàn có thể để trống như ví dụ sau.
                    //Mỗi đoạn[Khởi tạo]; hay[Điều kiện lặp]; hay[Bước lặp lại] là một câu lệnh riêng.
                    for (int i = 0; 5 < i; i++)
                    {
                        // câu lệnh
                    }
                    #endregion

                    #region  Vòng lặp foreach trong lập trình C# cơ bản

                    //            Cú pháp
                    //foreach (< kiểu dữ liệu > < tên biến tạm> in < tên mảng hoặc tập hợp>)

                    //{

                    //                // Code xử lý        

                    //            }

                    //            Trong đó:

                    //Các từ khoá foreach, in là từ khoá bắt buộc.
                    //< kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng hoặc tập hợp.
                    //< tên biến tạm> là tên 1 biến tạm đại diện cho phần tử đang xét khi duyệt mảng hoặc tập hợp.
                    // < tên mảng hoặc tập hợp> là tên của mảng hoặc tập hợp cần duyệt.
                    int[] monication = new int[i];
                    foreach (var item in monication)
                    {

                    }

                    #endregion

                    #region câu lệnh while
                    // cú pháp
                    //  while (< Điều kiện lặp>)

                    //  {

                    //      // khối lệnh lặp lại

                    //  }
                    // các câu lệnh được lặp lại cho đên khi thảo điều kiên lặp = false 
                    while (i == 6)
                    {

                    }
                    #endregion

                    #region câu lệnh while do
                    // cú pháp  
                    //  do

                    //  {

                    //    // khối lệnh lặp lai

                    //  }
                    //  while (< Điều kiện lặp>);

                    //vòng lặp do while sẽ thực hiện câu lệnh trong khối code xong rồi mới kiểm tra điều kiện lặp.
                    //Cuối vòng lặp do while có dấu ; ở cuối
                    do
                    {

                    } while (i == 8);
                    #endregion

                    #endregion

                #region object, dynamic và var
                #region kiểu dữ liệu object 
                //kiểu dữ liệu object cung cấp một số phương thức ảo cho phép mình overload để sử dụng
                // To string : trả về kiêu chuổi cho đối tượng (chuyển từ kiểu dữ liệu nào đó về kiểu chuổi)
                //GetHashcode() : trả về mã số băn của đối tượng 
                // Equals : so sánh hai đối tượng và trả về true khi hai giá trị bằng nha, và ngược lại trả về false
                //getType : trả về kiêu dữ liệu cho đối tượng

                #region Boxing Và unBoxing
                //Boxing là quá trình chuyển dữ liệu từ kiểu dữ liệu giá trị sang kiểu dữ liệu tham chiếu.
                //Quá trình boxing:
                //Khởi tạo một đối tượng trong vùng nhớ Heap(đã được trình bày trong bài KIỂU DỮ LIỆU TRONG C#).
                //Copy giá trị của biến có kiểu dữ liệu giá trị vào đối tượng này.

                // Unboxing là quá trình ngược lại với boxing, tức là đưa dữ liệu từ kiểu dữ liệu tham chiếu về kiểu dữ liệu giá trị.
                //Unboxing được thực hiện tường minh và thông qua cách ép kiểu tường minh(đã được trình bày trong bài ÉP KIỂU TRONG C#).
                // Phải chắc chắn rằng đối tượng cần boxing thuộc đúng kiểu dữ liệu đưa ra.Nếu không việc unboxing sẽ báo lỗi chương trình.
                // Quá trình unboxing:
                //Kiểm tra xem đối tượng cần un - boxing có thuộc đúng kiểu dữ liệu đưa ra hay không.
                //Nếu đúng thì thực hiện copy giá trị của đối tượng sang biến dữ liệu kiểu giá trị. Ngược lại thì thông báo lỗi.
                #endregion
                #endregion
                #region kiêu dữ liệu dynamic 
                // cú pháp :  dynamic < tên biến >;
                //dynamic là từ khóa.
                //< tên biến > là tên do người dùng đặt.

                //Đặc điểm của kiểu dynamic:
                //Các đối tượng thuộc kiểu dynamic sẽ không xác định được kiểu cho đến khi chương trình được thực thi.
                //Tức là trình biên dịch sẽ bỏ qua tất cả lỗi về cú pháp, việc kiểm tra này sẽ thực hiện khi chương trình thực thi.
                #endregion
                #region var
                #endregion
                #endregion

                #region cấu trúc của hàm cơ bản trong c#
                // cú pháp
                //[Từ khóa 1] [Từ khóa 2] [Từ khóa n]  < Kiểu dữ liệu trả về> < Tên hàm > ([Parameter])
                //{ }

                //[Từ khóa 1], [Từ khóa 2], [Từ khóa n] là các từ khóa như: public, static, read only … và có thể không điền.
                // Kiểu dữ liệu trả về như: từ khóa void, hay mọi kiểu dữ liệu như int, long, bool, SinhVien…
                // Tên hàm:
                //Là tên gọi của hàm.
                //Tên bạn có thể đặt tùy ý nhưng nên đặt tên theo quy tắc đặt tên để có sự đồng bộ ngầm định giữa các lập trình viên và dễ tìm, dễ nhớ(xem lại quy tắc đặt tên ở bài BIẾN TRONG C#).
                //Hãy xem cách khởi tạo hàm giống khởi tạo một biến ở chỗ. Đều cần kiểu dữ liệu và tên.Có thể có các từ khóa. Tên để tái sử dụng hàm ở nơi mong muốn.
                //Parameter là tham số truyền vào để sử dụng nội bộ trong hàm.Cấu trúc khởi tạo như một biến bình thường.Có thể không điền.
                //Hàm chỉ được khai báo bên trong class.

                // hàm main 
                //static void Main(string[] args)
                //{
                //}
                //static là từ khóa static (sẽ tìm hiểu kỹ hơn ở bài sau). Có thể không sử dụng cũng được.
                //Nhưng ở trường hợp hàm Main của console C# thì phải có.
                //void là kiểu trả về.Với hàm có kiểu trả về là void thì sẽ không cần từ khóa return trong hàm.
                //Hoặc có nhưng chỉ đơn giản là ghi return;
                //Main là tên hàm. Có thể đặt tùy ý.
                //Nhưng ở trường hợp này là bắt buộc phải là Main vì mỗi chương trình console C# đều cần hàm Main.
                //string[] args là parameter truyền từ bên ngoài vào để sử dụng hàm.Có thể không có cũng được.
                //nhưng ở trường hợp hàm Main của console C# là bắt buộc phải có.
                //Ở đây có thể thay thế tên args bằng bất cứ tên nào khác như đặt tên một biến bình thường.

                #endregion;

                #region Biến toàn cục và biến cục bộ trong C#
                //Biến toàn cục là biến được khai báo ở phân cấp cao hơn vị trí đang xác định.

                //Biến cục bộ là biến được khai báo ở cùng phân cấp tại vị trí đang xác định.

                #endregion

                #region Từ khóa ref và out trong C#

                // từ khóa ref
                //Từ khóa ref phải có trước tên parametter của hàm và trước tên biến truyền vào khi gọi hàm sử dụng.
                //Truyền parameter có từ khóa ref bắt buộc phải là một biến(không thể truyền vào một hằng vì hằng là giá trị không thay đổi).
                //Có thể có một hoặc nhiều parameter với từ khóa ref trong lời khai báo hàm.
                //Biến truyền vào có từ khóa ref thì phải được khởi tạo giá trị trước khi truyền vào.
                //Hàm sử dụng sẽ thao tác trực tiếp với vùng nhớ của các parameter trên RAM. Cho nên kết thúc lời gọi hàm giá trị các parameter sẽ bị thay đổi.

                //Từ khóa out
                //từ khóa out cũng tương tự từ khóa ref. Đó là:
                //Vùng nhớ của các parameter sẽ được hàm sử dụng thao tác trực tiếp, dẫn đến khi kết thúc lời gọi hàm giá trị của các parametter có thể bị thay đổi.
                // Phải có từ khóa out trước tên parameter của hàm và trước tên biến truyền vào khi gọi hàm sử dụng.
                //Nhưng có một sự khác biệt đó là:
                // Biến truyền vào có từ khóa out sẽ không cần khởi tạo giá trị ban đầu.
                // Parameter đó chỉ như một thùng chứa kết quả trả về khi kết thúc gọi hàm.
                // Đồng thời parameter đó phải được khởi tạo ngay bên trong lời gọi hàm.
                #endregion

                #region mảng

                //Mảng là
                // Tập hợp các đối tượng có cùng kiểu dữ liệu.
                // Mỗi đối tượng trong mảng được gọi là một phần tử.
                // Các phần tử phân biệt với nhau bằng chỉ số phần tử. Trong C# chỉ số phần tử là các số nguyên không âm và bắt đầu từ 0 1 2 3…
                //Đặc điểm của mảng:
                // Các phần tử trong mảng dùng chung một tên và được truy xuất thông qua chỉ số phần tử.
                // Một mảng cần có giới hạn số phần tử mà mảng có thể chứa.
                // Phải cấp phát vùng nhớ mới có thể sử dụng mảng.
                // Vị trí ô nhớ của các phần tử trong mảng được cấp phát liền kề nhau.

                #region Mảng 1 chiều trong C#

                // Cú pháp:
                //< kiểu dữ liệu> [] < tên mảng >;

                //            Trong đó:
                //< kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng.
                //Cặp dấu[] là ký hiệu cho khai báo mảng 1 chiều.
                //< tên mảng > là tên của mảng, cách đặt tên mảng cũng như cách đặt tên biến
                //(quy tắc đặt tên biến đã trình bày trong BIẾN TRONG C#).
                //Để sử dụng được mảng ta phải khởi tạo giá trị hoặc cấp phát vùng nhớ cho mảng. Cấp phát vùng nhớ:
                //Được thực hiện thông qua toán tử new(đã trình bày trong bài TOÁN TỬ TRONG C#).
                //Lưu ý là khi cấp phát vùng nhớ cho mảng 1 chiều ta cần chỉ ra số phần tử tối đa của mảng.

                //Sau khi mảng được cấp phát vùng nhớ thì các phần tử trong mảng sẽ mang giá trị mặc định:
                //Đối với số nguyên là 0
                //Đối với số thực là 0.0
                //Đối với kiểu ký tự là ‘’ (ký tự rỗng)
                //Đối với kiểu tham chiếu là null

                //Khởi tạo giá trị
                //<kiểu dữ liệu>[] <tên mảng> = { <giá trị 1>, …, <giá trị n> };

                //<kiểu dữ liệu>[] <tên mảng> = new <kiểu dữ liệu>[] { <giá trị 1>, …, <giá trị n> };
                //Các giá trị khởi tạo nằm trong cặp dấu ngoặc ngọn { }
                //và cách nhau bởi dấu phẩy.
                //Chúng ta không cần cung cấp số phần tử tối đa mà trình biên dịch sẽ tự đếm xem bạn đã khởi tạo bao nhiêu giá trị và xem nó như số phần tử tối đa.
                //Vì thế dù việc khai báo số phần tử tối đa không lỗi nhưng trong trường hợp này nó không có ý nghĩa lắm!

                int[] A= new int[2] {1,2};

                #endregion

                #region Mảng 2 chiều trong C#
                //            Cú pháp:
                //< kiểu dữ liệu> [ , ] < tên mảng >;

                //            Trong đó:

                //< kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng.
                //Cặp dấu[,] là ký hiệu cho khai báo mảng 2 chiều.
                //< tên mảng > là tên của mảng, cách đặt tên mảng cũng như cách đặt tên biến(quy tắc đặt tên biến đã trình bày trong BIẾN TRONG C#).
                //Để sử dụng được mảng ta phải khởi tạo giá trị hoặc cấp phát vùng nhớ cho mảng.


                //Cấp phát vùng nhớ
                //Được thực hiện thông qua toán tử new

                // Chúng ta có thể khởi tạo giá trị khác mà chúng ta mong muốn ngay khi cấp phát vùng nhớ bằng cú pháp sau:

                //< kiểu dữ liệu>[,] < tên mảng > = new < kiểu dữ liệu>[]

                //{

                //                { < giá trị dòng 1 cột 1 >, …, < giá trị dòng 1 cột n> },

                //           …

                //           { < giá trị dòng m cột 1 >, …, < giá trị dòng m cột n > }

                //            };

                // hay

                //Khởi tạo giá trị
                //            Cú pháp:
                //< kiểu dữ liệu>[,] < tên mảng > =

                //{

                //                { < giá trị dòng 1 cột 1 >, …, < giá trị dòng 1 cột n> },

                //            …

                //           { < giá trị dòng m cột 1 >, …, < giá trị dòng m cột n > }

                //            };
                #endregion

                #region mảng nhiều chiều
                //            < kiểu dữ liệu> [ , , ] < tên mảng >;

                //            Trong đó:

                //< kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng.
                //Cặp dấu[,,] là ký hiệu cho khai báo mảng 3 chiều.
                //< tên mảng > là tên của mảng, cách đặt tên mảng cũng như cách đặt tên biến


                #endregion

                #region  Mảng jagged trong C#
                //            Mảng jagged trong C#
                //Mảng jagged(hay còn gọi là mảng lởm chởm) là một mảng của các mảng. Nghe có vẻ giống mảng 2 chiều đã học nhưng thực ra là rất khác.

                //Đặc điểm của mảng jagged cũng là điểm khác biệt giữa mảng này với mảng 2 chiều:

                //            Số phần tử của chiều thứ 2 có thể khác nhau(đối với mảng 2 chiều là bằng nhau).
                //Các ô nhớ được cấp phát có thể không nằm liền kề nhau(đối với mảng 2 chiều là các ô nhớ sẽ được cấp phát liền kề nhau).
                //Bản chất vẫn là mảng 1 chiều nhưng các phần tử có thể chứa 1 mảng khác.
                //Ưu điểm lớn nhất của mảng jagged là tiết kiệm bộ nhớ. Bởi vì khi mình cần xài bao nhiêu thì mình cấp phát bấy nhiêu nên sẽ không bị thừa một ô nhớ nào.

                //Khai báo mảng jagged
                //Cú pháp:
                //< kiểu dữ liệu> [ ][ ] < tên mảng >;

                //            Trong đó:

                //< kiểu dữ liệu> là kiểu dữ liệu của các phần tử trong mảng.
                //Cặp dấu[][ ] là ký hiệu cho khai báo mảng jagged.
                //< tên mảng > là tên của mảng, cách đặt tên mảng cũng như cách đặt tên biến(quy tắc đặt tên biến đã trình bày trong BIẾN TRONG C#).
                #endregion

                #region Array

                //Array.Sort(< tên mảng >)
                //Array.Reverse(< tên mảng >)
                //Array.IndexOf(< tên mảng >, < phần tử cần tìm >)

                #endregion

                #endregion

                #region Lớp String trong Lập trình C# căn bản
                if (i == 6)
                {
                    string a = "hahahaha";
                    int i = a.Length; // đếm chuổi a = 1 số có kiểu int rồi gáng cho biến i
                    string b = "hihihi";
                    char c = '!';
                    string v;
                    string.Compare(a, b);// so sáng hai chuổi a,b có bàng nhau hay ko 
                                         // nếu bàng nhau thì trả về 0 ,nếu a>b thì bằng 1 và ngược lại bằng -1
                    a.CompareTo(b);// so sáng hai chuổi a,b có bàng nhau hay ko 
                                   // nếu bàng nhau thì trả về 0 ,nếu a>b thì bằng 1 và ngược lại bằng -1

                    String.Concat(a, b); // nối hai chuổi lại với nhau
                    String.IsNullOrEmpty(a);// kiểu tra xem chuổi a có null hay tróng rổng hay ko nếu đúng trả về true ngược lại false

                    a.IndexOf('h');// trả về một số kiểu int là vị trý xuất hiện đầu tiên của ký tự trông chuổi
                    a.LastIndexOf('a');//trả về một số kiểu int là vị trý xuất hiện cuối cùng của ký tự trông chuổi
                    a.Split(a);// trả về một mạng các chuổi dược kắt ra từ chuổi ban đầu có ở nhưng nơi có ký tụ đó
                    a.Substring(2, 3); // trả về 1 chuổi mới dc cắt từ vị trí 2 với 3 ký tự
                    a.Remove(3);//trả về chuổi mới dã gỡ vỏ từ vị trí thứ 3
                    a.Replace('a', 'e');// trả về chuổi mới khi đã thay thế ký tự a = e 
                    a.ToUpper(); //viết hoa 
                    v = a.ToLower();// viết thường
                    Console.WriteLine(v,c);
                }

                #endregion

                #region Lớp StringBuilder trong C#
                //            Cú pháp:
                //Khởi tạo một đối tượng rỗng:
                //StringBuilder < tên biến > = new StringBuilder();

                //            Khởi tạo một đối tượng chứa 1 chuỗi cho trước:
                //            StringBuilder < tên biến > = new StringBuilder(< chuỗi giá trị >);

                //Lớp StringBuilder được .NET xây dựng sẵn giúp chúng ta thao tác trực tiếp với chuỗi gốc và giúp tiết kiệm bộ nhớ hơn so với lớp String.

                //            Đặc điểm của StringBuilder là:

                //            Cho phép thao tác trực tiếp trên chuỗi ban đầu.
                //Có khả năng tự mở rộng vùng nhớ khi cần thiết.
                //Không cho phép lớp khác kế thừa
                #endregion

                #region Struct trong lập trình C# căn bản
                // đặc điểm 
                //Struct là một kiểu dữ liệu có cấu trúc, được kết hợp từ các kiểu dữ liệu nguyên thuỷ do người lập trình định nghĩa
                //để thuận tiện trong việc quản lý dữ liệu và lập trình.

                //            Đặc điểm của struct:
                //Là một kiểu dữ liệu tham trị (kiểu dữ liệu tham trị đã được trình bày trong bài KIỂU DỮ LIỆU )
                //Dùng để đóng gói các trường dữ liệu khác nhau nhưng có liên quan đến nhau.
                //Bên trong struct ngoài các biến có kiểu dữ liệu cơ bản còn có các phương thức, các struct khác.
                //Muốn sử dụng phải khởi tạo cấp phát vùng nhớ cho đối tượng thông qua toán tử new.
                //Struct không được phép kế thừa

                //            Cú pháp:
                //struct <tên struct>

                //{

                //            public <danh sách các biến>;

                //    }
                #endregion

                #region Enum trong lập trình C#

                //            Enum là từ khoá dùng để khai báo một kiểu liệt kê(Enumeration). Kiểu liệt kê là một tập hợp các hằng số do người dùng tự định nghĩa.

                //Nói cách khác, enum là cách mà C# hỗ trợ người dùng gom nhóm các hằng số lại với nhau và có chung một tên gọi (thường các hằng số này sẽ có liên quan với nhau ví dụ như các trạng thái của 1 sự vật, các tính chất của 1 sự vật, . . .)

                //Đặc điểm của enum:

                //Là một kiểu dữ liệu tham trị(kiểu dữ liệu tham trị đã được trình bày trong bài KIỂU DỮ LIỆU)
                //Enum không được phép kế thừa(khái niệm về kế thừa sẽ trình bày trong bài KẾ THỪA TRONG C#).
                //Khai báo và sử dụng enum

                //Khai báo
                //Cú pháp:
                //enum <tên enum>

                //{

                //                <danh sách các biểu tượng hằng>

                //}

                //    Trong đó:

                //<tên enum> là tên kiểu liệt kê do mình tự đặt và tuân thủ theo quy tắc đặt tên(đã trình bày trong bài BIẾN TRONG C#).
                //<danh sách các biểu tượng hằng> là danh sách các biểu tượng hằng thành phần mỗi biểu tượng hằng cách nhau bằng dấu “,”.

                #endregion

             

            }
        }
        
       

       
    }

}