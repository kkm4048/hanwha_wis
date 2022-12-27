namespace hanwha_wis
{
    partial class frm작업관리_작업지시서
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm작업관리_작업지시서));
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan데이타 = new System.Windows.Forms.Panel();
            this.txtBtno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt혼화일 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt무게비 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn수정 = new System.Windows.Forms.Button();
            this.btn저장 = new System.Windows.Forms.Button();
            this.txt공실번호 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt제품명 = new System.Windows.Forms.TextBox();
            this.btn제품명 = new System.Windows.Forms.Button();
            this.lblCnt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt혼화량 = new System.Windows.Forms.TextBox();
            this.txt사업코드 = new System.Windows.Forms.TextBox();
            this.txt사업명 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn작업지시번호 = new System.Windows.Forms.Button();
            this.txt작업지시번호 = new System.Windows.Forms.TextBox();
            this.cmb창고 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.btn출력 = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn재고량 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan데이타.SuspendLayout();
            this.pan등록.SuspendLayout();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.spr.Location = new System.Drawing.Point(0, 191);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1233, 424);
            this.spr.TabIndex = 98;
            this.spr.EditModeOff += new System.EventHandler(this.spr_EditModeOff);
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.PrintPreviewShowing += new FarPoint.Win.Spread.PrintPreviewShowingEventHandler(this.spr_PrintPreviewShowing);
            this.spr.PrintHeaderFooterArea += new FarPoint.Win.Spread.PrintHeaderFooterAreaEventHandler(this.spr_PrintHeaderFooterArea);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            this.spr.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spr_EditChange);
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
            // pan데이타
            // 
            this.pan데이타.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan데이타.Controls.Add(this.btn재고량);
            this.pan데이타.Controls.Add(this.txtBtno);
            this.pan데이타.Controls.Add(this.label12);
            this.pan데이타.Controls.Add(this.txt혼화일);
            this.pan데이타.Controls.Add(this.label11);
            this.pan데이타.Controls.Add(this.label8);
            this.pan데이타.Controls.Add(this.txt무게비);
            this.pan데이타.Controls.Add(this.label7);
            this.pan데이타.Controls.Add(this.btn수정);
            this.pan데이타.Controls.Add(this.btn저장);
            this.pan데이타.Controls.Add(this.txt공실번호);
            this.pan데이타.Controls.Add(this.label6);
            this.pan데이타.Controls.Add(this.txt제품명);
            this.pan데이타.Controls.Add(this.btn제품명);
            this.pan데이타.Controls.Add(this.lblCnt);
            this.pan데이타.Controls.Add(this.label5);
            this.pan데이타.Controls.Add(this.txt혼화량);
            this.pan데이타.Controls.Add(this.txt사업코드);
            this.pan데이타.Controls.Add(this.txt사업명);
            this.pan데이타.Controls.Add(this.label4);
            this.pan데이타.Controls.Add(this.label3);
            this.pan데이타.Controls.Add(this.label2);
            this.pan데이타.Controls.Add(this.btn작업지시번호);
            this.pan데이타.Controls.Add(this.txt작업지시번호);
            this.pan데이타.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan데이타.Location = new System.Drawing.Point(0, 50);
            this.pan데이타.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan데이타.Name = "pan데이타";
            this.pan데이타.Size = new System.Drawing.Size(1233, 141);
            this.pan데이타.TabIndex = 100;
            // 
            // txtBtno
            // 
            this.txtBtno.Enabled = false;
            this.txtBtno.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBtno.Location = new System.Drawing.Point(854, 96);
            this.txtBtno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBtno.MaxLength = 0;
            this.txtBtno.Name = "txtBtno";
            this.txtBtno.Size = new System.Drawing.Size(177, 32);
            this.txtBtno.TabIndex = 8;
            this.txtBtno.Enter += new System.EventHandler(this.txt_Enter);
            this.txtBtno.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(759, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 205;
            this.label12.Text = "배치번호";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt혼화일
            // 
            this.txt혼화일.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt혼화일.Location = new System.Drawing.Point(598, 96);
            this.txt혼화일.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt혼화일.MaxLength = 0;
            this.txt혼화일.Name = "txt혼화일";
            this.txt혼화일.Size = new System.Drawing.Size(155, 32);
            this.txt혼화일.TabIndex = 7;
            this.txt혼화일.TextChanged += new System.EventHandler(this.txt혼화일_TextChanged);
            this.txt혼화일.Enter += new System.EventHandler(this.txt_Enter);
            this.txt혼화일.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(524, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 203;
            this.label11.Text = "혼화일";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(494, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 19);
            this.label8.TabIndex = 201;
            this.label8.Text = "%";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt무게비
            // 
            this.txt무게비.Enabled = false;
            this.txt무게비.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt무게비.Location = new System.Drawing.Point(404, 96);
            this.txt무게비.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt무게비.MaxLength = 0;
            this.txt무게비.Name = "txt무게비";
            this.txt무게비.Size = new System.Drawing.Size(84, 32);
            this.txt무게비.TabIndex = 6;
            this.txt무게비.Enter += new System.EventHandler(this.txt_Enter);
            this.txt무게비.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(329, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 200;
            this.label7.Text = "혼합비";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn수정
            // 
            this.btn수정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn수정.Image = ((System.Drawing.Image)(resources.GetObject("btn수정.Image")));
            this.btn수정.Location = new System.Drawing.Point(1066, 88);
            this.btn수정.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn수정.Name = "btn수정";
            this.btn수정.Size = new System.Drawing.Size(107, 40);
            this.btn수정.TabIndex = 198;
            this.btn수정.Text = "    수 정";
            this.btn수정.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정.UseVisualStyleBackColor = true;
            this.btn수정.Click += new System.EventHandler(this.btn수정_Click);
            // 
            // btn저장
            // 
            this.btn저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn저장.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn저장.Image = ((System.Drawing.Image)(resources.GetObject("btn저장.Image")));
            this.btn저장.Location = new System.Drawing.Point(1066, 10);
            this.btn저장.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(107, 58);
            this.btn저장.TabIndex = 197;
            this.btn저장.Text = "  저 장";
            this.btn저장.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn저장.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // txt공실번호
            // 
            this.txt공실번호.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt공실번호.Location = new System.Drawing.Point(954, 53);
            this.txt공실번호.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt공실번호.MaxLength = 0;
            this.txt공실번호.Name = "txt공실번호";
            this.txt공실번호.Size = new System.Drawing.Size(77, 32);
            this.txt공실번호.TabIndex = 4;
            this.txt공실번호.TextChanged += new System.EventHandler(this.txt공실번호_TextChanged);
            this.txt공실번호.Enter += new System.EventHandler(this.txt_Enter);
            this.txt공실번호.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(850, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 196;
            this.label6.Text = "공실번호";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt제품명
            // 
            this.txt제품명.Enabled = false;
            this.txt제품명.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt제품명.Location = new System.Drawing.Point(598, 10);
            this.txt제품명.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt제품명.MaxLength = 0;
            this.txt제품명.Name = "txt제품명";
            this.txt제품명.Size = new System.Drawing.Size(219, 32);
            this.txt제품명.TabIndex = 1;
            this.txt제품명.TextChanged += new System.EventHandler(this.txt제품명_TextChanged);
            // 
            // btn제품명
            // 
            this.btn제품명.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn제품명.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn제품명.Location = new System.Drawing.Point(493, 7);
            this.btn제품명.Name = "btn제품명";
            this.btn제품명.Size = new System.Drawing.Size(99, 39);
            this.btn제품명.TabIndex = 194;
            this.btn제품명.Text = "제품명";
            this.btn제품명.UseVisualStyleBackColor = false;
            this.btn제품명.Click += new System.EventHandler(this.btn제품명_Click);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(12, 116);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 193;
            this.lblCnt.Text = "0";
            this.lblCnt.Click += new System.EventHandler(this.lblCnt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(283, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 192;
            this.label5.Text = "kg";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt혼화량
            // 
            this.txt혼화량.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt혼화량.Location = new System.Drawing.Point(172, 96);
            this.txt혼화량.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt혼화량.MaxLength = 0;
            this.txt혼화량.Name = "txt혼화량";
            this.txt혼화량.Size = new System.Drawing.Size(105, 32);
            this.txt혼화량.TabIndex = 5;
            this.txt혼화량.TextChanged += new System.EventHandler(this.txt혼화량_TextChanged);
            this.txt혼화량.Enter += new System.EventHandler(this.txt_Enter);
            this.txt혼화량.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt사업코드
            // 
            this.txt사업코드.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt사업코드.Location = new System.Drawing.Point(598, 53);
            this.txt사업코드.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt사업코드.MaxLength = 0;
            this.txt사업코드.Name = "txt사업코드";
            this.txt사업코드.Size = new System.Drawing.Size(219, 32);
            this.txt사업코드.TabIndex = 3;
            this.txt사업코드.TextChanged += new System.EventHandler(this.txt사업코드_TextChanged);
            this.txt사업코드.Enter += new System.EventHandler(this.txt_Enter);
            this.txt사업코드.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt사업명
            // 
            this.txt사업명.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt사업명.Location = new System.Drawing.Point(172, 53);
            this.txt사업명.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt사업명.MaxLength = 0;
            this.txt사업명.Name = "txt사업명";
            this.txt사업명.Size = new System.Drawing.Size(316, 32);
            this.txt사업명.TabIndex = 2;
            this.txt사업명.Enter += new System.EventHandler(this.txt_Enter);
            this.txt사업명.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(50, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 188;
            this.label4.Text = "혼화량";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(494, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 187;
            this.label3.Text = "사업코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(50, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 186;
            this.label2.Text = "사업명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn작업지시번호
            // 
            this.btn작업지시번호.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn작업지시번호.Location = new System.Drawing.Point(15, 7);
            this.btn작업지시번호.Name = "btn작업지시번호";
            this.btn작업지시번호.Size = new System.Drawing.Size(151, 39);
            this.btn작업지시번호.TabIndex = 185;
            this.btn작업지시번호.Text = "작업지시번호";
            this.btn작업지시번호.UseVisualStyleBackColor = true;
            this.btn작업지시번호.Click += new System.EventHandler(this.btn작업지시번호_Click);
            // 
            // txt작업지시번호
            // 
            this.txt작업지시번호.Enabled = false;
            this.txt작업지시번호.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt작업지시번호.Location = new System.Drawing.Point(172, 10);
            this.txt작업지시번호.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt작업지시번호.MaxLength = 0;
            this.txt작업지시번호.Name = "txt작업지시번호";
            this.txt작업지시번호.Size = new System.Drawing.Size(235, 32);
            this.txt작업지시번호.TabIndex = 0;
            this.txt작업지시번호.TextChanged += new System.EventHandler(this.txt작업지시번호_TextChanged);
            // 
            // cmb창고
            // 
            this.cmb창고.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb창고.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb창고.FormattingEnabled = true;
            this.cmb창고.Location = new System.Drawing.Point(718, 12);
            this.cmb창고.Name = "cmb창고";
            this.cmb창고.Size = new System.Drawing.Size(220, 27);
            this.cmb창고.TabIndex = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(663, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "창고";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.White;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.btn출력);
            this.pan등록.Controls.Add(this.dtp);
            this.pan등록.Controls.Add(this.cmb창고);
            this.pan등록.Controls.Add(this.lbl타이틀);
            this.pan등록.Controls.Add(this.btnSearch);
            this.pan등록.Controls.Add(this.label1);
            this.pan등록.Controls.Add(this.btnClose);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 0);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(1233, 50);
            this.pan등록.TabIndex = 99;
            // 
            // btn출력
            // 
            this.btn출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn출력.Image = ((System.Drawing.Image)(resources.GetObject("btn출력.Image")));
            this.btn출력.Location = new System.Drawing.Point(1065, 7);
            this.btn출력.Name = "btn출력";
            this.btn출력.Size = new System.Drawing.Size(82, 35);
            this.btn출력.TabIndex = 691;
            this.btn출력.Text = "   출 력";
            this.btn출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn출력.UseVisualStyleBackColor = true;
            this.btn출력.Click += new System.EventHandler(this.btn출력_Click);
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp.Location = new System.Drawing.Point(411, 12);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(232, 26);
            this.dtp.TabIndex = 149;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lbl타이틀
            // 
            this.lbl타이틀.AutoSize = true;
            this.lbl타이틀.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl타이틀.Location = new System.Drawing.Point(11, 15);
            this.lbl타이틀.Name = "lbl타이틀";
            this.lbl타이틀.Size = new System.Drawing.Size(59, 16);
            this.lbl타이틀.TabIndex = 44;
            this.lbl타이틀.Text = "타이틀";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(277, 7);
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
            this.btnClose.Location = new System.Drawing.Point(174, 7);
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
            // btn재고량
            // 
            this.btn재고량.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn재고량.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn재고량.Image = ((System.Drawing.Image)(resources.GetObject("btn재고량.Image")));
            this.btn재고량.Location = new System.Drawing.Point(924, 11);
            this.btn재고량.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn재고량.Name = "btn재고량";
            this.btn재고량.Size = new System.Drawing.Size(107, 35);
            this.btn재고량.TabIndex = 206;
            this.btn재고량.Text = " 재고량";
            this.btn재고량.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn재고량.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn재고량.UseVisualStyleBackColor = true;
            this.btn재고량.Click += new System.EventHandler(this.btn재고량_Click);
            // 
            // frm작업관리_작업지시서
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 615);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.pan데이타);
            this.Controls.Add(this.pan등록);
            this.Name = "frm작업관리_작업지시서";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "작업지시서";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm작업관리_작업지시서_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan데이타.ResumeLayout(false);
            this.pan데이타.PerformLayout();
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan데이타;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl타이틀;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cmb창고;
        private System.Windows.Forms.Button btn작업지시번호;
        private System.Windows.Forms.TextBox txt작업지시번호;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt혼화량;
        private System.Windows.Forms.TextBox txt사업코드;
        private System.Windows.Forms.TextBox txt사업명;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt제품명;
        private System.Windows.Forms.Button btn제품명;
        private System.Windows.Forms.TextBox txt공실번호;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.Button btn수정;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt무게비;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBtno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt혼화일;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn출력;
        private System.Windows.Forms.Button btn재고량;
    }
}