/*	실습 3번
	작성일 : 2020.05.10
    작성자 : 20165153 이재성
	프로그램 설명 : 버튼을 클릭하면 10일전 또는 10일 후의 날짜 정보를
            메시지 박스로 출력하는 윈 폼 어플리케이션을 작성하시오.
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

namespace Number3
{
    public partial class Form1 : Form
    {
        DateTime today;     // DateTime 선언
        int n = 0;          // int형 변수 n 선언 및 0으로 초기화
        public Form1()
        {
            InitializeComponent();
            today = DateTime.Today; // 현재 날짜 저장
        }

        private void button1_Click(object sender, EventArgs e)  // n일 전의 날짜 계산
        {
            if (n > 0)      // n의 값이 양수라면
                n = -10;    // -10으로 초기화
            else
                n -= 10;    // 그게 아니라면 n에 10을 빼준다
            var past = today.AddDays(n);    // 오늘 날짜에서 n만큼 빼준다
            MessageBox.Show("현재 날짜 :" + today.ToShortDateString() + "\n"+ -n + "일 전 날짜 "+ past.ToShortDateString());
            // 출력시 n의 절댓값 표기를 위해 -n으로 출력
        }

        private void button2_Click(object sender, EventArgs e)  // n일 후의 날짜 계산
        {
            if (n < 0)      // n의 값이 음수 라면
                n = 10;     // 10으로 초기화
            else
                n += 10;    // 그게 아니라면 n에 10을 더해준다
            var future = today.AddDays(n);  // 오늘 날짜에서 n만큼 더해준다
            MessageBox.Show("현재 날짜 :" + today.ToShortDateString() + "\n" + n + "일 후 날짜 " + future.ToShortDateString());
        }
    }
}
