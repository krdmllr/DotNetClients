namespace Maui.Pages;

public partial class CounterPage : ContentPage
{
    private int counterValue;

    public Command IncrementCounterCommand { get; }

    public int CounterValue
    {
        get => counterValue; set
        {
            counterValue = value;
            OnPropertyChanged();
        }
    }

    public CounterPage()
    {
        IncrementCounterCommand = new Command(() => CounterValue++);
        InitializeComponent();
        BindingContext = this;
    }
}