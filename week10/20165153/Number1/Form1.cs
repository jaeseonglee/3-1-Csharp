/*	실습 1번
	작성일 : 2020.05.29 
    작성자 : 20165153 이재성
	프로그램 설명 : 다음과 같이 파일 입출력을 수행하는 프로그램을 작성하시오.
    	‘파일 저장’ 버튼 클릭 : 텍스트 상자에 입력된 데이터를 파일에 저장하고, 파일명을 폼 제목으로 변경
	    ‘파일 불러오기’ 버튼 클릭 :  해당 파일을 읽어 메시지 상자로 출력, 이때 메시지 상자 제목표시줄에 파일명이 출력되도록 한다.
	    ‘리셋’ 버튼 클릭 :  텍스트 상자에 출력된 모든 데이터 삭제 & 폼 제목을 “파일 입출력”으로 변경
	    ‘종료’ 버튼 클릭 : 폼 종료
	    파일을 선택하지 않으면 메시지 상자로 “선택한 파일이 없습니다”를 출력
	    대화상자를 실행했을 때 기본 디렉토리를 임의로 설정할 것
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
using System.IO;        // 파일 입출력 사용을 위해 using

namespace Number1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void filesave(string filename)  // 파일 저장
        {
            using (StreamWriter sr = new StreamWriter(filename))
            {
                sr.WriteLine(textBox1.Text);        // 텍스트박스의 내용을 읽어서 저장
            }
            this.Text = filename;       // 폼의 제목을 파일의 절대경로로 초기화
        }

        private void fileopen(string filename)  // 파일 열기
        {
            string text = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                    text += sr.ReadLine() + "\r\n";   // 파일의 내용을 읽어 text변수에 저장
            }
            MessageBox.Show(text, filename);    // 파일의 내용 출력, 메세지 박스의 이름을 파일의 절대경로로 지정
        }


        private void button1_Click(object sender, EventArgs e)  // 파일 저장 버튼
        {
            saveFileDialog1.InitialDirectory = @"C:\";  // 기본 디렉토리 설정
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt |모든 파일(*.*)|*.*";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();       // 모달 방식

            if (saveFileDialog1.FileName != "")
            {
                filesave(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("선택한 파일이 없습니다", "파일 저장 대화상자");
            }
        }

        private void button2_Click(object sender, EventArgs e) // 파일 불러오기 버튼
        {
            openFileDialog1.InitialDirectory = @"C:\";  // 기본 디렉토리 설정
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt |모든 파일(*.*)|*.*";
            openFileDialog1.Multiselect = false;    
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();   // 모달 방식

            if (openFileDialog1.FileName != "")
            {
                fileopen(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("선택한 파일이 없습니다", "파일 저장 대화상자");
            }
        }

        private void button3_Click(object sender, EventArgs e) // 리셋 버튼
        {
            textBox1.Text = string.Empty;   // 텍스트의 박스의 내용을 공백으로 초기화
            this.Text = "파일 입출력";       // 폼의 이름을 "파일 입출력"으로 초기화
        }
        
        // 종료 버튼 
        private void button4_Click(object sender, EventArgs e) => Close();
    }
}
