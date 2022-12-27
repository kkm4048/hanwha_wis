namespace hanwha_wis
{
    partial class frm자재입출고관리_입고등록
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm자재입출고관리_입고등록));
            this.t시작 = new System.Windows.Forms.Timer(this.components);
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan자재_데이타 = new System.Windows.Forms.Panel();
            this.lblCnt = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.Button();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pan입고 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb창고 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt로트번호 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt시간 = new System.Windows.Forms.TextBox();
            this.txt일자 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.cmb구분 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb상태 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btn바코드출력 = new System.Windows.Forms.Button();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.btn등록 = new System.Windows.Forms.Button();
            this.btn수정 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.label16 = new System.Windows.Forms.Label();
            this.txt출력매수 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan자재_데이타.SuspendLayout();
            this.pan등록.SuspendLayout();
            this.pan입고.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.SuspendLayout();
            // 
            // t시작
            // 
            this.t시작.Enabled = true;
            this.t시작.Tick += new System.EventHandler(this.t시작_Tick);
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 72);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(376, 438);
            this.spr.TabIndex = 101;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            // 
            // spr_Sheet1
            // 
            this.spr_Sheet1.Reset();
            spr_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // pan자재_데이타
            // 
            this.pan자재_데이타.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan자재_데이타.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan자재_데이타.Controls.Add(this.lblCnt);
            this.pan자재_데이타.Controls.Add(this.btn조회);
            this.pan자재_데이타.Controls.Add(this.txt조회);
            this.pan자재_데이타.Controls.Add(this.label1);
            this.pan자재_데이타.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan자재_데이타.Location = new System.Drawing.Point(0, 0);
            this.pan자재_데이타.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan자재_데이타.Name = "pan자재_데이타";
            this.pan자재_데이타.Size = new System.Drawing.Size(376, 72);
            this.pan자재_데이타.TabIndex = 103;
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(4, 43);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // btn조회
            // 
            this.btn조회.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회.Image = ((System.Drawing.Image)(resources.GetObject("btn조회.Image")));
            this.btn조회.Location = new System.Drawing.Point(274, 5);
            this.btn조회.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(90, 32);
            this.btn조회.TabIndex = 39;
            this.btn조회.Text = "    조 회";
            this.btn조회.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(56, 12);
            this.txt조회.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt조회.MaxLength = 0;
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(198, 21);
            this.txt조회.TabIndex = 0;
            this.txt조회.TextChanged += new System.EventHandler(this.txt조회_TextChanged);
            this.txt조회.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "조회";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 104;
            this.label8.Text = "일자";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.White;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.lbl타이틀);
            this.pan등록.Controls.Add(this.btnClose);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 0);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(1286, 50);
            this.pan등록.TabIndex = 102;
            // 
            // lbl타이틀
            // 
            this.lbl타이틀.AutoSize = true;
            this.lbl타이틀.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl타이틀.Location = new System.Drawing.Point(3, 15);
            this.lbl타이틀.Name = "lbl타이틀";
            this.lbl타이틀.Size = new System.Drawing.Size(59, 16);
            this.lbl타이틀.TabIndex = 45;
            this.lbl타이틀.Text = "타이틀";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(240, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "    닫 기";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pan입고
            // 
            this.pan입고.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan입고.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan입고.Controls.Add(this.txt출력매수);
            this.pan입고.Controls.Add(this.label16);
            this.pan입고.Controls.Add(this.label15);
            this.pan입고.Controls.Add(this.txt7);
            this.pan입고.Controls.Add(this.label14);
            this.pan입고.Controls.Add(this.txt6);
            this.pan입고.Controls.Add(this.label9);
            this.pan입고.Controls.Add(this.cmb창고);
            this.pan입고.Controls.Add(this.label5);
            this.pan입고.Controls.Add(this.txt로트번호);
            this.pan입고.Controls.Add(this.label3);
            this.pan입고.Controls.Add(this.txt시간);
            this.pan입고.Controls.Add(this.txt일자);
            this.pan입고.Controls.Add(this.label13);
            this.pan입고.Controls.Add(this.txt8);
            this.pan입고.Controls.Add(this.label12);
            this.pan입고.Controls.Add(this.txt5);
            this.pan입고.Controls.Add(this.label11);
            this.pan입고.Controls.Add(this.txt4);
            this.pan입고.Controls.Add(this.cmb구분);
            this.pan입고.Controls.Add(this.label10);
            this.pan입고.Controls.Add(this.cmb상태);
            this.pan입고.Controls.Add(this.label4);
            this.pan입고.Controls.Add(this.dtp);
            this.pan입고.Controls.Add(this.btn바코드출력);
            this.pan입고.Controls.Add(this.btn초기화);
            this.pan입고.Controls.Add(this.label8);
            this.pan입고.Controls.Add(this.btn삭제);
            this.pan입고.Controls.Add(this.btn등록);
            this.pan입고.Controls.Add(this.btn수정);
            this.pan입고.Controls.Add(this.label2);
            this.pan입고.Controls.Add(this.lblCnt2);
            this.pan입고.Controls.Add(this.txt3);
            this.pan입고.Controls.Add(this.txt2);
            this.pan입고.Controls.Add(this.txt1);
            this.pan입고.Controls.Add(this.label6);
            this.pan입고.Controls.Add(this.label7);
            this.pan입고.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan입고.Location = new System.Drawing.Point(0, 0);
            this.pan입고.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan입고.Name = "pan입고";
            this.pan입고.Size = new System.Drawing.Size(906, 198);
            this.pan입고.TabIndex = 105;
            this.pan입고.Paint += new System.Windows.Forms.PaintEventHandler(this.pan입고_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 186;
            this.label15.Text = "입고량";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(89, 87);
            this.txt7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt7.MaxLength = 0;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(84, 21);
            this.txt7.TabIndex = 6;
            this.txt7.Enter += new System.EventHandler(this.txt_Enter);
            this.txt7.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(643, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 184;
            this.label14.Text = "용도";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(678, 61);
            this.txt6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt6.MaxLength = 0;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(215, 21);
            this.txt6.TabIndex = 5;
            this.txt6.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt6.Enter += new System.EventHandler(this.txt_Enter);
            this.txt6.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 12);
            this.label9.TabIndex = 182;
            this.label9.Text = "kg";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb창고
            // 
            this.cmb창고.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb창고.FormattingEnabled = true;
            this.cmb창고.Location = new System.Drawing.Point(306, 9);
            this.cmb창고.Name = "cmb창고";
            this.cmb창고.Size = new System.Drawing.Size(146, 20);
            this.cmb창고.TabIndex = 181;
            this.cmb창고.SelectedIndexChanged += new System.EventHandler(this.cmb창고_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 180;
            this.label5.Text = "창고";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt로트번호
            // 
            this.txt로트번호.Enabled = false;
            this.txt로트번호.Location = new System.Drawing.Point(569, 11);
            this.txt로트번호.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt로트번호.MaxLength = 0;
            this.txt로트번호.Name = "txt로트번호";
            this.txt로트번호.Size = new System.Drawing.Size(166, 21);
            this.txt로트번호.TabIndex = 179;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 178;
            this.label3.Text = "로트번호";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt시간
            // 
            this.txt시간.Enabled = false;
            this.txt시간.Location = new System.Drawing.Point(833, 11);
            this.txt시간.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt시간.MaxLength = 0;
            this.txt시간.Name = "txt시간";
            this.txt시간.Size = new System.Drawing.Size(96, 21);
            this.txt시간.TabIndex = 177;
            // 
            // txt일자
            // 
            this.txt일자.Enabled = false;
            this.txt일자.Location = new System.Drawing.Point(741, 11);
            this.txt일자.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt일자.MaxLength = 0;
            this.txt일자.Name = "txt일자";
            this.txt일자.Size = new System.Drawing.Size(86, 21);
            this.txt일자.TabIndex = 176;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(206, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 174;
            this.label13.Text = "비고";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(241, 87);
            this.txt8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt8.MaxLength = 0;
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(211, 21);
            this.txt8.TabIndex = 7;
            this.txt8.Enter += new System.EventHandler(this.txt_Enter);
            this.txt8.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 172;
            this.label12.Text = "제조사";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(518, 61);
            this.txt5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt5.MaxLength = 0;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(119, 21);
            this.txt5.TabIndex = 4;
            this.txt5.TextChanged += new System.EventHandler(this.txt5_TextChanged);
            this.txt5.Enter += new System.EventHandler(this.txt_Enter);
            this.txt5.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 170;
            this.label11.Text = "INDEX";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(306, 61);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt4.MaxLength = 0;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(146, 21);
            this.txt4.TabIndex = 3;
            this.txt4.Enter += new System.EventHandler(this.txt_Enter);
            this.txt4.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // cmb구분
            // 
            this.cmb구분.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb구분.FormattingEnabled = true;
            this.cmb구분.Location = new System.Drawing.Point(813, 36);
            this.cmb구분.Name = "cmb구분";
            this.cmb구분.Size = new System.Drawing.Size(80, 20);
            this.cmb구분.TabIndex = 169;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(778, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 168;
            this.label10.Text = "구분";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb상태
            // 
            this.cmb상태.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb상태.FormattingEnabled = true;
            this.cmb상태.Location = new System.Drawing.Point(678, 36);
            this.cmb상태.Name = "cmb상태";
            this.cmb상태.Size = new System.Drawing.Size(83, 20);
            this.cmb상태.TabIndex = 167;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 166;
            this.label4.Text = "상태";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(89, 11);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(158, 21);
            this.dtp.TabIndex = 165;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // btn바코드출력
            // 
            this.btn바코드출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn바코드출력.Image = ((System.Drawing.Image)(resources.GetObject("btn바코드출력.Image")));
            this.btn바코드출력.Location = new System.Drawing.Point(473, 113);
            this.btn바코드출력.Name = "btn바코드출력";
            this.btn바코드출력.Size = new System.Drawing.Size(116, 36);
            this.btn바코드출력.TabIndex = 164;
            this.btn바코드출력.Text = "  바코드 출력";
            this.btn바코드출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn바코드출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn바코드출력.UseVisualStyleBackColor = true;
            this.btn바코드출력.Click += new System.EventHandler(this.btn바코드출력_Click);
            // 
            // btn초기화
            // 
            this.btn초기화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화.Image")));
            this.btn초기화.Location = new System.Drawing.Point(44, 115);
            this.btn초기화.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화.Name = "btn초기화";
            this.btn초기화.Size = new System.Drawing.Size(90, 32);
            this.btn초기화.TabIndex = 106;
            this.btn초기화.Text = "   초기화";
            this.btn초기화.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화.UseVisualStyleBackColor = true;
            this.btn초기화.Click += new System.EventHandler(this.btn초기화_Click);
            // 
            // btn삭제
            // 
            this.btn삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제.Image")));
            this.btn삭제.Location = new System.Drawing.Point(359, 115);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(90, 32);
            this.btn삭제.TabIndex = 105;
            this.btn삭제.Text = "    취 소";
            this.btn삭제.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // btn등록
            // 
            this.btn등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn등록.Image = ((System.Drawing.Image)(resources.GetObject("btn등록.Image")));
            this.btn등록.Location = new System.Drawing.Point(167, 115);
            this.btn등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn등록.Name = "btn등록";
            this.btn등록.Size = new System.Drawing.Size(90, 32);
            this.btn등록.TabIndex = 104;
            this.btn등록.Text = "    등 록";
            this.btn등록.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn등록.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn등록.UseVisualStyleBackColor = true;
            this.btn등록.Click += new System.EventHandler(this.btn등록_Click);
            // 
            // btn수정
            // 
            this.btn수정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정.Image = ((System.Drawing.Image)(resources.GetObject("btn수정.Image")));
            this.btn수정.Location = new System.Drawing.Point(263, 115);
            this.btn수정.Name = "btn수정";
            this.btn수정.Size = new System.Drawing.Size(90, 32);
            this.btn수정.TabIndex = 103;
            this.btn수정.Text = "    수 정";
            this.btn수정.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정.UseVisualStyleBackColor = true;
            this.btn수정.Visible = false;
            this.btn수정.Click += new System.EventHandler(this.btn수정_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 102;
            this.label2.Text = "제조사 로트";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(18, 167);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(11, 12);
            this.lblCnt2.TabIndex = 98;
            this.lblCnt2.Text = "0";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(89, 61);
            this.txt3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt3.MaxLength = 0;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(146, 21);
            this.txt3.TabIndex = 2;
            this.txt3.Enter += new System.EventHandler(this.txt_Enter);
            this.txt3.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt2
            // 
            this.txt2.Enabled = false;
            this.txt2.Location = new System.Drawing.Point(306, 36);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.MaxLength = 0;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(331, 21);
            this.txt2.TabIndex = 1;
            this.txt2.Enter += new System.EventHandler(this.txt_Enter);
            this.txt2.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt1
            // 
            this.txt1.Enabled = false;
            this.txt1.Location = new System.Drawing.Point(89, 36);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(146, 21);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "자재코드";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 60;
            this.label7.Text = "자재명";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr2.Location = new System.Drawing.Point(0, 198);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(906, 312);
            this.spr2.TabIndex = 106;
            this.spr2.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr2_ColumnWidthChanged);
            this.spr2.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr2_CellClick);
            // 
            // spr2_Sheet1
            // 
            this.spr2_Sheet1.Reset();
            spr2_Sheet1.SheetName = "Sheet2";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr2_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr2_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr2_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr2_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr2_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc.Location = new System.Drawing.Point(0, 50);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.spr);
            this.sc.Panel1.Controls.Add(this.pan자재_데이타);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.spr2);
            this.sc.Panel2.Controls.Add(this.pan입고);
            this.sc.Size = new System.Drawing.Size(1286, 510);
            this.sc.SplitterDistance = 376;
            this.sc.TabIndex = 107;
            this.sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_SplitterMoved);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(608, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 187;
            this.label16.Text = "출력매수";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txt출력매수
            // 
            this.txt출력매수.Location = new System.Drawing.Point(667, 122);
            this.txt출력매수.Name = "txt출력매수";
            this.txt출력매수.Size = new System.Drawing.Size(60, 21);
            this.txt출력매수.TabIndex = 188;
            this.txt출력매수.Text = "1";
            this.txt출력매수.TextChanged += new System.EventHandler(this.txt출력매수_TextChanged);
            // 
            // frm자재입출고관리_입고등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 560);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.pan등록);
            this.Name = "frm자재입출고관리_입고등록";
            this.Text = "자재 입고 등록";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm자재입출고관리_입고등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan자재_데이타.ResumeLayout(false);
            this.pan자재_데이타.PerformLayout();
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.pan입고.ResumeLayout(false);
            this.pan입고.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t시작;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan자재_데이타;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl타이틀;
        private System.Windows.Forms.Panel pan입고;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Button btn등록;
        private System.Windows.Forms.Button btn수정;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn바코드출력;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb구분;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb상태;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt시간;
        private System.Windows.Forms.TextBox txt일자;
        private System.Windows.Forms.TextBox txt로트번호;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb창고;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt출력매수;
        private System.Windows.Forms.Label label16;
    }
}