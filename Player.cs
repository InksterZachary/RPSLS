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
        public List<Move> gesture;
        public Move rock;
        public Move paper;
        public Move scissors;
        public Move lizard;
        public Move spock;

        public Player(string name)
        {
            this.name = name;
            gesture = new List<Move>();
            rock = new Move("rock", "paper", "spock");
            paper = new Move("paper", "scissors", "lizard");
            scissors = new Move("scissors", "spock", "rock");
            lizard = new Move("lizard", "scissors", "rock");
            spock = new Move("spock", "lizard", "paper");
            gesture.Add(rock);
            gesture.Add(paper);
            gesture.Add(scissors);
            gesture.Add(lizard);
            gesture.Add(spock);
        }
        public abstract void ChooseMove();
    }
}
