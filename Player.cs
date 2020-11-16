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
        //public Move rock;
        //public Move paper;
        //public Move scissors;
       // public Move lizard;
        //public Move spock;

        public Player(string name)
        {
            this.name = name;
            gestures = new List<Move>();
            Move rock = new Move("rock", "paper", "spock");
            Move paper = new Move("paper", "scissors", "lizard");
            Move scissors = new Move("scissors", "spock", "rock");
            Move lizard = new Move("lizard", "scissors", "rock");
            Move spock = new Move("spock", "lizard", "paper");
            gestures.Add(new Move("rock", "paper", "spock"));
            gestures.Add(paper);
            gestures.Add(scissors);
            gestures.Add(lizard);
            gestures.Add(spock);
        }
        public abstract void ChooseMove();
    }
}
