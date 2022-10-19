using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace API_Problema_4._4.Configuration
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMvc(options =>
            {
                options.SuppressAsyncSuffixInActionNames = false;
            });

            services.AddControllers(opciones =>
            {
                //opciones.Conventions.Add(new SwaggerAgrupaPorVersion());
                //opciones.Filters.Add(typeof(FiltroDeExcepcion));

            }).
           
         AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            //services.AddIdentity<IdentityUser, IdentityRole>()
            // .AddEntityFrameworkStores<bootcampContext>()
            // .AddDefaultTokenProviders();

            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //  .AddJwtBearer(opciones => opciones.TokenValidationParameters = new TokenValidationParameters
            //  {
            //      ValidateIssuer = false,
            //      ValidateAudience = false,
            //      ValidateLifetime = true,
            //      ValidateIssuerSigningKey = true,
            //      IssuerSigningKey = new SymmetricSecurityKey(
            //        Encoding.UTF8.GetBytes(configuration["llavejwt"])),
            //      ClockSkew = TimeSpan.Zero
            //  });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API Problema 4-4 Programacion II",
                    Version = "v1",
                    Description = "API Problema 4-4 Programacion II"

                });

                c.SwaggerDoc("v2", new OpenApiInfo { Title = "WebAPIVentas", Version = "v2" });
                //c.OperationFilter<AgregarParametroHATEOAS>();
                //c.OperationFilter<AgregarParametroXVersion>();

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[]{}
                    }
                });

                //var archivoXML = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var rutaXML = Path.Combine(AppContext.BaseDirectory, archivoXML);
                //c.IncludeXmlComments(rutaXML);



            });

            services.AddAuthorization(opciones =>
            {
                opciones.AddPolicy("EsAdmin", politica => politica.RequireClaim("esAdmin"));
            });//Agregar otro claim para mas roles

            services.AddControllersWithViews(opciones => { opciones.SuppressAsyncSuffixInActionNames = false; });

            services.AddMvc(options =>
            {
                options.SuppressAsyncSuffixInActionNames = false;
            });

            return services;
        }
        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApiVentas v1");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "WebApiVentas v2");
            });

            return app;
        }

    }
}
