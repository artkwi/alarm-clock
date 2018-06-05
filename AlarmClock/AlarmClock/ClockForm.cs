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
        public ClockForm()
        {
            InitializeComponent();
            dateTimePickerAlarm.Format = DateTimePickerFormat.Custom;
            dateTimePickerAlarm.ShowUpDown = true;
            dateTimePickerAlarm.CustomFormat = "HH:mm dd.MM.yyyy";
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addAlarmButton_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerAlarm.Value;
            Console.WriteLine("siema" + date);
            AlarmsCheckedListBox.Items.Insert(0, date);

        }

        private void dateTimePickerAlarm_ValueChanged(object sender, EventArgs e)
        {

        }

        private void removeAlarmsButton_Click(object sender, EventArgs e)
        {        
            foreach (var item in AlarmsCheckedListBox.CheckedItems.OfType<DateTime>().ToList())
            {
                AlarmsCheckedListBox.Items.Remove(item);
            }

            foreach (int i in AlarmsCheckedListBox.CheckedIndices)
            {
                AlarmsCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }
}
