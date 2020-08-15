/*	실습 2번
	작성일 : 2020.05.23 ~25
    작성자 : 20165153 이재성
	프로그램 설명 : 라디오버튼과 체크 상자, 버튼을 이용하여 레이블의 정렬과 스타일, 배경색을 변경하는 프로그램을 작성하시오.  
	버튼을 클릭할 때 마다 레이블 배경색은 임의의 색으로 변경한다
    힌트) 색상 : Color[] colors = { Color.DarkOrange, Color.Blue, Color.Brown, Color.DarkGreen, Color.Cyan};
	붉은색 박스는 버튼 컨트롤, 파란색박스는 레이블 컨드롤
	폰트 변경 : Font font = new Font(label3.Font, label3.Font.Style | FontStyle.Bold)
	폰트 되돌리기(취소) : Font font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Bold)
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;           // 레이블에서 문자열 정렬을 위해 사용됨
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number2
{
    public partial class Form1 : Form
    {
        Random r = new Random();        // 난수 생성 Random 클래스
        Color[] colors = { Color.DarkOrange, Color.Blue, Color.Brown, Color.DarkGreen, Color.Cyan };
        // 색상 배열 선언 및 초기화
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();       // 종료 버튼, 폼 종료
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = r.Next(0, colors.Length); // 0부터 색상배열의 크기-1 까지 난수 생성
            label3.BackColor = colors[index];     // 그 인덱스에 해당하는 배열의 값으로 색상을 바꿔준다
        }
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;     // sender를 RadioButton 형변환
            switch (rb.Text)        // 텍스트에 따라 위치 변경
            {
                case "왼쪽":
                    label3.TextAlign = ContentAlignment.MiddleLeft; // 왼쪽
                    break;
                case "가운데":
                    label3.TextAlign = ContentAlignment.MiddleCenter;   // 가운에
                    break;
                case "오른쪽":
                    label3.TextAlign = ContentAlignment.MiddleRight;    // 오른쪽
                    break;
                default:
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;       // sender를 CheckBox 형변환
            bool checkState = cb.Checked;   // 체크박스클릭이후 현재 체크 박스가 체크 되어있는지 확인
            switch (cb.Text)        // switch문에서 체크 여부에 따라 글씨의 스타일을 변경
            {
                case "굵게":
                    if(checkState) 
                        label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Bold);
                    else
                        label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Bold);
                    break;

                case "밑줄":
                    if (checkState)
                        label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Underline);
                    else
                        label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Underline);
                    break;

                case "이탤릭":
                    if (checkState)
                        label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Italic);
                    else
                        label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Italic);
                    break;

                case "취소선":
                    if (checkState)
                        label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Strikeout);
                    else
                        label3.Font = new Font(label3.Font, label3.Font.Style ^ FontStyle.Strikeout);
                    break;

                default:
                    break;
            }
        }
    }
}
