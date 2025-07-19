using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeekendBlog.Dataaccess.Implementations;
using WeekendBlog.Dataaccess.Interfaces;

namespace WeekendBlog.Dataaccess
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BlogContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IBlogRepository, BlogRepository>();
            return services;
        }
    }
}
