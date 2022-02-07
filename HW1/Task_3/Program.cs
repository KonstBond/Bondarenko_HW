using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookMain = new Book("Dragonlance: dragons of autumn twilight","Fantazy book", "Margaret Weis, Tracy Hickman");
            bookMain.Show();

            bookMain.ReTitle("My path to programmer life");
            bookMain.ReContent("Very interesting content");
            bookMain.ReAuthor("Konstantin Bondarenko");
            bookMain.Show();

            Book book = new Book();
            book.Show();

            book.ReContent("Its book without Title and Author");
            book.Show();
        }
    }
}
