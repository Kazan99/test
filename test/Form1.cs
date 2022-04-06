using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        int a = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = a - 1;

            if (trackBar1.Value <=  2)
            {
                textBox1.BackColor = System.Drawing.Color.Red;
                timer1.Stop();
                //a = 0;
                //trackBar1.Value = 0;

            }
            trackBar1.Value = a;
            label1.Text = trackBar1.Value.ToString();

            //Form1_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text.ToString());

            timer1.Enabled = true;
            timer1.Interval = 1000;
            //timer1.Tick += timer1_Tick;


            textBox1.BackColor = System.Drawing.Color.Green;
            trackBar1.Value = a;
            label1.Text = trackBar1.Value.ToString();

            timer1.Start();
        }
    }
}
