using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int index, time;

        private void timer1_Tick(object sender, EventArgs e)
        {
            index %= imageList1.Images.Count;
            label1.Image = imageList1.Images[index++];
            button1.Text = (++time).ToString();
            progressBar1.Value = index;

            if (progressBar1.Value > progressBar1.Maximum)
                progressBar1.Value = 0;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            index = 0;
            time = 0;
            progressBar1.Maximum = imageList1.Images.Count;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e) => timer1.Stop();

    }
}
