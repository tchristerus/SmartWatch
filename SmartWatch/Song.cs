using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWatch
{
    class Song
    {
        private string path;
        private string artist;
        private string title;

        public Song(string path, string artist, string title) {
            this.path = path;
            this.artist = artist;
            this.title = title;
        }
        
        public string getPath() {
            return path;
        }

        public string getTitle() {
            return title;
        }

        public string getArtist() {
            return artist;
        }
    }
}
