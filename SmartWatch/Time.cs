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
            if (this.hours++ == 23)
                this.hours = 0;
        }

        public void incrementMinutes() {
            if (this.minutes++ == 59)
            {
                this.minutes = 0;
                this.incrementHours();
            }
        }

        public void incrementSeconds() {
            if (this.seconds++ == 59)
            {
                this.seconds = 0;
                this.incrementMinutes();
            }
        }

        public int getSeconds => this.seconds;
        public int getMinutes => this.minutes;
        public int getHours => this.hours;
    }
}
