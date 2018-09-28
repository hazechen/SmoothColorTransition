using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoothColorTransition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(244, 66, 66);
            labelr.Text = "R: " + r.ToString();
            labelg.Text = "G: " + g.ToString();
            labelb.Text = "B: " + b.ToString();
            timerR.Start();
        }

        int r = 244;
        int g = 65;
        int b = 65;

        private void timerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244)
            {
                r -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                labelr.Text = "R: " + r.ToString();
                if (r <= 65)
                {
                    timerR.Stop();
                    timerG.Start();
                }
            }

            if (b <= 65)
            {
                r += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                labelr.Text = "R: " + r.ToString();
                if (r >= 244)
                {
                    timerR.Stop();
                    timerG.Start();
                }
            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            if (r <= 65)
            {
                g += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                labelg.Text = "G: " + g.ToString();
                if (g >= 244)
                {
                    timerG.Stop();
                    timerB.Start();
                }
            }

            if (r >= 244)
            {
                g -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                labelg.Text = "G: " + g.ToString();
                if (g <= 65)
                {
                    timerG.Stop();
                    timerB.Start();
                }
            }
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            if (g <= 65)
            {
                b += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                labelb.Text = "B: " + b.ToString();
                if (b >= 244)
                {
                    timerB.Stop();
                    timerR.Start();
                }
            }
            if (g >= 244)
            {
                b -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                labelb.Text = "B: " + b.ToString();
                if (b <= 65)
                {
                    timerB.Stop();
                    timerR.Start();
                }
            }
        }
    }
}
