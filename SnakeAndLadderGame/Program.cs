using System.Net.NetworkInformation;

namespace SnakeAndLadderGame
{
    class Program
    {
       const int position = 0;
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
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Snake And Ladder Program\n");
            Console.WriteLine("Select a option from list");
            Console.WriteLine("1.UC-1");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\tUC1-Start of Game");
                    Program pro = new Program();
                    pro.StartPlayingPosition();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}