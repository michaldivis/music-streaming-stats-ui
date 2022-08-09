namespace MusicStreamingStatsApp.Controls;

public partial class LargeStatCount : ContentView
{
    public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(LargeStatCount), string.Empty);

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public static readonly BindableProperty CountProperty = BindableProperty.Create(nameof(Count), typeof(int), typeof(LargeStatCount), 0);

    public int Count
    {
        get => (int)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }

    public static readonly BindableProperty ChangeProperty = BindableProperty.Create(nameof(Change), typeof(int), typeof(LargeStatCount), 0);

    public int Change
    {
        get => (int)GetValue(ChangeProperty);
        set => SetValue(ChangeProperty, value);
    }

    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(LargeStatCount));

    public Color TextColor
    {
        get => (Color)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public LargeStatCount()
	{
		InitializeComponent();
	}
}