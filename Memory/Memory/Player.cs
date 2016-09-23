using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Player
    {
        public int time, trys;
        public string name;

        
        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Trys
        {
            get { return trys; }
            set { trys = value; }
        }

        public Player(string name, int time, int trys)
        {
            this.time = time;
            this.trys = trys;
            this.name = name;
        }
    }
}
