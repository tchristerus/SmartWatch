using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWatch
{
    class Time
    {
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;
        
        public void incrementHours() {
            if (this.hours++ == 60)
                this.hours = 0;
        }

        public void incrementMinutes() {
            if (this.minutes++ == 60)
                this.minutes = 0;
        }

        public void incrementSeconds() {
            if (this.seconds++ == 60)
                this.seconds = 0;
        }

        public int getSeconds { get; }
        public int getMinutes { get; }
        public int getHours { get; }
    }
}
