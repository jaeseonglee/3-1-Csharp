/* 윈도우 프로그래밍 기말 프로젝트
 * 빅데이터전공 20165153 이재성
 * 사다리 게임 프로젝트
 * 프로그램명 : Game_Start.cs
 * 사다리 게임 시작을 하는 프로그램
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

namespace Ghost_Leg_Game
{
    public partial class Game_Start : Form
    {
        public Game_Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 시작하기 버튼
        {
            Game_Action form2 = new Game_Action();  // 게임 시작을 위해 Game_Action 생성
            form2.Owner = this;
            form2.ShowDialog();             // 모달 방식을 통해 게임 시작
        }

    }
}
