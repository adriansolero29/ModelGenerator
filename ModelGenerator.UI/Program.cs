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
using static ModelGenerator.UI.Enums.Enums;

using ModelGenerator.UI.DataAccess;
using static ModelGenerator.UI.Helpers.ServiceResolvers;

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
                services.AddTransient<PropertyModelSetup>();

                services.AddSingleton<IDBInit, PostgreSQLConnection>();
                services.AddSingleton<IBusinessLogicService, BusinessLogicService>();
                services.AddSingleton<IXMLDatabaseSetting, XMLDatabaseSetting>();
                services.AddTransient<IXMLPropertyTypesList, XMLPropertyType>();
                services.AddTransient<IXMLDataProcessor, XMLPropertyModels>();

                services.AddTransient<PostgreSQLDataLoader>();
                services.AddTransient<XMLDatabaseSetting>();
                services.AddTransient<XMLPropertyModels>();
                services.AddTransient<PostgresDataTypeConverter>();

                services.AddTransient<DataTypeConverterServiceResolver>(ServiceProvider => DataLoaderService =>
                {
                    switch (DataLoaderService)
                    {
                        case DataLoaderService.PostgreSQL:
                            return ServiceProvider.GetService<PostgresDataTypeConverter>();
                        default:
                            throw new KeyNotFoundException("No service registered");
                    }
                });

                services.AddTransient<ServiceResolverXML>(ServiceProvider => XMLService =>
                {
                    switch (XMLService)
                    {
                        case (XMLService.XMLDatabaseSetting):
                            return ServiceProvider.GetService<XMLDatabaseSetting>();
                        case (XMLService.PropertyModels):
                            return ServiceProvider.GetService<XMLPropertyModels>();
                        default:
                            throw new KeyNotFoundException("No service registered");
                    }
                });

                services.AddTransient<ServiceResolver>(ServiceProvider => DataLoaderService =>
                {
                    switch (DataLoaderService)
                    {
                        case (DataLoaderService.PostgreSQL):
                            return ServiceProvider.GetService<PostgreSQLDataLoader>();
                        default:
                            throw new KeyNotFoundException("No service registered");
                    }
                });
            });
        }
    }
}
