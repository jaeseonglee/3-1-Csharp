/*	실습 2번
	작성일 : 2020.05.29 
    작성자 : 20165153 이재성
	프로그램 설명 : 텍스트 상자에 입력한 데이터의 글꼴과 텍스트 상자 배경색을 변경하는 프로그램을 작성하시오  
	    ‘색상 추가’ 체크 상자 체크 : 폰트 글꼴 대화상자에 색 콤보 박스 추가
	    인쇄하기 버튼 클릭 : pdf 파일로 텍스트 상자에 입력된 데이터 출력

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
using System.Drawing.Printing;  // 인쇄하기 작업을위해 using

namespace Number2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // 글꼴 변경 버튼
        {
            if (checkBox1.Checked)      // 체크 박스가 체크 되었다면
                fontDialog1.ShowColor = true;   // 색상도 같이 변경

            fontDialog1.ShowDialog();       // 모달 방식으로 열기
            textBox1.Font = fontDialog1.Font;   // 폰트 지정한대로 초기화
            textBox1.ForeColor = fontDialog1.Color; // 색상 지정한대로 초기화

            fontDialog1.ShowColor = false;      // 전부 끝나면 변경 여부를 다시 false로 지정
        }

        private void button2_Click(object sender, EventArgs e)  // 배경색 변경 버튼
        {
            colorDialog1.ShowDialog();      // 모달 방식으로 열기
            textBox1.BackColor = colorDialog1.Color; // 배경색상 지정한대로 초기화
        }

        private void button3_Click(object sender, EventArgs e)      // 인쇄하기 버튼
        {
            printDialog1.PrinterSettings = new PrinterSettings();   //프린터 설정
            printDialog1.Document = printDocument1;              //인쇄 문서 설정
            DialogResult result = printDialog1.ShowDialog();      // 모달 방식

            if (result == DialogResult.OK)
            {
                //print()함수 호출로 printDocument의 PrintPage이벤트 처리
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 10, 10);
            // 텍스트 박스의 내용과 폰트로 출력, pdf 파일의 글씨 색은 검정으로 지정
        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            MessageBox.Show(printDocument1.DocumentName + " 인쇄 완료");
        }

    }
}
