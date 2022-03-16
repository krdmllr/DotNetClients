using Shared.Data;
using System.Collections.ObjectModel;

namespace Maui.Pages;

public partial class FetchPage : ContentPage
{
	private WeatherForecastService _forecastService;

	public ObservableCollection<WeatherForecast> Forecasts { get; set; } = new ObservableCollection<WeatherForecast>();

	public FetchPage()
	{
		_forecastService = new WeatherForecastService();
		InitializeComponent();
		BindingContext = this;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		if(Forecasts.Any())
			Forecasts.Clear();
		Task.Run(async () =>
		{
			await Task.Delay(2000);
			var forecasts = await _forecastService.GetForecastAsync(DateTime.Now);
            foreach (var forecast in forecasts)
            {
				Forecasts.Add(forecast);
				await Task.Delay(250);
            }
		});
	}

    private void RowAppeared(object sender, EventArgs e)
    {
		var grid = (Grid)sender;
		grid.Animate("fadein", new Animation(value => grid.Opacity = value, easing: Easing.CubicIn), length: 750);
    }
}