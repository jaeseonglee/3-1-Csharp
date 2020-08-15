/*	실습 1번
	작성일 : 2020.06.02 ~ 06.05
    작성자 : 20165153 이재성
	프로그램 설명 : 
    (1)	선택한 메뉴 항목을 폼제목표시줄로 출력
    (2)	데이터 메뉴
    	자료입력 
	    “자료입력” 폼을 모달창으로 실행
	    ‘리스트박스에 저장’ 버튼 클릭 
        - 텍스트박스로 입력된 데이터를 ‘MenuStripApp’폼에 있는 리스트 박스에 추가
        	‘종료’ 버튼 클릭
        - 폼 종료
    	    MouseClick 이벤트
        - 각각의 텍스트 박스를 마우스로 클릭하면 입력 데이터 삭제
        	KeyPress 이벤트
        - ‘연락처’ 텍스트 박스에는 숫자와 ‘-‘문자만 입력. 
        - 단, 연락처 텍스트 박스의 ReadOnly 프로퍼티를 true로 설정  
	전체 삭제 – 리스트박스의 모든 항목을 삭제 
	선택 삭제 – 리스트 박스에서 선택한 항목만 삭제
  
    (3)	편집
        글꼴 대화 상자 – 텍스트 박스의 글꼴과 색 변경
    	색상 대화 상자 – 텍스트 박스의 배경색 변경

    (4)	파일 
    	파일 불러 오기 – 불러온 파일 내용을 리스트 박스로 출력
	    파일 저장 하기 – 리스트 박스 모든 항목을 파일로 저장

    (5)	‘Esc’키를 눌러도 main 폼을 종료할 수 있도록 한다
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
using System.IO;    // 파일 입출력 사용을 위해 using

namespace Number1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 자료입력NToolStripMenuItem_Click(object sender, EventArgs e) // 자료 입력
        {
            this.Text = "자료입력";     // 폼의 제목을 자료입력으로 바꾸고
            Form2 form2 = new Form2(); // Form2를 생성
            form2.Owner = this;        // Owner를 this로 바꿔주고
            form2.ShowDialog();        // 모달 방식 폼을 띄운다
        }  

        private void 전체삭제XToolStripMenuItem_Click(object sender, EventArgs e)   // 전체삭제
        {
            this.Text = "전체삭제";     // 폼의 제목을 전체 삭제로 바꾸고
            listBox1.Items.Clear();     // 리스트 박스의 내용 전체삭제
        }

        private void 선택삭제PToolStripMenuItem_Click(object sender, EventArgs e) // 선택 삭제
        {
            this.Text = "선택삭제";     // 폼의 제목을 선택 삭제로 바꾸고
            while (listBox1.SelectedItems.Count > 0)    // while 반복문, 선택 항목이 없을때까지 반복
                listBox1.Items.Remove(listBox1.SelectedItem);  // 선택된 아이템을 하나씩 제거
        }

        private void 글꼴대화상자TToolStripMenuItem_Click(object sender, EventArgs e) // 글꼴 대화 상자
        {
            this.Text = "글꼴 대화 상자";     // 폼의 제목을 글꼴 대화 상자로 바꾸고
            fontDialog1.ShowColor = true;    // 색상도 변경할수 있게 true로 변경
            fontDialog1.ShowDialog();        // 모달 방식
            textBox1.Font = fontDialog1.Font;   // 글꼴 대화 상자의 폰트로 변경
            textBox1.ForeColor = fontDialog1.Color;     // 색상도 변경
        }

        private void 색상대화상자CToolStripMenuItem_Click(object sender, EventArgs e) // 색상대화상자
        {   
            this.Text = "색상 대화 상자";         // 폼의 제목을 색상 대화 상자로 바꾸고
            colorDialog1.ShowDialog();          // 모달 방식
            textBox1.BackColor = colorDialog1.Color; // 배경색을 바꿔준다.
        }

        private void fileopen(string filename)  // 파일 열기
        {
            listBox1.Items.Clear(); // 리스트 박스를 내용을 비워주고
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                    listBox1.Items.Add(sr.ReadLine() + "\r\n");
                // 파일의 한줄씩읽어 리스트박스의 Items에 추가해준다.
            }
        }

        private void 파일불러오기DToolStripMenuItem_Click(object sender, EventArgs e) // 파일 불러오기
        {
            this.Text = "파일 불러 오기";         // 폼의 제목을 파일 불러 오기로 바꾸고
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
                MessageBox.Show("선택한 파일이 없습니다", "파일 불러오기 실패");
            }
        }

        private void filesave(string filename)  // 파일 저장
        { 
            using (StreamWriter sr = new StreamWriter(filename))
            {
                foreach (var i in listBox1.Items) // foreach 반복문으로 
                    sr.WriteLine(i);        // 리스트박스의 내용을 한줄씩 읽어서 저장
            }
        }
        private void 파일저장하기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "파일 저장 하기";         // 폼의 제목을 파일 저장 하기로 바꾸고
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
                MessageBox.Show("선택한 파일이 없습니다", "파일 저장하기 실패");
            }
        }
        private void formClose()
        {
            this.Text = "종료";         // 폼의 제목을 종료로 바꾸고
            MessageBox.Show("MenuStripApp폼 종료", "폼 종료");
            this.Close();
        }
        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e) => formClose();

        private void Form1_KeyDown(object sender, KeyEventArgs e)   // 폼에 대한 키보드 입력시 발생
        {
            if (e.KeyCode == Keys.Escape)       // ESC 키를 누르면 폼 종료
                formClose();
        }
    }
}
