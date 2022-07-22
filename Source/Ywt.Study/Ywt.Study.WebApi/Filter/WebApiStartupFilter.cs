using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Ywt.Study.WebApi
{
    /// <summary>
    /// 自定义筛选器
    /// </summary>
    public class WebApiStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                //builder.UseMiddleware<RequestSetOptionsMiddleware>();
                next(builder);
            };
        }
    }
}
