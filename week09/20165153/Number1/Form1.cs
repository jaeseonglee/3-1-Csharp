/*	실습 1번
	작성일 : 2020.05.23 ~25
    작성자 : 20165153 이재성
	프로그램 설명 :다음과 같이 텍스트상자로 입력된 URL로 이동하는 프로그램을 작성하시오.
	‘완료’ 버튼을 클릭하며 입력된 URL로 이동
	링크레이블 텍스트를 텍스트 상자로 입력된 값으로 변경
	링크레이블을 클릭하여도 해당 URL로 이동
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
using System.Diagnostics;       // 링크 레이블에서 Process를 사용하기 위해 using

namespace Number1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel hyper = (LinkLabel)sender;    // 링크 레이블을 통한 링크 이동
            Process.Start(hyper.Text);          // Process를 통해 해당 텍스트의 링크로 이동
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(linkLabel1.Text);   // 버튼 클릭의 경우 링크 레이블의 텍스트를 통해 연결
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            linkLabel1.Text = "http://" + textBox1.Text;    // 입력될때마다 링크 레이블을 새로 갱신
        }
    }
}
