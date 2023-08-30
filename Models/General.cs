using System;

namespace Janitor_V1.Models
{
    internal class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public double HourTime { get; set; }

        public Time(double hourTime)
        {
            this.HourTime = hourTime;
            this.Hour = (int)hourTime;
            this.Minute = (int)Math.Round(((hourTime % 1) * 60), 0, MidpointRounding.AwayFromZero);
        }
        public Time(string hourTime)
        {
            double time;
            if(double.TryParse(hourTime, out time))
            {
                this.HourTime = time;
                this.Hour = (int)time;
                this.Minute = (int)Math.Round(((time % 1) * 60), 0, MidpointRounding.AwayFromZero);
            }
        }

        public Time(int hours, int minutes)
        {
            this.Hour = hours;
            this.Minute = minutes;
            this.HourTime = Math.Round((hours + ((double)minutes / 60)), 2, MidpointRounding.AwayFromZero);
        }
        public Time(string hours, string minutes)
        {
            int h, m;
            if (int.TryParse(hours, out h) && int.TryParse(minutes, out m))
            {
                this.Hour = h;
                this.Minute = m;
                this.HourTime = Math.Round((h + ((double)m / 60)), 2, MidpointRounding.AwayFromZero);
            }
        }
    }
}
