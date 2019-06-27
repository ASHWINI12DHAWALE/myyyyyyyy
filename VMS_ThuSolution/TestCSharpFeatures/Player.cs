using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpFeatures
{
   public  class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Runs { get; set; }

        public override string ToString()
        {
            string str = string.Format("{0}, {1}, {2}", this.ID, this.Name, this.Runs);
            return str;
        }
    }
}
