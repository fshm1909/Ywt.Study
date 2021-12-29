using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    /// <summary>
    /// 对Person的模型配制
    /// 为了减小OnModelCreating 方法的大小，可以将实体类型的所有配置提取到实现 IEntityTypeConfigurationTEntity 的单独类中。
    /// </summary>
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .Property(b => b.Name)
                .IsRequired();
        }
    }
}
