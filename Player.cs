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
        public Move chosenGesture;

        public Player(string name)
        {
            this.name = name;
        }
        public abstract void ChooseMove();
    }
}
