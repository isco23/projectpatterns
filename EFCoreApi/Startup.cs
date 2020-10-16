using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FirstAppEFCore;
using FirstAppEFCore.Helper;
using FirstAppEFCore.MappingConfigurations;
using FirstAppEFCore.Security;
using FirstAppEFCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EFCoreApi
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
            MappingConfiguration(services);            
            services.AddDbContext<FirstAppEFCore.EFDemoContext>();
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ILessonService, LessonService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IAwardService, AwardService>();           
            
            services.AddControllers();
        }

        public void MappingConfiguration(IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new StudentMapping());
                mc.AddProfile(new CourseMapping());
                mc.AddProfile(new LessonMapping());
                mc.AddProfile(new AwardMapping());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
