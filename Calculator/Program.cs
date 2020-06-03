using CalculatorBL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static void ConfigureServices()
        {
            var services = new ServiceCollection();
            
            // Resolver to resolve correct calculator
            services.AddTransient<EitherCalculator>();
            services.AddTransient<CombinedCalculator>();
            services.AddTransient<Logger>();
            services.AddTransient<ServiceResolver>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "Either":
                        return serviceProvider.GetService<EitherCalculator>();
                    case "Combined":
                        return serviceProvider.GetService<CombinedCalculator>();
                    default:
                        throw new KeyNotFoundException(); // or maybe return null, up to you
                }
            });

            services.AddTransient<Form1>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
        }

        public delegate ICalculator ServiceResolver(string key);
    }
}
