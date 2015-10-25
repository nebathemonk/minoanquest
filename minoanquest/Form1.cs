using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minoanquest
{
    public partial class Form1 : Form
    {

        public int step;
        public string tickSpeed;
        public bool paused;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set this form as the one the timer updates
            TimeControl.setForm(this);

            tickSpeed = "x1";
        }

        public void updateStatusStrip()
        {
            statusStepLabel.Text = "Steps: " + TimeControl.getSteps().ToString();
            if (TimeControl.paused)
            {
                statusPlayLabel.Text = "Paused.";
            }
            else
            {
                statusPlayLabel.Text = "Playing...";
            }

            statusSpeedLabel.Text = tickSpeed;  
        }


        private void btnPause_Click(object sender, EventArgs e)
        {
            if(TimeControl.togglePause())
            {
                btnPause.Text = ">";
            }
            else
            {
                btnPause.Text = "||";
            }
            tickSpeed = "x1";
            TimeControl.setSpeed(1);
            updateStatusStrip();
        }

        private void btnSpeed2_Click(object sender, EventArgs e)
        {
            TimeControl.setSpeed(2);
            tickSpeed = "x2";
            updateStatusStrip();
        }

        private void btnSpeed3_Click(object sender, EventArgs e)
        {
            TimeControl.setSpeed(3);
            tickSpeed = "x3";
            updateStatusStrip();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mob newMob = new Mob();
        }
    }
}
