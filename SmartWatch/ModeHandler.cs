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

        public ModeHandler(Panel modePanel) {
            this.modePanel = modePanel;
        }

        public void nextMode() {
            throw new NotImplementedException();
        }

        public IMode getCurrentMode() {
            if(currentMode != null)
                return this.currentMode;
            throw new NullReferenceException("Mode is null");
        }

        public void tick() {
            throw new NotFiniteNumberException();
        }

        public void buttonOneEvent() {
            throw new NotImplementedException();
        }

        public void buttonTwoEvent() {
            throw new NotImplementedException();
        }

        public void bothButtonsEvent() {
            throw new NotImplementedException();
        }
    
    }
}
