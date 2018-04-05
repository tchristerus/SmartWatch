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
        private AudioManager audioManager;

        private Label titleLabel;
        private Label artistLabel;
        private Label caseLabel;

        private String[] caseLabels = {"Play / Pause", "Next song", "Previous song", "Volume up", "Volume down"};

        /**
         * Initialise components
         */
        public AudioPlayerMode()
        {
            audioManager = new AudioManager();
            titleLabel = new Label();
            artistLabel = new Label();
            caseLabel = new Label();
        }

        public void Mode(Time time)
        {
            this.time = time;
        }

        /**
         * Execute function depending on currentCase
         */
        public void buttonOne()
        {
            switch (currentCase)
            {
                case 0:
                    audioManager.playPauseSong();
                    displaySong();
                    break;
                case 1:
                    audioManager.nextSong();
                    displaySong();
                    break;
                case 2:
                    audioManager.previousSong();
                    displaySong();
                    break;
                case 3:
                    audioManager.volumeUp();
                    break;
                case 4:
                    audioManager.volumeDown();
                    break;
            }
        }

        /**
         * Switch the current case to the next one and in case start over again.
         */
        public void buttonTwo()
        {
            switchCase();
        }
        public void switchCase()
        {
            if (currentCase == 4)
            {
                currentCase = 0;
            }
            else
            {
                currentCase++;
            }
            caseLabel.Text = caseLabels[currentCase];
        }

        /**
         * Draw the GUI for the mediaplayer
         */
        public void drawGui(Panel modePanel)
        {

            titleLabel.Location = new Point(0, 0);
            titleLabel.Font = new Font("Arial", 15, FontStyle.Bold);
            titleLabel.AutoSize = true;
            artistLabel.Location = new Point(0, 25);
            artistLabel.Font = new Font("Arial", 12);
            artistLabel.AutoSize = true;
            caseLabel.Location = new Point(0, 50);
            caseLabel.Font = new Font("Arial", 12);
            caseLabel.AutoSize = true;

            displaySong();
            caseLabel.Text = "Play / Pause";

            modePanel.Controls.Add(titleLabel);
            modePanel.Controls.Add(artistLabel);
            modePanel.Controls.Add(caseLabel);
        }

        /**
         * Will display the current song on the gui if there is one.
         * Else display standart data.
         */
        private void displaySong()
        {
            if (audioManager.getCurrentSong() == null)
            {
                titleLabel.Text = "Title";
                artistLabel.Text = "Artist";
            }
            else
            {
                titleLabel.Text = audioManager.getCurrentSong().getTitle();
                artistLabel.Text = audioManager.getCurrentSong().getArtist();
            }
        }

        public void tick()
        {
            time.incrementSeconds();
        }
    }
}
