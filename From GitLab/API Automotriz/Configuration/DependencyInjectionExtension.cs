using API_Automotriz.Repository;
using API_Automotriz.Services;
using API_Problema_4._4;
using AutomotrizLibrary.Context;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Automotriz.Configuration
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
    
            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {

           
            services.AddAutoMapper(typeof(Startup));



            services.AddTransient<IProductServices, ProductRepository>();
            services.AddTransient<IOrderServices, OrderRepository>();
            services.AddTransient<IUserServices,UserRepository>();
            services.AddTransient<IProviderServices,ProviderRepository>();
            services.AddTransient<ISubsidiaryServices, SubsidiaryRepository>();
            services.AddTransient<IDeliverieServices, DeliveryRepository>();
            services.AddTransient<IRequestTypeServices,RequestTypeRepository>();
            services.AddTransient<IEmployServices, EmployRepository>();
            services.AddTransient<IClientServices, ClientRepository>();



            services.AddSingleton<Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor, ActionContextAccessor>();




            services.AddCors(opciones =>
            {
                opciones.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("https://webapiventas.azurewebsites.net/").AllowAnyMethod().AllowAnyHeader();
                });
            });

            return services;
        }

        public static IServiceCollection RegisterApplicationValidators(this IServiceCollection services)
        {
            
            return services;
        }
    }
}

