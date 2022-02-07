using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Author
    {
        public string _name { get; set; }

        public Author()
        {
            this._name = default;
        }

        public Author(string name)
        {
            this._name = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Author: {_name}\n");
            Console.ResetColor();
        }
    }
}
