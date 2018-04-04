using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartWatch
{
    class AudioPlayerMode : IMode
    {
        public int currentCase { get; set; }
        public Time time { get; set; }
        private Label lbl_Time;

        public void Mode(Time time)
        {
            this.time = time;
        }

        public void buttonOne()
        {

        }

        public void buttonTwo()
        {

        }

        public void switchCase()
        {

        }

        public void drawGui(Panel modePanel)
        {
            Label titleLabel = new Label();
            Label artistLabel = new Label();
            titleLabel.Location = new Point(0, 0);
            titleLabel.Font = new Font("Arial", 15, FontStyle.Bold);
            artistLabel.Location = new Point(0, 25);
            artistLabel.Font = new Font("Arial", 12);

            titleLabel.Text = "Title";
            artistLabel.Text = "Artist";

            modePanel.Controls.Add(titleLabel);
            modePanel.Controls.Add(artistLabel);
        }

        public void tick()
        {
            //this.time.incrementSeconds();
        }
    }
}
