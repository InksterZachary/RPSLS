﻿using System;
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
        public List<Move> gesture;
        public Move rock;
        public Move paper;
        public Move scissors;
        public Move lizard;
        public Move spock;
        public Move(string name)
        {
            this.name = name;
            gesture = new List<Move>();
            gesture.Add(rock);
            gesture.Add(paper);
            gesture.Add(scissors);
            gesture.Add(lizard);
            gesture.Add(spock); 
        }

       
            
    }
}