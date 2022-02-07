using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    struct Notebook
    {
        private string model;
        private string producer;
        private int price;
        
        public Notebook(string model, string producer, int price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }

        public void Info()
        {
            Console.Write($"Notebook: {model}, Producer: {producer}, Price: {price}");
        }
    }
}
