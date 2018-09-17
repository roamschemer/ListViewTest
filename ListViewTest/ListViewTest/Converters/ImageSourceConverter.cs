using System;
using System.Reflection;
using Xamarin.Forms;

namespace ListViewTest.Converters
{
    public class ImageSourceConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is string))
            {
                return default(ImageSource);
            }

            var assembly = typeof(App).GetTypeInfo().Assembly;
            return ImageSource.FromResource(value.ToString(), assembly);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
