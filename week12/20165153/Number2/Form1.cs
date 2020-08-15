/*	실습 2번
	작성일 : 2020.06.05 ~ 06.07
    작성자 : 20165153 이재성
	프로그램 설명 : 제시된 결과처럼 입력한 데이터를 리스트 뷰에 추가하고 리스트 뷰에서 선택한 항목을 삭제하는 프로그램을 작성하세요.
	    추가 버튼 클릭 : 입력된 수량과 단가, 금액(‘수량*단가’)을 리스트 뷰에 추가한 후 모든 컨트롤 초기화 
	    삭제 버튼 클릭 : 리스트 뷰에서 선택한 항목 삭제
	    종료 버튼 클릭 : 실행 중인 폼 종료
	    DomainUpDown 컨트롤에서 선택한 항목을 품목으로 출력
    	NumericUpDown 컨트롤에서 선택한 값을 수량으로 출력
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
        public Form1()
        {
            InitializeComponent();
        }

        private void textClear()        // 버튼 클릭 후 텍스트 박스의 내용을 초기화
        {
            domainUpDown1.Text = "=== 품목 선택 ===";   // 업다운 컨트롤은
            numericUpDown1.Value = 0;                   // 기본 설정한 값으로
            //여기서도 업다운 컨트롤의 SelectedItemChanged 이벤트가 발생하는 것을 주의
            // 0607. 텍스트 37~39행이 먼저 실행되면 오류

            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;   // 텍스트 박스는 공백으로 초기화
            textBox3.Text = String.Empty;
            
        }
        private ListViewItem listAdd()      // 내용 추가 
        {
            string item = textBox1.Text;    // 항목
            string cnt = textBox2.Text;     // 개수
            string money = textBox3.Text;   // 단가
            string result = (int.Parse(cnt) * int.Parse(money)).ToString(); // 총 금액

            return new ListViewItem(new string[] { item, cnt, money, result }); // 4가지 컬럼을 리턴
        }

        private void button1_Click(object sender, EventArgs e)  // 추가 버튼
        {
            listView1.Items.Add(listAdd()); // 리스트뷰에 항목을 추가한다.
            textClear();
        }

        private void button2_Click(object sender, EventArgs e)  // 삭제 버튼
        {
            foreach (ListViewItem item in listView1.SelectedItems)  // 선택된 항목들을
            {
                listView1.Items.Remove(item);   // 반복하며 삭제
            }

            textClear();
        }

        private void button3_Click(object sender, EventArgs e) => this.Close(); // 종료 버튼

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            textBox1.Text = domainUpDown1.Text;     // 업다운 컨트롤 이벤트로 텍스트 박스 초기화
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = numericUpDown1.Value.ToString();    // 업다운 컨트롤 이벤트로 텍스트 박스 초기화
        }

       
    }
}
