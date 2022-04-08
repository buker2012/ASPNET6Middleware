﻿using ASPNET6Middleware.Middleware;

namespace ASPNET6Middleware.Extensions
{
    public static class MiddlewareExtensions
    {
        /// <summary>
        /// 添加 Layout 中间件
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseLayoutMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LayoutMiddleware>();
        }

        /// <summary>
        /// 添加 Simple Response 中间件，该中间件将立即返回响应。
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseSimpleResponseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SimpleResponseMiddleware>();
        }

        /// <summary>
        /// 添加日志中间件，用于记录传入请求的路径。
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }

        /// <summary>
        /// 添加区域中间件，该中间件根据查询字符串设置当前区域性。
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseCultureMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureMiddleware>();
        }
    }
}
