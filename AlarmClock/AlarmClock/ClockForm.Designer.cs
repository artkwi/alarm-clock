namespace AlarmClock
{
    partial class ClockForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelClock = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerAlarm = new System.Windows.Forms.DateTimePicker();
            this.addAlarmButton = new System.Windows.Forms.Button();
            this.AlarmsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.removeAlarmsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanelClock);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clock";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tableLayoutPanelClock
            // 
            this.tableLayoutPanelClock.AutoSize = true;
            this.tableLayoutPanelClock.ColumnCount = 2;
            this.tableLayoutPanelClock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelClock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelClock.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelClock.Name = "tableLayoutPanelClock";
            this.tableLayoutPanelClock.RowCount = 2;
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelClock.Size = new System.Drawing.Size(770, 429);
            this.tableLayoutPanelClock.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alarm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AlarmsCheckedListBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 429);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerAlarm, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addAlarmButton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(313, 423);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dateTimePickerAlarm
            // 
            this.dateTimePickerAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAlarm.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerAlarm.Name = "dateTimePickerAlarm";
            this.dateTimePickerAlarm.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAlarm.TabIndex = 1;
            this.dateTimePickerAlarm.ValueChanged += new System.EventHandler(this.dateTimePickerAlarm_ValueChanged);
            // 
            // addAlarmButton
            // 
            this.addAlarmButton.Location = new System.Drawing.Point(3, 214);
            this.addAlarmButton.Name = "addAlarmButton";
            this.addAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.addAlarmButton.TabIndex = 2;
            this.addAlarmButton.Text = "Add alarm";
            this.addAlarmButton.UseVisualStyleBackColor = true;
            this.addAlarmButton.Click += new System.EventHandler(this.addAlarmButton_Click);
            // 
            // AlarmsCheckedListBox
            // 
            this.AlarmsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlarmsCheckedListBox.FormattingEnabled = true;
            this.AlarmsCheckedListBox.Location = new System.Drawing.Point(322, 3);
            this.AlarmsCheckedListBox.Name = "AlarmsCheckedListBox";
            this.AlarmsCheckedListBox.Size = new System.Drawing.Size(313, 214);
            this.AlarmsCheckedListBox.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.removeAlarmsButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(641, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(126, 423);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // removeAlarmsButton
            // 
            this.removeAlarmsButton.Location = new System.Drawing.Point(3, 3);
            this.removeAlarmsButton.Name = "removeAlarmsButton";
            this.removeAlarmsButton.Size = new System.Drawing.Size(75, 23);
            this.removeAlarmsButton.TabIndex = 0;
            this.removeAlarmsButton.Text = "Remove";
            this.removeAlarmsButton.UseVisualStyleBackColor = true;
            this.removeAlarmsButton.Click += new System.EventHandler(this.removeAlarmsButton_Click);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClockForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelClock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlarm;
        private System.Windows.Forms.Button addAlarmButton;
        private System.Windows.Forms.CheckedListBox AlarmsCheckedListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button removeAlarmsButton;
    }
}

