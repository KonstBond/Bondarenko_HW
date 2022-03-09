using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public delegate void DirectorysCreateDeleteHandler(string path);

    public class EventDir
    {
        public event DirectorysCreateDeleteHandler EventCreate = null;
        public event DirectorysCreateDeleteHandler EventDelete = null;

        private string _path;
        public EventDir(string path)
        {
            _path = path;
        }

        public void InvokeCreate()
        {
            EventCreate?.Invoke(_path);
        }

        public void InvokeDelete()
        {
            EventDelete?.Invoke(_path);
        }
        public void Start()
        {
            bool flag;
            if (Directory.Exists(@"." + @"Directory_0"))
                flag = true;
            else
                flag = false;


            Console.WriteLine("Enter \"Create\" if you want to create directory" +
                "\nEnter \"Delte\" if you want to delete directory");

            while (true)
            {
                string keys = Console.ReadLine();

                if (flag && keys == "Delete")
                {
                    flag = false;
                    InvokeDelete();
                    Console.WriteLine("Directorys was Deleted");
                }    
                else if (!flag && keys == "Create")
                {
                    flag = true;
                    InvokeCreate();
                    Console.WriteLine("Directorys was Create");
                }
                else if (!flag && keys == "Delete")
                    Console.WriteLine("Directory has been Deleted");
                else
                    Console.WriteLine("Directory has been Created");

            }
        }
    }
}
