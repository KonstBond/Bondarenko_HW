using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthOfRectanle, widthOfRectangle;
            Console.Write("Enter length: ");
            if (double.TryParse(Console.ReadLine(), out lengthOfRectanle) )
            {
                Console.Write("Enter width: ");
                if (double.TryParse(Console.ReadLine(), out widthOfRectangle))
                {
                    Rectangle rectangle = new Rectangle(lengthOfRectanle, widthOfRectangle);

                    Console.WriteLine($"\nArea: {rectangle.Area}");
                    Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
                }
                else
                {
                    Console.WriteLine("ERROR: You enter incorrect width");
                }   
            }
            else
            {
                Console.WriteLine("ERROR: You enter incorrect length");
            }  
        }
    }
}
