namespace TestLibrary
{
    public class TestClassPublic
    {
        public static string statField;
        public string Field = null;
        private static string statPrField;
        private string PrField = null;

        private event EventHandler PrEvent;
        public event EventHandler Event;
        private static event EventHandler StatPrEvent;

        static TestClassPublic() { }

        private TestClassPublic() { }

        public TestClassPublic(string TestField) { }

        private string PrProperty { get; set; }
        public int Property { get; set; }

        private void PrMethod() { }
        internal void InterMethod() { }
        public void Method() { }
    }
}