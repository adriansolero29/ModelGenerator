using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ModelGenerator.UI.Views;
using ModelGenerator.UI.Interface;
using ModelGenerator.UI.Services;
using ModelGenerator.UI.Helpers;
using static ModelGenerator.UI.Helpers.DataLoaderServiceResolver;
using ModelGenerator.UI.DataAccess;
using static ModelGenerator.UI.Helpers.XMLServiceResolver;

namespace ModelGenerator.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<GeneratorMainUI>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddTransient<GeneratorMainUI>();
                services.AddTransient<DatabaseSettingSetupWindow>();
                services.AddTransient<GeneratedModelViewer>();

                services.AddSingleton<IDBInit, PostgreSQLConnection>();
                services.AddSingleton<IBusinessLogicService, BusinessLogicService>();
                services.AddSingleton<IDataTypeConverter, PostgresDataTypeConverter>();

                services.AddTransient<PostgreSQLDataLoader>();
                services.AddTransient<XMLDatabaseSetting>();
                services.AddTransient<XMLPropertyModels>();

                services.AddTransient<ServiceResolverXML>(ServiceProvider => XMLService =>
                {
                    switch (XMLService)
                    {
                        case (XMLService.XMLDatabaseSetting):
                            return ServiceProvider.GetService<XMLDatabaseSetting>();
                        case (XMLService.PropertyModels):
                            return ServiceProvider.GetService<XMLPropertyModels>();
                        default:
                            throw new KeyNotFoundException("NO service registered");
                    }
                });

                services.AddTransient<ServiceResolver>(ServiceProvider => DataLoaderService =>
                {
                    switch (DataLoaderService)
                    {
                        case (DataLoaderService.PostgreSQL):
                            return ServiceProvider.GetService<PostgreSQLDataLoader>();
                        default:
                            throw new KeyNotFoundException("NO service registered");
                    }
                });
            });
        }
    }
}
