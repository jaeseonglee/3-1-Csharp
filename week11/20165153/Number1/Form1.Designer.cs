namespace Number1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.데이터입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자료입력NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전체삭제XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택삭제PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴대화상자TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색상대화상자CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일불러오기DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일저장하기CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.데이터입력ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.파일FToolStripMenuItem,
            this.종료XToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 데이터입력ToolStripMenuItem
            // 
            this.데이터입력ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자료입력NToolStripMenuItem,
            this.전체삭제XToolStripMenuItem,
            this.선택삭제PToolStripMenuItem});
            this.데이터입력ToolStripMenuItem.Name = "데이터입력ToolStripMenuItem";
            this.데이터입력ToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.데이터입력ToolStripMenuItem.Text = "데이터(&W)";
            // 
            // 자료입력NToolStripMenuItem
            // 
            this.자료입력NToolStripMenuItem.Name = "자료입력NToolStripMenuItem";
            this.자료입력NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.자료입력NToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.자료입력NToolStripMenuItem.Text = "자료입력(&N)";
            this.자료입력NToolStripMenuItem.Click += new System.EventHandler(this.자료입력NToolStripMenuItem_Click);
            // 
            // 전체삭제XToolStripMenuItem
            // 
            this.전체삭제XToolStripMenuItem.Name = "전체삭제XToolStripMenuItem";
            this.전체삭제XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.전체삭제XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.전체삭제XToolStripMenuItem.Text = "전체삭제(&X)";
            this.전체삭제XToolStripMenuItem.Click += new System.EventHandler(this.전체삭제XToolStripMenuItem_Click);
            // 
            // 선택삭제PToolStripMenuItem
            // 
            this.선택삭제PToolStripMenuItem.Name = "선택삭제PToolStripMenuItem";
            this.선택삭제PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.선택삭제PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.선택삭제PToolStripMenuItem.Text = "선택삭제(&P)";
            this.선택삭제PToolStripMenuItem.Click += new System.EventHandler(this.선택삭제PToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글꼴대화상자TToolStripMenuItem,
            this.색상대화상자CToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집ToolStripMenuItem.Text = "편집(&E)";
            // 
            // 글꼴대화상자TToolStripMenuItem
            // 
            this.글꼴대화상자TToolStripMenuItem.Name = "글꼴대화상자TToolStripMenuItem";
            this.글꼴대화상자TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.글꼴대화상자TToolStripMenuItem.ShowShortcutKeys = false;
            this.글꼴대화상자TToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.글꼴대화상자TToolStripMenuItem.Text = "글꼴 대화 상자(&T)";
            this.글꼴대화상자TToolStripMenuItem.Click += new System.EventHandler(this.글꼴대화상자TToolStripMenuItem_Click);
            // 
            // 색상대화상자CToolStripMenuItem
            // 
            this.색상대화상자CToolStripMenuItem.Name = "색상대화상자CToolStripMenuItem";
            this.색상대화상자CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.색상대화상자CToolStripMenuItem.ShowShortcutKeys = false;
            this.색상대화상자CToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.색상대화상자CToolStripMenuItem.Text = "색상 대화 상자(&C)";
            this.색상대화상자CToolStripMenuItem.Click += new System.EventHandler(this.색상대화상자CToolStripMenuItem_Click);
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일불러오기DToolStripMenuItem,
            this.파일저장하기CToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 파일불러오기DToolStripMenuItem
            // 
            this.파일불러오기DToolStripMenuItem.Name = "파일불러오기DToolStripMenuItem";
            this.파일불러오기DToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.파일불러오기DToolStripMenuItem.ShowShortcutKeys = false;
            this.파일불러오기DToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.파일불러오기DToolStripMenuItem.Text = "파일 불러 오기(&D)";
            this.파일불러오기DToolStripMenuItem.Click += new System.EventHandler(this.파일불러오기DToolStripMenuItem_Click);
            // 
            // 파일저장하기CToolStripMenuItem
            // 
            this.파일저장하기CToolStripMenuItem.Name = "파일저장하기CToolStripMenuItem";
            this.파일저장하기CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.파일저장하기CToolStripMenuItem.ShowShortcutKeys = false;
            this.파일저장하기CToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.파일저장하기CToolStripMenuItem.Text = "파일 저장 하기(&S)";
            this.파일저장하기CToolStripMenuItem.Click += new System.EventHandler(this.파일저장하기CToolStripMenuItem_Click);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.종료XToolStripMenuItem.ShowShortcutKeys = false;
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(322, 208);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 257);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 117);
            this.textBox1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 386);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MenuStripApp";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 데이터입력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자료입력NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체삭제XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택삭제PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴대화상자TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색상대화상자CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일불러오기DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일저장하기CToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

