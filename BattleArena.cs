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
        MainMenu game;
        public BattleArena()
        {
            if (game.PlayerChoice() == true)
            {
                player1 = new HumanPlayer(Console.ReadLine());
                player2 = new HumanPlayer(Console.ReadLine());
                Battle();
            }
            else
            {
                player1 = new HumanPlayer(Console.ReadLine());
                player2 = new ComputerPlayer("AlIx");
                Battle();
            }
            
        }
        public void Battle()
        {
            
        }
        public bool Paper()
        {
            if (player1.chosenGesture == player1.chosenGesture.gesture[4])
            {
                Console.WriteLine("Spock has been DISPROVEN");
                return true;
            }
            else if (move.name == rock)
            {
                Console.WriteLine("You really thought a rock could defeat my paper?");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Rock(Move move)
        {
            if (move.name == scissors)
            {
                Console.WriteLine("Only diamond can cut diamond!!");
                return true;
            }
            else if (move.name == lizard)
            {
                Console.WriteLine("Your lizard was no match for me.");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Scissors(Move move)
        {
            if (move.name == paper)
            {
                Console.WriteLine("One scissor to rule them all");
                return true;
            }
            else if (move.name == spock)
            {
                Console.WriteLine("Sir I'm going to need to see some ID.");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Lizard(Move move)
        {
            if (move.name == spock)
            {
                Console.WriteLine("HISS");
                return true;
            }
            else if (move.name == paper)
            {
                Console.WriteLine("hisssss");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Spock(Move move)
        {
            if (move.name == scissors)
            {
                Console.WriteLine("My Vulcan skin is no match for your earthly weapons");
                return true;
            }
            else if (move.name == rock)
            {
                Console.WriteLine("Was that supposed to hurt me, human?");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
