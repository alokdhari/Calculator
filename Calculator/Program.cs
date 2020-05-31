using CalculatorBL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<ICalculateLogic, AdditionLogic>();
            services.AddTransient<ICalculateLogic, SubstractLogic>();
            services.AddTransient<ICalculateLogic, DivisionLogic>();
            services.AddTransient<ICalculateLogic, MultiplyLogic>();
            services.AddTransient<ICalculateLogic, MultiplyLogic>();
            services.AddTransient<ILogger, Logger>();
            services.AddTransient<IUnityOfWork, UnityOfWork>();

            // Resolver to resolve correct calculator
            services.AddTransient<EitherCalculator>();
            services.AddTransient<ServiceResolver>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "Either":
                        return serviceProvider.GetService<EitherCalculator>();
                    default:
                        throw new KeyNotFoundException(); // or maybe return null, up to you
                }
            });

            ServiceProvider = services.BuildServiceProvider();
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
            Application.Run(new Form1());
        }

        public delegate ICalculator ServiceResolver(string key);
    }
}
