using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class AwakeForm : Form
    {
        private const string ImageFolderName = "Images";
        private string[] imageFileNames;
        private int imageIndex;

        public AlarmState AlarmState { get; set; }
        public AwakeForm()
        {
            InitializeComponent();
        }

        private void AwakeForm_Load(object sender, EventArgs e)
        {
            Text = AlarmState.AlarmMassage;
            InitImages();
        }

        private void InitImages()
        {
            imageFileNames = Directory.EnumerateFiles(ImageFolderName).ToArray();
            imageIndex = 0;
            AwakePictureBox.Load(imageFileNames[imageIndex]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imageIndex++;
            if (imageIndex >= imageFileNames.Length)
            {
                imageIndex = 0;
            }
            AwakePictureBox.Load(imageFileNames[imageIndex]);
        }

        private void AwakeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AlarmState.IsAlarmActive = false;
            AlarmState.IsAwakeActived = false;
        }
    }
}
