using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class DirectorysCreateDelete
    {
        public static void CreateDirectory(string path)
        {
            DirectoryInfo DI = new DirectoryInfo(path);

            if (Directory.Exists(path))
            {
                for (int i = 0; i < 100; i++)
                {
                    DI.CreateSubdirectory(path + $@"Directory_{i}");
                }
            }
            else
                throw new ArgumentException("Directory not exist");
        }

        public static void DeleteDirectory(string path)
        {
            DirectoryInfo DI = new DirectoryInfo(path);

            if (Directory.Exists(path))
            {
                for (int i = 0; i < 100; i++)
                {
                    Directory.Delete(path + $@"Directory_{i}");
                }
            }
            else
                throw new ArgumentException("Directory not exist");
        }
    }
}
