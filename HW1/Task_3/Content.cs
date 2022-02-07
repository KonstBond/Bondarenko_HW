using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Content
    {
        public string _content { get; set; }

        public Content()
        {
            this._content = default;
        }

        public Content(string content)
        {
            this._content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (_content == default)
            {
                Console.WriteLine("No content");
            }
            else
            {
                Console.WriteLine($"Content: {_content}");
            }
            Console.ResetColor();
        }
    }
}
