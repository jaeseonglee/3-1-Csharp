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

        Form2 pen;

        private void Form_Creation(string text)
        {
            pen = new Form2();
            pen.Text = text;
            pen.Owner = this;
            pen.StartPosition = FormStartPosition.CenterScreen;
            pen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Creation(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Creation(button2.Text);
        }
    }
}
