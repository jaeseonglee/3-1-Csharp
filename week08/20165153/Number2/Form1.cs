/*  실습 2번
 *	작성일 : 2020.05.17 ~ 18
 *  작성자 : 20165153 이재성
 *	프로그램 설명 : 다음과 같은 형태로 버튼을 배치하고 제시한 조건대로 처리하는 프로그램을 작성하시오
	[BringToFront] 버튼 클릭 : button2를 맨 위로 이동
	[SendToBack] 버튼 클릭 : button2를 맨 아래로 이동
	[Disable] 버튼 클릭 : button1 을 비활성화
	[Enable] 버튼 클릭 : button1 을 활성화
	[Show] 버튼 클릭 : button3 버튼을 보이게 함
	[Hide] 버튼 클릭 : button3 버튼을 사라지도록 함
	클릭한 버튼 이름을 제목 표시줄에 출력
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
        Button[] buttonArr;             // button을 저장할 배열 선언

        public Form1()
        {
            InitializeComponent();
            buttonArr = new Button[] { button1, button2, button3}; // button1,2,3을 배열로 저장
        }

        private void button4_Click(object sender, EventArgs e) // BringToFront 버튼
        {
            buttonArr[1].BringToFront();    // button2를 BringToFront로 컨트롤
            Text = "BringToFront";          // Text를 BringToFront로 변경
        }

        private void button5_Click(object sender, EventArgs e) // SendToBack 버튼 
        {
            buttonArr[1].SendToBack();      // button2를 SendToBack로 컨트롤
            Text = "SendToBack";            // Text를 SendToBack로 변경
        }

        private void button6_Click(object sender, EventArgs e)  // Disable 버튼
        {
            buttonArr[0].Enabled = false;   // Enabled값을 false를 초기화
            Text = "Disable";               // Text를 Disable로 변경
        }

        private void button7_Click(object sender, EventArgs e) // Enable 버튼
        {
            buttonArr[0].Enabled = true;    // Enabled값을 true로 초기화
            Text = "Enable";                // Text를 Enable로 변경
        }

        private void button8_Click(object sender, EventArgs e)  // Show 버튼
        {
            buttonArr[2].Show();        // button3을 Show로 컨트롤
            Text = "Show";              // Text를 Show로 변경
        }

        private void button9_Click(object sender, EventArgs e)  // Hide 버튼
        {
            buttonArr[2].Hide();        // button3을 Hide로 컨트롤
            Text = "Hide";              // Text를 Hide로 변경
        }
    }
}
