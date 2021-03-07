using Microsoft.Extensions.DependencyInjection;
using ProntMed.UI.AppTest.Interfaces;
using ProntMed.UI.AppTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProntMed.UI.AppTest.Data.Configurations
{
    public static class DependencyInjectionConfiguration
    {

        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<TodoDbContext>();
            services.AddScoped<ITodoRepository, TodoRepository>();
            return services;
        }
    }
}
