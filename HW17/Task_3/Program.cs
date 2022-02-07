using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<dynamic, dynamic> EngRu = new Dictionary<dynamic, dynamic>();

            EngRu.Add("other", "другой");
            EngRu.Add("were", "были");
            EngRu.Add("time", "время");
            EngRu.Add("each", "каждый");
            EngRu.Add("small", "маленький");
            EngRu.Add("end", "конец");
            EngRu.Add("follow", "другой");
            EngRu.Add("men", "люди");
            EngRu.Add("name", "имя");
            EngRu.Add("differ", "отличаться");

            foreach (var item in EngRu)
            {
                Console.WriteLine($"{item.Key} \t {item.Value}");
            }
        }
    }
}
