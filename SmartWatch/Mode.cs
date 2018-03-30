using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWatch
{
    interface IMode
    {
        int currentCase {set; }
        Time time {set; }

        void Mode(Time time);
        void buttonOne();
        void buttonTwo();
        void switchCase();
        void drawGui(Panel modePanel);
        void tick();
    }
}
