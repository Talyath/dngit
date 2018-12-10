using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dngit.Core.Data;
using dngit.Data;
using dngit.Data.Repository;
using dngit.Models;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace dngit
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<DngitContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DngitDB")));
            services.AddTransient<IPlaceRepository, PlaceRepository>();
            services.AddTransient<IRatingRepository, RatingRepository>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<DngitQuery>();
            services.AddSingleton<DngitMutation>();
            services.AddSingleton<PlaceType>();
            services.AddSingleton<RatingType>();
            services.AddSingleton<PlaceInputType>();
            services.AddSingleton<RatingInputType>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new DngitSchema(new FuncDependencyResolver(type => sp.GetService(type))));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
