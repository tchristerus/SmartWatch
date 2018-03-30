using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWatch
{
    public partial class Gui : Form
    {
        private SmartWatch smartWatch;

        public Gui() {
            InitializeComponent();
        }

        private void Gui_Load(object sender, EventArgs e) {
            this.smartWatch = new SmartWatch(modePanel);
        }
        
        private void buttonOne_Click(object sender, EventArgs e) {
            this.smartWatch.buttonOnePressed();
        }

        private void buttonTwo_Click(object sender, EventArgs e) {
            this.smartWatch.buttonTwoPressed();
        }

        private void buttonBoth_Click(object sender, EventArgs e) {
            this.smartWatch.buttonBothPressed();
        }
        
    }
}
