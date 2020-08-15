using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number1
{
    public partial class Form2 : Form
    {
        public Form2()          // Form2
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e) // 모든 텍스트박스 클릭시 발생
        {
            TextBox tb = sender as TextBox;     // sender를 형 변환 해주고
            tb.Text = String.Empty;         // 텍스트박스의 내용을 비워준다
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) // 연락처 입력시
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-') // 숫자와 '-'만을 입력받도록 지정
                textBox2.Text += e.KeyChar;
        }

        private void button1_Click(object sender, EventArgs e)  // 리스트 박스에 저장하기
        {
            string str = String.Empty;
            if (textBox1.Text == "")            // 각각의 텍스트박스의 내용이 없으면 입력해달라고 출력
                MessageBox.Show("이름을 입력해주세요", "입력 오류");
            else if (textBox2.Text == "")
                MessageBox.Show("연락처를 입력해주세요", "입력 오류");
            else if (textBox3.Text == "")
                MessageBox.Show("아이디를 입력해주세요", "입력 오류");
            else if (textBox4.Text == "")
                MessageBox.Show("비밀번호를 입력해주세요", "입력 오류");
            else
            {
                str += textBox1.Text + "\t";    // 모든 텍스트박스의 내용이 있으면 
                str += textBox2.Text + "\t";
                str += textBox3.Text + "\t";
                str += textBox4.Text;
                ((Form1)this.Owner).listBox1.Items.Add(str);    // 리스트박스에 내용 추가
            }
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();
    }
}
