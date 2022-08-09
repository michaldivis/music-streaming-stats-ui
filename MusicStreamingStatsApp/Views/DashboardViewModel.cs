using MusicStreamingStatsApp.Models;
using System.Collections.ObjectModel;

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

    [ObservableProperty] int _seed;

    [ObservableProperty] bool _isReloading;

    public ObservableCollection<SongDetails> Songs { get; } = new();
    public ObservableCollection<SongDetails> Playlists { get; } = new();

    public DashboardViewModel()
    {
        Reload();
    }

    [RelayCommand]
    private void Reload()
    {
        Avatar = "avatar.jpg";

        Seed = Random.Shared.Next();
        var random = new Random(Seed);

        Listeners = random.Next(500, 1000);
        ListenersChange = random.Next(-10, -1);

        Streams = random.Next(1500, 4000);
        StreamsChange = random.Next(5, 25);

        Followers = random.Next(1000, 2000);
        FollowersChange = random.Next(5, 15);

        ListeningNow = random.Next(10, 350);

        var songStreams = Enumerable
            .Range(0, 6)
            .Select(a => random.Next(50, 500))
            .OrderByDescending(a => a)
            .ToList();

        var songs = new[]
        {
            new SongDetails(1, "Dreamer", "dreamer.jpg", songStreams.ElementAt(0)),
            new SongDetails(2, "Spectre", "spectre.jpg", songStreams.ElementAt(1)),
            new SongDetails(3, "Ornaments", "dreamer.jpg", songStreams.ElementAt(2)),
            new SongDetails(4, "Labyrinth", "dreamer.jpg", songStreams.ElementAt(3)),
            new SongDetails(5, "Djinn", "djinn.jpg", songStreams.ElementAt(4)),
            new SongDetails(6, "Kraken", "kraken.jpg", songStreams.ElementAt(5)),
        };

        Songs.Clear();
        Songs.AddRange(songs);

        int GetPlaylistStreams() => random.Next(100, 1000);

        var playlists = new[]
        {
            new SongDetails(1, "Hidden Djems", "hiddendjems.jpg", GetPlaylistStreams()),
            new SongDetails(2, "Yatsu: Complete", "yatsucomplete.jpg", GetPlaylistStreams())
        };

        Playlists.Clear();
        Playlists.AddRange(playlists.OrderByDescending(a => a.Streams));

        IsReloading = false;
    }
}