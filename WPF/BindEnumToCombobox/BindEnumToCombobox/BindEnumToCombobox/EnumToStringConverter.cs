using System;
using System.Globalization;
using System.Windows.Data;

namespace BindEnumToCombobox
{
    [ValueConversion(typeof(ValuesEnum), typeof(object))]
    public class EnumToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((ValuesEnum)value).GetDescription<ValuesEnum>();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ValuesEnum.First.GetValueFromDescription<ValuesEnum>((string)value);
        }
    }
}
