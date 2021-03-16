using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Mappings;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdventureWorksContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("AdventureWorks"))
           );

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddTransient<IMapper, Mapper>();
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
