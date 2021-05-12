﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace com.redmine.gorilla {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddRazorPages();
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddSession(a => a.IdleTimeout = TimeSpan.FromMinutes(30));
            services.AddAntiforgery(options => {
                options.SuppressXFrameOptionsHeader = true;
            });
            services.AddCors(options => {
                options.AddPolicy("issues", builder => builder.WithOrigins("http://server.logichealth.cn").AllowAnyOrigin().WithMethods("GET"));
            });

            //services.AddDbContext<MovieContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("MsSql")));
            //services.AddDbContext<AccountContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            //services.AddDbContext<ProjectContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            //services.AddDbContext<ProvinceContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            //services.AddDbContext<CityContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            //services.AddDbContext<DepartmentContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            //services.AddDbContext<UserContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
            //services.AddDbContext<MainContext>(a => a.UseMySQL(Globals.MySqlConnectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Error");
            }
            app.Use(async (context, next) => {
                context.Response.Headers.Add("X-Frame-Options", "ALLOW-FROM http://redmine.logichealth.cn/");
                await next();
            });
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(x => { x.SwaggerEndpoint("/swagger/v1/swagger.json", "CSSD"); });
            app.UseCors("issues");
            app.UseEndpoints(endpoints => {
                endpoints.MapRazorPages();
            });
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
