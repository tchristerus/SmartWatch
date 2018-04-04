using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWatch
{
    class ModeHandler
    {
        private List<IMode> modes = new List<IMode>();
        private IMode currentMode;
        private Panel modePanel;

        public ModeHandler(Time time, Panel modePanel) {
            this.modePanel = modePanel;

            TimeMode timeMode = new TimeMode();
            timeMode.Mode(time);
            this.modes.Add(timeMode);
            this.currentMode = timeMode;
            timeMode.drawGui(modePanel);
        }

        private void nextMode() {
            int index = this.modes.IndexOf(currentMode);

            if (index == this.modes.Count) {
                index = 0;
            }

            this.currentMode = this.modes[index + 1];
            this.currentMode.drawGui(this.modePanel);
        }

        public IMode getCurrentMode() {
            if(this.currentMode != null)
                return this.currentMode;
            throw new NullReferenceException("Mode is null");
        }

        public void tick() {
            this.currentMode.tick();
        }

        public void buttonOneEvent() {
            this.currentMode.buttonOne();
        }

        public void buttonTwoEvent() {
            this.currentMode.buttonTwo();
        }

        public void bothButtonsEvent() {
            this.nextMode();
        }
    }
}
