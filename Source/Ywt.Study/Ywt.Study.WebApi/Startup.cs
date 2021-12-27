using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
        /// ���캯������ע��
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="environment"></param>
        /// <param name="appLifetime"></param>
        public Startup(IConfiguration configuration/*, IWebHostEnvironment environment, IHostApplicationLifetime appLifetime*/)
        {
            Configuration = configuration;
            //Environment = environment;
            //AppLifetime = appLifetime;
        }

        /// <summary>
        /// ����ѡ��
        /// ����Ӧ�õķ���ע����񣬲�ͨ��������ϵע�� (DI) �� ApplicationServices ������Ӧ����ʹ�÷��񡣣�
        /// </summary>
        /// <param name="services">��������</param>
        public void ConfigureServices(IServiceCollection services)
        {
            //����Ǩ�Ƴ���
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
        }

        /// <summary>
        /// ����ѡ��
        /// ���ƹܵ����м����
        /// </summary>
        /// <param name="app">Ӧ�ó�������������ͨ�����м�������ӵ� IApplicationBuilder ʵ������������ܵ���</param>
        /// <param name="env">������������</param>
        /// <param name="appLifetime">����Ӧ�ó���������</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime appLifetime)
        {
            //ͨ�û�������
            string ApplicationName = env.ApplicationName;//����Ӧ����ڵ�ĳ��򼯵����ơ�
            string ContentRoot = env.ContentRootPath;//Ӧ�ó������ڵ��ļ��С�
            string EnvironmentName = env.EnvironmentName;//�������ƣ���ܶ����ֵ���� Development��Staging �� Production��

            //IHostApplicationLifetime(����Ӧ�ó���������) ����������͹رջ�� �ӿ��ϵ���������������ע�� Action ���������ڶ��������͹ر��¼�����ȡ����ǡ�
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
    }
}
