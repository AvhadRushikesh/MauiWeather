using SkiaSharp.Extended.UI.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWeather.Converter
{
    public class CodeToLottieConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //var code = (float)value;
            var code = value;

            var lottienImageSource = new SKFileLottieImageSource();

            switch (code)
            {
                case 0:
                    lottienImageSource.File = "sunny.json";
                    return lottienImageSource;

                case 2:
                    lottienImageSource.File = "sunny.json";
                    return lottienImageSource;

                case 3:
                    lottienImageSource.File = "sunny.json";
                    return lottienImageSource;

                case 4:
                    lottienImageSource.File = "sunny.json";
                    return lottienImageSource;

                case 5:
                    lottienImageSource.File = "sunny.json";
                    return lottienImageSource;

                case 6:
                    lottienImageSource.File = "foggy.json";
                    return lottienImageSource;

                case 7:
                    lottienImageSource.File = "foggy.json";
                    return lottienImageSource;

                case 8:
                    lottienImageSource.File = "foggy.json";
                    return lottienImageSource;

                case 9:
                    lottienImageSource.File = "foggy.json";
                    return lottienImageSource;

                case 10:
                    lottienImageSource.File = "partly-shower.json";
                    return lottienImageSource;

                case 11:
                    lottienImageSource.File = "partly-shower.json";
                    return lottienImageSource;

                case 12:
                    lottienImageSource.File = "partly-shower.json";
                    return lottienImageSource;

                case 13:
                    lottienImageSource.File = "partly-shower.json";
                    return lottienImageSource;

                case 14:
                    lottienImageSource.File = "partly-shower.json";
                    return lottienImageSource;

                case 15:
                    lottienImageSource.File = "stormshowersday.json";
                    return lottienImageSource;

                case 16:
                    lottienImageSource.File = "stormshowersday.json";
                    return lottienImageSource;

                case 17:
                    lottienImageSource.File = "stormshowersday.json";
                    return lottienImageSource;

                case 18:
                    lottienImageSource.File = "stormshowersday.json";
                    return lottienImageSource;

                case 19:
                    lottienImageSource.File = "stormshowersday.json";
                    return lottienImageSource;

                case 20:

                    lottienImageSource.File = "snow.json";
                    return lottienImageSource;

                case 21:
                    lottienImageSource.File = "snow.json";
                    return lottienImageSource;

                case 22:
                    lottienImageSource.File = "snow.json";
                    return lottienImageSource;

                case 23:
                    lottienImageSource.File = "snow.json";
                    return lottienImageSource;

                case 24:
                    lottienImageSource.File = "snow.json";
                    return lottienImageSource;

                case 25:
                    lottienImageSource.File = "storm.json";
                    return lottienImageSource;

                case 26:
                    lottienImageSource.File = "storm.json";
                    return lottienImageSource;

                case 27:
                    lottienImageSource.File = "storm.json";
                    return lottienImageSource;

                case 28:
                    lottienImageSource.File = "storm.json";
                    return lottienImageSource;

                case 29:
                    lottienImageSource.File = "storm.json";
                    return lottienImageSource;

                case 30:
                    lottienImageSource.File = "storm.json";
                    return lottienImageSource;

                default:
                    return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}