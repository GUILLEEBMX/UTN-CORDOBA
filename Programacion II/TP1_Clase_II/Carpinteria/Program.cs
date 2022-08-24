using Carpinteria.Context;
using Carpinteria.Domain;
using Carpinteria.Fronted;
using Carpinteria.FrontEnd;
using Carpinteria.Services;
using Carpinteria.Validators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria.FrontEnd
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services; Application.Run(ServiceProvider.GetRequiredService<FormBudget>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddTransient<FormBudget>();
                services.AddTransient<Budget>();
                services.AddTransient<Entity>();
                services.AddTransient<IContextService,Entity>();
                services.AddTransient<IFormBudgetValidatorService, FormBudgetValidator>();
                
            });
        }
    }



}



