using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace FormDetalMech.Libr
{
    /// <summary>
    /// Класс сравнения id или проверка на Админа.
    /// </summary>
    public class IsEqualForIDThanConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IComparable v1 = values[0] as IComparable;
            IComparable v2 = values[1] as IComparable;

            //int v1 = (int)values[0];
            //int v2 = (int)values[1];

            if (v1 == null || v2 == null)
                throw new FormatException("to use this converter, value and parameter shall inherit from Double");

            return ((string)v1 == v2.ToString() || (string)v1 == "1");
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Not implemented");
        }
    }

    public class IsEqualForButtAddThanConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IComparable v1 = values[0] as IComparable; // ID.
            IComparable v2 = values[1] as IComparable; // Gn_uceh;
            IComparable v3 = values[2] as IComparable; // Ceh.
            IComparable v4 = values[3] as IComparable; // dmpconfirm.

            //int v1 = (int)values[0];
            //int v2 = (int)values[1];

            if (v1 == null || v2 == null || v3==null || v4==null)
                throw new FormatException("to use this converter, value and parameter shall inherit from Double");

            return ((int)v4==0 && ((string)v1=="1" || (int)v2==(int)v3));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Not implemented");
        }
    }

    /// <summary>
    /// Проверка на права отк.
    /// </summary>
    public class IsOTKThanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IComparable v1 = value as IComparable;

            if (v1 == null)
                throw new FormatException("to use this converter, value and parameter shall inherit from Double");

            return ((string)v1 == "1" || (string)v1 == "2");
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Not implemented");
        }
    }
}
