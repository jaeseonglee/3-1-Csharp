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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("KeyDown Event 폼을 종료합니다.", $"KeyCode: {e.KeyCode.ToString()}");
                Dispose();
            }

            if (e.Modifiers == Keys.None)
                MessageBox.Show($"KeyCode: {e.KeyCode}", "KeyDown Event");
            else if (e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Menu && e.KeyCode != Keys.Shift)
                MessageBox.Show($"KeyCode: {e.Modifiers.ToString()} + {e.KeyCode.ToString()}", "KeyCode Event");
        }
    }
}
