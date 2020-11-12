using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Moves
    {
        public string defeats;
        public List<Moves> attackMethod;

        public Moves(string defeats)
        {
            this.defeats = defeats;
            attackMethod = new List<Moves>();
        }

       
    }
}
