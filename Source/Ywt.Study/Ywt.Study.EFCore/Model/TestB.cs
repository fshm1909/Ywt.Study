using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    /// <summary>
    /// 测试列顺序
    /// </summary>
    public class TestB
    {
        public int Id { get; set; }
        [Column(Order = 5)]
        public string Field { get; set; }
        [Column(Order = 4)]
        public string Field2 { get; set; }
        [Column(Order = 3)]
        public string Field3 { get; set; }
        [Column(Order = 2)]
        public string Field4 { get; set; }
        [Column(Order = 1)]
        public string Field5 { get; set; }
    }
}
