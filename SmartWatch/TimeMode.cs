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

        private Label lbl_hours;
        private Label lbl_minutes;
        
        public void Mode(Time time)
        {
            this.time = time;
        }

        public void buttonOne()
        {
            throw new NotImplementedException();
        }

        public void buttonTwo()
        {
            throw new NotImplementedException();
        }

        public void switchCase()
        {
            throw new NotImplementedException();
        }

        public void drawGui(Panel modePanel)
        {
            lbl_hours = new Label();
            lbl_hours.Text = time.getHours.ToString();
            lbl_hours.Location = new Point(0,0);
            modePanel.Controls.Add(lbl_hours);

        }

        public void tick()
        {
            throw new NotImplementedException();
        }

        public void DisplayTime()
        {

        }
    }
}
