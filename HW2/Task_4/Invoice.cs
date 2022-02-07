using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        private const double NDS = 1.07;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public string Article{ get; set; }
        public int quantity { get; set; }

        public void Cost(bool need_NDS)
        {
            double cost;
            switch (Article)
            {
                case "TV":
                    {
                        cost = 10000;
                        break;
                    }
                case "PC":
                    {
                        cost = 12000;
                        break;
                    }
                case "Laptop":
                    {
                        cost = 9000;
                        break;
                    }
                default:
                    {
                        cost = 0;
                    }
                    break;
            }
            cost *= quantity;
            if (need_NDS)
            {
                cost *= NDS;
            }

            Console.WriteLine($"Account: {account}\n" +
                $"Customer: {customer}\n" +
                $"Provider: {provider}\n" +
                $"Article: {Article}\n" +
                $"Quantity: {quantity}\n" +
                $"Cost: {cost}");
        }
    }
}
