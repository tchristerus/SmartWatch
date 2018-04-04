using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWatch
{
    class TimeMode : IMode
    {
        public TimeMode()
        {
            var t = new Time();

        }
     
        public int currentCase { get; set; }
        public Time time { get; set; }
        public void Mode(Time time)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
