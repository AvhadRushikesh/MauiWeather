using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWeather.Converter
{
    public class CodeToWeatherConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //var code = (float)value;
            var code = value;

            switch (code)
            {
                case 0:
                    return "Clear Sky";
                case 1:
                    return "Mainly Clear";

                case 2:
                    return "Partly Cloudy";

                case 3:
                    return "Overcast";

                case 4:
                    return "Fog";

                case 5:
                    return "Depositing rime fog";

                case 6:
                    return "Drizzle: Light";

                case 7:
                    return "Drizzle: Moderalte";

                case 8:
                    return "Drizzle: Dense Intensity";

                case 9:
                    return "Freezing Drizzle: Light";

                case 10:
                    return "Freezing Drizzle: Dense Intensity";

                case 11:
                    return "Rain: Slight";

                case 12:
                    return "Rain: Moderate";

                case 13:
                    return "Rain: Heavy Intensity";

                case 14:
                    return "Freezing Rain: Light";

                case 15:
                    return "Freezing Rain: Heavy intensity";

                case 16:
                    return "Snow fall: Slight";

                case 73:
                    return "Snow fall: Moderate";

                case 75:
                    return "Snow fall: Heavy intensity";

                case 77:
                    return "Snow grains";

                case 80:
                    return "Rain showers: Slight";

                case 81:
                    return "Rain showers: Moderate";

                case 82:
                    return "Rain showers: Violent";

                case 85:
                    return "Snow showers: Slight";

                case 86:
                    return "Snow showers: Heavy";

                case 95:
                    return "Thunderstorm: Slight or moderate";

                case 96:
                    return "Thunderstorm with slight and heavy hail";

                case 99:
                    return "Thunderstorm with slight and heavy hail";

                default: return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
