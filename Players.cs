using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Players
    {
        public string name;
        public string type;
        public string rock;
        public string paper;
        public string scissors;
        public string lizard;
        public string spock;
        public List<string> move;

        public Players(string name, string type)
        {
            this.name = name;
            this.type = type;
            move = new List<string>();
            move.Add(rock);
            move.Add(paper);
            move.Add(scissors);
            move.Add(lizard);
            move.Add(spock);
        }
    }
}
