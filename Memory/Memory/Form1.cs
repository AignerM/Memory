﻿using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Memory
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool shown = false;
        private bool started = false;
        private Game game;
        Bitmap img;
        Timer t;
        int cardsturned = 0;
        public string playerName;
        int x = 0;
        public string[,] highscoreArray = new string[6, 3];
        private string[] tempArray = new string[3];
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
            if (playerName == null)
            {
                MessageBox.Show("Bitte geben Sie zuerst einen Namen an und klicken Sie die Accept-Taste!");
            }
            else
            {
                if (shown == true)
                {
                    highscorelist.Hide();
                    shown = false;
                }
                this.game = new Game();
                game.Timer();
                t.Interval = 1000;
                t.Start();
                started = true;
                CheckGame();
            }
        }

        private void CheckGame()
        {
            if (started == true)
            {
                start.Enabled = false;
            }
            else
            {
                start.Enabled = true;
                nameaccept.Enabled = true;
                name.Enabled = true;
            }
        }

        private void stopp_Click(object sender, EventArgs e)
        {
            t.Stop();
            if (started == true)
            {
                Reset();
            }
            nameaccept.Enabled = true;
            name.Enabled = true;
            name.Text = null;
            playerName = null;
        }

        private void Reset()
        {
            Trys = 0;
            if (game.turnarray[0] != 0 && game.turnarray[1] != 0)
            {
                game.turnarray[0] = 0;
                game.turnarray[1] = 0;
            }
            card1.Image = null; card1.Enabled = true;
            card2.Image = null; card2.Enabled = true;
            card3.Image = null; card3.Enabled = true;
            card4.Image = null; card4.Enabled = true;
            card5.Image = null; card5.Enabled = true;
            card6.Image = null; card6.Enabled = true;
            card7.Image = null; card7.Enabled = true;
            card8.Image = null; card8.Enabled = true;
            card9.Image = null; card9.Enabled = true;
            card10.Image = null; card10.Enabled = true; ;
            cardsturned = 0;
            trycounter.Text = Trys.ToString();
            time.Text = "0";
            name.Text = null;
            started = false;
            playerName = null;
            CheckGame();
        }

        public void GameComplete()
        {
            highscorelist.Text = null;
            x = 0;
            t.Stop();
            game.AddPlayer(playerName, game.TotalTime, Trys);
            MessageBox.Show(game.Player.Name + " hat das Spiel in " + game.Player.Time + " Sekunden und mit " + game.Player.Trys + " Zügen beendet");
            game.AddHighscore();
            
            for (int i = 0; i < 6; i++)
            {
                if (highscoreArray[i, 0] == null)
                {
                    highscoreArray[i, 0] = game.Player.Name;
                    highscoreArray[i, 1] = game.Player.Time.ToString();
                    highscoreArray[i, 2] = game.Player.Trys.ToString();
                    break;
                }
            }

            StringBuilder sb = new StringBuilder();

            HighscoreSortierung();
            for (int i = 0; i < 5; i++)
            {
                if (highscoreArray[i, 0] != null)
                {
                    sb.Append((x + 1) + ". ");
                    sb.Append(highscoreArray[i, 0] + " ");
                    sb.Append(highscoreArray[i, 1] + " Sekunden ");
                    sb.AppendLine(highscoreArray[i, 2] + " Versuche");
                    x++;
                }
                else
                {
                    break;
                }
            }

            highscorelist.Text = sb.ToString();

            if (shown == false)
            {
                highscorelist.Show();
                shown = true;
            }
            else
            {
                highscorelist.Hide();
                shown = false;
            }
            Reset();
        }

        private void HighscoreSortierung()
        {
            bool passed;
            do
            {
                passed = true;
                for (int i = 0; i < 5; i++)
                {
                    if (Convert.ToInt32(highscoreArray[i,1])>Convert.ToInt32(highscoreArray[i+1,1]) && highscoreArray[i,0] != null && highscoreArray[i+1,0] != null || Convert.ToInt32(highscoreArray[i, 2]) > Convert.ToInt32(highscoreArray[i + 1, 2]) && Convert.ToInt32(highscoreArray[i, 1]) == Convert.ToInt32(highscoreArray[i + 1, 1]))
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            tempArray[y] = highscoreArray[i, y];
                            highscoreArray[i, y] = highscoreArray[i + 1, y];
                            highscoreArray[i + 1, y] = tempArray[y];
                            passed = false;
                        }
                    }
                }
            } while (passed != true);
            for(int i = 0; i < 3; i++)
            {
                highscoreArray[5, i] = null;
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Turn(int pos)
        {
            img = game.Path(pos);
            cardsturned++;
            switch (pos)
            {
                case 1:
                    card1.Enabled = false;
                    break;

                case 2:
                    card2.Enabled = false;
                    break;

                case 3:
                    card3.Enabled = false;
                    break;

                case 4:
                    card4.Enabled = false;
                    break;

                case 5:
                    card5.Enabled = false;
                    break;

                case 6:
                    card6.Enabled = false;
                    break;

                case 7:
                    card7.Enabled = false;
                    break;

                case 8:
                    card8.Enabled = false;
                    break;

                case 9:
                    card9.Enabled = false;
                    break;

                case 10:
                    card10.Enabled = false;
                    break;
            }
            if (cardsturned == 3)
            {
                game.Parse();
                if (game.parse == false)
                {
                    TurnCard();
                }

                cardsturned = 1;
                Trys++;
            }
            switch (pos)
            {
                case 1:
                    card1.Image = img;
                    break;

                case 2:
                    card2.Image = img;
                    break;

                case 3:
                    card3.Image = img;
                    break;

                case 4:
                    card4.Image = img;
                    break;

                case 5:
                    card5.Image = img;
                    break;

                case 6:
                    card6.Image = img;
                    break;

                case 7:
                    card7.Image = img;
                    break;

                case 8:
                    card8.Image = img;
                    break;

                case 9:
                    card9.Image = img;
                    break;

                case 10:
                    card10.Image = img;
                    break;
            }
            int id = game.Id(pos);
            game.IdArray(id);
            trycounter.Text = Trys.ToString();
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
                                card1.Enabled = true;
                                break;
                            case 2:
                                card2.Image = null;
                                card2.Enabled = true;
                                break;
                            case 3:
                                card3.Image = null;
                                card3.Enabled = true;
                                break;
                            case 4:
                                card4.Image = null;
                                card4.Enabled = true;
                                break;
                            case 5:
                                card5.Image = null;
                                card5.Enabled = true;
                                break;
                            case 6:
                                card6.Image = null;
                                card6.Enabled = true;
                                break;
                            case 7:
                                card7.Image = null;
                                card7.Enabled = true;
                                break;
                            case 8:
                                card8.Image = null;
                                card8.Enabled = true;
                                break;
                            case 9:
                                card9.Image = null;
                                card9.Enabled = true;
                                break;
                            case 10:
                                card10.Image = null;
                                card10.Enabled = true;
                                break;
                        }
                    }
                }
            }
            game.turnarray[0] = 0;
            game.turnarray[1] = 0;

        }

           public int Trys { get; set; }


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
            trycounter.Text = Trys.ToString();
            trycounter.Update();
        }

        private void nameaccept_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Bitte geben Sie einen Namen ein!");
            }
            else
            {
                playerName = name.Text;
                name.Enabled = false;
                nameaccept.Enabled = false;
            }
        }

        private void highscores_Click(object sender, EventArgs e)
        {
           if (shown == false)
            {
                highscorelist.Show();
                shown = true;
            }
           else
            {
                highscorelist.Hide();
                shown = false;
            }
        }
    }
}
