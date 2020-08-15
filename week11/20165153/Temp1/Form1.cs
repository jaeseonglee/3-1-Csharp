using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(this.Form1_MouseWheel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = 0;
            textBox1.Text = num.ToString();
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            textBox1.Text = (e.Delta > 0 ? num++ : num--).ToString();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            string str = $"Mouse Position {mousePoint.X}, {mousePoint.Y}";
            textBox2.Text = str;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e) => textBox1.BackColor = Color.Blue;


        private void textBox1_MouseMove(object sender, MouseEventArgs e) => textBox1.BackColor = Color.Brown;
        
    }
}
