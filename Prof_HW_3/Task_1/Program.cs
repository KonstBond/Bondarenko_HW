using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Task_1
{

    public class Program
    {
        //Я через события сделал чисто для себя :)
        static void Main()
        {
            EventDir eventDir = new EventDir(@".");

            eventDir.EventCreate += DirectorysCreateDelete.CreateDirectory;
            eventDir.EventDelete += DirectorysCreateDelete.DeleteDirectory;

            eventDir.Start();
        }
    }
}
