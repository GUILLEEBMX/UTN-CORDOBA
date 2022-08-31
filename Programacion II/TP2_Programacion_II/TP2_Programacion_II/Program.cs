using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Programacion_II.Models;
using TP2_Programacion_II.Repository;
using TP2_Programacion_II.Services;
using TP2_Programacion_II.Validators;

namespace TP2_Programacion_II
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
           // Application.Run(new Form1());


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services; Application.Run(ServiceProvider.GetRequiredService<FormInvoice>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddTransient<FormInvoice>();
                services.AddTransient<InvoiceModel>();
                services.AddTransient<Context>();
                services.AddTransient<DetailInvoice>();
                services.AddTransient<IFormInvoiceValidatorServices, FormInvoiceValidator>();
                services.AddTransient<IBudgetRepositoryServices, BudgetRepository>();
           

            });
        }
    }
}
