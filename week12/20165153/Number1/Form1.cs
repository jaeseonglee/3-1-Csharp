/*	실습 1번
	작성일 : 2020.06.05 ~ 06.07
    작성자 : 20165153 이재성
	프로그램 설명 : 트랙 바에서 선택한 값에 따라 레이블 배경색을 변경하는 프로그램을 작성하시오.
    힌트) 레이블 배경 채우기 : label1.BackColor = Color.FromArgb(trackBar1.Value,  ,  );
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

        private void colorResult()      // label1의 배경색을 결정하는 colorresult 
        {
            label1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            //label1.BackColor = Color.FromArgb(int.Parse(label2.Text), int.Parse(label3.Text), int.Parse(label4.Text));
            // 트랙바의 Value대신에 label의 텍스트로 해도 된다. 이때는 int형이 지정되어야하니 형변환 필수
        }

        private void trackBar1_Scroll(object sender, EventArgs e) // Red 트랙바
        {
            label2.Text = trackBar1.Value.ToString();   // 트랙바를 움직인 만큼 텍스트를 바꿔주고
            colorResult();      // 배경색 결정
        }

        private void trackBar2_Scroll(object sender, EventArgs e) // Green 트랙바
        {
            label3.Text = trackBar2.Value.ToString(); // 트랙바를 움직인 만큼 텍스트를 바꿔주고
            colorResult();      // 배경색 결정
        }

        private void trackBar3_Scroll(object sender, EventArgs e) // Blue 트랙바
        {
            label4.Text = trackBar3.Value.ToString(); // 트랙바를 움직인 만큼 텍스트를 바꿔주고
            colorResult();      // 배경색 결정
        }
    }
}
