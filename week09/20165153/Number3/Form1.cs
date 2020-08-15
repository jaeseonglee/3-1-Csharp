/*	실습 3번
	작성일 : 2020.05.24 ~25
    작성자 : 20165153 이재성
	프로그램 설명 : 수업 자료에 제시된 리스트 기반 컨트롤 예제를 활용하여 다음과 같이 실행되는 프로그램을 작성하시오
	‘콤보 상자에 추가’ 버튼 클릭 : 텍스트 상자에 입력된 값을 콤보 상자에 추가 후 텍스트 상자에서 제거 
	단, 텍스트 상자에 입력 값이 없으면 메시지 상자로 경고문 출력
	‘리스트에 추가’ 버튼 클릭 : 체크리스트 상자에서 선택한 항목을 리스트에 추가
	단, 추가하는 항목을 메시지 상자로 출력

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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)     // 폼이 로딩과 동시에
        {       
            listBox1.Items.Add("Button");       // 리스트 박스에 항목 추가
            listBox1.Items.Add("CheckBox");
            listBox1.Items.Add("RadioButton");
            listBox1.Items.Add("Label");

            checkedListBox1.Items.Add("영화감상");      // 체크 리스트에도 항목들을 추가
            checkedListBox1.Items.Add("음악감상");
            checkedListBox1.Items.Add("스키");
            checkedListBox1.Items.Add("스노우보드");
            checkedListBox1.Items.Add("수영");
            checkedListBox1.Items.Add("농구");
            checkedListBox1.Items.Add("장기");
            checkedListBox1.Items.Add("골프");
            checkedListBox1.Items.Add("바둑");
            checkedListBox1.Items.Add("축구");
        }

        private void button1_Click(object sender, EventArgs e) // >> 버튼
        {
            if (listBox1.SelectedItem != null)  // 리스트박스에서 선택한 항목이 있고
            {
                if (!comboBox1.Items.Contains(listBox1.SelectedItem))   // 콤보박스에도 그 항목이 없으면
                    comboBox1.Items.Add(listBox1.SelectedItem);     // 항목을 추가해준다.

                listBox1.Items.Remove(listBox1.SelectedItem);       // 기존의 항목은 지워준다.
            }

        }

        private void button2_Click(object sender, EventArgs e)  // << 버튼
        {
            if (comboBox1.SelectedItem != null) // 콤보박스에서 선택한 항목이 있고
            {
                if (!listBox1.Items.Contains(comboBox1.SelectedItem)) // 리스트 박스에도 그 항목이 없으면
                    listBox1.Items.Add(comboBox1.SelectedItem);     // 항목을 추가해준다
                
                comboBox1.Items.Remove(comboBox1.SelectedItem);     // 기존의 항목은 지워주고
                comboBox1.Text = "";            // 콤보박스의 텍스트도 공백으로 비워준다
            }
        }

        private void button3_Click(object sender, EventArgs e)  // 텍스트상자의 내용 콤보박스에 추가
        {
            if (textBox1.Text == "")          // 텍스트상자에 아무것도 없다면 
                MessageBox.Show("입력데이터가 없습니다.", "입력오류");    // 메세지박스로 출력
            else
            {
                 if (!comboBox1.Items.Contains(textBox1.Text))  // 콤보박스에도 텍스트상자의 내용이 없다면
                    comboBox1.Items.Add(textBox1.Text);         // 그 항목을 추가해준다

                 textBox1.Text = "";            // 텍스트 상자의 텍스트도 공백으로 비워준다
            }
        }

        private void button4_Click(object sender, EventArgs e) // 체크리스트 상자의 내용을 리스트박스로 추가
        {
            string str = string.Empty;          // 문자열 변수 선언 및 초기화
            foreach(var obj in checkedListBox1.CheckedItems)    // foreach문으로 현재 선택된 항목들을 가지고
            {
                if (!listBox1.Items.Contains(obj)) {    // 리스트박스에 그 항목들이 없다면
                    listBox1.Items.Add(obj);            // 그 항목을 추가해주고     
                    str += obj.ToString() + "\n\r";     // str에 항목들을 연결해준다
                }
            }
            if(str != "")           // 반복문이 끝나고 str이 공백이 아니라면
                MessageBox.Show($"{str}리스트 상자에 추가", "항목 추가");   // 메세지박스로 어떤 항목이 추가되었는지 출력
        }

        
    }
}
