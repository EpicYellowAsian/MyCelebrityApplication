using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCelebrityApplication
{
    public class NetWorthConverter
    {
        public static string Convert(long netWorth)
        {
                switch (netWorth)
                {
                    case 1:
                        return "Rich";
                    case 2:
                        return "Very rich";
                    case 3:
                        return "Filthy rich";
                    case 4:
                        return "F*cking rich";
                }
            return "No data available";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
