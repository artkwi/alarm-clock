using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class MyAlarm
    {
        private DateTime alarmTime;
        private String notification;

        public DateTime AlarmTime { get => alarmTime; set => alarmTime = value; }
        public string Notification { get => notification; set => notification = value; }
    }
}
