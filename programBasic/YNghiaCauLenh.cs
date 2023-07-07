// using <tên Thư Viên.  chỉ cho trình biên dịch biết những thư viện dc sử dụng trong chương trình
// thư viện là 1 tập các phương kiểu dữ liệu nào đó tạo ra nhằm hổ trợ cho việc lập trình nhanh chống hiệu quả hơn
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace programBasic
{
    class YNghiaCauLenh //chỉ tên của chương trình
    //khối qoặc nhọn bên dưới phụ thuộc vào namespacse. namespace có thể chứa nhiều lớp 
    {
        // qui tắc lập trình và phím tắt
        class QUITAC
        {
            // khối câu lệnh lớp (class)
            class example
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
            ///  /// </summary>
            
        }

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

                #region vùng có thể ẩn đi
                // tạo ra 1 vùng có thẻ đống lại
                // câu trúc
                //#region <các câu lệnh > #endregion
                
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
                    string f;
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
                    string a = Console.ReadLine();
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
                    for (int i = 0; i < i; i++)
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

                int[] A;

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
                    Console.WriteLine(v);
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

        class nangcao
        {
            public void study()
            {
                #region Tổng quan về Collection trong C#

                #endregion

            }
        }

        //lập trình hướng đối tượng
        class ObjectOrientedProgremming
        {
            public void study()
            {
                #region Tổng quan về lập trình hướng đối tượng
                //            Lập trình hướng đối tượng là gì?
                //Sự tiến hoá của các phương pháp lập trình
                //Đầu tiên là lập trình không có cấu trúc:

                //            Là phương pháp xuất hiện đầu tiên.Phương pháp này đơn giản chỉ là viết tất cả mã lệnh vào 1 hàm main duy nhất và chạy.
                //Ngôn ngữ sử dụng phương pháp này là Assembly(hợp ngữ).
                //Nhược điểm của phương pháp này:
                // Chỉ sử dụng biến toàn cục dẫn đến rất tốn bộ nhớ.
                // Vì có những đoạn chương trình cần sử dụng lại nhiều lần nên dẫn đến lạm dụng lệnh goto.
                // Khó hiểu, khó bảo trì, không thể tái sử dụng.
                // Khó phát triển các ứng dụng lớn.
                //Tiếp theo là lập trình có cấu trúc(lập trình thủ tục):

                //Sau 1 thời gian tồn tại người ta dần nhận ra những nhược điểm của phương pháp trên và đưa ra giải pháp đó là chia chương trình lớn ra thành các chức năng, mỗi chức năng được đưa vào 1 hàm.Khi cần dùng đến chức năng nào thì ta sẽ gọi hàm tương ứng.
                //Mỗi chương trình con lại có thể chia nhỏ ra nữa.
                //Hầu hết các ngôn ngữ lập trình đều hỗ trợ phương pháp này.
                //Ưu điểm:
                // Chương trình được module hoá, dễ hiểu, dễ bảo trì.
                // Dễ dàng tạo ra các thư viện phần mềm.
                //Nhược điểm:
                // Dữ liệu và xử lý tách rời.
                // Khi cấu trúc dữ liệu thay đổi sẽ dẫn đến thuật toán bị thay đổi.
                // Không tự động khởi tạo, giải phóng dữ liệu động.
                // Không mô tả được đầy đủ, trung thực hệ thống trong thực tế.
                //Tiếp theo là lập trình hướng đối tượng, phương pháp mà chúng ta sẽ tìm hiểu trong series này.

                //Khái niệm lập trình hướng đối tượng
                //Với mong muốn xây dựng một phương pháp lập trình trực quan, mô tả trung thực hệ thống trong thực tế vì thế phương pháp lập trình hướng đối tượng ra đời.

                //Lập trình hướng đối tượng là phương pháp lập trình lấy đối tượng làm nền tảng để xây dựng chương trình.

                //Một định nghĩa khác về lập trình hướng đối tượng đó là phương pháp lập trình dựa trên kiến trúc lớp(class) và đối tượng(object).

                //Một số khái niệm cơ bản trong lập trình hướng đối tượng
                //Đối tượng
                //Trong lập trình hướng đối tượng, đối tượng được hiểu như là 1 thực thể: người, vật hoặc 1 bảng dữ liệu, . . .

                //Một đối tượng bao gồm 2 thông tin: thuộc tính và phương thức.

                // Thuộc tính chính là những thông tin, đặc điểm của đối tượng.Ví dụ: một người sẽ có họ tên, ngày sinh, màu da, kiểu tóc, . . .
                // Phương thức là những thao tác, hành động mà đối tượng đó có thể thực hiện.Ví dụ: một người sẽ có thể thực hiện hành động nói, đi, ăn, uống, . . .
                //Lớp
                //Các đối tượng có các đặc tính tương tự nhau được gom lại thành 1 lớp đối tượng.

                //Bên trong lớp cũng có 2 thành phần chính đó là thuộc tính và phương thức.

                //Ngoài ra, lớp còn được dùng để định nghĩa ra kiểu dữ liệu mới.

                //Sự khác nhau giữa đối tượng và lớp
                //Lớp là một khuôn mẫu còn đối tượng là một thể hiện cụ thể dựa trên khuôn mẫu đó.

                //Để dễ hiểu hơn mình sẽ lấy một ví dụ thực tế:

                //Nói về con mèo thì lớp chính là loài mèo. Loài mèo có:
                // Các thông tin, đặc điểm như 4 chân, 2 mắt, có đuôi, có chiều cao, có cân nặng, màu lông . . .
                // Các hành động như: kêu meo meo, đi, ăn, ngủ, . . .
                //Như vậy mọi động vật thuộc loài mèo sẽ có những đặc điểm như trên.
                //Đối tượng chính là một con mèo cụ thể nào đó như con mèo con đang nằm dưới chân mình.
                //Một ví dụ khác. Ví dụ này mình sẽ dùng 1 hình ảnh để minh hoạ:

                //Tổng quan về lập trình hướng đối tượng

                // Bạn thấy đấy khi nói đến xe otô thì lớp chính khuôn mẫu của cái xe với các đặc trưng như có 4 bánh và có thiết kế tương tự như hình vẽ. Đối tượng chính là các chiếc xe otô cụ thể như Toyota camry, Honda city, Ford ranger.
                //Sự xuất hiện của 2 khái niệm mới là lớp và đối tượng chính là đặc trưng của phương pháp lập trình hướng đối tượng. Nó đã giải quyết được các khuyết điểm của phương pháp lập trình hướng cấu trúc để lại. Ngoài ra 2 khái niệm này đã giúp biểu diễn tốt hơn thế giới thực trên máy tính.

                //Các đặc điểm của lập trình hướng đối tượng
                //  + Lập trình hướng đối tượng có 4 đặc điểm chính:

                //       - Tính đóng gói:

                //             * Các dữ liệu và phương thức có liên quan với nhau được đóng gói thành các lớp để tiện cho việc quản lý và sử dụng.
                //             * Ngoài ra, đóng gói còn để che giấu một số thông tin và chi tiết cài đặt nội bộ để bên ngoài không thể nhìn thấy.

                //       - Tính trừu tượng: Khi viết chương trình theo phong cách hướng đối tượng, việc thiết kế các đối tượng ta cần rút tỉa ra những đặc trưng chung của chúng rồi trừu tượng thành các interface (khái niệm interface sẽ được trình bày trong bài INTERFACE TRONG C#) và thiết kế xem chúng sẽ tương tác với nhau như thế nào.

                //       - Tính kế thừa: Lớp cha có thể chia sẽ dữ liệu và phương thức cho các lớp con, các lớp con khỏi phải định nghĩa lại, giúp chương trình ngắn gọn.Chi tiết sẽ được trình bày trong bài TÍNH KẾ THỪA TRONG C#.

                //       - Tính đa hình: Là hiện tượng các đối tượng thuộc các lớp khác nhau có thể hiểu cùng một thông điệp theo các cách khác nhau.Chi tiết sẽ được trình bày và giải thích trong bài TÍNH ĐA HÌNH TRONG C#.
                #endregion

                #region Class trong Lập trình hướng đối tượng
                //Một class trong C# có các thành phần như:

                //    Thuộc tính: là các thành phần dữ liệu hay còn gọi là các biến.
                //    Phương thức: là các hàm thành phần thể hiện các hành vi của một đối tượng thuộc lớp.
                //    Phương thức khởi tạo.
                //    Phương thức huỷ bỏ.

                //Class trong C# thực chất là một kiểu dữ liệu mới do người dùng tự định nghĩa.

                //Khởi tạo:
                //    Bạn có thể khởi tạo 1 đối tượng thuộc lớp thông qua toán tử new.

                //    Ví dụ:

                //    Animal Dog = new Animal();

                //    Class là kiểu dữ liệu tham chiếu vì thế đối tượng dữ liệu thực sự được lưu trên heap.

                //Sử dụng:
                //    Để gọi đến các thuộc tính bên trong lớp:

                //    <tên đối tượng>. <tên thuộc tính>;

                //    Để gọi đến các phương thức bên trong lớp:

                //    <tên đối tượng> . <tên phương thức> (<danh sách tham số nếu có>);

                //Phương thức khởi tạo
                //        Phương thức khởi tạo(Constructor) là những phương thức đặc biệt được gọi đến ngay khi khởi tạo 1 đối tượng nào đó.

                //        Đặc điểm
                //        Có tên trùng với tên lớp.
                //        Không có kiểu trả về.
                //        Được tự động gọi khi 1 đối tượng thuộc lớp được khởi tạo.
                //        Nếu như bạn không khai báo bất kỳ phương thức khởi tạo nào thì hệ thống sẽ tự tạo ra phương thức khởi tạo mặc định không đối số và không có nội dung gì.
                //        Có thể có nhiều constructor bên trong 1 lớp.

                //        + Có 2 loại phương thức khởi tạo:

                //              - Phương thức khởi tạo không đối số:
                //        Là phương thức khởi tạo không có bất kỳ tham số truyền vào nào.
                //        Thường dùng để khởi tạo các giá trị mặc định cho các thuộc tính bên trong class khi khởi tạo đối tượng(giá trị mặc định này do người lập trình quyết định).
                //              - Phương thức khởi tạo có đối số:
                //        Là phương thức khởi tạo có tham số truyền vào.Và khi khởi tạo đối tượng để phương thức này được gọi ta cần truyền đầy đủ các tham số.
                //        Thường dùng để khởi tạo các giá trị cho các thuộc thuộc tính bên trong class khi khởi tạo đối tượng(các giá trị này do người khởi tạo đối tượng truyền vào).

                //Phương thức huỷ bỏ
                //        Phương thức huỷ bỏ(destructor) là phương thức đặc biệt được gọi đến trước khi 1 đối tượng bị thu hồi.

                //        + Đặc điểm
                //                - Có tên trùng với tên lớp nhưng để phân biệt với constructor thì ta thêm dấu “~” vào trước tên lớp.
                //                -Không có kiểu trả về.
                //                -Được tự động gọi khi 1 đối tượng thuộc lớp kết thúc “vòng đời” của nó thông qua bộ thu dọn rác tự động GC(Garbage Collection).
                //                - Nếu bạn không khai báo destructor thì C# sẽ tự động tạo ra 1 destructor mặc định và không có nội dung gì.
                //                - Chỉ có 1 destructor duy nhất trong 1 lớp.
                /*cú pháp destructer 
                 * ~ nameClass(){}
                 */
                #endregion

                #region Các loại phạm vi truy cập trong Lập trình hướng đối tượng

                //Phạm vi truy cập là cách mà người lập trình quy định về quyền được truy xuất đến các thành phần của lớp.

                //Trong C# có 5 loại phạm vi truy cập:
                //    public: không hạn chế. CÓ thể truy cập ở bất kỳ nơi nào
                //    private: thành phần mang thuộc tính này là thành phần riêng tư chỉ có nội bộ bên trông lớp chưa nó mới có thê sử dụng.
                //    protected: tưng tự như private ngoài ra nó còn có thể truy cập từ lớp dẫn xuât lớp chứa nó
                //    internal: thuộc tính truy cập cho một assembly( nói các khác là là cùng 1 project ) thuộc tín này thường được dùng cho class.
                //    protected internal: tương tự như internal ngoài ra nó có thể truy cập từ lớp dẫn xuất lớp chưa nó

                //Nếu khai báo lớp mà không chỉ ra phạm vi cụ thể thì phạm vi mặc định là internal.
                //Nếu khai báo thành phần bên trong lớp mà không chỉ ra phạm vi cụ thể thì phạm vị mặc định là private.

                //Trong tính đóng gói có 2 ý chính:
                //    + Các dữ liệu và phương thức có liên quan với nhau được đóng gói thành các lớp để tiện cho việc quản lý và sử dụng.Điều này được thể hiện qua cách ta xây dựng 1 class.
                //    + Đóng gói còn để che giấu một số thông tin và chi tiết cài đặt nội bộ để bên ngoài không thể nhìn thấy.Điều này được thể hiện qua các phạm vi truy cập đã trình bày ở trên.Cụ thể:
                //        - Các thuộc tính thường sẽ có phạm vi là private. Vì đây chính là các thông tin nội bộ của lớp không thể để truy cập 1 cách tuỳ tiện được(che giấu thông tin).
                //        - Các phương thức thường sẽ có phạm vi là public. Vì đây chính là các hành vi(thao tác) mà lớp hỗ trợ cho chúng ta thực hiện những công việc nhất định nên cần phải cho phép mọi người có thể sử dụng được.

                //Phương thức truy vấn, phương thức cập nhật

                //     + Một số quy ước nhỏ về cách đặt tên các phương thức này:

                //            - Những phương thức truy vấn nên bắt đầu bằng từ khoá get và kèm theo sau là tên thuộc tính tương ứng. Ví dụ: getHoTen(), getDiemToan(), . . .
                //            - Những phương thức cập nhật nên bắt đầu bằng từ khoá set và kèm theo sau là tên thuộc tính tương ứng. Ví dụ: setDiemToan(), setHoTen(), . . .
                //            - Nếu thuộc tính kiểu luận lý(bool) thì tên phương thức truy vấn nên bắt đầu bằng từ khoá is và kèm theo sau là tên thuộc tính tương ứng.
                //            - Phương thức truy vấn sẽ có kiểu trả về trùng với kiểu dữ liệu của thuộc tính tương ứng và không có tham số truyền vào.
                //            - Phương thức cập nhật sẽ có kiểu trả về là void và có 1 tham số truyền vào có kiểu dữ liệu trùng với kiểu dữ liệu của thuộc tính tương ứng.
                #endregion

                #region Từ khóa Static trong Lập trình hướng đối tượng
                //Đặc điểm của static :

                //    Được khởi tạo 1 lần duy nhất ngay khi biên dịch chương trình.
                //    Có thể dùng chung cho mọi đối tượng.
                //    Được gọi thông qua tên lớp.
                //    Được huỷ khi kết thúc chương trình.

                //Biến tĩnh
                //        Cú pháp:
                //        < phạm vi truy cập > static <kiểu dữ liệu> < tên biến > = < giá trị khởi tạo >;

                //    Bạn có thể hiểu biến tĩnh là:

                //        Một biến dùng chung cho mọi đối tượng thuộc lớp.
                //        Nó được khởi tạo vùng nhớ 1 lần duy nhất ngay khi chương trình được nạp vào bộ nhớ để thực thi và huỷ khi kết thúc chương trình.

                //Phương thức tĩnh
                //    Cú pháp:
                //    < phạm vi truy cập > static <kiểu trả về> < tên phương thức>
                //    {
                //               // nội dung phương thức
                //    }

                //Hàm tĩnh được sử dụng với 2 mục đích chính:

                //    Hàm tĩnh là 1 hàm dùng chung của lớp.Được gọi thông qua tên lớp và không cần khởi tạo bất kỳ đối tượng nào, từ đó tránh việc lãng phí bộ nhớ.
                //    Hỗ trợ trong việc viết các hàm tiện ích để sử dụng lại.

                //Lớp tĩnh
                //    Cú pháp:
                //    < phạm vi truy cập > static class <tên lớp>
                //    {
                //                            // các thành phần của lớp
                //    }

                //Lớp tĩnh có các đặc điểm
                //        Chỉ chứa các thành phần tĩnh(biến tĩnh, phương thức tĩnh).
                //        Không thể khai báo, khởi tạo 1 đối tượng thuộc lớp tĩnh.
                //    Với 2 đặc điểm trên có thể thấy lớp tĩnh thường được dùng với mục đích khai báo 1 lớp tiện ích chứa các hàm tiện ích hoặc hằng số vì:

                //        Ràng buộc các thành phần bên trong lớp phải là static.
                //        Không cho phép tạo ra các đối tượng dư thừa làm lãng phí bộ nhớ.
                //        Mọi thứ đều được truy cập thông qua tên lớp.
                //    Xét lại ví dụ trong phần hàm tĩnh. Rõ ràng là người có thể vô ý tạo ra đối tượng thuộc TienIch. Đối tượng này khá vô nghĩa vì không có gì để sử dụng.Để tránh điều này ta thêm từ khoá static vào trước khai báo lớp.

                //Phương thức khởi tạo tĩnh
                //        Cú pháp:
                //static <tên lớp> ()

                //{
                //                    // nội dung của constructor
                //}

                //Đặc điểm của constructor tĩnh
                //    Không được phép khai báo phạm vi truy cập. Nếu cố tình làm điều này C# sẽ báo lỗi khi biên dịch.
                //    Constructor tĩnh sẽ được gọi 1 lần duy nhất khi chương trình được nạp vào bộ nhớ để thực thi như là 1 cách để ta thiết lập một số thông số theo ý muốn trước khi có bất kỳ đối tượng nào được tạo ra.
                //    Constructor tĩnh cũng giống phương thức tĩnh nên không thể gọi các thuộc tính không phải static.
                #endregion

                #region Kế thừa trong Lập trình hướng đối tượng
                //    khái niệm
                //    Trong thực tế, kế thừa là việc thừa hưởng lại những gì mà người khác để lại. Ví dụ: con kế thừa tài sản của cha, . . .
                //    Trong lập trình cũng vậy, kế thừa trong lập trình là cách 1 lớp có thể thừa hưởng lại những thuộc tính, phương thức từ 1 lớp khác và sử dụng chúng như là của bản thân mình.
                //    Một định nghĩa trừu tượng hơn về kế thừa: là một đặc điểm của ngôn ngữ hướng đối tượng dùng để biểu diễn mối quan hệ đặc biệt hoá – tổng quát hoá giữa các lớp.

                //    ưu điểm
                //        Cho phép xây dựng 1 lớp mới từ lớp đã có.
                //             Lớp mới gọi là lớp con(subclass) hay lớp dẫn xuất(derived class).
                //             Lớp đã có gọi là lớp cha(superclass) hay lớp cơ sở(base class).
                //        Cho phép chia sẽ các thông tin chung nhằm tái sử dụng và đồng thời giúp ta dễ dàng nâng cấp, dễ dàng bảo trì.
                //        Định nghĩa sự tương thích giữa các lớp, nhờ đó ta có thể chuyển kiểu tự động .
                //    Cú pháp
                //        class <tên lớp con> : <tên lớp cha>

                //        {

                //        }
                //    Lưu ý:

                //        Trong C#, không hỗ trợ đa kế thừa (1 lớp kế thừa từ nhiều lớp) những lại hỗ trợ thực thi nhiều interface (khái niệm về interface sẽ được trình bày trong bài INTERFACE TRONG C#).

                //        Các thành phần của lớp cha có được kế thừa xuống lớp con hay không là do phạm vi truy cập của thành phần đó là gì.

                //             Thành phần có phạm vi là private thì không được kế thừa.
                //            Thành phần có phạm vi là protected, public thì được phép kế thừa.
                //        Phương thức khởi tạo và phương thức huỷ bỏ không được kế thừa.

                //    các vấn đề trông kế thừa
                //        Phương thức khởi tạo mặc định của lớp cha luôn luôn được gọi mỗi khi có 1 đối tượng thuộc lớp con khởi tạo.Và được gọi trước phương thức khởi tạo của lớp con.

                //        Nếu như lớp cha có phương thức khởi tạo có tham số thì đòi hỏi lớp con phải có phương thức khởi tạo tương ứng và thực hiện gọi phương thức khởi tạo của lớp cha thông qua từ khoá base.
                //    cú pháp
                //        public <tên lớp>(<danh sách tham số của lớp con>) : base(<danh sách tham số>)
                //            {

                //            }
                //     Vấn đề hàm trùng tên và cách gọi phương thức của lớp cha
                //        Xét lại ví dụ phía trên.Giả sử lớp Animal có phương phức tên Info(). Lớp Cat kế thừa lớp Animal nên cũng sẽ nhận được phương thức này.

                //         Bây giờ trong lớp Cat ta cũng định nghĩa 1 phương thức tên Info(), có kiểu trả về là void và không có tham số truyền vào. Vậy câu lệnh sau sẽ gọi phương thức Info() nào?
                //         Cụ thể bạn sẽ thêm từ khoá new vào trước khai báo hàm Info() trong lớp Cat.
                //    cú pháp
                //           public new void Info()
                //                {

                //                }
                //    Khi đó hàm Info() của lớp cha sẽ bị che giấu đi.Và mọi đối tượng bên ngoài chỉ gọi được hàm Info() của lớp Cat.
                //    Từ khoá này chỉ làm tường minh khai báo của hàm Info() chứ về kết quả khi chạy chương trình sẽ không có thay đổi.
                //    Đến đây 1 câu hỏi nữa được đặt ra: Vậy có cách nào gọi hàm Info() của lớp cha được nữa không?
                //    Câu trả lời là có nhưng chỉ có thể gọi trong nội bộ của lớp Cat mà thôi
                //    Bạn có thể sử dụng từ khoá base để đại diện cho lớp cha và gọi đến các thành phần của lớp cha.
                //        ví dụ
                //        public new void Info()
                //            {

                //                Console.WriteLine(" Info of Cat: ");
                //                base.Info(); // gọi đến hàm Info() của lớp cha

                //            }
                //Vấn đề cấp phát vùng nhớ cho đối tượng
                //    Bình thường nếu như 1 đối tượng kiểu Animal không thể khởi tạo vùng nhớ có kiểu Cat được.
                //    Animal cat = new Cat();
                //    Câu lệnh này sẽ báo lỗi: “không thể chuyển từ kiểu Cat sang kiểu Animal”.
                //    Nhưng nếu như 2 lớp này có quan hệ kế thừa thì điều này hoàn toàn được.
                //    Tính chất này được phát biểu như sau:
                //    “Một đối tượng thuộc lớp cha có thể tham chiếu đến vùng nhớ của đối tượng thuộc lớp con nhưng ngược lại thì không”.
                //    Có nghĩa là nếu lớp Cat kế thừa từ lớp Animal thì câu lệnh Animal cat = new Cat(); hoàn toàn đúng nhưng ngược lại Cat cat = new Animal(); sẽ báo lỗi.
                //    Bạn cần lưu ý điều này.Vì muốn thể hiện tính đa hình trong lập trình ta phải sử dụng tính chất này.

                #endregion

                #region Đa hình trong Lập trình hướng đối tượng
                //Khái niệm tính đa hình
                //     * Tính đa hình là hiện tượng các đối tượng thuộc các lớp khác nhau có thể hiểu cùng 1 thông điệp theo các cách khác nhau.
                //     * Để thể hiện được tính đa hình:
                //        + Các lớp phải có quan hệ kế thừa với cùng 1 lớp cha nào đó.
                //        + Phương thức đa hình phải được ghi đè(override) ở các lớp con(sẽ được trình bày ngay sau đây).
                //Từ khoá virtual và từ khoá override
                //    * Virtual là từ khoá dùng để khai báo 1 phương thức ảo(phương thức ảo là phương thức có thể ghi đè được).

                //    * Override là từ khoá dùng để đánh dấu phương thức ghi đè lên phương thức của lớp cha.

                //    * Lưu ý:

                //        + Chỉ có thể ghi đè lên phương thức virtual hoặc abstract (sẽ trình bày ngay sau đây).
                //        + Tính đa hình chỉ được thể hiện khi đã ghi đè lên phương thức của lớp cha.

                //Lớp trừu tượng và phương thức thuần ảo
                //    Phương thức thuần ảo là 1  phương thức ảo và không có định nghĩa bên trong.
                //        Lớp trừu tượng là lớp chứa phương thức thuần ảo.
                //        Abstract là từ khoá dùng để khai báo 1 lớp trừu tượng hoặc 1 phương thức thuần ảo.
                //    lưu ý:
                //        Khi kế thừa 1 lớp trừu tượng bạn bắt buộc phải override tất cả các phương thức thuần ảo nhằm đảm bảo tính hợp lệ cho chương trình.

                #endregion

                #region Interface trong Lập trình hướng đối tượng
                //Interface là gì? Tại sao lại sử dụng interface
                //    Interface (nhiều tài liệu gọi là giao diện hoặc lớp giao tiếp) là 1 tập các thành phần chỉ có khai báo mà không có phần định nghĩa(giống phương thức thuần ảo đã trình bày ở bài ĐA HÌNH TRONG C#).

                //    Các thành phần này có thể là:

                //    Phương thức
                //    Property 
                //    Event 
                //    Indexers

                //    Một interface được hiểu như là 1 khuôn mẫu mà mọi lớp thực thi nó đều phải tuân theo.Interface sẽ định nghĩa phần “làm gì” (khai báo) và những lớp thực thi interface này sẽ định nghĩa phần “làm như thế nào” (định nghĩa nội dung) tương ứng.

                //Đặc điểm của interface
                //    Chỉ chứa khai báo không chứa phần định nghĩa(giống phương thức thuần ảo). Mặc dù giống phương thức thuần ảo nhưng bạn không cần phải khai báo từ khoá abstract.
                //    Việc ghi đè 1 thành phần trong interface cũng không cần từ khoá override.
                //    Không thể khai báo phạm vi truy cập cho các thành phần bên trong interface. Các thành phần này sẽ mặc định là public.
                //    Interface không chứa các thuộc tính(các biến) dù là hằng số hay biến tĩnh vẫn không được.
                //    Interface không có constructor cũng không có destructor.
                //    Các lớp có thể thực thi nhiều interface cùng lúc(ở 1 góc độ nào đó có thể nó là phương án thay thế đa kế thừa).
                //    Một interface có thể kế thừa nhiều interface khác nhưng không thể kế thừa bất kỳ lớp nào.
                //Khai báo và sử dụng interface
                //Cú pháp:
                //    interface <tên interface>

                //        {

                //            // Khai báo các thành phần bên trong interface

                //        }
                #endregion
            }


        }
        
    }
}
