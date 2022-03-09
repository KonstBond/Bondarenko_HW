using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class CustomerOrder : IEnumerable
    {
        private NameValueCollection _CustomerOrder;

        public CustomerOrder()
        {
            _CustomerOrder = new NameValueCollection();
        }

        public void Add(string Customer, string Order)
        {
            if (Customer is not string || Order is not string)
                throw new ArgumentException("Some arguments is not string");
            else
                _CustomerOrder.Add(Customer, Order);
        }

        public IEnumerator GetEnumerator()
        {
            return _CustomerOrder.GetEnumerator();
        }

        public void Remove(string Customer)
        {
            if (_CustomerOrder is not null && Customer is string)
                _CustomerOrder.Remove(Customer);
        }

        public Array ReturnCustomersOfOrder(string Order)
        {
            if (Order is not string)
                throw new ArgumentException("Some arguments is not string");

            List<string> allCustomers = new List<string>();

            for (int i = 0; i < _CustomerOrder.Count; i++)
            {
                if (_CustomerOrder.Get(i).Contains(Order))
                    allCustomers.Add(_CustomerOrder.GetKey(i));
            }
            return allCustomers.ToArray();
        }

        public Array ReturnOrdersOfCustomers(string Customer)
        {
            if (Customer is not string)
                throw new ArgumentException("Some arguments is not string");

            Array allOrders = _CustomerOrder.GetValues(Customer);

            if (allOrders == null)
                throw new ArgumentException($"{Customer} is not found");

            return allOrders;
        }
    }
}
