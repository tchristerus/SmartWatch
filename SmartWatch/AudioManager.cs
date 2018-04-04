using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace SmartWatch
{
    class AudioManager
    {
        private List<Song> songs;
        private Song currentSong;
        private int currentSongIndex;
        private Boolean playing;
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        private int volume;

        public AudioManager()
        {
            playing = false;
            addSongs();
        }

        public void addSongs()
        {
            Song song;
            String path = @"D:\Documenten\GitHub\SmartWatch\SmartWatch\Songs\";

            song = new Song(path + "Macklemore  Ryan Lewis vs Major Lazer - Cant Hold Us Remix.mp3", "Macklemore & Ryan Lewis", "Can't Hold Us Remix");
            songs.Add(song);

            song = new Song(path + "Nightcore-B-What-U-Wanna-B.mp3", "Nightcore", "B What U Wanna B");
            songs.Add(song);
        }

        public void loadSong(int index)
        {
            currentSong = songs[currentSongIndex];
            player.URL = currentSong.getPath();
            player.controls.play();
            playing = true;
        }

        public void playSong()
        {
            if (currentSong == null)
            {
                currentSongIndex = 0;
                loadSong(currentSongIndex);
                return;
            }
            if (!playing)
            {
                player.controls.play();
            }
        }

        public void pauseSong()
        {
            if (playing)
            {
                player.controls.pause();
                playing = false;
            }
        }

        public void nextSong()
        {
            if (currentSong == null)
                return;
            if(currentSongIndex == songs.Count)
            {
                currentSongIndex = 0;
            }
            else
            {
                currentSongIndex++;
            }
            loadSong(currentSongIndex);

        }

        public void previousSong()
        {
            if (currentSong == null)
                return;
            if (currentSongIndex == 0)
            {
                loadSong(songs.Count);
            }
            else
            {
                loadSong(currentSongIndex--);
            }
        }

        //===================ONNODIG====================================
        public void getNextSong()
        {
            throw new NotImplementedException();
        }

        public void getPreviousSong()
        {
            throw new NotImplementedException();
        }
        //===================ONNODIG====================================

        public void volumeUp()
        {
            throw new NotImplementedException();
        }

        public void volumeDown()
        {
            throw new NotImplementedException();
        }

    }
}
