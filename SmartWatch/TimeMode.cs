using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWatch
{
    class TimeMode : IMode
    {
        public int currentCase { get; set; }
        public Time time { get; set; }
        private TimeManager timeManager;

        private Label lbl_Time;

        
        public void Mode(Time time)
        {
            this.time = time;
            this.timeManager = new TimeManager(time);
        }

        // Action on current mode
        public void buttonOne()
        {
            if (currentCase == 0) // Increment minutes mode
            {
                this.timeManager.incrementMinutes();
            }
            else
            {
                this.timeManager.incrementHours();
            }
            DisplayTime();
        }

        // Change mode
        public void buttonTwo()
        {
           switchCase();
        }

        public void switchCase()
        {
            currentCase = (currentCase == 0) ? 1 : 0;
        }

        public void drawGui(Panel modePanel)
        {
            lbl_Time = new Label();
            lbl_Time.Location = new Point(0,0);
            lbl_Time.Font = new Font("Arial", 15, FontStyle.Bold);
            modePanel.Controls.Add(lbl_Time);
            DisplayTime();

        }

        public void tick()
        {
           this.time.incrementSeconds();
           this.DisplayTime();
        }

        public void DisplayTime()
        {
            string hours = (currentCase == 1) ? ">" + this.timeManager.getHours : this.timeManager.getHours.ToString();
            string minutes = (currentCase == 0) ? this.timeManager.getMinutes + "<" : this.timeManager.getMinutes.ToString();
            this.lbl_Time.Text = $@"{hours}:{minutes}";
        }
    }
}
