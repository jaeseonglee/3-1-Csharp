namespace Number3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("1학년", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("2학년", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("3학년", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("1학기");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("2학기");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("4학년", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "노드1";
            treeNode13.Text = "1학기";
            treeNode14.Name = "노드2";
            treeNode14.Text = "2학기";
            treeNode15.Name = "노드0";
            treeNode15.Text = "1학년";
            treeNode16.Name = "노드4";
            treeNode16.Text = "1학기";
            treeNode17.Name = "노드5";
            treeNode17.Text = "2학기";
            treeNode18.Name = "노드3";
            treeNode18.Text = "2학년";
            treeNode19.Name = "노드7";
            treeNode19.Text = "1학기";
            treeNode20.Name = "노드8";
            treeNode20.Text = "2학기";
            treeNode21.Name = "노드6";
            treeNode21.Text = "3학년";
            treeNode22.Name = "노드10";
            treeNode22.Text = "1학기";
            treeNode23.Name = "노드11";
            treeNode23.Text = "2학기";
            treeNode24.Name = "노드9";
            treeNode24.Text = "4학년";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18,
            treeNode21,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(300, 250);
            this.treeView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 21);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(348, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 244);
            this.listBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "과목 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "과목 삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "과목 출력";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 340);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "TreeView App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

