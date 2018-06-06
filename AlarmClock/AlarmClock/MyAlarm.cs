using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class MyAlarm
    {
        private DateTime alarmTime;
        private String notification;
        private bool isNotify;

        public DateTime AlarmTime { get => alarmTime; set => alarmTime = value; }
        public string Notification { get => notification; set => notification = value; }
        public bool IsNotify { get => isNotify; set => isNotify = value; }

        public MyAlarm()
        {
            notification = "Alarm!";
            isNotify = true;
        }
    }
}
