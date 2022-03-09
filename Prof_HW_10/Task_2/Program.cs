using System;

namespace Task_2
{
    public class Program
    {
        public static void Main()
        {
            AbstractPhone phone = new IPhone();
            AbstractPhone anotherPhone = new SAMSUNG();
            phone.Phone();
            anotherPhone.Phone();
        }
    }
}
