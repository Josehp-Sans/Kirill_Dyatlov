using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class SettingsForm : Form
    {
        public AlarmState AlarmState {  get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (AlarmState.AlarmTime < DateTime.Now)
            {
                TimetextBox.Text = DateTime.Now.AddHours(1).ToShortTimeString();
            }
            else
            {
                TimetextBox.Text = AlarmState.AlarmTime.ToShortTimeString();
            }

            MessagetextBox.Text = AlarmState.AlarmMassage;
            ActivecheckBox.Checked = AlarmState.IsAlarmActive;
            SoundcheckBox.Checked = AlarmState.IsSoundActive;
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if(!TimeSpan.TryParse(TimetextBox.Text, out TimeSpan duration))
            {
                MessageBox.Show("Введено неверное время","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(duration > DateTime.Now.TimeOfDay)
            {
                AlarmState.AlarmTime = DateTime.Today + duration;
            }
            else
            {
                AlarmState.AlarmTime = DateTime.Today.AddDays(1) + duration;
            }

            AlarmState.AlarmMassage = TimetextBox.Text;
            AlarmState.IsAlarmActive = ActivecheckBox.Checked;
            AlarmState.IsSoundActive = SoundcheckBox.Checked;

            DialogResult = DialogResult.OK;
        }
    }
}
