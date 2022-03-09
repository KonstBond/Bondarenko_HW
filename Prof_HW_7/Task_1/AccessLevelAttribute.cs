using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple =false)]
    public class AccessLevelAttribute : Attribute
    {
        private Level _level;
        public Level Level { get { return _level; } }
        public AccessLevelAttribute(Level level)
        {
            _level = level;
        }
        
    }
}
