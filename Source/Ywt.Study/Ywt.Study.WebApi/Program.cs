using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
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
            //IHostBuilder��IHost��IHostBuilder�������ƣ�IHost��������

            CreateHostBuilder(args)
                .Build()//���и����Ĳ����Գ�ʼ����������ֻ�ܵ���һ�Ρ�
                        //.Start()//ͬ������������
                .Run();//����Ӧ�ò���ֹ�����̣߳�ֱ���ر�������
        }

        /// <summary>
        /// ������
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host
                 .CreateDefaultBuilder(args)//ʹ��Ԥ�����õ�Ĭ��ֵ��ʼ��Microsoft.Extensions.Hosting.HostBuilder�����ʵ����
                                            
                 //ʹ��Ĭ��ֵ����Microsoft.Extensions.Hosting.IHostBuilder���й�webӦ�á�
                 .ConfigureWebHostDefaults(webBuilder =>
                 {
                     webBuilder.UseStartup<Startup>();
                 });
        }
    }
}
