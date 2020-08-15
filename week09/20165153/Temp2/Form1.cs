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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("춘천");
            comboBox1.Items.Add("서울");
            comboBox1.Items.Add("경기");
            comboBox1.Items.Add("전북");
            comboBox1.Items.Add("강릉");
            comboBox1.Items.Add("원주");
            comboBox1.Items.Add("전남");
            comboBox1.Items.Add("경북");
            comboBox1.Items.Add("경남");
            comboBox1.Items.Add("충북");
            comboBox1.Items.Add("충남");
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = string.Empty;
            string place = comboBox1.SelectedItem.ToString();
            string name = textBox1.Text;
            string pw = textBox2.Text;

            string lang = "언어 ";
            foreach(CheckBox cb in groupBox1.Controls)
            {
                if (cb.Checked)
                    lang += cb.Text + " ";
            }

            item = $"이름: {name} pw: {pw} 거주지: {place} {lang}";
            listBox1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx = listBox1.FindString($"이름: {textBox1.Text}");
            if (idx != -1)
                listBox1.SetSelected(idx, true);
            else
                MessageBox.Show(textBox1.Text + "님은 미등록", "등록확인");
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            string delName = listBox1.SelectedItem.ToString().Substring(4, 3);
            MessageBox.Show($"{delName}님을 삭제합니다.", "삭제확인");
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedItem = null;
            foreach(CheckBox cb in groupBox1.Controls)
            {
                if (cb.Checked)
                    cb.Checked = false;

                listBox1.ClearSelected();
            }
        }
    }
}
