using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Game
    {
        private Player player;
        private TimeSpan totaltime;

        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        private void AddPlayer(string name)
        {
            player = new Player(name);
        }
    }
}
