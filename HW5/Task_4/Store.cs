using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Store
    {
        private Article[] articles;
        private int count;

        public Store(int CountProduct)
        {
            articles = new Article[CountProduct];
            count = 0;
        }

        public string this[int index]
        {
            get 
            {
                if (index > -1 && index < articles.Length)
                {
                    return articles[index].ArticleInfo();
                }
                return "Index out of range";
            }
        }

        public string this[string index]
        {
            get 
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Product == index)
                    {
                        return articles[i].ArticleInfo();
                    }           
                }
                return "This Article is not found";
            }
        }

        public void AddProduct(string ArticleName, int cost, string store)
        {
            if (count < articles.Length)
            {
                Console.WriteLine("Рroduct added to the store");
                Article NewArticle = new Article(ArticleName,cost,store);
                articles[count] = NewArticle;
                count++;
            }
            else
            {
                Console.WriteLine("Store is full");
            }
        }
    }
}
