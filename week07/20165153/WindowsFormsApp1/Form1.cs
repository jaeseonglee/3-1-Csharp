using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Form form;
       
        void formSet()
        {
            form = new Form
            {
                Text = "Second Form",
                TopMost = true,
                StartPosition = FormStartPosition.CenterScreen
            };
        }


        public Form1()
        {
            InitializeComponent();
            formSet();
        }

        private void button1_Click(object sender, EventArgs e) // Show/Hide
        {
            if (form.Visible)
                form.Hide();
            else
            {
                form.Text = ((Button)sender).Text;
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) // form Create
        {
            if (form.IsDisposed)
            {
                formSet();
            }
            form.Show();
        }
    }
}
