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


        public Move(string name, string enemy, string enemyTwo)
        {
            this.name = name;
            this.enemy = enemy;
            this.enemyTwo = enemyTwo;
        }         
    }
}