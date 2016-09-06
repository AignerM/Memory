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
        private Game turns;
        private Game game;
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
            
            
        }

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void card1_Click(object sender, EventArgs e)
        {
            if (started)
            {
                card1.Image = Image.FromFile("C:\\Users\\maigner\\Documents\\Memory\\Images\\Bild1.jpg");
            }
            else
            {
                MessageBox.Show("Zum Spielen drücken Sie auf Spiel Starten!");
            }
            
            
        }

        public void card2_Click(object sender, EventArgs e)
        {
            turns.Turns();
        }
        public void card3_Click(object sender, EventArgs e)
        {
            turns.Turns();
        }
        public void card4_Click(object sender, EventArgs e)
        {
            turns.Turns();
        }
        public void card5_Click(object sender, EventArgs e)
        {
            turns.Turns();
        }
        public void card6_Click(object sender, EventArgs e)
        {
            turns.Turns();
        }
        public void card7_Click(object sender, EventArgs e)
        {
            turns.Turns();
        }
        public void card8_Click(object sender, EventArgs e)
        {
            turns.Turns();
        }
        public void card9_Click(object sender, EventArgs e)
        {
            turns.Turns();
        }
        public void card10_Click(object sender, EventArgs e)
        {
            turns.Turns();
        }

    }
}
