using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class AbstractHandler
    {
        protected string file;

        public AbstractHandler(string fileName) { file = fileName; }

        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }
}
