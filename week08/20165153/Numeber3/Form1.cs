/*  실습 3번
 *	작성일 : 2020.05.17 ~ 18
 *  작성자 : 20165153 이재성
 *	프로그램 설명 : ‘초기화’ 버튼을 클릭하면 체크되어 있는 상태를 체크 해제가 되는 프로그램을 작성하시오. 
 *	            단, 종료 버튼을 클릭하면 폼을 종료한다.
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

namespace Numeber3
{
    public partial class Form1 : Form
    {
        CheckBox []checkBoxArr; // 체크박스 배열 생성
        public Form1()
        {
            InitializeComponent();
            checkBoxArr = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };
                // 체크 박스들을 배열로 초기화
        }

        private void button1_Click(object sender, EventArgs e)  // 초기화 버튼
        {
            foreach (CheckBox ct in checkBoxArr)        // foreach 반복문
                ct.CheckState = CheckState.Unchecked;   // 모든 버튼의 CheckState를 Unchecked로 초기화

            MessageBox.Show("모든 체크 박스 초기화", "초기화"); // 메세지 박스 출력
        }

        private void button2_Click(object sender, EventArgs e)  // 종료 버튼
        {
            MessageBox.Show("종료", "종료");        // 메세지 박스 출력
            this.Close();        // Close를 통해 폼 종료
        }
    }
}
