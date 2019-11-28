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
    public partial class mousemove : Form
    {
        public mousemove()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        

        private void mousemove_Load(object sender, EventArgs e)
        {
            utility.startstopwatch();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }
        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            utility.ImageBoxMouseMove(ref imageBox1, ref sender, ref e, ref textBox1, ref imageBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utility.ReadandDrawFromFileCall(ref imageBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            utility.startstopwatch();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            utility.clearimagebox(ref imageBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            utility.savetofile();
        }
    }
}
