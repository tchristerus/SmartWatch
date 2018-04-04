using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWatch
{
    class SmartWatch
    {
        private Time time;
        private Timer timer;
        private ModeHandler modeHandler;

        public SmartWatch(Panel modePanel) {

            // Initializing time obj
            this.time = new Time();

            // Initializing ModeHandler
            this.modeHandler = new ModeHandler(this.time, modePanel);
            
            // Initializing timer
            this.timer = new Timer();
            this.timer.Interval = 1000; // 1 second
            timer.Tick += new EventHandler(TimerTickEvent);
            timer.Start();
        }

        private void TimerTickEvent(Object myObject, EventArgs myEventArgs) {
            this.modeHandler.tick();
        }

        public void buttonOnePressed() {
            this.modeHandler.buttonOneEvent();
        }

        public void buttonTwoPressed() {
            this.modeHandler.buttonTwoEvent();
        }

        public void buttonBothPressed() {
            this.modeHandler.bothButtonsEvent();
        }
    }
}
