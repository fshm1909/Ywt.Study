using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    /// <summary>
    /// 测试 显式配置值生成
    /// </summary>
    public class TestC
    {
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]/*数据库在插入行时生成一个值。*/
        public string Field { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]/*数据库在插入或者更新行时生成一个值。*/
        public string Field2 { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]/*无值生成*/
        public string Field3 { get; set; }
    }
}
