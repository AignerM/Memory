using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Highscore
    {
        private int hTime =0, hTrys =0;
        private string hName=string.Empty;

        public Highscore(string name, int time, int trys)
        {
            this.hName = name;
            this.hTime = time;
            this.hTrys = trys;
        }

        public int HTime
        {
            get { return hTime; }
            set { hTime = value; }
        }

        public int HTrys
        {
            get { return hTrys; }
            set { hTrys = value; }
        }

        public string HName
        {
            get { return hName; }
            set { hName = value; }
        }
    }
}
