using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Title
    {
        public string _title { get; set; }

        public Title()
        {
            this._title = default;
        }

        public Title(string title)
        {
            this._title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (_title == default)
            {
                Console.WriteLine("No Title");
            }
            else
            {
                Console.WriteLine($"Title: {_title}");
            }
            Console.ResetColor();
        }
    }
}
