namespace hanwha_wis
{
    partial class frm메인
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
            this.ss = new System.Windows.Forms.StatusStrip();
            this.ssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m파일 = new System.Windows.Forms.ToolStripMenuItem();
            this.m파일_설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.m파일_종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.기초데이타ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_자재등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_제품등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_사용자등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_공장부서창고등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_공통코드등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.로그조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.입출고관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m자재입출고관리_입고등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m자재입출고관리_출고등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m자재입출고관리_투입예정원료예약 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m자재입출고관리_입고조회 = new System.Windows.Forms.ToolStripMenuItem();
            this.m자재입출고관리_출고조회 = new System.Windows.Forms.ToolStripMenuItem();
            this.m자재입출고관리_재고조회 = new System.Windows.Forms.ToolStripMenuItem();
            this.m작업관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.m작업관리_작업지시서 = new System.Windows.Forms.ToolStripMenuItem();
            this.m작업관리_계량 = new System.Windows.Forms.ToolStripMenuItem();
            this.ss.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssl});
            this.ss.Location = new System.Drawing.Point(0, 766);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(1258, 22);
            this.ss.TabIndex = 1;
            this.ss.Text = "statusStrip1";
            // 
            // ssl
            // 
            this.ssl.Name = "ssl";
            this.ssl.Size = new System.Drawing.Size(31, 17);
            this.ssl.Text = "상태";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m파일,
            this.기초데이타ToolStripMenuItem,
            this.입출고관리ToolStripMenuItem,
            this.m작업관리});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m파일
            // 
            this.m파일.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m파일_설정,
            this.m파일_종료});
            this.m파일.Name = "m파일";
            this.m파일.Size = new System.Drawing.Size(47, 20);
            this.m파일.Text = "파 일";
            // 
            // m파일_설정
            // 
            this.m파일_설정.Name = "m파일_설정";
            this.m파일_설정.Size = new System.Drawing.Size(102, 22);
            this.m파일_설정.Text = "설 정";
            this.m파일_설정.Click += new System.EventHandler(this.m파일_설정_Click);
            // 
            // m파일_종료
            // 
            this.m파일_종료.Name = "m파일_종료";
            this.m파일_종료.Size = new System.Drawing.Size(102, 22);
            this.m파일_종료.Text = "종 료";
            // 
            // 기초데이타ToolStripMenuItem
            // 
            this.기초데이타ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m기초데이타_자재등록,
            this.m기초데이타_제품등록,
            this.m기초데이타_사용자등록,
            this.m기초데이타_공장부서창고등록,
            this.m기초데이타_공통코드등록,
            this.로그조회ToolStripMenuItem});
            this.기초데이타ToolStripMenuItem.Name = "기초데이타ToolStripMenuItem";
            this.기초데이타ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.기초데이타ToolStripMenuItem.Text = "기초 데이타";
            // 
            // m기초데이타_자재등록
            // 
            this.m기초데이타_자재등록.Name = "m기초데이타_자재등록";
            this.m기초데이타_자재등록.Size = new System.Drawing.Size(200, 22);
            this.m기초데이타_자재등록.Text = "자재 등록";
            this.m기초데이타_자재등록.Click += new System.EventHandler(this.m기초데이타_자재등록_Click);
            // 
            // m기초데이타_제품등록
            // 
            this.m기초데이타_제품등록.Name = "m기초데이타_제품등록";
            this.m기초데이타_제품등록.Size = new System.Drawing.Size(200, 22);
            this.m기초데이타_제품등록.Text = "제품 등록";
            this.m기초데이타_제품등록.Click += new System.EventHandler(this.m기초데이타_제품등록_Click);
            // 
            // m기초데이타_사용자등록
            // 
            this.m기초데이타_사용자등록.Name = "m기초데이타_사용자등록";
            this.m기초데이타_사용자등록.Size = new System.Drawing.Size(200, 22);
            this.m기초데이타_사용자등록.Tag = "frm기초데이타_사용자등록";
            this.m기초데이타_사용자등록.Text = "사용자 등록";
            this.m기초데이타_사용자등록.Click += new System.EventHandler(this.m기초데이타_사용자등록_Click);
            // 
            // m기초데이타_공장부서창고등록
            // 
            this.m기초데이타_공장부서창고등록.Name = "m기초데이타_공장부서창고등록";
            this.m기초데이타_공장부서창고등록.Size = new System.Drawing.Size(200, 22);
            this.m기초데이타_공장부서창고등록.Text = "공장 / 부서 / 창고 등록";
            this.m기초데이타_공장부서창고등록.Click += new System.EventHandler(this.m기초데이타_공장부서창고등록_Click);
            // 
            // m기초데이타_공통코드등록
            // 
            this.m기초데이타_공통코드등록.Name = "m기초데이타_공통코드등록";
            this.m기초데이타_공통코드등록.Size = new System.Drawing.Size(200, 22);
            this.m기초데이타_공통코드등록.Text = "공통 코드 등록";
            this.m기초데이타_공통코드등록.Click += new System.EventHandler(this.m기초데이타_공통코드등록_Click);
            // 
            // 로그조회ToolStripMenuItem
            // 
            this.로그조회ToolStripMenuItem.Name = "로그조회ToolStripMenuItem";
            this.로그조회ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.로그조회ToolStripMenuItem.Text = "로그 조회";
            this.로그조회ToolStripMenuItem.Click += new System.EventHandler(this.로그조회ToolStripMenuItem_Click);
            // 
            // 입출고관리ToolStripMenuItem
            // 
            this.입출고관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m자재입출고관리_입고등록,
            this.m자재입출고관리_출고등록,
            this.m자재입출고관리_투입예정원료예약,
            this.toolStripMenuItem1,
            this.m자재입출고관리_입고조회,
            this.m자재입출고관리_출고조회,
            this.m자재입출고관리_재고조회});
            this.입출고관리ToolStripMenuItem.Name = "입출고관리ToolStripMenuItem";
            this.입출고관리ToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.입출고관리ToolStripMenuItem.Text = "자재 입/출고 관리";
            // 
            // m자재입출고관리_입고등록
            // 
            this.m자재입출고관리_입고등록.Name = "m자재입출고관리_입고등록";
            this.m자재입출고관리_입고등록.Size = new System.Drawing.Size(182, 22);
            this.m자재입출고관리_입고등록.Text = "입고 등록";
            this.m자재입출고관리_입고등록.Click += new System.EventHandler(this.m자재입출고관리_입고등록_Click);
            // 
            // m자재입출고관리_출고등록
            // 
            this.m자재입출고관리_출고등록.Name = "m자재입출고관리_출고등록";
            this.m자재입출고관리_출고등록.Size = new System.Drawing.Size(182, 22);
            this.m자재입출고관리_출고등록.Text = "출고 등록";
            this.m자재입출고관리_출고등록.Click += new System.EventHandler(this.m자재입출고관리_출고등록_Click);
            // 
            // m자재입출고관리_투입예정원료예약
            // 
            this.m자재입출고관리_투입예정원료예약.Name = "m자재입출고관리_투입예정원료예약";
            this.m자재입출고관리_투입예정원료예약.Size = new System.Drawing.Size(182, 22);
            this.m자재입출고관리_투입예정원료예약.Text = "투입 예정 원료 예약";
            this.m자재입출고관리_투입예정원료예약.Click += new System.EventHandler(this.m자재입출고관리_투입예정원료예약_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // m자재입출고관리_입고조회
            // 
            this.m자재입출고관리_입고조회.Name = "m자재입출고관리_입고조회";
            this.m자재입출고관리_입고조회.Size = new System.Drawing.Size(182, 22);
            this.m자재입출고관리_입고조회.Text = "입고 조회";
            this.m자재입출고관리_입고조회.Click += new System.EventHandler(this.m자재입출고관리_입고조회_Click);
            // 
            // m자재입출고관리_출고조회
            // 
            this.m자재입출고관리_출고조회.Name = "m자재입출고관리_출고조회";
            this.m자재입출고관리_출고조회.Size = new System.Drawing.Size(182, 22);
            this.m자재입출고관리_출고조회.Text = "출고 조회";
            this.m자재입출고관리_출고조회.Click += new System.EventHandler(this.m자재입출고관리_출고조회_Click);
            // 
            // m자재입출고관리_재고조회
            // 
            this.m자재입출고관리_재고조회.Name = "m자재입출고관리_재고조회";
            this.m자재입출고관리_재고조회.Size = new System.Drawing.Size(182, 22);
            this.m자재입출고관리_재고조회.Text = "재고 조회";
            this.m자재입출고관리_재고조회.Click += new System.EventHandler(this.m자재입출고관리_재고조회_Click);
            // 
            // m작업관리
            // 
            this.m작업관리.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m작업관리_작업지시서,
            this.m작업관리_계량});
            this.m작업관리.Name = "m작업관리";
            this.m작업관리.Size = new System.Drawing.Size(71, 20);
            this.m작업관리.Text = "작업 관리";
            // 
            // m작업관리_작업지시서
            // 
            this.m작업관리_작업지시서.Name = "m작업관리_작업지시서";
            this.m작업관리_작업지시서.Size = new System.Drawing.Size(134, 22);
            this.m작업관리_작업지시서.Text = "작업지시서";
            this.m작업관리_작업지시서.Click += new System.EventHandler(this.m작업관리_작업지시서_Click);
            // 
            // m작업관리_계량
            // 
            this.m작업관리_계량.Name = "m작업관리_계량";
            this.m작업관리_계량.Size = new System.Drawing.Size(134, 22);
            this.m작업관리_계량.Text = "계 량";
            this.m작업관리_계량.Click += new System.EventHandler(this.m작업관리_계량_Click);
            // 
            // frm메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 788);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm메인";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "한화 계량/투입 관리 시스템 v1.1 221227";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm메인_Load);
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m파일;
        private System.Windows.Forms.ToolStripMenuItem m파일_설정;
        private System.Windows.Forms.ToolStripMenuItem m파일_종료;
        private System.Windows.Forms.ToolStripMenuItem 기초데이타ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_자재등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_사용자등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_공장부서창고등록;
        private System.Windows.Forms.ToolStripMenuItem 입출고관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m자재입출고관리_입고등록;
        private System.Windows.Forms.ToolStripMenuItem m자재입출고관리_출고등록;
        private System.Windows.Forms.ToolStripMenuItem m작업관리;
        private System.Windows.Forms.ToolStripMenuItem m작업관리_계량;
        private System.Windows.Forms.ToolStripMenuItem m자재입출고관리_투입예정원료예약;
        private System.Windows.Forms.ToolStripStatusLabel ssl;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem m자재입출고관리_입고조회;
        private System.Windows.Forms.ToolStripMenuItem m자재입출고관리_출고조회;
        private System.Windows.Forms.ToolStripMenuItem m자재입출고관리_재고조회;
        private System.Windows.Forms.ToolStripMenuItem m작업관리_작업지시서;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_제품등록;
        private System.Windows.Forms.ToolStripMenuItem 로그조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_공통코드등록;
    }
}

