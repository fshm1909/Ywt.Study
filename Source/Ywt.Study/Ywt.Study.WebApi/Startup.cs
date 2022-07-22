using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ywt.Study.EFCore;

namespace Ywt.Study.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        //public IWebHostEnvironment Environment { get; }
        //public IHostApplicationLifetime AppLifetime { get; }

        /// <summary>
        /// 构造函数依赖注入
        /// </summary>
        /// <param name="configuration">表示一组键/值应用程序配置属性。</param>
        /// <param name="environment">主机环境设置</param>
        /// <param name="appLifetime">主机应用程序生存期</param>
        public Startup(IConfiguration configuration/*, IWebHostEnvironment environment, IHostApplicationLifetime appLifetime*/)
        {
            Configuration = configuration;
            //Environment = environment;
            //AppLifetime = appLifetime;
        }

        /// <summary>
        /// （必选）
        /// 配制管道（中间件）
        /// </summary>
        /// <param name="app">应用程序生成器（可通过将中间件组件添加到 IApplicationBuilder 实例来配置请求管道）</param>
        /// <param name="env">主机环境设置</param>
        /// <param name="appLifetime">主机应用程序生存期</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime appLifetime)
        {
            //通用环境设置
            string ApplicationName = env.ApplicationName;//包含应用入口点的程序集的名称。
            string ContentRoot = env.ContentRootPath;//应用程序集所在的文件夹。
            string EnvironmentName = env.EnvironmentName;//环境名称（框架定义的值包括 Development、Staging 和 Production）

            //IHostApplicationLifetime(主机应用程序生存期) 允许后启动和关闭活动。 接口上的三个属性是用于注册 Action 方法（用于定义启动和关闭事件）的取消标记。
            //appLifetime.ApplicationStarted.Register(() => { });
            //appLifetime.ApplicationStopping.Register(() => { });
            //appLifetime.ApplicationStopped.Register(() => { });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ywt.Study.WebApi v1"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        /// <summary>
        /// （可选）
        /// 配置应用的服务（注册服务，并通过依赖关系注入 (DI) 或 ApplicationServices 在整个应用中使用服务。）
        /// </summary>
        /// <param name="services">服务容器</param>
        public void ConfigureServices(IServiceCollection services)
        {
            //IServiceCollection 是 ServiceDescriptor 对象的集合
            //var descriptor = new ServiceDescriptor(typeof(IService), _ => new Service(), ServiceLifetime.Transient);
            //services.Add(descriptor);

            //注册不同类型的服务(内部调用services.Add(descriptor)方法)
            //services.AddTransient<IService, Service>();//注册[暂时]服务
            //services.AddScoped<IService, Service>();//注册[范围内]服务
            //services.AddSingleton<IService, Service>();//注册[单一实例]服务

            //只有当尚未注册某个实现时，才注册该服务
            //services.TryAddTransient<IService, Service>();//注册[暂时]服务
            //services.TryAddScoped<IService, Service>();//注册[范围内]服务
            //services.TryAddSingleton<IService, Service>();//注册[单一实例]服务


            //配置迁移程序集
            //services.AddDbContext<StudyDbContext>(options =>
            //options.UseSqlServer(
            //   Configuration.GetConnectionString("DefaultConnection"),
            //   x => x.MigrationsAssembly("Ywt.Study.EFCore.Migrations")
            //   )
            //);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ywt.Study.WebApi", Version = "v1" });
            });

            //注册自定义筛选器
            services.AddTransient<IStartupFilter, WebApiStartupFilter>();//注册[暂时]服务

        }
    }
}
