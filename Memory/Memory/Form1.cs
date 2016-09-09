using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Memory
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool started = false;
        private Game game;
        Bitmap img;
        Timer t;
        int cardsturned = 0;
        public int trys = 0;        

        public Form()
        {
            InitializeComponent();
            t = new Timer();
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            this.time.Text = game.TotalTime.ToString();
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.game = new Game();
            game.Timer();
            t.Interval = 1000;
            t.Start();
            started = true;
        }

        private void stopp_Click(object sender, EventArgs e)
        {
            t.Stop();
            Reset();
        }
        private void Reset()
        {
            trys = 0;
            if (game.turnarray[0] != 0 && game.turnarray[1] != 0)
            {
                game.turnarray[0] = 0;
                game.turnarray[1] = 0;
            }
            card1.Image = null;
            card2.Image = null;
            card3.Image = null;
            card4.Image = null;
            card5.Image = null;
            card6.Image = null;
            card7.Image = null;
            card8.Image = null;
            card9.Image = null;
            card10.Image = null;
            trycounter.Text = trys.ToString();
            time.Text = "0";
        }
        public void GameComplete()
        {
            t.Stop();
            MessageBox.Show("Sie haben das Spiel in "+game.TotalTime+" Sekunden und mit "+trys.ToString()+" Zügen beendet");
            Reset();
        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Turn(int pos)
        {
            
            img = game.Path(pos);
            switch (pos)
            {
                case 1:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card1.Image = img;
                    int id = game.Id(pos);
                    game.IdArray(id);
                    break;
                case 2:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card2.Image = img;
                    id = game.Id(pos);
                    game.IdArray(id);
                    break;
                case 3:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card3.Image = img;
                    id = game.Id(pos);
                    game.IdArray(id);
                    break;
                case 4:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card4.Image = img;
                    id = game.Id(pos);
                    game.IdArray(id);
                    break;
                case 5:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card5.Image = img;
                    id = game.Id(pos);
                    game.IdArray(id);
                    break;
                case 6:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card6.Image = img;
                    id = game.Id(pos);
                    game.IdArray(id);
                    break;
                case 7:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card7.Image = img;
                    id = game.Id(pos);
                    game.IdArray(id);
                    break;
                case 8:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card8.Image = img;
                    id = game.Id(pos);
                    game.IdArray(id);
                    break;
                case 9:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card9.Image = img;
                    id = game.Id(pos);
                    game.IdArray(id);
                    break;
                case 10:
                    cardsturned++;

                    if (cardsturned == 3)
                    {
                        game.Parse();
                        if (game.parse == false)
                        {
                            TurnCard();
                        }
                        cardsturned = 1;
                    }
                    card10.Image = img;
                    id = game.Id(pos);
                    game.IdArray(id);
                    break;
            }
            trys++;
            trycounter.Text = trys.ToString();
            if (game.parsecount == 4 && cardsturned == 2)
            {
                game.Parse();
            }
            if (game.parsecount == 5)
            {
                GameComplete();
            }



        }

        

        private void TurnCard()
        {
            int turncard;
            for (int i = 0; i < 2; i++)
            {
                turncard = game.turnarray[i];
                foreach (Card card in game.cards)
                {
                    if (card.Id == turncard)
                    {
                        int pos = card.Pos;
                        switch (pos)
                        {
                            case 1:
                                card1.Image = null;
                                break;
                            case 2:
                                card2.Image = null;
                                break;
                            case 3:
                                card3.Image = null;
                                break;
                            case 4:
                                card4.Image = null;
                                break;
                            case 5:
                                card5.Image = null;
                                break;
                            case 6:
                                card6.Image = null;
                                break;
                            case 7:
                                card7.Image = null;
                                break;
                            case 8:
                                card8.Image = null;
                                break;
                            case 9:
                                card9.Image = null;
                                break;
                            case 10:
                                card10.Image = null;
                                break;
                        }
                    }
                }
            }
            game.turnarray[0] = 0;
            game.turnarray[1] = 0;

        }
           public int Trys
        {
           get { return trys; }
           set { trys = value; }
        }
        

        public void card1_Click(object sender, EventArgs e)
        {
            
            if (started)
            {
                Turn(1);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
            
            
        }

        public void card2_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Turn(2);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }
        public void card3_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Turn(3);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }
        public void card4_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Turn(4);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }
        public void card5_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Turn(5);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }
        public void card6_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Turn(6);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }
        public void card7_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Turn(7);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }
        public void card8_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Turn(8);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }
        public void card9_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Turn(9);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }
        public void card10_Click(object sender, EventArgs e)
        {
            if (started)
            {
                Turn(10);
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }

        private void trycounter_TextChanged(object sender, EventArgs e)
        {
            trycounter.Text = trys.ToString();
            trycounter.Update();
        }
    }
}
