using College.DataAccess;
using College.EntityFramework;
using College.Logic;
using Microsoft.Extensions.DependencyInjection;

namespace College.RestApi
{
    public static class ConfigurationServiceCollectionExtentions
    {
        public static IServiceCollection AddAppConfiguration(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<CourseLogic>();
            services.AddTransient<DepartmentLogic>();
            services.AddTransient<EnrollmentLogic>();
            services.AddTransient<StudentLogic>();
            return services;
        }
    }
}
