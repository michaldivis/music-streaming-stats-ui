using MusicStreamingStatsApp.Views;

namespace MusicStreamingStatsApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DashboardView();
	}
}
