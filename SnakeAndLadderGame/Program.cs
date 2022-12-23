using System.Net.NetworkInformation;

namespace SnakeAndLadderGame
{
    class Program
    {
      public const int position = 0;
        public void StartPlayingPosition()
        {
            //UC1: If Dice Value Is Zero Than You Can Start Game Otherwise Not Using Random
            Random random = new Random();
            int dice = random.Next(0, 2);

            if (dice == 0)
            {
                Console.WriteLine("Ready To Play Dice Value is : {0}", dice);
                Console.WriteLine("Position Is : {0}", position);
            }
            else
            {
                Console.WriteLine("Not Ready To Play Dice Value is {0}", dice);
            }

        } 
        public static void RollsDie()
        {
            // UC2-To Get Value Between 1 To 6 Using Random
            int a =0;
            Random r = new Random();
            a = r.Next(1, 7);           
            Console.WriteLine("Dice Value is :" + a);
            return ;
        }
        public void CheckOption(int position)
        {
            // UC3-To Check for Option like Noplay,Snakke,Laddder
            Console.WriteLine("The postition of player starts From : {0} ", position);
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random r = new Random();
            int dice = r.Next(1, 7);//Random Number Between 1 to 6 Including 6
            int opt = r.Next(1, 3);//Random Number Between 1 to 2 Including 2
            switch (opt)
            {
                case NoPlay:
                    //If Random Number Is 0
                    Console.WriteLine("Stay at Same Place :" + position);
                    break;

                case Ladder:
                    //If Random Number Is 1
                    position += dice;
                    Console.WriteLine("You Move Ahead:" + position + "\t"+"Dice Value is {0}", dice);
                    break;

                case Snake:
                    //If Random Number Is 2
                    position -= dice;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    Console.WriteLine("You move Behind:" + position + "\t" + "Dice Value is {0}", dice);
                    break;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Snake And Ladder Program\n");
            Console.WriteLine("Select a option from list");
            Console.WriteLine("1.UC-1 \n2.UC-2 \n3.UC-3");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\tUC1-Start of Game");
                    Program pro = new Program();
                    pro.StartPlayingPosition();
                    break;
                    case 2:
                    Console.WriteLine("\tUC2-Player rolls a die to get a number between 1 to 6");
                    Program.RollsDie();
                    break;
                case 3:
                    Console.WriteLine("\tUC3-Player checks for a options");
                    Program program = new Program();
                    program.CheckOption(position);
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}