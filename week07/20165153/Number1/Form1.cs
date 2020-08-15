/*	실습 1번
	작성일 : 2020.05.10
    작성자 : 20165153 이재성
	프로그램 설명 : 폼이 로드 될 때와 종료될 때의 시간 정보를 출력하는 윈 폼 어플리케이션을 작성하시오. 
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

namespace Number1
{
    public partial class Form1 : Form
    {
        DateTime startTime,closeTime;       // Datetime 선언
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // 로드할 때 발생하는 이벤트
        {
            startTime = DateTime.Now;       // 로드할 때 현재 시간 저장
            MessageBox.Show(startTime.ToString(),"로딩...");  // 시간과 폼의 이름을 "로딩..."으로 출력
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // 종료시의 발생
        {
            closeTime = DateTime.Now;       // 종료시의 현재 시간 저장
            MessageBox.Show(closeTime.ToString(), "클로징..."); // 시간과 폼의 이름을 "클로징..."으로 출력
        }
    }
}
