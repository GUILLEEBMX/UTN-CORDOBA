using API_Problema_4._4.Models;
using API_Problema_4._4.Repository.ProductRepository;
using API_Problema_4._4.Services.ProductServices;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Problema_4._4.Configuration
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            //    /*
            //     * TIPS: Configuración de repositorios en el contenedor de dependencias.
            //     *
            //     * Formato:
            //     * services.AddTransient<I[Model]Repository, [Tecnologia][Model]Repository>();
            //     *
            //     * Ejemplos:
            //     * services.AddTransient<IUsuarioRepository, MySqlUsuarioRepository>();
            //     * services.AddTransient<IUsuarioRepository, CiDiUsuarioRepository>();
            //     * services.AddTransient<IUsuarioRepository, ActiveDirectorysUsuarioRepository>();
            //     * services.AddTransient<IUsuarioRepository, MockUsuarioRepository>();
            //     */

            //    //services.AddTransient<ILicenciaRepository, MsSqlServerLicenciaRepository>();


            return services;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddDbContext<bootcampContext>(options => options.UseSqlServer(configuration.GetConnectionString("defaultConnection")));
            //services.AddAutoMapper(typeof(Startup));



            services.AddTransient<IProductService, ProductRepository>();

            services.AddSingleton<Microsoft.AspNetCore.Mvc.Infrastructure.IActionContextAccessor, ActionContextAccessor>();




            services.AddCors(opciones =>
            {
                opciones.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("https://webapiventas.azurewebsites.net/").AllowAnyMethod().AllowAnyHeader();
                });
            });

            //services.AddControllers(opciones =>
            //{
            //    opciones.Filters.Add(typeof(FiltroDeExcepcion));
            //    //opciones.Filters.Add(typeof(MiFiltroDeAccion));

            //});

            return services;
        }

        public static IServiceCollection RegisterApplicationValidators(this IServiceCollection services)
        {
            /*
             * TIPS: Configuración de validadores en el contenedor de dependencias. No todos los modelos tendrán un validador.
             *
             * Formato:
             * services.AddTransient<IValidator<[Model]Model>, [Model]Validator>();
             *
             * Ejemplos:
             * services.AddTransient<IValidator<UsuarioModel>, UsuarioValidator>();
             */

            // services.AddScoped<IValidator<ProductoModel>, ProductoValidator>();

            return services;
        }
    }
}
