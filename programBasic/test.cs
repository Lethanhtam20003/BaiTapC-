using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace programBasic
{
    internal class test
    {
        [TestFixture]
        class TestLuuDoThuatToan
        {
            private LuuDoThuatToan_ThuatToan ld;
            [SetUp]
            public void Init()
            {
                ld = new LuuDoThuatToan_ThuatToan();    
            }

            
        }

    }
}
