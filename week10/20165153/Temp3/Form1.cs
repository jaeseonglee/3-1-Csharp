using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void messageResult(DialogResult result)
        {
            switch(result)
            {
                case DialogResult.OK:
                    MessageBox.Show("OK 버튼을 눌렀습니다.", "OK");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Cancel 버튼을 눌렀습니다.", "Cancel");
                    break;
                case DialogResult.No:
                    MessageBox.Show("No 버튼을 눌렀습니다.", "No");
                    break;
                case DialogResult.Abort:
                    MessageBox.Show("Abort 버튼을 눌렀습니다.", "Abort");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("Retry 버튼을 눌렀습니다.", "Retry");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show("Ignore 버튼을 눌렀습니다.", "Ignore");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Yes 버튼을 눌렀습니다.", "Yes");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("OKCancle MessageBox",
                        "MessageBox Test",MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information);
            messageResult(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("YesNoCancle MessageBox",
                        "MessageBox Test", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);
            messageResult(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("AbortRetryIgnore MessageBox",
                        "MessageBox Test", MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            messageResult(result);
        }
    }
}
