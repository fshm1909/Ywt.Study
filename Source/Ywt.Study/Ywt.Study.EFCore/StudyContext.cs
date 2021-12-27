using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    public class StudyDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

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

            //ConnectionStrings = "server=.;database=YwtStudy;uid=sa;pwd=ywt133447";
        }

        /// <summary>
        /// 配置要使用的数据库
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer(ConnectionStrings);

            //你可能想要将迁移存储在与包含你的不同的项目中 DbContext 。 你还可以使用此策略来维护多个迁移集，例如，一个用于开发，另一个用于发布到发布升级。
            //将迁移存储放到Ywt.Study.EFCore.Migrations项目
            //PMC语句:Add-Migration InitialCreate2 -Project Ywt.Study.EFCore.Migrations
            options.UseSqlServer(ConnectionStrings, x => x.MigrationsAssembly("Ywt.Study.EFCore.Migrations")); 
        }
    }
}
