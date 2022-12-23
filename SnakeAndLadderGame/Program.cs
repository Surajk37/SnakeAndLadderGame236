using System.Net.NetworkInformation;

namespace SnakeAndLadderGame
{
    class Program
    {
        const int position = 0;
        public static void StartPlayingPosition(int position)
        {
            //UC4- Repeat till the Player reaches the winning position 100.

            int currentpos = 0, startpos = 0;
            const int Won = 100;
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random r = new Random();
            //Loop Will Execute Till 100 Position
            while (position < Won)
            {
                int ran = r.Next(1, 7);
                int opt = r.Next(0, 3);
                switch (opt)
                {
                    case NoPlay:
                        //If Random Number Is 0
                        Console.WriteLine("You Got No Play");
                        Console.WriteLine("--------------------------");
                        break;

                    case Ladder:
                        //If Random Number Is 1
                        position = currentpos;
                        if (position < Won)
                        {
                            currentpos += ran;
                            Console.WriteLine("Player Climbed Ladder By:" + ran);
                            if (currentpos > Won)
                            {
                                currentpos = position;
                            }
                        }
                        break;

                    case Snake:
                        //If Random Number Is 2
                        if (currentpos > 0)
                        {
                            Console.WriteLine("Player Is Bitten By Snake By:" + ran);
                            currentpos -= ran;
                        }
                        else if (currentpos <= 0)
                        {
                            currentpos = startpos;
                            currentpos = position;
                        }
                        break;
                }
            }
            Console.WriteLine("You're at Final Position Is:" + position);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Snake And Ladder Program\n");
            Program.StartPlayingPosition(position);
            Console.ReadLine();
        }
    }
}