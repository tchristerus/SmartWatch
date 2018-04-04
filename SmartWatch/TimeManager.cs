using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWatch
{
    class TimeManager
    {
        private Time time;

        public TimeManager(Time time)
        {
            this.time = time;
        }

        public void incrementHours()
        {
            this.time.incrementHours();
        }

        public void incrementMinutes()
        {
            this.time.incrementMinutes();

        }

        public void incrementSeconds()
        {
            this.incrementSeconds();
        }

        public int getSeconds => this.time.getSeconds;
        public int getMinutes => this.time.getMinutes;
        public int getHours => this.time.getHours;
    }
}
