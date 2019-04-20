// <copyright file="Startup.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using ProtoX.DataAccess.Initializer;
    using ProtoX.Services.Manager;

    /// <summary>
    /// Startup Class for the Api.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">Configuration Injected Object</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            this.Initialize(services);

            services.AddMemoryCache();

            services.AddMvc(options => {
                options.Filters.Add(new RequireHttpsAttribute());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        private void Initialize(IServiceCollection services)
        {
            ServiceManager.RegisterServices(services, this.Configuration);
        }
    }
}
