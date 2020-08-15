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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => Close();

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ((Form1)Owner).textBox1.Text = e.Start.ToShortDateString();
        }
    }
}
