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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            //this.AddOwnedForm(form2);
            form2.ShowDialog();

            switch(form2.DialogResult)
            {
                case DialogResult.OK:
                    MessageBox.Show("입력 데이터를 확인합니다.", "입력 데이터 확인");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("취소 버튼을 클릭했습니다.", "입력 데이터 취소");
                    break;

            }
        }
    }
}
