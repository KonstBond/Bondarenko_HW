using System;
using System.Globalization;

namespace Task_2_Lib
{
    internal class Temperature : IFormattable
    {
        private double _tempValue;
        public Temperature(double tempValueCelc)
        {
            if (tempValueCelc > -273.15)
                _tempValue = tempValueCelc;
            else
                throw new ArgumentException($"{tempValueCelc} is less of -273.15 °Ñ");
        }
        public double TempCelc { get { return _tempValue; } }
        public double TempFar { get { return _tempValue * 9 / 5 + 32; } }
        public double TempKelv { get { return _tempValue + 273.15; } }
        public override string ToString()
        {
            return ToString("°Ñ", CultureInfo.CurrentCulture);
        }
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (format == null)
                format = "C";

            if (formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;

            switch (format)
            {
                case "C":
                    return TempCelc.ToString("F2", formatProvider) + "°C";
                case "F":
                    return TempFar.ToString("F2", formatProvider) + "°F";
                case "K":
                    return TempKelv.ToString("F2", formatProvider) + "°K";
                default:
                    throw new ArgumentException($"Invalid format: {format}");
            }
        }
        public string ShowTempCelc()
        {
            return this.ToString("C");
        }
        public string ShowTempKelv()
        {
            return this.ToString("K");
        }
        public string ShowTempFar()
        {
            return this.ToString("F");
        }
    }
}
