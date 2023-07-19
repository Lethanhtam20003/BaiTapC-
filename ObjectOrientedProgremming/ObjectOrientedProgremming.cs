using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgremming
{
        //lập trình hướng đối tượng
    internal class ObjectOrientedProgremming
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
