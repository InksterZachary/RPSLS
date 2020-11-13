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
                player1 = new HumanPlayer(Console.ReadLine());
                player2 = new HumanPlayer(Console.ReadLine());
                BattlePVP();
            }
            else
            {
                player1 = new HumanPlayer(Console.ReadLine());
                player2 = new ComputerPlayer("AlIx");
                BattleComputer();
            }
        }
        public void BattlePVP()
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
        
        public void BattleComputer()
        {
            while (player1.score != player2.score + 2 && player1.score != 3 && player2.score != player1.score + 2 && player2.score != 3)
            {
                player1.ChooseMove();
                player2.ChooseMove();
                CompareMoves();
            }
            if (player1.score > player2.score)
            {
                Console.WriteLine(player1.name + " is unequivically the most ruthless gesturer this side of town.");
            }
            else
            {
                Console.WriteLine("I bet " + player2.name + " could take you with one arm tied behind their back.");
            }
        }
        public void CompareMoves()
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("TIE no points!");
            }
            for (int i = 0; i < player1.gesture.Count; i++)
            {
              if(player1.gesture[i].name != player2.gesture[i].enemy && player1.gesture[i].name != player2.gesture[i].enemyTwo)
                {
                    player1.score++;
                }
                else
                {
                    player2.score++;
                }
            }
            
        }
    }
}
