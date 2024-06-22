using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SEO_Application.Controllers;
using SerpAPI;
using System.Configuration;
using System.Data;
using System.Security.RightsManagement;
using System.Windows;

namespace SEO_Application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }
        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    //services.AddScoped<SearchController>();
                    services.AddSingleton<MainWindow>();
                })
                .Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();//due to constructor will never be null
            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();

            startupForm.Show();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }

}
