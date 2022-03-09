using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Task_3
{
    public class Program
    {
        static void Main()
        {
            string RootD = @"D:\";
            
            DirectoryInfo directoryRoot = new DriveInfo(RootD).RootDirectory;
            FileInfo file = Finder.RecursFind(directoryRoot, "text.txt");
            
            using FileStream FS = new FileStream(file.FullName,FileMode.OpenOrCreate);
            {
                for (int i = 0; i < FS.Length; i++)
                {
                    Console.Write((char)FS.ReadByte());
                }          
            }

            FileStream destination = File.Create(RootD + @"archive.rar");
            GZipStream gZip = new GZipStream(destination, CompressionMode.Compress);

            int fileByte = FS.ReadByte();

            while (fileByte != -1)
            {
                gZip.WriteByte((byte)fileByte);
                fileByte = FS.ReadByte();
            }
            gZip.Close();
        }
    }
}
