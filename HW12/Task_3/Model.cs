using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Threading;

namespace Task_3
{
    class Model
    {
        const int tenSec = 100000000;
        const int OneSec = 1000;
        private TimeSpan time;

        public Model()
        {
            time = new TimeSpan(0);
        }

        public string ValueUp()
        {
            if ((time.TotalSeconds + 10) < 3600)
            {
                time = time.Add(new TimeSpan(tenSec));
            }
            return time.ToString(@"mm\:ss\:ff");
        }

        public string ValueDown()
        {
            if ((time.TotalSeconds-10) > 0)
            {
                time = time.Add(new TimeSpan(-tenSec));
            }
            return time.ToString(@"mm\:ss\:ff");
        }

        public string RUN()
        {
            time = time.Add(new TimeSpan(-OneSec));
            return time.ToString(@"mm\:ss\:ff");
        }
    }
}
