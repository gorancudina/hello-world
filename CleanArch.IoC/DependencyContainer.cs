using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //app layer
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IProgramServices, ProgramService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IProgramRepository, ProgramRepository>();





        }
    }
}
