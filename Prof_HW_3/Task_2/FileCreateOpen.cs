using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class FileCreateOpen
    {
        public static void CreateAndWrite(string path, string name)
        {
            if (!File.Exists(path + name))
            {
                Console.WriteLine($"File {name} has been created, write your data:");
                FileInfo file = new FileInfo(path + @"\" + name);

                using (StreamWriter SW = new StreamWriter(file.FullName, false, Encoding.ASCII))
                {
                    SW.Write(Console.ReadLine());
                }

                Console.WriteLine($"File {name} has been closed, your data saved");
            }
            else
                throw new FileLoadException("File with the same name already exists");
        }

        public static void OpenAndRead(string path, string name)
        {
            if (File.Exists(path + name))
            {
                Console.WriteLine($"File {name} has been opened:");
                FileInfo file = new FileInfo(path + @"\" + name);

                using (StreamReader SW = new StreamReader(file.FullName, Encoding.ASCII))
                {
                    Console.WriteLine(SW.ReadToEnd());
                }
            }
            else
                throw new FileLoadException("File with the same name no exists");
        }

    }
}
