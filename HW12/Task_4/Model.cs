using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Model
    {
        char[] delimiterChars = { '+', '-', '*', '/'};

        public string Input(string str, char value)
        {
            if (str == "0" && delimiterChars.Contains(value))
            {
                return "0";
            }
            else if (str == "0")
            {
                return value.ToString();
            }
            return $"{str}{value}";
        } 

        public string Clear()
        {
            return "0";
        }

        public string Rez(string str)
        {
            List<string> Digit = str.Split(delimiterChars).ToList();
            if (str[0] == '-')
            {
                Digit[1] = (-double.Parse(Digit[1])).ToString();
                Digit.Remove(Digit[0]);
                str = str[1..];
            }
            var operators = from s in str
                            where s == '-' || s == '*' || s == '/' || s =='+'
                            select s;
            double rezult = 0;
            int counter = 0;

            foreach (var item in operators)
            {
                rezult = item switch
                {
                    '+' => double.Parse(Digit[counter]) + double.Parse(Digit[counter+1]),
                    '-' => double.Parse(Digit[counter]) - double.Parse(Digit[counter+1]),
                    '*' => double.Parse(Digit[counter]) * double.Parse(Digit[counter+1]),
                    '/' => double.Parse(Digit[counter]) / double.Parse(Digit[counter+1]),
                    _ => 10000000000000000
                };
                Digit[counter + 1] = rezult.ToString();
                counter++;
            }
            return rezult.ToString();
        }
    }
}
