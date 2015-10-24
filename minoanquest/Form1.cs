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
            paused = false;
            tickSpeed = "x1";
            timerStep.Start();
        }

        internal bool toggleTimer()
        {
            if (paused)
            {
                //unpause
                timerStep.Start();
            }
            else
            {
                timerStep.Stop();
            }
            paused = !paused;

            //give back the status of pause for button to change
            return paused;
        }

        private void updateStatusStrip()
        {
            statusStepLabel.Text = "Steps: " + step.ToString();
            if (paused)
            {
                statusPlayLabel.Text = "Paused.";
            }
            else
            {
                statusPlayLabel.Text = "Playing...";
            }

            statusSpeedLabel.Text = tickSpeed;  
        }

        private void timerStep_Tick(object sender, EventArgs e)
        {
            step++;
            updateStatusStrip();
        }

        private void setTimerSpeed(int newSpeed)
        {
            timerStep.Interval = newSpeed;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(toggleTimer())
            {
                btnPause.Text = ">";
            }
            else
            {
                btnPause.Text = "||";
            }
            tickSpeed = "x1";
            setTimerSpeed(1000);
            updateStatusStrip();
        }

        private void btnSpeed2_Click(object sender, EventArgs e)
        {
            setTimerSpeed(500);
            tickSpeed = "x2";
        }

        private void btnSpeed3_Click(object sender, EventArgs e)
        {
            setTimerSpeed(200);
            tickSpeed = "x3";
        }
    }
}
