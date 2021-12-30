using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    /// <summary>
    /// 测试 阴影属性(模型类中没有定义的，但数据表中存在的属性——即模型类与数据表中没有对应关系的属性。)
    /// </summary>
    public class TestD
    {
        public int Id { get; set; }
        public string Field { get; set; }
    }
}
