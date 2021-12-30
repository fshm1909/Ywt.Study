using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    public class Test1
    {
        public int Test1Id { get; set; }

        public string Field { get; set; }

        public string Field2 { get; set; }

        public List<Test2> Test2s { get; set; }
    }
}
