/*	실습 1번
	작성일 : 2020.05.17 ~ 18
    작성자 : 20165153 이재성
	프로그램 설명 : 폼의 크기가 변경되어도 폭은 300에서 500이고, 높이는 300에서 700사이만 가능한 프로그램을 작성하시오.
	힌트1) 폭과 높이는 Width, Height 프로퍼티
	힌트2) Resize 이벤트 핸들러 – 폼 크기가 변경되는 이벤트가 발행하면 폭과 높이가 지정한 범위 내에 있는지 검사하여 범위내로만 변경되도록 한다
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
        public Form1()
        {
            InitializeComponent();
        }

        private void PrintHeightWidth()     // PrintHeightWidth 메소드 생성
        {
            button1.Text = $"Height = {Height}\nWidth = {Width}"; // 버튼을 현재 폭과 높이로 초기화
        }
        private void Form1_Resize(object sender, EventArgs e)   // Resize를 통해 폭과 높이 조정
        {
            if (Height < 300)       // 높이가 300보다 작으면
                Height = 300;       // 300으로 초기화
            else if (Height > 700)  // 높이가 700보다 크다면 
                Height = 700;       // 700으로 초기화

            if (Width < 300)        // 폭이 300보다 작으면
                Width = 300;        // 300으로 초기화
            else if (Width > 500)   // 폭이  500보다 크다면
                Width = 500;        // 500으로 초기화

            PrintHeightWidth();     // 메소드 호출로 현재 폭과 높이 확인
        }

        private void Form1_Load(object sender, EventArgs e) // Load를 통해 처음 폼이 켜질 때
        {
            PrintHeightWidth();     // 현재 폭과 높이 확인
        }
    }
}
