using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programBasic
{
    internal class runApp
    {
        public static void main(string[] args) { 
            programBasic.runForBaiTapTrenKteam_ThuatToanBT cls = new runForBaiTapTrenKteam_ThuatToanBT();
            programBasic.runForcacpheptinh_CacPhepTinh cls2 = new runForcacpheptinh_CacPhepTinh();
            programBasic.runForLuaDoThuatToan cls3 = new runForLuaDoThuatToan();
            programBasic.runForMatrixProgram_ThuatToanMaTran cls4 = new runForMatrixProgram_ThuatToanMaTran();


            cls.runForThisClass();
        }
    }
}
