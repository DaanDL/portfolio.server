using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Server.Core;
using Portfolio.Server.Data.Context;
using Portfolio.Server.Data.Repositories;
using Portfolio.Server.Data.Seeding;
using Swashbuckle.AspNetCore.Swagger;

namespace Portfolio.Server.Api
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
            services.AddMvc();
            services.AddScoped<IBlogPostRepository, BlogPostRepository>();
            services.AddScoped<IBlogPostService, BlogPostService>();
            services.AddDbContext<BlogPostContext>(c =>
            {
                c.UseSqlServer(Configuration.GetConnectionString("BlogPostConnection"));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Portfolio Api", Version = "v1" });
            });

            services.AddCors();
        }
         
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            DatabaseSeeder.Initialize(app.ApplicationServices);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod());

            app.UseMvc();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Portfolio API V1");
            });

        }
    }
}
