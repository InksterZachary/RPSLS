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
            if (game.PlayerChoice())
            {
                Console.WriteLine("What is player one's name?");
                player1 = new HumanPlayer(Console.ReadLine());
                Console.WriteLine("What is player two's name?");
                player2 = new HumanPlayer(Console.ReadLine());
                
            }
            else
            {
                Console.WriteLine("What is player one's name?");
                player1 = new HumanPlayer(Console.ReadLine());
                player2 = new ComputerPlayer("AlIx");
                
            }
            Battle();
            Console.ReadLine();
        }
        public void Battle()
        {

            while(player1.score != player2.score + 2 && player1.score != 3 && player2.score != player1.score + 2 && player2.score != 3)
            {
                player1.ChooseMove();
                player2.ChooseMove();
                CompareMoves();

            }
            if(player1.score > player2.score)
            {
                Console.WriteLine(player1.name +" is unequivically the most ruthless gesturer this side of the boarder.");
            }
            else
            {
                Console.WriteLine("I bet "+ player2.name +" could take you with one arm tied behind their back.");
            }
        }
        public void CompareMoves()
        {
            if (player1.chosenGesture == player2.chosenGesture)
            {
                Console.WriteLine("TIE no points!");
            }
            else if(player1.chosenGesture.enemyTwo != player2.chosenGesture.name && player2.chosenGesture.name != player1.chosenGesture.enemy)
            {
                Console.WriteLine(player1.name +" just destroyed "+player2.name);
                    player1.score++;
            }
            else
            {
                Console.WriteLine(player2.name + "could sure teach you a thing or two, "+ player1.name);
                    player2.score++;
            }
            
            
        }
    }
}
