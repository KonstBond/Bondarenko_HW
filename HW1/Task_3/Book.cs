using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Book
    {
        private Title title;
        private Content content;
        private Author author;

        public Book()
        {

        }

        public Book(string title, string content, string author)
        {
            this.title = new Title(title);
            this.content = new Content(content);
            this.author = new Author(author);
        }

        public void Show()
        {
            if (title != null)
                title.Show();
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("No title");
            }

            if (content != null)
                content.Show();
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("No content");
            }

            if (author != null)
                author.Show();
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("No author\n");
            }        
            Console.ResetColor();
        }

        public void ReTitle(string title)
        {
            this.title = new Title(title);
        }
        public void ReContent(string content)
        {
            this.content = new Content(content);
        }
        public void ReAuthor(string author)
        {
            this.author = new Author(author);
        }
    }
}
