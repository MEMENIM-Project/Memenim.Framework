using System.Windows.Data;

namespace Memenim.Framework.Converters
{
    public sealed class PreviewImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            string result = null;

            if (value is string stringValue)
                result = stringValue;

            return result == null
                   || !Uri.TryCreate(result, UriKind.Absolute, out _)
                ? DependencyProperty.UnsetValue
                : result;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            string result = null;

            if (value is string stringValue)
                result = stringValue;

            return result == null
                   || !Uri.TryCreate(result, UriKind.Absolute, out _)
                ? string.Empty
                : result;
        }
    }
}
