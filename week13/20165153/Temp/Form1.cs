using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Rectangle rect = new Rectangle(80, 80, 40, 40);
            if (rect.Contains(e.X, e.Y))
            {
                MessageBox.Show("사각형 내부입니다.", "Contains 확인");
                graphics.FillRectangle(new SolidBrush(GetColor()), rect);
            }
            else
            {
                Rectangle rec1 = new Rectangle(e.X - 10, e.Y - 10, 50, 60);
                graphics.FillRectangle(new SolidBrush(GetColor()), rec1);
            }
        }
        
        private Color GetColor()
        {
            Random r = new Random();
            //Color c = Color.FromArgb(r.Next(0,255), r.Next(0, 255), r.Next(0, 255) );
             Color c = Color.FromArgb(50 , r.Next(0,255), r.Next(0, 255), r.Next(0, 255) );
            // 투명도 추가
            return c;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String result = String.Empty;
            Graphics graphics = CreateGraphics();

            Rectangle rect1 = new Rectangle(10, 20, 60, 30);
            graphics.FillRectangle(new SolidBrush(Color.Aqua), rect1);

            Rectangle rect2 = new Rectangle(60, 30, 50, 60);
            graphics.FillRectangle(new SolidBrush(Color.Bisque), rect2);

            Rectangle rect3 = Rectangle.Intersect(rect1, rect2);
            graphics.FillRectangle(new SolidBrush(Color.Coral), rect3);
            result = $"교차 영역: {rect3.ToString()}\n";


            rect3 = Rectangle.Union(rect1, rect2); // 합
            result += $"합 영역: {rect3.ToString()}\n";

            //graphics.FillRectangle(new SolidBrush(Color.YellowGreen), rect3);
            rect3.Offset(10,20); 
            result += $"이동 영역: {rect3.ToString()}\n";

            rect3.Inflate(20, 20);
            result += $"확장 영역: {rect3.ToString()}\n";
            MessageBox.Show(result, "Rectangle Method");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            Color c = this.BackColor;
            gr.Clear(c);
        }
    }
}
