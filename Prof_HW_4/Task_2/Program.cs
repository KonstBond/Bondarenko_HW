using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Program
    {
        static void Main()
        {
            Finder finder = new Finder(new FileInfo(@"Example.html"));

            List<string> links = finder.FindLinks();

            foreach (var item in links)
            {
                Console.WriteLine(item);
            }

            List<string> phone = finder.FindTelephone();

            foreach (var item in phone)
            {
                Console.WriteLine(item);
            }

            List<string> mail = finder.FindMail();

            foreach (var item in mail)
            {
                Console.WriteLine(item);
            }
        }
    }
}
