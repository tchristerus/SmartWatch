using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MediaPLayer library
using WMPLib;

namespace SmartWatch
{
    class AudioManager
    {
        private List<Song> songs; // List of all the songs.
        private Song currentSong; // The song which is currently playing.
        private int currentSongIndex; // The index of the current song.
        private Boolean playing; // True if song is played. False when no song is played.
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer(); // The mediaplayer
        // private int volume; NOT NEEDED

        /*
          The constructor of the AudioManager class.
         */
        public AudioManager()
        {
            playing = false;
            addSongs();
        }

        // Adds songs with their path, artist and title to songs.
        public void addSongs()
        {
            Song song;
            String path = @"D:\Documenten\GitHub\SmartWatch\SmartWatch\Songs\";

            song = new Song(path + "Macklemore  Ryan Lewis vs Major Lazer - Cant Hold Us Remix.mp3", "Macklemore & Ryan Lewis", "Can't Hold Us Remix");
            songs.Add(song);

            song = new Song(path + "Nightcore-B-What-U-Wanna-B.mp3", "Nightcore", "B What U Wanna B");
            songs.Add(song);
        }

        /*
          Selects an song from songs and start playing it.
         */
        private void loadSong(int index)
        {
            // In case a index is given larger than songs
            if (index < 0 || index > songs.Count - 1)
                throw new IndexOutOfRangeException();

            currentSong = songs[currentSongIndex];  // Set the current song to the loaded song.
            currentSongIndex = index;               // Set the current sonfIndex of the loaded song.
            player.URL = currentSong.getPath();     // Set the url of the loaded song.
            player.controls.play();                 // Start playing the song.
            playing = true;                         // Set playing to true.
        }

        // Resume or start a new song.
        private void playSong()
        {
            // In case no song has yet started. Start from the beginning.
            if (currentSong == null)
            {
                loadSong(0);
                return;
            }
            // Resume the player.
            player.controls.play();
            playing = true;
        }

        // Pause the player
        private void pauseSong()
        {
            // This will only pause if playing = false
            player.controls.pause();
            playing = false;
        }

        // Switch between playing and pausing using the playing variable.
        public void playPauseSong()
        {
            if (playing)
            {
                pauseSong();
            }
            else
            {
                playSong();
            }
        }

        // Select and play the next song in the list.
        public void nextSong()
        {
            // Cant go next if no song has been selected.
            if (currentSong == null)
                return;
            if (currentSongIndex == songs.Count) // Start at the beginning when at last song.
            {
                currentSongIndex = 0;
            }
            else
            {
                currentSongIndex++; // Increase index.
            }
            // Load the next song.
            loadSong(currentSongIndex);

        }

        // Select and play the previous song in the list
        public void previousSong()
        {
            // Cant go previous if no song has been selected.
            if (currentSong == null)
                return;
            if (currentSongIndex == 0) // Go to end of list when at beginning
            {
                currentSongIndex = songs.Count + 1;
            }
            else
            {
                currentSongIndex--;
            }
            // Load the previous song.
            loadSong(currentSongIndex);
        }

        // Increase the volume of player
        public void volumeUp()
        {
            player.settings.volume = player.settings.volume + 10;
        }

        // Decrease the volume of player.
        public void volumeDown()
        {
            player.settings.volume = player.settings.volume - 10;
        }

    }
}
