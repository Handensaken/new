using System;
using System.Collections.Generic;
using System.IO;
namespace Slutprojekt
{
    class Program
    {
        private static Random rand = new Random();
        enum Rooms
        {
            Start,
            Train,
            Battle,
            Shop,
            Quit
        }
        static void Main(string[] args)
        {
            string[] choices = new string[2];
            bool playing = true;
            Rooms room = Rooms.Start;
            Instructions();
            Player player = new Player();
            ChooseStarter(player);

            System.Console.WriteLine("you chose " + player.children[0].Name);
            Console.ReadLine();

            while (playing)
            {
                UpdateRoomArrays(room, choices);


            }


        }
        static string[] UpdateRoomArrays(Rooms g, string[] s)
        {
            switch (g)
            {
                case Rooms.Start:
                    {
                        s = new string[4];
                        s[0] = "Train";
                        s[1] = "Battle";
                        s[2] = "Shop";
                        s[3] = "Quit";
                        return s;
                    }
                case Rooms.Train:
                    {
                        s = new string[2];
                        s[0] = "Start";
                        s[1] = "Shop";
                        return s;
                    }
                case Rooms.Shop:
                    {
                        s = new string[3];
                        s[0] = "Start";
                        s[1] = "Shop";
                        s[2] = "Battle";
                        return s;
                    }
                case Rooms.Battle:
                    {
                        s = new string[2];
                        s[0] = "Start";
                        s[1] = "Shop";
                        return s;
                    }
                case Rooms.Quit:
                    {
                        s = new string[2];
                        s[0] = "Start";
                        return s;
                    }
                default:
                    {
                        System.Console.WriteLine("something is written wrong fool");
                        return s;
                    }
            }
        }
        static Rooms SelectRoom(string[] s, Rooms r)
        {
            if (r == Rooms.Start)
            {
                switch (Selection(s))
                {
                    case 0:
                        {
                            return Rooms.Train;
                        }
                    case 1:
                        {

                            return Rooms.Battle;
                        }
                    case 2:
                        {

                            return Rooms.Shop;
                        }
                    case 3:
                        {

                            return Rooms.Quit;
                        }
                    default:
                        {
                            return Rooms.Start;
                        }
                }
            }
            else if (r == Rooms.Train)
            {
                switch (Selection(s))
                {
                    case 0:
                        {
                            return Rooms.Start;
                        }
                    case 1:
                        {
                            return Rooms.Shop;
                        }
                    default:
                        {
                            return Rooms.Train;
                        }
                }
            }
            else if (r == Rooms.Shop)
            {
                switch (Selection(s))
                {
                    case 0:
                        {
                            return Rooms.Start;
                        }
                    case 1:
                        {
                            return Rooms.Shop;
                        }
                    case 2:
                        {
                            return Rooms.Battle;
                        }
                    default:
                        {
                            return Rooms.Shop;
                        }
                }
            }
            else if (r == Rooms.Battle)
            {
                switch (Selection(s))
                {
                    case 0:
                        {
                            return Rooms.Start;
                        }
                    case 1:
                        {
                            return Rooms.Shop;
                        }
                    default:
                        {
                            return Rooms.Battle;
                        }
                }
            }
            else if (r == Rooms.Quit)
            {
                switch (Selection(s))
                {
                    case 0:
                        {
                            return Rooms.Start;
                        }
                    default:
                        {
                            return Rooms.Quit;
                        }
                }
            }
            else
            {
                System.Console.WriteLine("Overlode run. Room is now Start");
                return Rooms.Start;
            }
        }
        static void Instructions()
        {
            System.Console.WriteLine("In this game you will navigate entirely by selecting an option presented in the form of a multi-choice page.");
            System.Console.WriteLine("To navigate this page you may use the up and down arrows on your keyboard. With enter you select the currently hovered option. Any other keys will do nothing.");
            System.Console.WriteLine("To close this page press enter. Any other button will write text that does not affect the game in nay way.");
            Console.ReadLine();
            Console.Clear();
        }
        static void ChooseStarter(Player p)
        {
            System.Console.WriteLine("Before  you can begin you adventure och weaponizing young children for your own profit and entertainment you must choose a starting child.");
            System.Console.WriteLine("You will be presented with 3 choices. Press enter to continue");
            Console.ReadLine();
            Child[] starterChildren = new Child[3];
            string[] choices = new string[3];
            for (int i = 0; i < starterChildren.Length; i++)
            {
                starterChildren[i] = ChildSpawner.SpawnChild();
                starterChildren[i].Age = 2;
                starterChildren[i].Name = File.ReadAllLines(@"names.txt")[rand.Next(100)];
                choices[i] = $"Name: {starterChildren[i].Name} Age: {starterChildren[i].Age}";
            }
            p.children.Add(starterChildren[Selection(choices)]);
        }










        //you know the usual shebang
        static void PrintChoices(string[] choices, int current)
        {
            for (int i = 0; i < choices.Length; i++)
            {
                if (current == i)
                {
                    System.Console.WriteLine($">  {choices[i]}");
                }
                else
                {
                    System.Console.WriteLine($"  {choices[i]} ");
                }
            }
        }
        static int Selection(string[] choices)
        {
            int current = 0;
            while (true)
            {
                Console.Clear();
                PrintChoices(choices, current);
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        {
                            current++;
                            current = current % choices.Length;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        {
                            current--;
                            if (current < 0) { current = choices.Length - 1; }
                            else
                            {
                                current = Math.Abs(current % choices.Length);
                            }
                        }
                        break;
                    case ConsoleKey.Enter:
                        {
                            return current;
                        }
                    default:
                        {
                            // handle everything else
                        }
                        break;
                }
            }
        }
    }
}
