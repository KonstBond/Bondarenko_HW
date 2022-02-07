using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Accountant Jack = new Accountant();

            if (Jack.AskForBonus(Post.Admin, 83))
            {
                Console.WriteLine("Give Bonus");
            }
            else
            {
                Console.WriteLine("Without Bonus");
            }
            
        }
    }
}
