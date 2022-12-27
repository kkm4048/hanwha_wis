namespace hanwha_wis
{
    partial class frm기초데이타_공장부서창고등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기초데이타_공장부서창고등록));
            this.t시작 = new System.Windows.Forms.Timer(this.components);
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan창고_데이타 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btninit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCnt = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pan창고 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn바코드출력 = new System.Windows.Forms.Button();
            this.btn초기화2 = new System.Windows.Forms.Button();
            this.btn삭제2 = new System.Windows.Forms.Button();
            this.btn등록2 = new System.Windows.Forms.Button();
            this.btn수정2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.txt23 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.spr3 = new FarPoint.Win.Spread.FpSpread();
            this.spr3_Sheet2 = new FarPoint.Win.Spread.SheetView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn초기화3 = new System.Windows.Forms.Button();
            this.btn삭제3 = new System.Windows.Forms.Button();
            this.btn등록3 = new System.Windows.Forms.Button();
            this.btn수정3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCnt3 = new System.Windows.Forms.Label();
            this.txt33 = new System.Windows.Forms.TextBox();
            this.txt32 = new System.Windows.Forms.TextBox();
            this.txt31 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan창고_데이타.SuspendLayout();
            this.pan등록.SuspendLayout();
            this.pan창고.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr3_Sheet2)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.spr.Location = new System.Drawing.Point(0, 150);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(565, 448);
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
            // pan창고_데이타
            // 
            this.pan창고_데이타.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan창고_데이타.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan창고_데이타.Controls.Add(this.label9);
            this.pan창고_데이타.Controls.Add(this.txt5);
            this.pan창고_데이타.Controls.Add(this.label8);
            this.pan창고_데이타.Controls.Add(this.txt4);
            this.pan창고_데이타.Controls.Add(this.label5);
            this.pan창고_데이타.Controls.Add(this.btninit);
            this.pan창고_데이타.Controls.Add(this.btnDelete);
            this.pan창고_데이타.Controls.Add(this.lblCnt);
            this.pan창고_데이타.Controls.Add(this.btnAdd);
            this.pan창고_데이타.Controls.Add(this.btnEdit);
            this.pan창고_데이타.Controls.Add(this.txt3);
            this.pan창고_데이타.Controls.Add(this.txt2);
            this.pan창고_데이타.Controls.Add(this.txt1);
            this.pan창고_데이타.Controls.Add(this.label1);
            this.pan창고_데이타.Controls.Add(this.label3);
            this.pan창고_데이타.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan창고_데이타.Location = new System.Drawing.Point(0, 0);
            this.pan창고_데이타.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan창고_데이타.Name = "pan창고_데이타";
            this.pan창고_데이타.Size = new System.Drawing.Size(565, 150);
            this.pan창고_데이타.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 106;
            this.label9.Text = "비고";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(68, 103);
            this.txt5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt5.MaxLength = 0;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(262, 21);
            this.txt5.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 104;
            this.label8.Text = "연락처";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(68, 80);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt4.MaxLength = 0;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(198, 21);
            this.txt4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "주소";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btninit
            // 
            this.btninit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninit.Image = ((System.Drawing.Image)(resources.GetObject("btninit.Image")));
            this.btninit.Location = new System.Drawing.Point(344, 8);
            this.btninit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(90, 32);
            this.btninit.TabIndex = 40;
            this.btninit.Text = "   초기화";
            this.btninit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninit.UseVisualStyleBackColor = true;
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(440, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "    삭 제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(4, 133);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(440, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "    등 록";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(440, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "    수 정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(68, 57);
            this.txt3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt3.MaxLength = 0;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(262, 21);
            this.txt3.TabIndex = 2;
            this.txt3.Enter += new System.EventHandler(this.txt_Enter);
            this.txt3.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(68, 34);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.MaxLength = 0;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(198, 21);
            this.txt2.TabIndex = 1;
            this.txt2.Enter += new System.EventHandler(this.txt_Enter);
            this.txt2.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(68, 11);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(198, 21);
            this.txt1.TabIndex = 0;
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "공장명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "담당자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.White;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.lbl타이틀);
            this.pan등록.Controls.Add(this.btnSearch);
            this.pan등록.Controls.Add(this.btnClose);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 0);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(1120, 50);
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
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(332, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "    조 회";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // pan창고
            // 
            this.pan창고.Controls.Add(this.spr);
            this.pan창고.Controls.Add(this.pan창고_데이타);
            this.pan창고.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan창고.Location = new System.Drawing.Point(0, 50);
            this.pan창고.Name = "pan창고";
            this.pan창고.Size = new System.Drawing.Size(565, 598);
            this.pan창고.TabIndex = 104;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn바코드출력);
            this.panel1.Controls.Add(this.btn초기화2);
            this.panel1.Controls.Add(this.btn삭제2);
            this.panel1.Controls.Add(this.btn등록2);
            this.panel1.Controls.Add(this.btn수정2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCnt2);
            this.panel1.Controls.Add(this.txt23);
            this.panel1.Controls.Add(this.txt22);
            this.panel1.Controls.Add(this.txt21);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 119);
            this.panel1.TabIndex = 105;
            // 
            // btn바코드출력
            // 
            this.btn바코드출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn바코드출력.Image = ((System.Drawing.Image)(resources.GetObject("btn바코드출력.Image")));
            this.btn바코드출력.Location = new System.Drawing.Point(461, 3);
            this.btn바코드출력.Name = "btn바코드출력";
            this.btn바코드출력.Size = new System.Drawing.Size(116, 36);
            this.btn바코드출력.TabIndex = 164;
            this.btn바코드출력.Text = "  바코드 출력";
            this.btn바코드출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn바코드출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn바코드출력.UseVisualStyleBackColor = true;
            this.btn바코드출력.Visible = false;
            this.btn바코드출력.Click += new System.EventHandler(this.btn바코드출력_Click);
            // 
            // btn초기화2
            // 
            this.btn초기화2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화2.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화2.Image")));
            this.btn초기화2.Location = new System.Drawing.Point(239, 4);
            this.btn초기화2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화2.Name = "btn초기화2";
            this.btn초기화2.Size = new System.Drawing.Size(90, 32);
            this.btn초기화2.TabIndex = 106;
            this.btn초기화2.Text = "   초기화";
            this.btn초기화2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화2.UseVisualStyleBackColor = true;
            this.btn초기화2.Click += new System.EventHandler(this.btn초기화2_Click);
            // 
            // btn삭제2
            // 
            this.btn삭제2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제2.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제2.Image")));
            this.btn삭제2.Location = new System.Drawing.Point(334, 78);
            this.btn삭제2.Name = "btn삭제2";
            this.btn삭제2.Size = new System.Drawing.Size(90, 32);
            this.btn삭제2.TabIndex = 105;
            this.btn삭제2.Text = "    삭 제";
            this.btn삭제2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제2.UseVisualStyleBackColor = true;
            this.btn삭제2.Click += new System.EventHandler(this.btn삭제2_Click);
            // 
            // btn등록2
            // 
            this.btn등록2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn등록2.Image = ((System.Drawing.Image)(resources.GetObject("btn등록2.Image")));
            this.btn등록2.Location = new System.Drawing.Point(334, 4);
            this.btn등록2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn등록2.Name = "btn등록2";
            this.btn등록2.Size = new System.Drawing.Size(90, 32);
            this.btn등록2.TabIndex = 104;
            this.btn등록2.Text = "    등 록";
            this.btn등록2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn등록2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn등록2.UseVisualStyleBackColor = true;
            this.btn등록2.Click += new System.EventHandler(this.btn등록2_Click);
            // 
            // btn수정2
            // 
            this.btn수정2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정2.Image = ((System.Drawing.Image)(resources.GetObject("btn수정2.Image")));
            this.btn수정2.Location = new System.Drawing.Point(334, 42);
            this.btn수정2.Name = "btn수정2";
            this.btn수정2.Size = new System.Drawing.Size(90, 32);
            this.btn수정2.TabIndex = 103;
            this.btn수정2.Text = "    수 정";
            this.btn수정2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정2.UseVisualStyleBackColor = true;
            this.btn수정2.Click += new System.EventHandler(this.btn수정2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 102;
            this.label2.Text = "비고";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(4, 83);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(11, 12);
            this.lblCnt2.TabIndex = 98;
            this.lblCnt2.Text = "0";
            // 
            // txt23
            // 
            this.txt23.Location = new System.Drawing.Point(80, 58);
            this.txt23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt23.MaxLength = 0;
            this.txt23.Name = "txt23";
            this.txt23.Size = new System.Drawing.Size(198, 21);
            this.txt23.TabIndex = 103;
            this.txt23.Enter += new System.EventHandler(this.txt_Enter);
            this.txt23.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt22
            // 
            this.txt22.Location = new System.Drawing.Point(80, 31);
            this.txt22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt22.MaxLength = 0;
            this.txt22.Name = "txt22";
            this.txt22.Size = new System.Drawing.Size(146, 21);
            this.txt22.TabIndex = 102;
            this.txt22.Enter += new System.EventHandler(this.txt_Enter);
            this.txt22.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt21
            // 
            this.txt21.Enabled = false;
            this.txt21.Location = new System.Drawing.Point(80, 4);
            this.txt21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt21.MaxLength = 0;
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(146, 21);
            this.txt21.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "공장명";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 60;
            this.label7.Text = "부서명";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr2.Location = new System.Drawing.Point(0, 119);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(553, 170);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.spr2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(565, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 291);
            this.panel2.TabIndex = 107;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.spr3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(565, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 307);
            this.panel3.TabIndex = 108;
            // 
            // spr3
            // 
            this.spr3.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr3.Location = new System.Drawing.Point(0, 119);
            this.spr3.Name = "spr3";
            this.spr3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr3_Sheet2});
            this.spr3.Size = new System.Drawing.Size(553, 186);
            this.spr3.TabIndex = 106;
            this.spr3.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr3_CellClick);
            // 
            // spr3_Sheet2
            // 
            this.spr3_Sheet2.Reset();
            spr3_Sheet2.SheetName = "Sheet2";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr3_Sheet2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr3_Sheet2.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr3_Sheet2.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet2.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr3_Sheet2.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.RowHeader.Columns.Default.Resizable = false;
            this.spr3_Sheet2.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet2.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr3_Sheet2.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet2.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr3_Sheet2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btn초기화3);
            this.panel4.Controls.Add(this.btn삭제3);
            this.panel4.Controls.Add(this.btn등록3);
            this.panel4.Controls.Add(this.btn수정3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblCnt3);
            this.panel4.Controls.Add(this.txt33);
            this.panel4.Controls.Add(this.txt32);
            this.panel4.Controls.Add(this.txt31);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(553, 119);
            this.panel4.TabIndex = 105;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(461, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 164;
            this.button1.Text = "  바코드 출력";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // btn초기화3
            // 
            this.btn초기화3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화3.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화3.Image")));
            this.btn초기화3.Location = new System.Drawing.Point(239, 4);
            this.btn초기화3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화3.Name = "btn초기화3";
            this.btn초기화3.Size = new System.Drawing.Size(90, 32);
            this.btn초기화3.TabIndex = 106;
            this.btn초기화3.Text = "   초기화";
            this.btn초기화3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화3.UseVisualStyleBackColor = true;
            this.btn초기화3.Click += new System.EventHandler(this.btn초기화3_Click);
            // 
            // btn삭제3
            // 
            this.btn삭제3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제3.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제3.Image")));
            this.btn삭제3.Location = new System.Drawing.Point(334, 78);
            this.btn삭제3.Name = "btn삭제3";
            this.btn삭제3.Size = new System.Drawing.Size(90, 32);
            this.btn삭제3.TabIndex = 105;
            this.btn삭제3.Text = "    삭 제";
            this.btn삭제3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제3.UseVisualStyleBackColor = true;
            this.btn삭제3.Click += new System.EventHandler(this.btn삭제3_Click);
            // 
            // btn등록3
            // 
            this.btn등록3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn등록3.Image = ((System.Drawing.Image)(resources.GetObject("btn등록3.Image")));
            this.btn등록3.Location = new System.Drawing.Point(334, 4);
            this.btn등록3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn등록3.Name = "btn등록3";
            this.btn등록3.Size = new System.Drawing.Size(90, 32);
            this.btn등록3.TabIndex = 104;
            this.btn등록3.Text = "    등 록";
            this.btn등록3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn등록3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn등록3.UseVisualStyleBackColor = true;
            this.btn등록3.Click += new System.EventHandler(this.btn등록3_Click);
            // 
            // btn수정3
            // 
            this.btn수정3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정3.Image = ((System.Drawing.Image)(resources.GetObject("btn수정3.Image")));
            this.btn수정3.Location = new System.Drawing.Point(334, 42);
            this.btn수정3.Name = "btn수정3";
            this.btn수정3.Size = new System.Drawing.Size(90, 32);
            this.btn수정3.TabIndex = 103;
            this.btn수정3.Text = "    수 정";
            this.btn수정3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정3.UseVisualStyleBackColor = true;
            this.btn수정3.Click += new System.EventHandler(this.btn수정3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 102;
            this.label4.Text = "비고";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCnt3
            // 
            this.lblCnt3.AutoSize = true;
            this.lblCnt3.Location = new System.Drawing.Point(4, 83);
            this.lblCnt3.Name = "lblCnt3";
            this.lblCnt3.Size = new System.Drawing.Size(11, 12);
            this.lblCnt3.TabIndex = 98;
            this.lblCnt3.Text = "0";
            // 
            // txt33
            // 
            this.txt33.Location = new System.Drawing.Point(80, 58);
            this.txt33.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt33.MaxLength = 0;
            this.txt33.Name = "txt33";
            this.txt33.Size = new System.Drawing.Size(198, 21);
            this.txt33.TabIndex = 103;
            // 
            // txt32
            // 
            this.txt32.Location = new System.Drawing.Point(80, 31);
            this.txt32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt32.MaxLength = 0;
            this.txt32.Name = "txt32";
            this.txt32.Size = new System.Drawing.Size(146, 21);
            this.txt32.TabIndex = 102;
            // 
            // txt31
            // 
            this.txt31.Enabled = false;
            this.txt31.Location = new System.Drawing.Point(80, 4);
            this.txt31.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt31.MaxLength = 0;
            this.txt31.Name = "txt31";
            this.txt31.Size = new System.Drawing.Size(146, 21);
            this.txt31.TabIndex = 101;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 70;
            this.label11.Text = "공장명";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 60;
            this.label12.Text = "창고명";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm기초데이타_공장부서창고등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 648);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pan창고);
            this.Controls.Add(this.pan등록);
            this.Name = "frm기초데이타_공장부서창고등록";
            this.Text = "공장/부서/창고 등록";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm기초데이타_공장부서창고등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan창고_데이타.ResumeLayout(false);
            this.pan창고_데이타.PerformLayout();
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.pan창고.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr3_Sheet2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t시작;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan창고_데이타;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl타이틀;
        private System.Windows.Forms.Panel pan창고;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.TextBox txt23;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Button btn삭제2;
        private System.Windows.Forms.Button btn등록2;
        private System.Windows.Forms.Button btn수정2;
        private System.Windows.Forms.Button btn초기화2;
        private System.Windows.Forms.Button btn바코드출력;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn초기화3;
        private System.Windows.Forms.Button btn삭제3;
        private System.Windows.Forms.Button btn등록3;
        private System.Windows.Forms.Button btn수정3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCnt3;
        private System.Windows.Forms.TextBox txt33;
        private System.Windows.Forms.TextBox txt32;
        private System.Windows.Forms.TextBox txt31;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FarPoint.Win.Spread.FpSpread spr3;
        private FarPoint.Win.Spread.SheetView spr3_Sheet2;
    }
}