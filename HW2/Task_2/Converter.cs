using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Converter
    {
        private double usdCurse, eurCurse, rubCurse;

        public Converter(double usd, double eur, double rub)
        {
            usdCurse = usd;
            eurCurse = eur;
            rubCurse = rub;
        }

        public string UAHToUSD(double UAH)
        {
            return (UAH * usdCurse).ToString() + " USD";
        }

        public string UAHToEUR(double UAH)
        {
            return (UAH * eurCurse).ToString() + " EUR";
        }

        public string UAHToRUB(double UAH)
        {
            return (UAH * rubCurse).ToString() + " RUB";
        }

        public string RUBToUAH(double RUB)
        {
            return (RUB / rubCurse).ToString() + " UAH";
        }

        public string EURToUAH(double EUR)
        {
            return (EUR / eurCurse).ToString() + " UAH";
        }

        public string USDToUAH(double USD)
        {
            return (USD / usdCurse).ToString() + " UAH";
        }
    }
}
