using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using Tulpep.NotificationWindow;

namespace AlarmClock
{
    public partial class ClockForm : Form
    {
        private static Timer timerClock = new Timer();
        private DateTime currentTime;
        private PrivateFontCollection fontCol;


        public ClockForm()
        {
            InitializeComponent();

            // timer
            currentTime = DateTime.Now;
            timerClock.Interval = 1000;
            timerClock.Tick += new EventHandler(timerClock_Tick);
            timerClock.Start();

            // custom fields
            dateTimePickerAlarm.Format = DateTimePickerFormat.Custom;
            dateTimePickerAlarm.ShowUpDown = true;
            dateTimePickerAlarm.CustomFormat = "HH:mm dd.MM.yyyy";

            timeLabel.Text = currentTime.ToString("HH:mm:ss");
            dateLabel.Text = currentTime.ToString("dd.MM.yyyy");
            timeInAlarmLabel.Text = currentTime.ToString("HH:mm:ss");
            dateInAlarmlabel.Text = currentTime.ToString("dd.MM.yyyy");

            // set font
            //initCustomLabelFont();

            // display just time in alarms list
            alarmsCheckedListBox.DisplayMember = "alarmTime";
        }

        public void initCustomLabelFont()
        {
            //Create your private font collection object.
            PrivateFontCollection fontCol = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = AlarmClock.Properties.Resources.DSDIGI.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.DSDIGI;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            fontCol.AddMemoryFont(data, fontLength);
            timeLabel.Font = new Font(fontCol.Families[0], timeLabel.Font.Size);
            dateLabel.Font = new Font(fontCol.Families[0], dateLabel.Font.Size);
        }

        public void timerClock_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            timeLabel.Text = currentTime.ToString("HH:mm:ss");
            dateLabel.Text = currentTime.ToString("dd.MM.yyyy");
            timeInAlarmLabel.Text = currentTime.ToString("HH:mm:ss");
            dateInAlarmlabel.Text = currentTime.ToString("dd.MM.yyyy");

            // compare current time with alarms list
            for (int i = 0; i < alarmsCheckedListBox.Items.Count; i++)
            {
                MyAlarm tempAlarm = (MyAlarm)(alarmsCheckedListBox.Items[i]);
                String tempDateAlarm = Convert.ToDateTime(tempAlarm.AlarmTime).ToString("dd.MM.yyyy HH:mm");
                String tempDateNow = currentTime.ToString("dd.MM.yyyy HH:mm");
                int compareDateResult = String.Compare(tempDateAlarm, tempDateNow, true);
                if (compareDateResult == 0)
                {
                    // sound
                    //System.Media.SystemSounds.Beep.Play();
                    // one notification
                    if (tempAlarm.IsNotify)
                    {
                        notifyAlarm(tempAlarm);
                        tempAlarm.IsNotify = false;
                        alarmsCheckedListBox.Items[i] = tempAlarm; 
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addAlarmButton_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerAlarm.Value;
            MyAlarm myAlarm = new MyAlarm();
            myAlarm.AlarmTime = date;
            myAlarm.Notification = alarmTextBox.Text;
            alarmsCheckedListBox.Items.Insert(0, myAlarm);
        }

        private void dateTimePickerAlarm_ValueChanged(object sender, EventArgs e)
        {

        }

        private void removeAlarmsButton_Click(object sender, EventArgs e)
        {
            foreach (var item in alarmsCheckedListBox.CheckedItems.OfType<MyAlarm>().ToList())
            {
                alarmsCheckedListBox.Items.Remove(item);
            }

            foreach (int i in alarmsCheckedListBox.CheckedIndices)
            {
                alarmsCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            dateTimePickerAlarm.ResetText();
            alarmTextBox.Text = "";
        }

        public void notifyAlarm(MyAlarm alarm)
        {
            var popupNotifier = new PopupNotifier();
            popupNotifier.TitleText = "Alarm";
            popupNotifier.ContentText = alarm.Notification;
            popupNotifier.IsRightToLeft = false;
            popupNotifier.Popup();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/artkwi/alarm-clock");
        }
    }
}
