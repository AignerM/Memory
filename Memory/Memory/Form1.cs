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
        private Game parse;
        private Game game;
        private Card card;
        Bitmap img;
        Timer t;
       

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
            started = false;
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


        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void card1_Click(object sender, EventArgs e)
        {
            
            if (started)
            {
                img = game.Path(1);
                card1.Image = img;
                int id = game.Id(1);
                game.IdArray(id);
                if (game.parse == false)
                {
                    card1.Image = null;
                }
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
                img = game.Path(2);
                card2.Image = img;
                int id = game.Id(2);
                game.IdArray(id);
                if (game.parse == false)
                {
                    
                    card2.Image = null;
                }
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
                img = game.Path(3);
                card3.Image = img;
                //turns.Turns();
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
                img = game.Path(4);
                card4.Image = img;
                //turns.Turns();
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
                img = game.Path(5);
                card5.Image = img;
                //turns.Turns();
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
                img = game.Path(6);
                card6.Image = img;
                //turns.Turns();
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
                img = game.Path(7);
                card7.Image = img;
                //turns.Turns();
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
                img = game.Path(8);
                card8.Image = img;
                //turns.Turns();
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
                img = game.Path(9);
                card9.Image = img;
                //turns.Turns();
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
                img = game.Path(10);
                card10.Image = img;
                //turns.Turns();
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
        }

    }
}
