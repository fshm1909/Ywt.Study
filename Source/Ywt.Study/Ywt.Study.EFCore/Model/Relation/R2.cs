using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    public class R2
    {
        public int Id { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }

        //外键
        public int R1Id { get; set; }

        //导航属性
        //[NotMapped]//使用NotMapped不会创建外键关系
        public R1 r1s { get; set; }
    }
}
