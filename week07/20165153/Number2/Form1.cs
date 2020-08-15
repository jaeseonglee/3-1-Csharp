/*	실습 2번
	작성일 : 2020.05.10
    작성자 : 20165153 이재성
	프로그램 설명 : 	폼 테두리 모양과 폼 제목을 클릭한 버튼으로 변경하는 프로그램을 작성하시오
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // FixedSingle 버튼
        {
            Text = "FixedSingle";           // 폼의 이름과 테두리 모양을 
            FormBorderStyle = FormBorderStyle.FixedSingle; // FixedSingle로 변경
        }

        private void button2_Click(object sender, EventArgs e)  // None 버튼
        {
            Text = "None";       // None의 경우 이름이 안나온다.
            FormBorderStyle = FormBorderStyle.None; // 테두리 모양을 None으로 변경
        }

        private void button3_Click(object sender, EventArgs e)  // FixedDialog 버튼
        {
            Text = "FixedDialog";           // 폼의 이름과 테두리 모양을 
            FormBorderStyle = FormBorderStyle.FixedDialog; //FixedDialog로 변경
        }

        private void button4_Click(object sender, EventArgs e)  // FixedToolWindow 버튼
        {
            Text = "FixedToolWindow";      // 폼의 이름과 테두리 모양을 
            FormBorderStyle = FormBorderStyle.FixedToolWindow;// FixedToolWindow 버튼
        }
    }
}
