using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Patronage_16.Converters
{
    public class LiczbaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.String language)
        {
            if (value == null || !(value is int))
                return "blad";

            int liczba = System.Convert.ToInt32(value);

            return (liczba == 0) ? "zero" : "nie zero"; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.String language)
        {
            throw new NotImplementedException();
        }
    }
}
