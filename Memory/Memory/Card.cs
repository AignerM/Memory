using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public class Card
    {
        private int id;
        private string path;

        public Card(int id, string path)
        {
            this.id = id;
            this.path = path;
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public Card()
        {
            id = 0;
            path = string.Empty;
        }
    }
}
