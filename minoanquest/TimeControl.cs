using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minoanquest
{
    static class TimeControl
    {
        static int worldSteps = 0;
        static int worldSpeed = 1000;
        static public bool paused = true;

        static System.Windows.Forms.Timer worldTimer;

        static Form1 parentForm;

        static TimeControl()
        {
            //create a timer object
            worldTimer = new System.Windows.Forms.Timer();
            worldTimer.Tick += worldTimer_Tick;
            //set the interval for the timer
            worldTimer.Interval = worldSpeed;
            //set the parent form to be updated with ticks
        }

        static public void setForm(Form1 formToSet)
        {
            parentForm = formToSet;
        }

        static void startTime()
        {
            worldTimer.Start();
        }

        static void stopTime()
        {
            worldTimer.Stop();
        }

        static public bool togglePause()
        {
            if (paused)
            {
                //unpause
                startTime();
            }
            else
            {
                stopTime();
            }
            paused = !paused;
            return paused;
        }

        static public void setSpeed(int newspeed)
        {
            switch(newspeed)
            {
                case 1:
                    worldTimer.Interval = 1000;
                    return;
                case 2:
                    worldTimer.Interval = 500;
                    return;
                case 3:
                    worldTimer.Interval = 200;
                    return;
                default:
                    worldTimer.Interval = 1000;
                    return;
            }
            
        }

        static public int getSteps()
        {
            return worldSteps;
        }

        static void worldTimer_Tick(object sender, EventArgs e)
        {
            //increase the step count
            worldSteps++;
            //update the form to show timer status
            parentForm.updateStatusStrip();

        }
    }
}
