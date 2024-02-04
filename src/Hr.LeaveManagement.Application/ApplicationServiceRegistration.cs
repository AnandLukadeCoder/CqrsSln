﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Hr.LeaveManagement.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(c=>c.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}