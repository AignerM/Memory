﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace Memory
{
    public class Game
    {
        private Form card;
        private Player player;
        private int totaltime;
        private Bitmap[] img = new Bitmap[5];
        public List<Card> cards;
        string num;
        string tempnum;
        int tempzahl = 1;
        Bitmap source;
        int pos;
        Timer t;
        int turns;
        int[] turnarray = new int[] { 0, 0 };

        private void Paths()
        {
            int i = 0;
            img[i] = Memory.Properties.Resources.Bild1;
            i++;
            img[i] = Memory.Properties.Resources.Bild2;
            i++;
            img[i] = Memory.Properties.Resources.Bild3;
            i++;
            img[i] = Memory.Properties.Resources.Bild4;
            i++;
            img[i] = Memory.Properties.Resources.Bild5;
            

            InitCrads();
        }
        public Bitmap Path(int pos)
        {
            foreach(Card card in cards)
            {
                if (pos == card.Pos)
                {
                    source = card.Img;
                }
            }
            return source;
        }

        public Game()
        {
            cards = new List<Card>();
            t = new Timer();
            Paths();
            parse = true;
        }

        public void IdArray(int id)
        {
            if (turnarray[0] == 0)
            {
                turnarray[0] = id;
            }
            else
            {
                turnarray[1] = id;
            }
            
            if (turnarray[0] != 0 && turnarray[1] != 0)
            {
                Parse();
            }
        }
        public bool parse;
        public bool Parse()
        {
            parse = true;
            if (turnarray[0]+1 == turnarray[1]||turnarray[0]-1==turnarray[1])
            {
                parse = true;
            }
            else
            {
                parse = false;
            }
            return parse;
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
                    source = img[y];
                    s = 1;
                }
                else
                {
                    source = img[y];
                    y++;
                    s = 2;
                }
                
                if ((i % 2) == 0 && i>0)
                {
                    idc += 10;
                }

                int id = s + idc;

                

                cards.Add(new Card(id,source, pos));
            }
            SetCards();
        }
        private bool CheckPos(int pos)
        {
            bool check = true;
            foreach(Card card in cards)
            {
                if (card.Pos == pos)
                {
                    check = false;
                }
            }
            return check;
        }
        public int Id(int pos)
        {
            int id=0;
            foreach(Card card in cards)
            {
                if (card.Pos == pos)
                {
                    id = card.Id;
                }
            }
            return id;
        }
        private void SetCards()
        {
            List<Card> tempCards = cards;
            Random rnd = new Random();
            for (int i = 0;i< 10; i++)
            {
                do
                {
                    int zufall = rnd.Next(0, tempCards.Count+1);
                    pos = zufall;
                } while (CheckPos(pos) == false);
                cards[i].Pos = pos;

            }
        }
    }
}
