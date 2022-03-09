using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public static class Finder
    {
        //finded всегда должен быть false
        public static FileInfo RecursFind(DirectoryInfo directory, string fileName)
        {
            DirectoryInfo[] subDirs = directory.GetDirectories();

            for (int i = 0; i < subDirs.Count(); i++)
            {
                if (subDirs[i].Attributes == FileAttributes.Directory)
                {
                    FileInfo file = RecursFind(subDirs[i], fileName);

                    if (!(file is null))
                        return file;
                }
                else
                    continue;          
            }

            FileInfo[] files = directory.GetFiles();

            for (int j = 0; j < files.Count(); j++)
            {
                if (files[j].Name == fileName)
                    return files[j];
            }
            return null;
        }
    }
}
