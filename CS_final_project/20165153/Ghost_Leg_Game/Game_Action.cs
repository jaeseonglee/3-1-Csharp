/* 프로그램명: Game_Action.cs
 * 사다리 게임을 진행하는 프로그램.
 * 사다리 게임을 통해 랜덤한 결과로 데이터를 매칭 시킨다.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;  
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghost_Leg_Game
{
    public partial class Game_Action : Form
    {
        private int num;                // 참여 인원을 저장할 num
        private int differX;            // 사다리 게임의 X축 차이를 저장하는 differX
        private int differY;            // 사다리 게임의 Y축 차이를 저장하는 differY
        private int stateNum;           // 마우스 클릭에 따라 어떤 실행을 할지 결정하는 stateNum
        private string[] resultStirng;  // 매칭시킨 데이터를 결과창에 출력할 문자열 배열 resultString
        private Rectangle[] topRect;    // 사다리 게임의 상단 사각형 배열 topRect
        private Rectangle[] bottomRect; // 사다리 게임의 하단 사각형 배열 bottomRect
        private TextBox[] topTB;        // 상단 사각형의 문자를 저장할 텍스트 박스 배열 topTB
        private TextBox[] bottomTB;     // 하단 사각형의 문자를 저장할 텍스트 박스 배열 bottomTB
        private Brush[] brush;          // 사각형의 색깔을 지정할 Brush 배열 brush
        private Point[] ptArr;          // 사다리 게임의 중간 직선 위치를 저장할 Point 배열 ptArr
        private Graphics g;             // 그림을 그리기 위해 사용하는 Graphics
        
        public Game_Action()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) // 게임창이 로딩시
        {
            stateNum = 1;                   // stateNum을 1로 초기화
            this.Size = new Size(700, 150); // SIZE 보기 좋게 지정
            brush = new Brush[] { Brushes.OrangeRed, Brushes.Orange, Brushes.Yellow,
                Brushes.GreenYellow, Brushes.CadetBlue, Brushes.SeaGreen, Brushes.Cyan,
                Brushes.DarkGray, Brushes.Pink, Brushes.IndianRed };
            // brush 배열을 임의로 지정, 가시성을 위해 대체로 밝은 색으로 선택
        }

        private void button1_Click(object sender, EventArgs e) // 확인 버튼
        {
            label1.Visible = false;         // 라벨,
            numericUpDown1.Visible = false; // 수치적 업다운 컨트롤.
            button1.Visible = false;        // 확인 버튼을 보이지 않게 함
            Size = new Size(900, 600);      // 게임 진행을 위해 Size를 넓게 지정
            g = CreateGraphics();           // Graphics g = CreateGraphics

            RectInfo();         // 사다리 게임의 사각형들을 만드는 RectInfo 호출
            PaintLadder();      // 생성된 사각형들을 통해 사다리 게임을 그리는 PaintLadder 호출

            // 메세지 박스를 통해 사다리 게임이 생성되었음과 각각의 사각형에 이름들(데이터)을 입력해달라고 출력
            MessageBox.Show("사다리 게임의 모든 네모칸에 정보를 입력해주세요!\n네모를 클릭하면 글자를 입력할 수 있습니다!",
                "게임 안내 메세지", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)  //마우스 왼쪽 클릭 시 실행하는 함수
        {
            if (stateNum == 1)      // stateNum이 1이라면 아직 텍스트 박스에 입력이 끝나지 않은 것을 의미한다.
            {
                for (int i = 0; i < num; i++)        // 반복문을 통해 사각형 클릭을 통해 텍스트 박스를 보여준다.
                {
                    if (topRect[i].Contains(e.X, e.Y))          // 상단 사각형이면
                    {
                        InputTextBox(topRect[i], topTB[i]);     // 상단 사각형의 텍스트박스 입력을 실행하는 InputTextBox 호출
                        break;                       // 해당 조건문 실행시 반복 종료
                    }
                    else if (bottomRect[i].Contains(e.X, e.Y))  // 하단 사각형이면
                    {
                        InputTextBox(bottomRect[i], bottomTB[i]); // 하단 사각형의 텍스트 박스 입력을 실행하는 InputTextBox 호출
                        break;                          // 해당 조건문 실행시 반복 종료
                    }
                }
            }
            else if (stateNum == 2)              // stateNum이 2라면 입력이 끝나고 출력을 진행할 것을 의미한다.
            {
                button3.Visible = true;         // 결과를 보여주는 결과보기 버튼을 보이게 하고
                for (int i = 0; i < num; i++)   // 반복문을 통해 사다리 게임을 진행
                {
                    if (topRect[i].Contains(e.X, e.Y))      // 상단 사각형에서 부터 선을 그리며 게임 진행
                    {
                        DrawResult(topRect[i], i);          // DrawResult 호출로 결과 그림을 본다.
                        break;                  // 조건문 실행시 반복 종료
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)      // 입력 완료 버튼
        {
            for(int i = 0; i < num; i++)        // 먼저 반복문을 통해 모든 사각형의 정보가 입력되었는지 확인
            {                                   // 텍스트 박스의 내용이 하나라도 없다면
                if (topTB[i].Text == string.Empty || bottomTB[i].Text == string.Empty)
                {
                    MessageBox.Show("모든 네모칸의 글자를 입력해주세요", "미입력 유무 확인 메세지"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);      // 모든 텍스트 박스에 내용을 입력해달라고 알림
                    return;     // 조건문에 해당하면 함수를 종료시킨다.
                }
            }
            
            button2.Visible = false;        // 모든 텍스트 박스에 내용이 있다면, 입력 완료 버튼을 보이지 않게 한다.

            for (int i = 0; i < num; i++)   // 반복문을 통해 사다리 게임에 있는 모든 텍스트박스를 지워준다.
            {
                topTB[i].Visible = false;
                bottomTB[i].Visible = false;
            }

            PaintLadder();      // 모든 텍스트 박스가 지워지고 난 뒤에 지워진 사각형을 그리기 위해 다시 PaintLadder를 호출한다.
            PaintMiddleLine();  // 그뒤에 사다리 게임의 중간 선들을 그리는 PaintMiddleLine을 호출하고
            DrawStringBox();    // 텍스트 박스에 입력된 정보를 사각형에 글씨로 그리는 DrawStringBox 호출을 통해 게임 준비를 마친다.
            
            stateNum = 2;       // 게임 준비가 다 끝났으므로 stateNum을 2로 초기화해줌으로써 마우스 클릭에 대해 실행을 바꿔준다.
            MessageBox.Show("사다리 게임 시작!\n네모칸을 눌러 결과를 확인해보세요!", "게임 시작 메세지",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e) // 결과 보기 버튼
        {
            string str = string.Empty;          
            foreach (string s in resultStirng)  // 지금까지 프로그램 진행을 통해 저장된 resultStirng에서
                str += s;               // 값이 있는 결과들로 초기화
            MessageBox.Show(str, "결과 출력 메세지");      // 결과를 출력한다.
        }

        private void RectInfo()     // 사각형 정보를 생성하는 RectInfo
        {
            num = (int)numericUpDown1.Value;    // 업다운 컨트롤의 입력된 숫자를 num에 저장
            topRect = new Rectangle[num];       // num의 값만큼 topRect,
            bottomRect = new Rectangle[num];    // bottomRect,
            topTB = new TextBox[num];           // topTB,
            bottomTB = new TextBox[num];        // bottomTB,
            resultStirng = new string[num];     // resultStirng를 num만큼 초기화

            differX = 750 / num;                // num 값에 따라 사다리들의 X 축 간격 조정

            for (int i = 0; i < num; i++)       // 반복문을 통해 사각형 정보 생성
            {
                // 첫번째 사각형 위치 (30,20)에서 differX의 값만큼 간격을 조정해서 사각형을 생성
                topRect[i]    = new Rectangle(30 + differX * i, 20, 60, 40); 
                bottomRect[i] = new Rectangle(30 + differX * i, 450, 60, 40);
                topTB[i] = new TextBox();          
                bottomTB[i] = new TextBox();
            }
        }

        private void PaintLadder()      // 사다리 게임을 그리는 PaintLadder 호출
        {
            for(int i = 0; i < num; i++)   // 반복문을 통해서 사각형과 선을 그린다.
            {
                g.FillRectangle(brush[i], topRect[i]);                  // 상단 사각형
                g.FillRectangle(Brushes.White, bottomRect[i]);          // 하단 사각형들은 전부 흰색으로 그려준다.
                g.DrawRectangle(new Pen(Color.Black, 2), topRect[i]);   // DrawRectangle을 통해 테두리 선을 그려준다.
                g.DrawRectangle(new Pen(Color.Black, 2), bottomRect[i]);

                // 상단 사각형부터 하단 사각형까지 선을 그리는 DrawLine
                g.DrawLine(new Pen(Color.Black, 4),     // 검정색으로 그려준다 
                    new Point(topRect[i].X + (topRect[i].Width / 2), topRect[i].Y + topRect[i].Height), // 상단 사각형의 아래쪽 가운데부터 
                    new Point(bottomRect[i].X  + (bottomRect[i].Width / 2), bottomRect[i].Y));      // 하단 사각형의 위쪽 가운데까지 선을 그려준다.
            }
        }

        private void PaintMiddleLine()          // 사다리 게임의 중간 직선을 그리는 PaintMiddleLine 함수
        {
            Random r = new Random();            // 난수 생성을 위해 Random 생성 및 초기화
            int lineCnt = r.Next(num * 3, num * 5); // 입력된 인원(데이터)의 수에 따라 난수 범위를 바꿔주고, 그 숫자는 중간 직선의 숫자이다. 
            ptArr = new Point[lineCnt];         // 마찬가지로 중간 직선의 시작점 개수도 lineCnt만큼 초기화한다.
            int[] xPt = new int[num];           // ptArr의 X좌표를 저장할 xPt 배열
            int[] yPt = new int[lineCnt];       // ptArr의 Y좌표를 저장할 yPt 배열
            differY = 370 / lineCnt;        // 상단에서 하단까지 닫는 거리를 370(실제로는 더 큰값, 사각형 바로 위헤 직선이 생기는 것을 방지)
                                            //으로 지정하고 중간 직선의 수만큼 나눈 값을 Y축 간격으로 저장한다.
            
            for (int i = 0; i < num; i++)       // 현재 사각형의 개수만큼 반복
                xPt[i] = topRect[i].X + (topRect[i].Width / 2); // 각각의 사각형의 가운데 위치의 X값을 저장

            for (int i = 0; i < lineCnt; i++)   // 반복문을 통해 ptArr 초기화 및 직선 그리기
            {
                yPt[i] = (differY * i) +  (2 * topRect[0].Height);  // 매 반복마다 Y축의 간격만큼 늘려주면서 yPt 저장
                                             
                ptArr[i] = new Point(xPt[r.Next(0, num - 1)], yPt[i]); 
                // 난수 생성을 통해 어떤 사각형의 x좌표에서 시작할지 지정하고, -1을 해줌으로써 마지막 직선의 X좌표는 가리키지 않게 한다

                g.DrawLine(new Pen(Color.Black, 5), ptArr[i],      // ptArr값이 초기화되면 그 값을 기준으로 differX(X축 간격)만큼 
                    new Point(ptArr[i].X + differX, ptArr[i].Y));  // 오른쪽으로 직선을 그려준다.
            }
        }

        private void InputTextBox(Rectangle rect, TextBox tb)   // 텍스트 박스 생성 및 입력을 실행하는 InputTextBox함수
        {
            tb.Location = new Point(rect.X, rect.Y);    // 텍스트 박스들은 각각의 사각형의 위치와
            tb.Width = 60;
            tb.Height = 40;                             // 그 크기와 똑같게 지정한다.
            tb.MaxLength = 5;                           // 5자(유니코드기준) 까지 입력할 수 있게 지정
            tb.Multiline = true;                        // 크기가 작은 것을 고려해 Multiline을 true로 지정
            tb.TextAlign = HorizontalAlignment.Center;  // 가운데 정렬
            tb.Font = new Font("Consolas", 12);         // Consolas 폰트로 지정하고
            this.Controls.Add(tb);                      // 사각형위에 띄워준다. 이때 사각형이 지워진다. 
        }

        private void DrawStringBox()                // 문자열을 그리는 DrawStringBox함수
        {
            StringFormat sf = new StringFormat();       // StringFormat을 통해
            sf.Alignment = StringAlignment.Center;      // 수평 정렬
            sf.LineAlignment = StringAlignment.Center;  // 수직 정렬로 지정한다.
           
            for (int i = 0; i < num; i++)           // 반복문을 통해 텍스트 박스의 문자열을 사각형 위에 그려준다
            {
                g.DrawString(topTB[i].Text, new Font("Consolas", 10, FontStyle.Bold),
                    Brushes.Black, topRect[i], sf);
                g.DrawString(bottomTB[i].Text, new Font("Consolas", 10, FontStyle.Bold),
                    Brushes.Black, bottomRect[i], sf);
            }
        }

         private void DrawResult(Rectangle rect, int index)     // 게임을 진행하는 DrawResult함수
        {
            /* 초기 계획 단계에서 타이머를 여러개 사용하여
             * 왼쪽으로 선그리기, 오른쪽으로 선그리기, 아래쪽으로 선그리기 구현하려 했으나,
             * 타이머가 Start한 이후로 Start한 코드에서 대기하는 것과
             * 다중 타이머들이 따로 따로 실행하는 것에 대해서 부족한 실력과 미숙지된 부분으로 실패.
             * Thread.Sleep()을 여러번 사용하여 선을 그리려 했으나 사용자가 대기하는 문제가 발생
             * 
             * 3중 반복문을 통해 선을 그리는 것으로 사다리 게임을 진행한다. (20.06.26)
             */

            // 입력받은 상단 사각형의 가운데서부터 출발하기 때문에 가운에 위치를 Point 변수에 저장
            Point p = new Point(rect.X + rect.Width / 2, rect.Height + rect.Height / 2);

                                      // 처음 위치와 첫번째 중간 직선 사이의 거리와 
            while (p.Y < ptArr[0].Y)  // 중간 직선 사이들의 거리가 다르기 때문에 첫번째 선을 그리는 것만 따로 반복문을 진행
            {
                g.DrawLine(new Pen(brush[index], 5), p, new Point(p.X, p.Y + 1) );  // 첫번째 중간 직선의 y축까지 선을 그려준다. index는 상단 사각형의 색깔이다.
                p.Offset(0, 1);     // 선을 그리면서 Y좌표값을 계속 움직여준다.
            }

            while (p.Y < bottomRect[0].Y)       // 그렇게 그려지는 선이 하단 사각형들의 Y축과 같아질때 까지 반복
            {
                for (int i = 0; i < ptArr.Length; i++)  // 2중 반복문. 선이 내려가면서 중간 직선을 만나는지 확인
                {
                    if (p.Equals(ptArr[i]))             // 중간 직선을 만나 오른쪽으로 이동하는 조건문
                    {
                        for(int j = 0; j < differX; j++)    // 3중 반복문. differX(X축의 간격)만큼 오른쪽으로 선을 그려준다
                        {
                            g.DrawLine(new Pen(brush[index], 5), p, new Point(p.X + 1, p.Y));   // X값 증가로 선을 그려준다.
                            p.Offset(1, 0);             // 반복을 통해 p의 X좌표값도 움직인다.
                           
                        }
                        break;          // 조건문을 지나 중간 직선을 그렸다면 for 반복문을 탈출
                    }
                    else if (p.X - differX == ptArr[i].X && p.Y == ptArr[i].Y)  // 중간 직선을 만났으나 왼쪽으로 향하게 될 경우
                    {
                        for (int j = 0; j < differX; j++)   // 3중 반복문. differX(X축의 간격)만큼 왼쪽으로 선을 그려준다
                        {
                            g.DrawLine(new Pen(brush[index], 5), p, new Point(p.X - 1, p.Y));   // X값 감소로 선을 왼쪽으로 그려준다.
                            p.Offset(-1, 0);                // -1을 통해 X좌표값을 움직여 준다.
                            
                        }
                        break;          // 조건문을 지나 중간 직선을 그렸다면 for 반복문을 탈출
                    }
                }

                if (p.Y + differY > bottomRect[0].Y)        // 현재 Y좌표값이 마지막 중간 직선을 지났다면
                {
                    while (p.Y < bottomRect[0].Y)           // 하단 사각형을 만날때까지 
                    {
                        g.DrawLine(new Pen(brush[index], 5), p, new Point(p.X, p.Y + 1));       // 아래로 선을 그려준다.
                        p.Offset(0, 1);             // Y좌표값도 움직여준다.
                    }   
                    break;          // 이 조건문의 경우에는 하단 사각형을 만나기 때문에 전체 반복문(while)을 탈출한다
                }

                for(int k = 0; k < differY; k++)        // 위의 반복문 이후 내려가는 직선을 그리기 위해 있는 반복문
                {
                    g.DrawLine(new Pen(brush[index], 5), p, new Point(p.X, p.Y + 1));   // Y좌표 값을 증가시켜 아래로 그려준다.
                    p.Offset(0, 1);                     // Y좌표값 증가
                    //Thread.Sleep(1); 
                    // 전체 프로그램으로 보았을때 상단 사각형에서 하단 사각형까지 선을 그리는데
                    // 1초가 걸리지 않기 때문에 게임의 속도가 너무 빠르다면 주석을 지워 속도를 늦출수 있다.
                }
            }

            for(int i = 0; i < bottomRect.Length; i++)      // 위쪽의 전체 반복문이 끝나면 하단 사각형까지 다 그린것이다.
            {
                if (bottomRect[i].X.Equals(p.X - (rect.Width /2) ))       // 어떤 상단 사각형이 어떤 하단 사각형을 만났는지 확인하기 위한 반복문과 조건문
                {
                    g.DrawRectangle(new Pen(brush[index], 5), bottomRect[i]);   // 하단 사각형을 찾으면 그 사각형의 테두리를 상단 사각형의 색깔로 그려준다.
                    resultStirng[index] = $"{topTB[index].Text,5} => {bottomTB[i].Text,-5}\n";   // 상단 텍스트와 하단 텍스트를 매칭시켜준다.
                    break;      // 결과를 찾았으니 break문을 통해 탈출
                }
            }
        }
    }
}

