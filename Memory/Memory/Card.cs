using System.Drawing;

namespace Memory
{
    public class Card
    {

        public Card(int id, Bitmap source, int pos)
        {
            this.Id = id;
            this.Img = source;
            this.Pos = pos;
        }

        public int Pos { get; set; }

        public int Id { get; set; }

        public Bitmap Img { get; set; }
    }
}
