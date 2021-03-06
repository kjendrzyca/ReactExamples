﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace aspnetmvc6
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseStaticFiles();

            //app.Run(async (context) =>
            //{
            //    if (context.Request.Path == "/relativePath")
            //    {
            //        await context.Response.WriteAsync("relativePath");
            //        return;
            //    }

            //    await context.Response.WriteAsync("Hello World! sup?");
            //});
        }
    }
}
