using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Local : IFormattable
    {
        private List<string> _nameOfProduct;
        private List<double> _cost;
        private List<DateOnly> _dateOfBuying;
        public Local(FileInfo fileDB)
        {
            StreamReader reader = new StreamReader(fileDB.FullName);

            _nameOfProduct = new List<string>();
            _cost = new List<double>();
            _dateOfBuying = new List<DateOnly>();

            string[] line = reader.ReadToEnd().Split("\r\n");
            for (int i = 0; i < line.Length; i++)
            {
                string[] words = line[i].Split('-');
                for (int j = 0; j < words.Length; j++)
                {
                    switch (j % 3)
                    {
                        case 0:
                            _nameOfProduct.Add(words[j % 3]);
                            break;
                        case 1:
                            _cost.Add(Double.Parse(words[j % 3]));
                            break;
                        case 2:
                            _dateOfBuying.Add(DateOnly.Parse(words[j % 3]));
                            break;
                    }
                }     
            }
        }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();
            for (int i = 0; i < _nameOfProduct.Count; i++)
            {
                SB.Append(_nameOfProduct[i] + "\t" + _cost[i] + RegionInfo.CurrentRegion.CurrencySymbol + "\t" + _dateOfBuying[i] + "\n");
            }
            return SB.ToString();
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder SB = new StringBuilder();
            if (format is null || formatProvider is null)
                return this.ToString();
            else
            {
                RegionInfo region = new RegionInfo(formatProvider.ToString());
                for (int i = 0; i < _nameOfProduct.Count; i++)
                {
                    SB.Append(_nameOfProduct[i].ToString(formatProvider) + "\t");
                    SB.Append(_cost[i].ToString(format, formatProvider) + region.CurrencySymbol + "\t");
                    SB.Append(_dateOfBuying[i].ToString(formatProvider) + "\n");
                }
                return SB.ToString();
            }
        }
    }
}
