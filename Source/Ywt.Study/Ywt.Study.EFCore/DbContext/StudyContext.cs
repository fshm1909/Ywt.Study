using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Ywt.Study.EFCore
{
    public class StudyDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<TestA> TestA { get; set; }
        public DbSet<TestB> TestB { get; set; }
        public DbSet<TestC> TestC { get; set; }
        public DbSet<TestD> TestD { get; set; }


        public DbSet<R1> R1 { get; set; }
        public DbSet<R2> R2 { get; set; }

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionStrings { get; private set; }

        public StudyDbContext()
        {
            //需要安装Microsoft.Extensions.Configuration.Json包,用于读取json配制文件
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json");
            var configuration = builder.Build();

            ConnectionStrings = configuration["ConnectionStrings1"];
        }

        /// <summary>
        /// 配置要使用的数据库
        /// </summary>
        /// <param name="options">DbContext配制生成器</param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionStrings);

            //你可能想要将迁移存储在与包含你的不同的项目中 DbContext 。 你还可以使用此策略来维护多个迁移集，例如，一个用于开发，另一个用于发布到发布升级。
            //将迁移存储放到Ywt.Study.EFCore.Migrations项目
            //PMC语句:Add-Migration InitialCreate2 -Project Ywt.Study.EFCore.Migrations
            //options.UseSqlServer(ConnectionStrings, x => x.MigrationsAssembly("Ywt.Study.EFCore.Migrations")); 

            //options.UseSqlServer(ConnectionStrings, x => x.MigrationsHistoryTable("__MyMigrationsHistory"));
        }

        /// <summary>
        /// 配置模型（此处用Fluent API 配置，具有最高优先级，并将替代约定和数据注释。也可将特性（称为数据注释）应用于类和属性）
        /// </summary>
        /// <param name="modelBuilder">模型生成器</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 配置的几种不同方法

            //此处直接配制指定类模型
            //modelBuilder.Entity<Person>().Property(b => b.Name).IsRequired(); ;

            //此处分组配置
            //new PersonEntityTypeConfiguration().Configure(modelBuilder.Entity<Person>());

            //可以在给定程序集中应用实现 IEntityTypeConfiguration 的类型中指定的所有配置。
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonEntityTypeConfiguration).Assembly);

            #endregion

            #region 实体类型

            //从模型中排除类型（数据注释使用[NotMapped]）
            //modelBuilder.Ignore<Person>();

            //从迁移中排除
            //modelBuilder.Entity<TestA>().ToTable("TestA", t => t.ExcludeFromMigrations());

            //表名称;表架构
            //modelBuilder.Entity<TestA>().ToTable("TestA");
            //modelBuilder.Entity<TestA>().ToTable("TestA", schema: "schema");

            //视图映射(使用以后不会在创建Person表了)
            //modelBuilder.Entity<Person>().ToView("view_Person");
            //modelBuilder.Entity<Person>().ToView("view_Person", schema: "schema");

            //表注释(SQL:select value from sys.extended_properties where major_id = object_id('Person');)
            modelBuilder.Entity<TestA>().HasComment("测试表A");

            #endregion

            #region 实体属性

            //按照约定，所有具有 Getter 和 Setter 的公共属性都将包含在模型中。
            //可以按如下所示排除特定属性（数据注释使用[NotMapped]）
            modelBuilder.Entity<TestA>().Ignore(tb => tb.Field);

            //按照约定，使用关系数据库时，实体属性将映射到与属性同名的表列。
            //如果希望配置具有不同名称的列，可以按以下代码片段进行操作：
            modelBuilder.Entity<TestA>().Property(tb => tb.Field2).HasColumnName("Field2_1");

            //列数据类型
            modelBuilder.Entity<TestA>(tb =>
            {
                tb.Property(b => b.Field3).HasColumnType("varchar(200)");
                tb.Property(b => b.Field4).HasColumnType("decimal(5, 2)");
            });

            //最大长度
            modelBuilder.Entity<TestA>().Property(b => b.Field5).HasMaxLength(500);
            modelBuilder.Entity<TestA>().Property(b => b.Field6).HasMaxLength(500);

            //精度和小数位数
            modelBuilder.Entity<TestA>(tb =>
            {
                tb.Property(b => b.Field7).HasPrecision(14, 2);
                tb.Property(b => b.Field8).HasPrecision(3);
            });

            //表示 Unicode 和非 Unicode 文本数据
            modelBuilder.Entity<TestA>().Property(b => b.Field9).IsUnicode(false);

            //必需和可选属性
            modelBuilder.Entity<TestA>().Property(b => b.Field10).IsRequired(true);

            //列顺序(EF Core 6.0 中已引入此功能。)
            //请注意，在一般情况下，大多数数据库仅支持在创建表时对列进行排序。 这意味着不能使用列顺序特性对现有表中的列进行重新排序。
            //modelBuilder.Entity<TestA>(tb =>
            //{
            //    tb.Property(b => b.Field11).HasColumnOrder(0);
            //    tb.Property(b => b.Field12).HasColumnOrder(1);
            //});

            #endregion

            #region 键

            //配置主键;根据约定(默认)，名为 Id 或 <type name>Id 的属性将被配置为实体的主键。
            modelBuilder.Entity<TestA>().HasKey(b => new { b.Id });

            //主键名称
            modelBuilder.Entity<TestA>().HasKey(b => new { b.Id }).HasName("PK_TestA");

            #endregion

            #region 生成的值

            //默认值
            modelBuilder.Entity<TestA>().Property(b => b.Field13).HasDefaultValue("默认值");
            modelBuilder.Entity<TestA>().Property(b => b.Field14).HasDefaultValueSql("getdate()");

            //计算列
            modelBuilder.Entity<TestA>().Property(b => b.Field15).HasComputedColumnSql("[Field12] + ', ' + [Field13]");
            //modelBuilder.Entity<TestA>().Property(b => b.Field15).HasComputedColumnSql("LEN([Field12]) + LEN([Field13])", stored: true);

            //显式配置值生成
            //modelBuilder.Entity<TestC>().Property(b => b.Field).ValueGeneratedOnAdd();
            //modelBuilder.Entity<TestC>().Property(b => b.Field2).ValueGeneratedOnAddOrUpdate();
            //modelBuilder.Entity<TestC>().Property(b => b.Field3).ValueGeneratedNever();

            #endregion

            #region 阴影属性和索引器属性

            //配置阴影属性(模型类中没有定义的，但数据表中存在的属性——即模型类与数据表中没有对应关系的属性。)
            modelBuilder.Entity<TestD>().Property<DateTime>("InsertTime");

            //配置索引器属性
            modelBuilder.Entity<TestE>().IndexerProperty<DateTime>("InsertTime");

            #endregion

            #region 关系

            modelBuilder.Entity<Test1>().HasMany(tb1 => tb1.Test2s).WithOne(tb2 => tb2.Test1).HasForeignKey(tb2 => tb2.Test1Id);

            //modelBuilder.Entity<Test1>().HasMany(tb1 => tb1.Test2s).WithOne(tb2 => tb2.Test1)
            //modelBuilder.Entity<Test1>().HasData();
            #endregion
        }

    }
}
