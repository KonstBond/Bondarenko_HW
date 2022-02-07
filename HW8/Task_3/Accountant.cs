using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            return false;
        }
    }
}
