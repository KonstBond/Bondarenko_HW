using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Program
    {
        public static void Main()
        {

            FileEvent file = new FileEvent(@"D:\", "tex.txt");
            file.OpenAndRead += FileCreateOpen.OpenAndRead;
            file.CreateAndWrite += FileCreateOpen.CreateAndWrite;


            Console.WriteLine($"File: {file.Name}\n");

            Console.WriteLine("If you want create file, Enter \"Create\"" +
                "\nIf you want read file, Enter \"Read\"\n");

            string check = Console.ReadLine();

            if (check == "Create")
            {
                file.InvokeCreateAndWrite();
            }
            else if (check == "Read")
            {
                file.InvokeOpenAndRead();
            }
            else
            {
                Console.WriteLine("Invalid command");
            }
        }

    }
}
