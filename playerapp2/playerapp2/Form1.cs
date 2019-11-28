using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace playerapp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VideoCapture _capture;
        private void button1_Click(object sender, EventArgs e)
        {

            string filename = openFile();
            _capture = new VideoCapture(filename);
           
            Application.Idle += ProcessFrame;
            //apture.ImageGrabbed += ProcessFrame;
            CvInvoke.WaitKey(0);
            
        }
        private string openFile()
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Title = "Select video file..";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Select video file..";
            openFileDialog1.DefaultExt=".avi";
            openFileDialog1.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3;*.mp4|All Files|*.*";
            string filename = openFileDialog1.FileName;
            return filename;
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            Mat frame = _capture.QueryFrame();
            if (frame != null)
            {
                pictureBox1.Image = frame.ToImage<Bgr, Byte>().ToBitmap();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            { 
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mousemove m = new mousemove();
            m.Show();
            this.Hide();
        }
    }
}
