using System.Globalization;

namespace MusicStreamingStatsApp.Converters;
public class IsIntPositiveToBoolConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is int change ? change > 0 : value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value;
    }
}
