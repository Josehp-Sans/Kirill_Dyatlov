using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class HelloForm : Form
    {

        private int sec = 0;
        private int min = 0;
        private int hour = 0;

        private AlarmState alarmState = new AlarmState();
        public HelloForm()
        {
            InitializeComponent();
        }

        private void HelloForm_Load(object sender, EventArgs e)
        {

        }
        private void HelloButton_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = DateTime.Now.ToLongTimeString();

            if (alarmState.IsAlarmActive && !alarmState.IsAwakeActived && 
                DateTime.Now.Hour == alarmState.AlarmTime.Hour && DateTime.Now.Minute == alarmState.AlarmTime.Minute)
            {
                alarmState.IsAwakeActived = true;

                var awakeForm = new AwakeForm();
                awakeForm.AlarmState = alarmState;
                awakeForm.FormClosed += AwakeForm_FormClosed;

                awakeForm.ShowDialog();
            }

            if(alarmState.IsSoundActive && alarmState.IsAwakeActived)
            {
                SystemSounds.Beep.Play();
            }

        }

        private void AwakeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= AwakeForm_FormClosed;
            UpdateControls();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm();
            form.AlarmState = alarmState;
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateControls();
            }
        }

        private void UpdateControls()
        {
            if (alarmState.IsAlarmActive)
            {
                Text = $"Будильник (ожидает срабатывания в {alarmState.AlarmTime.ToShortTimeString()})";
            }
            else
            {
                Text = $"Будильник";
            }
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            sec++;

            if (sec >= 60)
            {
                sec = 0;
                min++;

                if(min >= 60)
                {
                    min = 0;
                    hour++;
                }
            }

            labelSeconds.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
        }

        private void StartTimerButton_Click(object sender, EventArgs e)
        {
            timerSeconds.Enabled = true;
        }

        private void StopSecondButton_Click(object sender, EventArgs e)
        {
            timerSeconds.Enabled = false;
        }

        private void ResetSecondButton_Click(object sender, EventArgs e)
        {
            timerSeconds.Enabled = false;

            hour = 0;
            min = 0;
            sec = 0;

            labelSeconds.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
        }
    }
}
