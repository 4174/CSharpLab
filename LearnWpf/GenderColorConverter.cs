using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace LearnWpf
{
    public class GenderColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Gender gender = (Gender)value;
            if (gender == Gender.Male)
                return new SolidColorBrush(Colors.Blue);
            else if (gender == Gender.Female)
                return new SolidColorBrush(Colors.Pink);
            else
                return Binding.DoNothing;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
