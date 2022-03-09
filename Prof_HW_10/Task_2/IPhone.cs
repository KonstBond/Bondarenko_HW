using System;

namespace Task_2
{
    public class IPhone : AbstractPhone
    {
        protected override void ResourceProvider() => Console.WriteLine("Toiler");
        protected override void Manufacturer() => Console.WriteLine("Foxconn");
        protected override void SalesMarket() => Console.WriteLine("Europe, America, Asia");
    }
}
