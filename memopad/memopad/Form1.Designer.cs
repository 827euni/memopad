﻿namespace memopad
{
    partial class 메모장
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.페이지설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bing으로검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이전찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바꾸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기본확대축소복원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시줄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.실행취소ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bing으로서치ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1312, 60);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새창ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.페이지설정ToolStripMenuItem,
            this.인쇄ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(102, 56);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새창ToolStripMenuItem
            // 
            this.새창ToolStripMenuItem.Name = "새창ToolStripMenuItem";
            this.새창ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.새창ToolStripMenuItem.Size = new System.Drawing.Size(628, 54);
            this.새창ToolStripMenuItem.Text = "새 창";
            this.새창ToolStripMenuItem.Click += new System.EventHandler(this.새창ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(628, 54);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(628, 54);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(628, 54);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른 이름으로 저장";
            this.다른이름으로저장ToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장ToolStripMenuItem_Click);
            // 
            // 페이지설정ToolStripMenuItem
            // 
            this.페이지설정ToolStripMenuItem.Name = "페이지설정ToolStripMenuItem";
            this.페이지설정ToolStripMenuItem.Size = new System.Drawing.Size(628, 54);
            this.페이지설정ToolStripMenuItem.Text = "페이지 설정";
            this.페이지설정ToolStripMenuItem.Click += new System.EventHandler(this.페이지설정ToolStripMenuItem_Click);
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            this.인쇄ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.인쇄ToolStripMenuItem.Size = new System.Drawing.Size(628, 54);
            this.인쇄ToolStripMenuItem.Text = "인쇄";
            this.인쇄ToolStripMenuItem.Click += new System.EventHandler(this.인쇄ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(628, 54);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ToolStripMenuItem,
            this.잘라내기ToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.toolStripSeparator3,
            this.삭제ToolStripMenuItem,
            this.toolStripSeparator2,
            this.bing으로검색ToolStripMenuItem,
            this.찾기ToolStripMenuItem,
            this.다음찾기ToolStripMenuItem,
            this.이전찾기ToolStripMenuItem,
            this.바꾸기ToolStripMenuItem,
            this.이동ToolStripMenuItem,
            this.toolStripSeparator1,
            this.모두선택ToolStripMenuItem,
            this.시간날짜ToolStripMenuItem,
            this.toolStripSeparator4,
            this.글꼴ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(102, 56);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 실행취소ToolStripMenuItem
            // 
            this.실행취소ToolStripMenuItem.Enabled = false;
            this.실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            this.실행취소ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.실행취소ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.실행취소ToolStripMenuItem.Text = "실행 취소";
            this.실행취소ToolStripMenuItem.Click += new System.EventHandler(this.실행취소ToolStripMenuItem_Click);
            // 
            // 잘라내기ToolStripMenuItem
            // 
            this.잘라내기ToolStripMenuItem.Enabled = false;
            this.잘라내기ToolStripMenuItem.Name = "잘라내기ToolStripMenuItem";
            this.잘라내기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.잘라내기ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.잘라내기ToolStripMenuItem.Text = "잘라내기";
            this.잘라내기ToolStripMenuItem.Click += new System.EventHandler(this.잘라내기ToolStripMenuItem_Click);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.복사ToolStripMenuItem.Text = "복사";
            this.복사ToolStripMenuItem.Click += new System.EventHandler(this.복사ToolStripMenuItem_Click);
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            this.붙여넣기ToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(474, 6);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Enabled = false;
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(474, 6);
            // 
            // bing으로검색ToolStripMenuItem
            // 
            this.bing으로검색ToolStripMenuItem.Enabled = false;
            this.bing으로검색ToolStripMenuItem.Name = "bing으로검색ToolStripMenuItem";
            this.bing으로검색ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.bing으로검색ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.bing으로검색ToolStripMenuItem.Text = "Bing으로 검색";
            this.bing으로검색ToolStripMenuItem.Click += new System.EventHandler(this.bing으로검색ToolStripMenuItem_Click);
            // 
            // 찾기ToolStripMenuItem
            // 
            this.찾기ToolStripMenuItem.Enabled = false;
            this.찾기ToolStripMenuItem.Name = "찾기ToolStripMenuItem";
            this.찾기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.찾기ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.찾기ToolStripMenuItem.Text = "찾기";
            this.찾기ToolStripMenuItem.Click += new System.EventHandler(this.찾기ToolStripMenuItem_Click);
            // 
            // 다음찾기ToolStripMenuItem
            // 
            this.다음찾기ToolStripMenuItem.Enabled = false;
            this.다음찾기ToolStripMenuItem.Name = "다음찾기ToolStripMenuItem";
            this.다음찾기ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.다음찾기ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.다음찾기ToolStripMenuItem.Text = "다음 찾기";
            this.다음찾기ToolStripMenuItem.Click += new System.EventHandler(this.다음찾기ToolStripMenuItem_Click);
            // 
            // 이전찾기ToolStripMenuItem
            // 
            this.이전찾기ToolStripMenuItem.Enabled = false;
            this.이전찾기ToolStripMenuItem.Name = "이전찾기ToolStripMenuItem";
            this.이전찾기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.이전찾기ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.이전찾기ToolStripMenuItem.Text = "이전 찾기";
            this.이전찾기ToolStripMenuItem.Click += new System.EventHandler(this.이전찾기ToolStripMenuItem_Click);
            // 
            // 바꾸기ToolStripMenuItem
            // 
            this.바꾸기ToolStripMenuItem.Enabled = false;
            this.바꾸기ToolStripMenuItem.Name = "바꾸기ToolStripMenuItem";
            this.바꾸기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.바꾸기ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.바꾸기ToolStripMenuItem.Text = "바꾸기";
            this.바꾸기ToolStripMenuItem.Click += new System.EventHandler(this.바꾸기ToolStripMenuItem_Click);
            // 
            // 이동ToolStripMenuItem
            // 
            this.이동ToolStripMenuItem.Name = "이동ToolStripMenuItem";
            this.이동ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.이동ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.이동ToolStripMenuItem.Text = "이동";
            this.이동ToolStripMenuItem.Click += new System.EventHandler(this.이동ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(474, 6);
            // 
            // 모두선택ToolStripMenuItem
            // 
            this.모두선택ToolStripMenuItem.Name = "모두선택ToolStripMenuItem";
            this.모두선택ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.모두선택ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.모두선택ToolStripMenuItem.Text = "모두 선택";
            this.모두선택ToolStripMenuItem.Click += new System.EventHandler(this.모두선택ToolStripMenuItem_Click);
            // 
            // 시간날짜ToolStripMenuItem
            // 
            this.시간날짜ToolStripMenuItem.Name = "시간날짜ToolStripMenuItem";
            this.시간날짜ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.시간날짜ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.시간날짜ToolStripMenuItem.Text = "시간/날짜";
            this.시간날짜ToolStripMenuItem.Click += new System.EventHandler(this.시간날짜ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(474, 6);
            // 
            // 글꼴ToolStripMenuItem
            // 
            this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(477, 54);
            this.글꼴ToolStripMenuItem.Text = "글꼴";
            this.글꼴ToolStripMenuItem.Click += new System.EventHandler(this.글꼴ToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대축소ToolStripMenuItem,
            this.상태표시줄ToolStripMenuItem,
            this.자동줄바꿈ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(102, 56);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 확대축소ToolStripMenuItem
            // 
            this.확대축소ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대ToolStripMenuItem,
            this.축소ToolStripMenuItem,
            this.기본확대축소복원ToolStripMenuItem});
            this.확대축소ToolStripMenuItem.Name = "확대축소ToolStripMenuItem";
            this.확대축소ToolStripMenuItem.Size = new System.Drawing.Size(356, 54);
            this.확대축소ToolStripMenuItem.Text = "확대/축소";
            // 
            // 확대ToolStripMenuItem
            // 
            this.확대ToolStripMenuItem.Name = "확대ToolStripMenuItem";
            this.확대ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.확대ToolStripMenuItem.Size = new System.Drawing.Size(561, 54);
            this.확대ToolStripMenuItem.Text = "확대";
            this.확대ToolStripMenuItem.Click += new System.EventHandler(this.확대ToolStripMenuItem_Click);
            // 
            // 축소ToolStripMenuItem
            // 
            this.축소ToolStripMenuItem.Name = "축소ToolStripMenuItem";
            this.축소ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.축소ToolStripMenuItem.Size = new System.Drawing.Size(561, 54);
            this.축소ToolStripMenuItem.Text = "축소";
            this.축소ToolStripMenuItem.Click += new System.EventHandler(this.축소ToolStripMenuItem_Click);
            // 
            // 기본확대축소복원ToolStripMenuItem
            // 
            this.기본확대축소복원ToolStripMenuItem.Name = "기본확대축소복원ToolStripMenuItem";
            this.기본확대축소복원ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.기본확대축소복원ToolStripMenuItem.Size = new System.Drawing.Size(561, 54);
            this.기본확대축소복원ToolStripMenuItem.Text = "기본 확대/축소 복원";
            this.기본확대축소복원ToolStripMenuItem.Click += new System.EventHandler(this.기본확대축소복원ToolStripMenuItem_Click);
            // 
            // 상태표시줄ToolStripMenuItem
            // 
            this.상태표시줄ToolStripMenuItem.Name = "상태표시줄ToolStripMenuItem";
            this.상태표시줄ToolStripMenuItem.Size = new System.Drawing.Size(356, 54);
            this.상태표시줄ToolStripMenuItem.Text = "상태 표시줄";
            this.상태표시줄ToolStripMenuItem.Click += new System.EventHandler(this.상태표시줄ToolStripMenuItem_Click);
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            this.자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            this.자동줄바꿈ToolStripMenuItem.Size = new System.Drawing.Size(356, 54);
            this.자동줄바꿈ToolStripMenuItem.Text = "자동 줄 바꿈";
            this.자동줄바꿈ToolStripMenuItem.Click += new System.EventHandler(this.자동줄바꿈ToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ToolStripMenuItem1,
            this.toolStripSeparator5,
            this.잘라내기ToolStripMenuItem1,
            this.복사ToolStripMenuItem1,
            this.붙여넣기ToolStripMenuItem1,
            this.삭제ToolStripMenuItem1,
            this.toolStripSeparator6,
            this.모두선택ToolStripMenuItem1,
            this.toolStripSeparator7,
            this.bing으로서치ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(334, 358);
            // 
            // 실행취소ToolStripMenuItem1
            // 
            this.실행취소ToolStripMenuItem1.Name = "실행취소ToolStripMenuItem1";
            this.실행취소ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.실행취소ToolStripMenuItem1.Size = new System.Drawing.Size(333, 48);
            this.실행취소ToolStripMenuItem1.Text = "실행 취소";
            this.실행취소ToolStripMenuItem1.Click += new System.EventHandler(this.실행취소ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(330, 6);
            // 
            // 잘라내기ToolStripMenuItem1
            // 
            this.잘라내기ToolStripMenuItem1.Enabled = false;
            this.잘라내기ToolStripMenuItem1.Name = "잘라내기ToolStripMenuItem1";
            this.잘라내기ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.잘라내기ToolStripMenuItem1.Size = new System.Drawing.Size(333, 48);
            this.잘라내기ToolStripMenuItem1.Text = "잘라내기";
            this.잘라내기ToolStripMenuItem1.Click += new System.EventHandler(this.잘라내기ToolStripMenuItem1_Click);
            // 
            // 복사ToolStripMenuItem1
            // 
            this.복사ToolStripMenuItem1.Enabled = false;
            this.복사ToolStripMenuItem1.Name = "복사ToolStripMenuItem1";
            this.복사ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사ToolStripMenuItem1.Size = new System.Drawing.Size(333, 48);
            this.복사ToolStripMenuItem1.Text = "복사";
            this.복사ToolStripMenuItem1.Click += new System.EventHandler(this.복사ToolStripMenuItem1_Click);
            // 
            // 붙여넣기ToolStripMenuItem1
            // 
            this.붙여넣기ToolStripMenuItem1.Name = "붙여넣기ToolStripMenuItem1";
            this.붙여넣기ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기ToolStripMenuItem1.Size = new System.Drawing.Size(333, 48);
            this.붙여넣기ToolStripMenuItem1.Text = "붙여넣기";
            this.붙여넣기ToolStripMenuItem1.Click += new System.EventHandler(this.붙여넣기ToolStripMenuItem1_Click);
            // 
            // 삭제ToolStripMenuItem1
            // 
            this.삭제ToolStripMenuItem1.Enabled = false;
            this.삭제ToolStripMenuItem1.Name = "삭제ToolStripMenuItem1";
            this.삭제ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.삭제ToolStripMenuItem1.Size = new System.Drawing.Size(333, 48);
            this.삭제ToolStripMenuItem1.Text = "삭제";
            this.삭제ToolStripMenuItem1.Click += new System.EventHandler(this.삭제ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(330, 6);
            // 
            // 모두선택ToolStripMenuItem1
            // 
            this.모두선택ToolStripMenuItem1.Name = "모두선택ToolStripMenuItem1";
            this.모두선택ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.모두선택ToolStripMenuItem1.Size = new System.Drawing.Size(333, 48);
            this.모두선택ToolStripMenuItem1.Text = "모두 선택";
            this.모두선택ToolStripMenuItem1.Click += new System.EventHandler(this.모두선택ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(330, 6);
            // 
            // bing으로서치ToolStripMenuItem
            // 
            this.bing으로서치ToolStripMenuItem.Enabled = false;
            this.bing으로서치ToolStripMenuItem.Name = "bing으로서치ToolStripMenuItem";
            this.bing으로서치ToolStripMenuItem.Size = new System.Drawing.Size(333, 48);
            this.bing으로서치ToolStripMenuItem.Text = "Bing으로 정의";
            this.bing으로서치ToolStripMenuItem.Click += new System.EventHandler(this.bing으로서치ToolStripMenuItem_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox.Location = new System.Drawing.Point(-6, 52);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(1318, 593);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 636);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1312, 58);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.TabStop = true;
            this.statusStrip1.Text = "Windows (CRLF)";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(156, 45);
            this.toolStripStatusLabel1.Text = "줄 1, 열 1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 45);
            this.toolStripStatusLabel2.Text = "0자";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(98, 45);
            this.toolStripStatusLabel3.Text = "100%";
            // 
            // 메모장
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1312, 694);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "메모장";
            this.Text = "메모장";
            this.Load += new System.EventHandler(this.메모장_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 페이지설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem bing으로검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다음찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이전찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 바꾸기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 모두선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기본확대축소복원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 실행취소ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 모두선택ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem bing으로서치ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

