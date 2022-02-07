using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Article
    {
        private int cost;
        private string store;

        public int Cost { get { return cost; } set { cost = value > 0 ? value : 100; } }
        public string Product { get; private set; }

        public Article(string product, int cost, string store)
        {
            Cost = cost;
            Product = product;
            this.store = store;
        }

        public string ArticleInfo()
        {
            return $"Product: {Product}, Cost: {cost}, Store: {store}";
        }
    }
}
