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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            MessageBox.Show(cb.Text + ":" + cb.CheckState, "CheckedChanged Event");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (Control ct in this.Controls)
            {     //폼안의 컨트롤들을 꺼내오기
                CheckBox cb = ct as CheckBox;        // 체크박스로 형 변환
                if (cb != null && cb.Checked == true)   // 체크된 체크박스만 확인
                    msg += cb.Text + ";";
                  }
            MessageBox.Show(msg, "Checked");
        }
    }
}
