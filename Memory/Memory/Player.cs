using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Player
    {
        private int score;
        private string name;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Player(string name)
        {
            score = 0;
            this.name = name;
        }
    }
}
