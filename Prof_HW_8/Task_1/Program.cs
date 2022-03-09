//#define Write
#define Read

using System;
using Newtonsoft.Json;
namespace Task_1
{
    //SOAP-формат не поддерживается в .NET 6.0
    //JSON тоже является не плохим форматом для передачи по сети и использование при совместной работе в интернете
    public class Program
    {
        static void Main()
        {
#if Write
            Game game = new Game("Alex");

            game.Info();
            Console.WriteLine(new String('-', 50));
            game.HardQuest();
            Console.WriteLine(new String('-', 50));
            game.Info();

            string json = JsonConvert.SerializeObject(game, Formatting.Indented);

            FileStream FSwrite = new FileStream(@"." + @"\game.json", FileMode.OpenOrCreate, FileAccess.Write);

            using (var stream = new StreamWriter(FSwrite))
                stream.Write(json);

            FSwrite.Close();
#endif
#if Read
            string JSON = new StreamReader(@"." + @"\game.json").ReadToEnd();
            Game game1 = JsonConvert.DeserializeObject<Game>(JSON)!;
            game1.Info();
#endif
        }
    }
}
