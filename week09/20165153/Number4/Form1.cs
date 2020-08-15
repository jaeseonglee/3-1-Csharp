/*	실습 4번
	작성일 : 2020.05.24 ~25
    작성자 : 20165153 이재성
	프로그램 설명 : 제시된 결과처럼 실행되는 프로그램을 작성하시오
	입학년도 : 콤보박스, 폼 로드시 항목을 추가 할 것
	결과 : 리스트박스
	등록 버튼 클릭 : 리스트 박스에 추가
	삭제 버튼 클릭 : 선택된 항목 리스트 박스에서 제거
	종료 버튼 클릭 : 프로그램 종료
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

namespace Number4
{
    public partial class Form1 : Form
    {
        string str = string.Empty;      // 리스트에 출력할 내용을 저장할 str
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // 폼을 로딩할때
        {
            for(int i = 2000; i <= 2020; i++ )  // 반복문을 통해
            {
                comboBox1.Items.Add(i.ToString());  // 콤보박스의 내용을 추가한다.
            }
        }

        private bool checkInfo()        // 폼에서 체크된 정보가 전부 입력되었는지 확인하는 메소드
        {
            int cnt = 0;        // cnt 선언 및 0으로 초기화
            if(textBox1.Text == "") // 이름을 입력하는 텍스트 박스에 아무것도 없으면 
            {
                MessageBox.Show("이름을 입력해주세요!", "입력 오류");    // 이름을 입력달라고 출력
                return false;   
            } else if( comboBox1.Text == "")        // 입학년도가 선택되지 않았다면
            {
                MessageBox.Show("입학년도을 선택해주세요!", "입력 오류");  // 년도를 선택해달라고 출력
                return false;
            }

            str += $"이름: {textBox1.Text}, ";          // 위의 두 조건문을 통과하면 정보가 있으므로 
            str += $"입학년도: {comboBox1.Text}, ";     // str에 이름과 입학년도에 대한 정보를 추가한다.

            foreach (RadioButton ct in groupBox1.Controls)  
            {
                if (ct.Checked)         // 학점 선택란에 선택된 학점이 있다면
                {  
                    cnt++;              // cnt를 증가시키고
                    str += $"평점: {ct.Text}, "; // 학점을 str에 추가
                }
            }
            if(cnt == 0)        // 반복문에서 cnt 값이 증가하지 않았다면
            {
                MessageBox.Show("직전 학기 등급을 선택해주세요!", "입력 오류");  // 학점을 선택해달라고 출력
                return false;
            }

            cnt = 0;            // 다시 cnt를 0으로 초기화
            str += "이수과목: "; // 이수과목에 대한 str 작성
            foreach (CheckBox cb in groupBox2.Controls)
            {
                if (cb.Checked)     // 이수과목란에 선택된 과목이 있으면
                {
                    cnt++;              // cnt를 증가시키고
                    str += cb.Text + " "; // 그 과목을 추가시킨다.
                }
            }
            if (cnt == 0)       // 반복문에서 cnt 값이 증가하지 않았다면
            {
                MessageBox.Show("이수 과목을 선택해주세요!", "입력 오류"); // 이수 과목을 선택해달라고 출력
                return false;
            }

            return true;        // 모든 정보가 입력되어 모든 조건문을 만족시키면 true를 반환한다.
        }

        private void button1_Click(object sender, EventArgs e)  // 등록 버튼
        {

            if (checkInfo())       // checkInfo 호출 및 str 값을 새로 초기화
            {
                listBox1.Items.Add(str);    // checkInfo를 통해 얻은 str을 리스트 박스에 추가

                str = string.Empty;     // 등록이 끝나면 폼에 있는 정보를 지운다.
                textBox1.Clear();       // 텍스트박스와
                comboBox1.Text = "";    // 콤보 박스의 텍스트를 지워주고

                // 두 그룹박스에 있는 내용, 즉 체크 상태를 false로 바꿔준다.
                foreach (RadioButton ct in groupBox1.Controls)
                    ct.Checked = false;
                foreach (CheckBox cb in groupBox2.Controls)
                    cb.Checked = false;
            }
            else
                str = string.Empty; // checkInfo가 false를 반환했다면 str를 다시 초기화해준다.
        }

        private void button2_Click(object sender, EventArgs e)  // 삭제 버튼
        {
            if(listBox1.Items.Count == 0)           // 리스트 박스에 아무것도 없으면
                MessageBox.Show("목록이 없습니다!", "삭제 오류!"); // 목록이 없다고 출력
            else if (listBox1.SelectedItem == null) // 선택이 안되었으면 
                MessageBox.Show("삭제할 목록을 선택해주세요!", "삭제 오류!"); // 선택해 달라고 출력
            else
                listBox1.Items.Remove(listBox1.SelectedItem);   // 선택한 목록 삭제
        }

        private void button3_Click(object sender, EventArgs e)  // 종료 버튼 
        {
            this.Close();
        }
    }
}
