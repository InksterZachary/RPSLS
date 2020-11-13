using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Move
    {
        public string name;
        public string enemy;
        public string enemyTwo;
        //public List<Move> gesture;
        //public Move rock;
        //public Move paper;
        //public Move scissors;
        //public Move lizard;
        //public Move spock;
        public Move(string name, string enemy, string enemyTwo)
        {
            this.name = name;
            this.enemy = enemy;
            this.enemyTwo = enemyTwo;
        }
       //public void LearnGestures()
       // {
            //gesture = new List<Move>();
            //rock = new Move("rock", "paper", "spock");
            //paper = new Move("paper", "scissors", "lizard");
            //scissors = new Move("scissors", "spock", "rock");
            //lizard = new Move("lizard", "scissors", "rock");
            //spock = new Move("spock", "lizard", "paper");
            //gesture.Add(rock);
           // gesture.Add(paper);
            //gesture.Add(scissors);
            //gesture.Add(lizard);
            //gesture.Add(spock);
        //}
            
    }
}