using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    //[Table("TestA")]/*表名称，默认使用类名*/
    //[Table("TestA", Schema = "Schema")]/*表架构*/
    //[NotMapped]/*从模型中排除类型*/
    [Comment("测试表A")]
    public class TestA
    {
        public int Id { get; set; }

        [NotMapped]/*从模型中排除类型*/
        public string Field { get; set; }

        [Column("Field2_1")]/*自定义列名*/
        public string Field2 { get; set; }

        [Column(TypeName = "varchar(200)")]/*列数据类型*/
        public string Field3 { get; set; }

        [Column(TypeName = "decimal(5, 2)")]/*列数据类型*/
        public decimal Field4 { get; set; }

        [MaxLength(500)]/*最大长度*/
        public string Field5 { get; set; }

        [MaxLength(500)]/*最大长度*/
        public byte[] Field6 { get; set; }

        //[Precision(14, 2)]//EF Core 6.0 中引入了用于配置精度和小数位数的数据注释。
        public decimal Field7 { get; set; }

        //[Precision(3)]//EF Core 6.0 中引入了用于配置精度和小数位数的数据注释。
        public DateTime Field8 { get; set; }

        //[Unicode(false)]//EF Core 6.0 中引入了用于配置 Unicode 的数据注释。
        public string Field9 { get; set; }

        [Required]/*必需属性(不允许null值)*/
        public string Field10 { get; set; }

        [Comment("这是一个测试列")]
        public string Field11 { get; set; }

        //[Column(Order = 0)]/*列顺序(EF Core 6.0 中已引入此功能。)*/
        public string Field12 { get; set; }

        public string Field13 { get; set; }

        public string Field14 { get; set; }

        public string Field15 { get; set; }

        public string Field16 { get; set; }
    }
}
