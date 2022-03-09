using System;
using System.Collections;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            CustomerOrder customerOrder = new CustomerOrder();

            customerOrder.Add("Konstantin","Telephone");
            customerOrder.Add("Jack", "TV");
            customerOrder.Add("Konstantin", "Laptop");
            customerOrder.Add("Mickle", "Telephone");
            customerOrder.Add("Mickle", "Mouse");
            customerOrder.Add("Vlad", "Keyboard");
            customerOrder.Add("Konstantin", "Keyboard");

            foreach (var item in customerOrder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', Console.BufferWidth));

            Array allOrders = customerOrder.ReturnOrdersOfCustomers("Konstantin");
            foreach (var item in allOrders)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', Console.BufferWidth));

            customerOrder.Remove("Vlad");

            Array allCustomers = customerOrder.ReturnCustomersOfOrder("Keyboard");
            foreach (var item in allCustomers)
            {
                Console.WriteLine(item);
            }

           
            
        }
    }
}