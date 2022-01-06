using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore.Model.Relation
{
    public class R4
    {
        public int Id { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }

        //外键
        public int R1Id { get; set; }

        //导航属性
        public R3 R3_1 { get; set; }
    }
}
