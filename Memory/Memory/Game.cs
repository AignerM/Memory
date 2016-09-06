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
        private int totaltime;
        private string[] paths = new string[5];
        private List<Card> cards;
        string num;
        string tempnum;
        string path;
        private void Paths()
        {
            for(int i = 0; i < 5; i++)
            {
                tempnum = i + 1.ToString();
                num = tempnum + ".jpg";
                paths[i] = "C:\\Users\\maigner\\Documents\\Memory\\Images\\Bild" + num;
            }
        }
        public Game()
        {
            cards = new List<Card>();
        }


        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        private void AddPlayer(string name)
        {
            player = new Player(name);
        }

        public void InitCrads()
        {
            int idc = 10;

            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        path = paths[y];
                    }
                }
                if ((i % 2) == 0)
                {
                    idc += 10;
                }

                int id = (i/2) + idc;

                

                cards.Add(new Card(id,path));
            }
        }

        private void SetCards()
        {
            List<Card> tempCards = cards;
            Random rnd = new Random();

            int zufall = rnd.Next(0, tempCards.Count);
            tempCards.Remove(tempCards[zufall]);
        }
    }
}
