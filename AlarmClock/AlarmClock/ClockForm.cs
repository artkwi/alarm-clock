using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClock
{
    public partial class ClockForm : Form
    {
        private static Timer timerClock = new Timer();
        private DateTime currentTime;

        public ClockForm()
        {
            InitializeComponent();
            dateTimePickerAlarm.Format = DateTimePickerFormat.Custom;
            dateTimePickerAlarm.ShowUpDown = true;
            dateTimePickerAlarm.CustomFormat = "HH:mm dd.MM.yyyy";


            currentTime = DateTime.Now;
            timeLabel.Text = currentTime.ToString("HH:mm:ss");
            dateLabel.Text = currentTime.ToString("dd.MM.yyyy");

            timerClock.Interval = 1000;
            timerClock.Tick += new EventHandler(timerClock_Tick);
            timerClock.Start();
            
        }

        public void timerClock_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            timeLabel.Text = currentTime.ToString("HH:mm:ss");
            dateLabel.Text = currentTime.ToString("dd.MM.yyyy");

            // compare current time with alarms list
            for (int i = 0; i < alarmsCheckedListBox.Items.Count; i++)
            {
                String tempDateAlarm = Convert.ToDateTime(alarmsCheckedListBox.Items[i]).ToString("dd.MM.yyyy HH:mm");
                String tempDateNow = currentTime.ToString("dd.MM.yyyy HH:mm");
                int compareDateResult = String.Compare(tempDateAlarm, tempDateNow, true);
                if (compareDateResult == 0)
                {
                    Console.WriteLine("Alarm");
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addAlarmButton_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerAlarm.Value;
            
            alarmsCheckedListBox.Items.Insert(0, date);

        }

        private void dateTimePickerAlarm_ValueChanged(object sender, EventArgs e)
        {

        }

        private void removeAlarmsButton_Click(object sender, EventArgs e)
        {        
            foreach (var item in alarmsCheckedListBox.CheckedItems.OfType<DateTime>().ToList())
            {
                alarmsCheckedListBox.Items.Remove(item);
            }

            foreach (int i in alarmsCheckedListBox.CheckedIndices)
            {
                alarmsCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        

    }
}
