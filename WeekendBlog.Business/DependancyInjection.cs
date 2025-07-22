using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekendBlog.Business.Interfaces;
using WeekendBlog.Business.Services;
using WeekendBlog.Dataaccess;

namespace WeekendBlog.Business
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            //get services from dataaccess
            services.AddDataServices(configuration);

            // Register business services here
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<ICategoryService, CategoryService>();
            return services;
        }
    }
}
