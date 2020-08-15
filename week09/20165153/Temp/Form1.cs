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
        Calculator cal;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cal = new Calculator();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(checkBlank(textBox1.Text.Trim(), textBox2.Text.Trim()))
            {
                textClear();
            }
            else
            {
                Button bt = sender as Button;
                switch (bt.Text)
                {
                    case "+":
                        textBox3.Text = cal.plus(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                        break;

                    case "-":
                        textBox3.Text = cal.minus(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                        break;

                    case "*":
                        textBox3.Text = cal.multiply(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                        break;

                    case "/":
                        textBox3.Text = cal.divide(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        private bool checkBlank(string text1, string text2)
        {
            if (text1 == "" || text2 == "")
            {
                MessageBox.Show("피연산자를 입력해주세요", "오류!");
                return true;
            }
            else
                return false;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textClear();
        }
        
        private void textClear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }

    class Calculator
    {
        public double plus(double a, double b)
        {
            return a + b;
        } //계산 결과 반환
        public double minus(double a, double b)
        {
            return a - b;
        }
        public double multiply(double a, double b)
        {
            return a * b;
        }
        public double divide(double a, double b)
        {
            return a / b;
        }
    }
}
