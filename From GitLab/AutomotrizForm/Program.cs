using API_Automotriz.Repository;
using API_Automotriz.Services;
using AutomotrizForm.Clients;
using AutomotrizForm.Fronted;
using AutomotrizForm.Services;
using AutomotrizForm.Validators;
using AutomotrizLibrary;
using AutomotrizLibrary.DTOs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace AutomotrizForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services; Application.Run(ServiceProvider.GetRequiredService<LogginForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                //SERVICES
                services.AddTransient<IUserLoggiClient, LogginClient>();
                services.AddTransient<IUserClientServices, UserClient>();
                services.AddTransient<IProductClientServices,ProductClient>();
                services.AddTransient<IOrderClientServices, OrderClient>();
                services.AddTransient<IValidatorServices,ValidatorForm>();
                services.AddTransient<IQueryServices, QueryClient>();
                services.AddTransient<IContactServices,ContactClient>();
                services.AddTransient<ITeamServices, TeamClient>();
               


                //CLIENT HTTP     
                services.AddTransient<HttpClient>();

                //FORMS
                services.AddTransient<UsersForms>();
                services.AddTransient<LogginForm>();
                services.AddTransient<ListOrdersForm>();
                services.AddTransient<OrderForm>();
                services.AddTransient<ProductForm>();
                services.AddTransient<PrincipalMenuForm>();
                services.AddTransient<QueriesListForm>();
                services.AddTransient<ContactForm>();
                services.AddTransient<TeamForm>();

                //DTOs
                services.AddTransient<UserLogginDTO>();
                services.AddTransient<UserRegisterDTO>();
                services.AddTransient<UserAdminDTO>();
                services.AddTransient<OrderPostDTO>();
                services.AddTransient<OrderDetailDTO>();
                services.AddTransient<ProductPostDTO>();
                
            });
        }
    }
}