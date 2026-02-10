using DVLD.Domain.Interfaces;
using DVLD.Infrastructure.Data;
using DVLD.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Infrastructure.DependencyInjection
{
    public static class InfrastructureServiceContainer
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // 1. Setup DbContext with Connection String
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // 2. Register Unit of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // 3. Register Repositories (Optional if UoW handles them, but good for explicit injection)
            //services.AddScoped<IPersonRepository, PersonRepository>();
            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IApplicationRepository, ApplicationRepository>();
            //services.AddScoped<IDriverRepository, DriverRepository>();
            //services.AddScoped<ILicenseRepository, LicenseRepository>();
            //services.AddScoped<ITestAppointmentRepository, TestAppointmentRepository>();
            //services.AddScoped<IDetainedLicenseRepository, DetainedLicenseRepository>();
            //services.AddScoped<IInternationalLicenseRepository, InternationalLicenseRepository>();

            return services;
        }
    }
}
