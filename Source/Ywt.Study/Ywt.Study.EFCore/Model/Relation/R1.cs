using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    /// <summary>
    /// 【测试约定】
    /// R1和R2：一对一关系。
    /// 建立了导航属性 按照约定自动创建外键表关系。
    /// R1或R2只要其中一个没有建立导航属性，就不会默认创建外键
    /// </summary>
    public class R1
    {
        public int Id { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }

        //导航属性
        //[NotMapped]//使用NotMapped不会创建外键关系
        public R2 r2s { get; set; }
    }
}
