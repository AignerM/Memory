using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Memory
{
    public class Game
    {
        private Form card1;
        private Player player;
        private int totaltime;
        private string[] paths = new string[5];
        private List<Card> cards;
        string num;
        string tempnum;
        int tempzahl = 1;
        string path;
        Timer t;
        int turns;
        private void Paths()
        {
            for(int i = 0; i < 5; i++)
            {
                tempzahl = 1;
                tempzahl = tempzahl + i;
                tempnum = tempzahl.ToString();
                num = tempnum + ".jpg";
                paths[i] = "C:\\Users\\maigner\\Documents\\Memory\\Images\\Bild" + num;
            }
            InitCrads();
        }
        public Game()
        {
            cards = new List<Card>();
            t = new Timer();
            Paths();
        }

        public void Turns()
        {
            turns += 1;
            if(turns % 2 == 0)
            {

            }
        }


        public Player Player
        {
            get { return player; }
            set { player = value; }
        }
        public int TotalTime
        {
            get { return totaltime; }
        }
        public void Timer()
        {
            
            t.Interval = 1000;
            t.Tick += Timer_Tick;
            t.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            totaltime++;
        }

        private void AddPlayer(string name)
        {
            player = new Player(name);
        }

        public void InitCrads()
        {
            int idc = 10;
            int y = 0;
            int s;
            for(int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    path = paths[y];
                    s = 1;
                }
                else
                {
                    path = paths[y];
                    y++;
                    s = 2;
                }
                
                if ((i % 2) == 0 && i>0)
                {
                    idc += 10;
                }

                int id = s + idc;

                

                cards.Add(new Card(id,path));
            }
            SetCards();
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
