/*	실습 1번
	작성일 : 2020.06.13~14
    작성자 : 20165153 이재성
	프로그램 설명 : 제시된 결과처럼 팩맨의 입과 먹이가 움직일 수 있도록 프로그램을 작성하시오
    (힌트:Timer 컴포넌트와 DrawPie() 메소드 사용)
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;       // 도형을 그리기 위해 using
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int num = 0; // int형 변수 num

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();   // 도형을 그리기 위한 그래피 객체
            Rectangle pacMan = new Rectangle(50, 50, 130, 130); // 팩맨을 그릴 Rectangle
            Rectangle circle = new Rectangle(300 - (5 * num), 105, 20, 20); 
            // 먹이를 그릴 Rectangle 시간이 지남에 따라 점점 팩맨쪽으로 가까이 간다.

            if (num++ < 45) // 각도가 45도까지 조정
            {
                graphics.Clear(this.BackColor);    // 폼의 모든 그림을 지우고 
                graphics.FillEllipse(Brushes.Red, circle); // 먹이를 원으로 그린다.

                // 팩맨은 호의 그림으로 그리기 때문에 FillPie로 각도를 조정해준다
                graphics.FillPie(Brushes.Yellow, pacMan, 45 - num, 270 + (2 * num));
                // 팩맨 바깥 선까지 그려준다.
                graphics.DrawPie(new Pen(Color.Black), pacMan, 45 - num, 270 + (2 * num));
            }
        }

        private void Form1_Load(object sender, EventArgs e) // 폼이 시작되면서
        {
            timer1.Start();  // 타이머 시작
        }
    }
}
