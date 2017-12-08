using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace mr_system.Converter
{
    public class VisiableOrNot : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Uri uri = new Uri(value.ToString());
            if (uri != null)
            {
                if (uri.Equals("/View/App/OverView.xaml"))
                {
                    return Visibility.Visible;
                }
                else if (uri.Equals("/View/App/MainPage.xaml"))
                {
                    
                }
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}