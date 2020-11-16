using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class BattleArena
    {
        public Player player1;
        public Player player2;
        public MainMenu game = new MainMenu();
        public BattleArena()
        {
            
        }
        public void RunGame()
        {
            game.WelcomeRules();
            int userChoice = game.PlayerChoice();
            if (userChoice == 1)
            {
                Console.WriteLine("What is player one's name?");
                player1 = new HumanPlayer(Console.ReadLine());
                Console.WriteLine("What is player two's name?");
                player2 = new HumanPlayer(Console.ReadLine());
                
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("What is player one's name?");
                player1 = new HumanPlayer(Console.ReadLine());
                player2 = new ComputerPlayer("AlIx");
                
            }
            else
            {
                player1 = new ComputerPlayer("Killer");
                player2 = new ComputerPlayer("Terminator");
            }
            Battle();
            Console.ReadLine();
        }
        public void Battle()
        {

            while(player1.score != player2.score + 2 && player1.score != 5 && player2.score != player1.score + 2 && player2.score != 5)
            {
                player1.ChooseMove();
                System.Threading.Thread.Sleep(500);
                player2.ChooseMove();
                CompareMoves();

            }
            if(player1.score > player2.score)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("WINNER\n"
                    +player1.name +" is unequivically the most ruthless gesturer this side of the boarder.");
                if(game.NewGame())
                {
                    Console.Clear();
                    RunGame();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("GAME OVER");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("WINNER\n" +
                    "I bet "+ player2.name +" could take you with one arm tied behind their back.");
                if (game.NewGame())
                {
                    RunGame();
                }
                else
                {
                    Console.WriteLine("GAME OVER");
                }
            }
        }
        public void CompareMoves()
        {
            if (player1.chosenGesture.name == player2.chosenGesture.name)
            {
                Console.WriteLine("TIE no points!");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please press enter when you are ready for the next round");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
            }
            else if(player1.chosenGesture.enemyTwo != player2.chosenGesture.name && player2.chosenGesture.name != player1.chosenGesture.enemy)
            {
                Console.WriteLine(player1.name +" just destroyed "+player2.name+"-("+player1.name+"-"+(player1.score+1)+")");
                    player1.score++;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please press enter when you are ready for the next round or to see results");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
            }
            else
            {
                Console.WriteLine(player2.name + " could sure teach you a thing or two, "+ player1.name+"-(" +player2.name+ "-"+ (player2.score+1) + ")");
                    player2.score++;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Please press enter when you are ready for the next round or to see results");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
            }
            
            
        }
    }
}
