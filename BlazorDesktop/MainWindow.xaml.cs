using BlazorDesktop.Data;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace BlazorDesktop {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            serviceCollection.AddSingleton<WeatherForecastService>();
            Resources.Add("services", serviceCollection.BuildServiceProvider());
            InitializeComponent();
        }
    }
}
