using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ywt.Study.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //IHostBuilder和IHost；IHostBuilder用于配制，IHost用于运行

            var host = CreateHostBuilder(args).Build();//运行给定的操作以初始化主机。这只能调用一次。
            //host.Start()；//同步启动主机。

            //获取ILoggerProvider的服务
            var Services = host.Services.GetServices<ILoggerProvider>();

            host.Run();//运行应用并阻止调用线程，直到关闭主机。
        }

        /// <summary>
        /// 生成器
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host
                 .CreateDefaultBuilder(args)//使用预先配置的默认值初始化Microsoft.Extensions.Hosting.HostBuilder类的新实例。
                 .ConfigureAppConfiguration((context,config)=>{
                     //config.Sources.Clear();//清空配置源

                     //config.AddJsonFile("appsettings.json",optional:true,reloadOnChange:true);//添加文件作为配置源
                 })
                 //使用默认值配置Microsoft.Extensions.Hosting.IHostBuilder以托管web应用。
                 .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder.UseStartup<Startup>();
                 });
        }
    }
}
