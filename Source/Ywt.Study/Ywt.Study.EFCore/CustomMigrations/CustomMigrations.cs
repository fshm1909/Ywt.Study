using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore.CustomMigrations
{
    /// <summary>
    /// 自定义迁移 
    /// </summary>
    public static class CustomMigrations
    {
        /// <summary>
        /// 自定义一个迁移方法，测试插一条数据到数据库
        /// </summary>
        /// <param name="migrationBuilder"></param>
        /// <returns></returns>
        public static OperationBuilder<SqlOperation> InsertPerson(this MigrationBuilder migrationBuilder)
        {
            string sql = " INSERT INTO Person ([Name],[Age],[Height],[weight],[IsDeleted])";
            sql += " VALUES ('测试',18,175,120,0)";

            return migrationBuilder.Sql(sql);
        }
    }
}
