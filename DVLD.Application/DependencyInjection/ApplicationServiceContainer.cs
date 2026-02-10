using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using DVLD.Application.Mapping;

namespace DVLD.Application.DependencyInjection
{
    public static class ApplicationServiceContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register AutoMapper and scan the current assembly for mapping profiles.
            services.AddAutoMapper(cfg =>
            {
                cfg.AddMaps(Assembly.GetExecutingAssembly());
            });

            // تسجيل الـ Services (هنضيفهم هنا لما نكريتهم)
            // services.AddScoped<IPersonService, PersonService>();

            return services;
        }
    }
}
