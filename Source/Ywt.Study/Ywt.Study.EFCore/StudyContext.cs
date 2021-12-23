using Microsoft.EntityFrameworkCore;
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
            ConnectionStrings = "server=.;database=YwtStudy;uid=sa;pwd=ywt133447";
        }

        /// <summary>
        /// 配置要使用的数据库
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(ConnectionStrings);
    }
}
