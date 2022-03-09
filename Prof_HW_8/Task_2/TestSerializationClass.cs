#define Auto
//#define Attr

using System;
using System.Xml.Serialization;

namespace Task_2
{
    [XmlRoot("RootNode")]
    public class TestSerializationClass
    {
        private int FirstField;
        private int IgnoreField;
        private string _stringField;

        public TestSerializationClass()
        {
            FirstField = 1;
            IgnoreField = 2;
            _stringField = "abc";
        }

#if Auto
        public int Property
        {
            get { return FirstField; }
            set { FirstField = value; }
        }
        public int MyProperty
        {
            get { return IgnoreField; }
            set { IgnoreField = value; }
        }
        public string MyPropertyStr
        {
            get { return _stringField; }
            set { _stringField = value; }
        }
#endif

#if Attr
        
        [XmlAttribute("IntegerAttr")]
        public int Property
        {
            get { return FirstField; }
            set { FirstField = value; }
        }
        [XmlIgnore]
        public int MyProperty
        {
            get { return IgnoreField; }
            set { IgnoreField = value; }
        }
        [XmlAttribute("StringAttr")]
        public string MyPropertyStr
        {
            get { return _stringField; }
            set { _stringField = value; }
        }
#endif

        public override string ToString()
        {
            return $"{this.FirstField + "\t" + this._stringField + "\t" + this.IgnoreField}";
        }

    }
}
