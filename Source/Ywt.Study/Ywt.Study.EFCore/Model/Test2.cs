using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    public class Test2
    {
        public int Test2Id { get; set; }
        public int Test1Id { get; set; }

        public string Field { get; set; }

        public string Field2 { get; set; }

        public Test1 Test1 { get; set; }

    }
}
