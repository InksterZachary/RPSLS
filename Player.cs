using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public string name;
        public int score;
        public Move chosenGesture;
        public List<Move> gestures;

        public Player(string name)
        {
            this.name = name;
            gestures = new List<Move>();
            gestures.Add(new Move("rock", "paper", "spock"));
            gestures.Add(new Move("paper","scissors","lizard"));
            gestures.Add(new Move("scissors","spock","rock"));
            gestures.Add(new Move("lizard", "scissors","rock"));
            gestures.Add(new Move("spock", "lizard", "paper"));
        }
        public abstract void ChooseMove();
    }
}
