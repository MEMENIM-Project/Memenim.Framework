using System.Windows.Data;

namespace Memenim.Framework.Converters
{
	public sealed class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            try
            {
                return value?
                    .ToString() ?? string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            try
            {
                return ((string)value)?
                    .ToInt() ?? 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
