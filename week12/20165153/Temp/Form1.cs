using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ListViewItem listAdd()
        {
            string name = textBox1.Text;
            string age = textBox2.Text;
            string address = textBox3.Text;

            return new ListViewItem(new string[] {name, age, address });
        }

        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(listAdd());
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection sub = item.SubItems;
                sub[0].Text = textBox1.Text;
                sub[1].Text = textBox2.Text;
                sub[2].Text = textBox3.Text;
            }
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item); 
            }
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int index = item.Index;
                listView1.Items.Insert(index, listAdd());
            }
            clear();
        }

        private void button5_Click(object sender, EventArgs e) => clear();

        private void listView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection sub = item.SubItems;
                textBox1.Text = sub[0].Text;
                textBox2.Text = sub[1].Text;
                textBox3.Text = sub[2].Text;
            }
        }
    }
}
