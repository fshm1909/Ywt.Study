using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore.Model.Relation
{
    /// <summary>
    /// 【手动配制-数据注释】
    /// R3和R4
    /// </summary>
    public class R3
    {
        public int Id { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }

        //导航属性
        [InverseProperty("R3_1")]//反向导航属性
        public R4 R4_1 { get; set; }
    }
}
