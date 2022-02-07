using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    abstract class PartOfDoc
    {
        public abstract void Show();
        public abstract string Content { get; set; }
        protected string content;
    }
}
