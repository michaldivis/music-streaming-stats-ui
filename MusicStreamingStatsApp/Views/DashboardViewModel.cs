using MusicStreamingStatsApp.Models;

namespace MusicStreamingStatsApp.Views;

public partial class DashboardViewModel : ObservableObject
{
    [ObservableProperty] string _avatar;

    [ObservableProperty] int _listeners;
    [ObservableProperty] int _listenersChange;
    [ObservableProperty] int _streams;
    [ObservableProperty] int _streamsChange;
    [ObservableProperty] int _followers;
    [ObservableProperty] int _followersChange;
    [ObservableProperty] int _listeningNow;

    public List<SongDetails> Songs { get; } = new();

    public DashboardViewModel()
    {
        LoadData();
    }

    private void LoadData()
    {
        _avatar = "avatar.jpg";

        var random = new Random(444555666);

        _listeners = random.Next(100, 1000);
        _listenersChange = random.Next(-10, 20);

        _streams = random.Next(250, 2500);
        _streamsChange = random.Next(-10, 20);

        _followers = random.Next(1000, 2000);
        _followersChange = random.Next(-5, 10);

        _listeningNow = random.Next(10, 120);

        int GetStreams() => random.Next(_streams / 15, _streams / 5);

        var songs = new[]
        {
            new SongDetails("Dreamer", "dreamer.jpg", GetStreams()),
            new SongDetails("Ornaments", "dreamer.jpg", GetStreams()),
            new SongDetails("Labyrinth", "dreamer.jpg", GetStreams()),
            new SongDetails("Spectre", "spectre.jpg", GetStreams()),
            new SongDetails("Djinn", "djinn.jpg", GetStreams()),
            new SongDetails("Kraken", "kraken.jpg", GetStreams()),
        };

        Songs.AddRange(songs.OrderByDescending(a => a.Streams));
    }
}