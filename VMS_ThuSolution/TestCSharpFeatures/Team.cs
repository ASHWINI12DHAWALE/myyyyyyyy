using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpFeatures
{
    public class Team
    {
        public List<Player> players = new List<Player>();

        //indexer :-----Smart Array
        public Player this[int index]
        {
            get {
                return players[index];
            }
            set {
               
                 players.Add(value) ;
            }
        }
    }
}
