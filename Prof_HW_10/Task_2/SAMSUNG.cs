using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class SAMSUNG : AbstractPhone
    {
        protected override void Manufacturer() => Console.WriteLine("Samsung Electronics");
        protected override void ResourceProvider() => Console.WriteLine("STATEN");
        protected override void SalesMarket() => Console.WriteLine("Europe, Asia, Oceania, America");
    }
}
