using System.Drawing;

namespace Memory
{
    public class Card
    {
        private int id;
        private Bitmap img;
        private int pos;

        public Card(int id, Bitmap source, int pos)
        {
            this.id = id;
            this.img = source;
            this.pos = pos;
        }

        public int Pos
        {
            get { return pos; }
            set { pos = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Bitmap Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
