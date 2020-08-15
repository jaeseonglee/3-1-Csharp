/*	실습 3번
	작성일 : 2020.06.07
    작성자 : 20165153 이재성
	프로그램 설명 : 텍스트 박스로 입력된 과목을 트리 뷰와 리스트 박스로 처리하는 프로그램을 작성하시오.
    	‘과목 추가’ 버튼 : 텍스트 박스에 입력한 데이터를 트리 뷰에서 선택한 노드의 자식 노드로 추가
    	‘과목 삭제’ 버튼 : 트리 뷰에서 선택한 노드 삭제
    	‘과목 출력’ 버튼 : 트리 뷰에서 선택한 노드의 부모 노드와 자식 노드를 리스트박스로 출력

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

namespace Number3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)     // 폼을 로드할때
        {
            treeView1.ExpandAll();      // 모든 트리 뷰를 확장시켜 준다.
        }

        private void button1_Click(object sender, EventArgs e)  // 과목 추가
        {
            if(textBox1.Text != String.Empty)   // 텍스트 박스의 내용이 공백이 아니어야하고
            {
                if (treeView1.SelectedNode.Text.Contains("학기")) { // n학기 선택시 
                    treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text)); // 트리 노드를 만들어주고
                    textBox1.Text = string.Empty;       // 텍스트 박스는 공백으로 초기화
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)      // 과목 삭제
        {
            if( treeView1.SelectedNode.Parent != null)
            { // 만약 루트 노드에 접근하려 하면 오류를 일으키지 않기 위해 조건문 사용
                if (treeView1.SelectedNode.Parent.Text.Contains("학기")) // 부모에 학기가 포함되어있다면
                {
                    treeView1.SelectedNode.Remove(); // 선택된 과목 삭제
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // 과목 출력
        {
            TreeNode tn = treeView1.SelectedNode;       // 현재 선택된 노드에 대한 변수 선언 및 초기화
            listBox1.Items.Clear();         // 리스트 박스의 내용을 비워 주고

            if(tn.Text.Contains("학년"))      // 학년을 선택할 경우, 
            {
                listBox1.Items.Add(tn.Text);     // 지금 텍스트를 추가하고
                foreach (TreeNode i in tn.Nodes) // 자식 노드에 대해 반복문 => 학기
                {
                    listBox1.Items.Add(i.Text);  // 자식 노드의 텍스트를 추가하고
                    foreach (TreeNode j in i.Nodes) // 자식의 자식노드에 대해 반복문 => 과목 
                    {
                        listBox1.Items.Add(j.Text); // 과목의 텍스트까지 추가한다.
                    }
                }
            }

            else if (tn.Text.Contains("학기"))     // 학기를 선택할 경우
            {
                listBox1.Items.Add(tn.Parent.Text); // 부모 노드로 접근해 학년을 추가
                listBox1.Items.Add(tn.Text);        // 학기도 리스트 박스에 추가
                foreach( TreeNode i in tn.Nodes)    // 자식에 대해 반복문 => 과목
                {
                    listBox1.Items.Add(i.Text);    // 과목의 텍스트 추가
                }
            }

            else // 과목을 선택할경우
            {
                listBox1.Items.Add(tn.Parent.Text); // 학기와
                listBox1.Items.Add(tn.Text);        // 과목만을 추가해준다.
            }
 
        }      
    }
}
