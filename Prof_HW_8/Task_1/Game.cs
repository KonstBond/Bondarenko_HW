using System;
using Newtonsoft.Json;
namespace Task_1
{
    public class Game
    {
        [JsonProperty(PropertyName = "HeroName")]
        private readonly string _heroName;
        [JsonProperty(PropertyName = "HP")]
        private int _HP;
        [JsonProperty(PropertyName = "MP")]
        private int _MP;
        [JsonProperty(PropertyName = "Level")]
        private int _level;
        [JsonProperty(PropertyName = "Coins")]
        private int _coins;
        private bool life;

        public Game(string Name)
        {
            _heroName = Name;
            _HP = 20;
            _MP = 10;
            _level = 1;
            _coins = 100;
            life = true;

        }
        public void Info()
        {
            Console.WriteLine($"Name: {_heroName}\n" +
                $"Status {(life ? "Live" : "Dead")}\n" +
                $"Level: {_level}\n" +
                $"Health: {_HP}\n" +
                $"Mana: {_MP}\n" +
                $"Money: {_coins}");
        }
        public void LevelUp()
        {
            if (life)
            {
                if (_coins >= 1000)
                {
                    _coins -= 1000;
                    _level++;
                    _HP += 10;
                    _MP += 10;
                    Console.WriteLine("I got the next level");
                }
                else
                    Console.WriteLine($"I need {1000 - _coins} more coins ");
            }
            else
                Console.WriteLine("Your hero is dead");
        }
        public void EasyQuest()
        {
            if (life)
            {
                if (_HP > 3 && _MP > 2)
                {
                    _HP -= new Random().Next(5);
                    _MP -= new Random().Next(3);
                    if (aLeave(this))
                    {
                        Console.WriteLine("I did this quest ");
                        _coins += 150;
                    }
                }
                else
                    Console.WriteLine("I'am so tired, I need some sleep");
            }
            else
                Console.WriteLine("Your hero is dead");
        }
        public void HardQuest()
        {
            if (life)
            {
                if (_HP > 6 && _MP > 4)
                {
                    _HP -= new Random().Next(10);
                    _MP -= new Random().Next(5);
                    if (aLeave(this))
                    {
                        Console.WriteLine("I did this quest ");
                        _coins += 400;
                    }
                    
                }
                else
                    Console.WriteLine("I'am so tired, I need some sleep");
            }
            else
                Console.WriteLine("Your hero is dead");
        }
        private static bool aLeave(Game game)
        {
            if (game._HP <= 0)
            {
                game.life = false;
                game._HP = game._MP = 0;
                Console.WriteLine("Aghhh... i am... dead");
                return false;
            }
            else
                return true;
        }
        public void Rest()
        {
            if (life)
            {
                Console.WriteLine("zzz...ZZZ...zzz");
                _HP += new Random().Next(5);
                _MP += new Random().Next(3);
                if (_HP > (_level+1)*10)
                    _HP = (_level+1)*10;
                if (_MP > (_level*10))
                    _MP = (_level*10);
            }
        }
    }
}
