using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public delegate void FileHandler(string path, string fileName);
    public class FileEvent
    {
        private string _path;
        private string _fileName;
        FileHandler fileHandler;

        public string Name { get; }

        public FileEvent(string path, string filename)
        {
            _path = path;
            _fileName = filename;
            fileHandler = null;
            Name = _fileName;
        }

        public event FileHandler CreateAndWrite = null;
        public event FileHandler OpenAndRead = null;

        public void InvokeCreateAndWrite()
        {
            CreateAndWrite?.Invoke(_path, _fileName);
        }
        public void InvokeOpenAndRead()
        {
            OpenAndRead?.Invoke(_path, _fileName);
        }
    }
}
