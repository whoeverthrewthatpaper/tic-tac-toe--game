using System;


namespace tic_tac_toe__game
{
    class Program
    {
        static int turns = 9;
        static int choice; // position choice
       
        static char[] section = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static void Main(string[] args)
        {


            int player = 1;
            
             do
            {
                Console.Clear();

                Console.WriteLine("player 1 : x and plaer2: o");
                Console.WriteLine("\n");
                turns--;

              // who gets to play 
                if (player % 2 == 0)
                {
                    Console.WriteLine("player 2 chance");

                }
                else
                {
                    Console.WriteLine("player 1 chance ");
                }
                Console.Write("\n");

                gameBoard();

                choice = int.Parse(Console.ReadLine());


                if (section[choice] != 'x' && section[choice] != 'o')
                {
                    if (player % 2 == 0)
                    {
                        section[choice] = '0';

                        player++;
                    }
                    else
                    {
                        section[choice] = 'x';
                        player++;
                    }
                }

                else
                {// in case of illigal moves 
                    Console.WriteLine("sorry the row {0} is already marked with {1} ", choice, section[choice]); 
                    Console.WriteLine("\n");
                    Console.WriteLine("please wait ");

                }


                if (turns == 0)
                {
                   
                    Console.WriteLine("GAME OVER!");
                    break;
                }


            } while (turns>0);



            Console.WriteLine();
            Console.ReadLine();
        }
        private static void gameBoard()
        {


                Console.WriteLine(" {0} | {1} | {2} ", section[1], section[2], section[3]);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" {0} | {1} | {2} ", section[4], section[5], section[6]);
                Console.WriteLine("---+---+---");
                Console.WriteLine(" {0} | {1} | {2} ", section[7], section[8], section[9]);
        }
    }
}
