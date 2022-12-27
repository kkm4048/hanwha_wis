namespace hanwha_wis
{
    partial class frm기초데이타_자재등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기초데이타_자재등록));
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan데이타 = new System.Windows.Forms.Panel();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lblCnt = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.btn엑셀_등록 = new System.Windows.Forms.Button();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btninit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.spr.Location = new System.Drawing.Point(0, 165);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1258, 450);
            this.spr.TabIndex = 98;
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
            // pan데이타
            // 
            this.pan데이타.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan데이타.Controls.Add(this.txt13);
            this.pan데이타.Controls.Add(this.label13);
            this.pan데이타.Controls.Add(this.txt12);
            this.pan데이타.Controls.Add(this.label12);
            this.pan데이타.Controls.Add(this.txt11);
            this.pan데이타.Controls.Add(this.label11);
            this.pan데이타.Controls.Add(this.txt10);
            this.pan데이타.Controls.Add(this.txt9);
            this.pan데이타.Controls.Add(this.label10);
            this.pan데이타.Controls.Add(this.label8);
            this.pan데이타.Controls.Add(this.txt8);
            this.pan데이타.Controls.Add(this.label4);
            this.pan데이타.Controls.Add(this.txt7);
            this.pan데이타.Controls.Add(this.label9);
            this.pan데이타.Controls.Add(this.label7);
            this.pan데이타.Controls.Add(this.txt6);
            this.pan데이타.Controls.Add(this.label6);
            this.pan데이타.Controls.Add(this.txt5);
            this.pan데이타.Controls.Add(this.label5);
            this.pan데이타.Controls.Add(this.txt4);
            this.pan데이타.Controls.Add(this.lblCnt);
            this.pan데이타.Controls.Add(this.txt3);
            this.pan데이타.Controls.Add(this.txt2);
            this.pan데이타.Controls.Add(this.label2);
            this.pan데이타.Controls.Add(this.txt1);
            this.pan데이타.Controls.Add(this.label1);
            this.pan데이타.Controls.Add(this.label3);
            this.pan데이타.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan데이타.Location = new System.Drawing.Point(0, 50);
            this.pan데이타.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan데이타.Name = "pan데이타";
            this.pan데이타.Size = new System.Drawing.Size(1258, 115);
            this.pan데이타.TabIndex = 100;
            // 
            // txt13
            // 
            this.txt13.Location = new System.Drawing.Point(488, 74);
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(84, 21);
            this.txt13.TabIndex = 12;
            this.txt13.TextChanged += new System.EventHandler(this.txt13_TextChanged);
            this.txt13.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt13_MouseDoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(453, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 120;
            this.label13.Text = "색상";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt12
            // 
            this.txt12.Location = new System.Drawing.Point(88, 74);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(322, 21);
            this.txt12.TabIndex = 11;
            this.txt12.Enter += new System.EventHandler(this.txt_Enter);
            this.txt12.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 118;
            this.label12.Text = "비고";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt11
            // 
            this.txt11.Location = new System.Drawing.Point(954, 50);
            this.txt11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt11.MaxLength = 0;
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(146, 21);
            this.txt11.TabIndex = 10;
            this.txt11.Enter += new System.EventHandler(this.txt_Enter);
            this.txt11.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 117;
            this.label11.Text = "내외자구분";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(822, 49);
            this.txt10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt10.MaxLength = 0;
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(62, 21);
            this.txt10.TabIndex = 9;
            this.txt10.Enter += new System.EventHandler(this.txt_Enter);
            this.txt10.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt9
            // 
            this.txt9.Location = new System.Drawing.Point(649, 49);
            this.txt9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt9.MaxLength = 0;
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(108, 21);
            this.txt9.TabIndex = 8;
            this.txt9.Enter += new System.EventHandler(this.txt_Enter);
            this.txt9.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 115;
            this.label10.Text = "단위중량";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 113;
            this.label8.Text = "자재코드명";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(488, 49);
            this.txt8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt8.MaxLength = 0;
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(84, 21);
            this.txt8.TabIndex = 7;
            this.txt8.Enter += new System.EventHandler(this.txt_Enter);
            this.txt8.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 12);
            this.label4.TabIndex = 112;
            this.label4.Text = "적용Sieve";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(318, 49);
            this.txt7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt7.MaxLength = 0;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(92, 21);
            this.txt7.TabIndex = 6;
            this.txt7.Enter += new System.EventHandler(this.txt_Enter);
            this.txt7.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 109;
            this.label9.Text = "제조사약어";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 106;
            this.label7.Text = "INDEX유무";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(88, 49);
            this.txt6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt6.MaxLength = 0;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(153, 21);
            this.txt6.TabIndex = 5;
            this.txt6.Enter += new System.EventHandler(this.txt_Enter);
            this.txt6.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1106, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 104;
            this.label6.Text = "제조국가코드";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(1189, 22);
            this.txt5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt5.MaxLength = 0;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(51, 21);
            this.txt5.TabIndex = 4;
            this.txt5.Enter += new System.EventHandler(this.txt_Enter);
            this.txt5.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(890, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "제조국가";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(954, 22);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt4.MaxLength = 0;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(146, 21);
            this.txt4.TabIndex = 3;
            this.txt4.Enter += new System.EventHandler(this.txt_Enter);
            this.txt4.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(12, 88);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(649, 22);
            this.txt3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt3.MaxLength = 0;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(235, 21);
            this.txt3.TabIndex = 2;
            this.txt3.Enter += new System.EventHandler(this.txt_Enter);
            this.txt3.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(318, 22);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.MaxLength = 0;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(254, 21);
            this.txt2.TabIndex = 1;
            this.txt2.Enter += new System.EventHandler(this.txt_Enter);
            this.txt2.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 81;
            this.label2.Text = "제조사";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(88, 22);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(153, 21);
            this.txt1.TabIndex = 0;
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "자재코드";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "자재명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.White;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.txt조회);
            this.pan등록.Controls.Add(this.btn엑셀_등록);
            this.pan등록.Controls.Add(this.lbl타이틀);
            this.pan등록.Controls.Add(this.btnDelete);
            this.pan등록.Controls.Add(this.btnAdd);
            this.pan등록.Controls.Add(this.btnEdit);
            this.pan등록.Controls.Add(this.btninit);
            this.pan등록.Controls.Add(this.btnSearch);
            this.pan등록.Controls.Add(this.btnClose);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 0);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(1258, 50);
            this.pan등록.TabIndex = 99;
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(380, 12);
            this.txt조회.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt조회.MaxLength = 0;
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(153, 21);
            this.txt조회.TabIndex = 149;
            this.txt조회.TextChanged += new System.EventHandler(this.txt조회_TextChanged);
            this.txt조회.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // btn엑셀_등록
            // 
            this.btn엑셀_등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀_등록.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀_등록.Image")));
            this.btn엑셀_등록.Location = new System.Drawing.Point(934, 8);
            this.btn엑셀_등록.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀_등록.Name = "btn엑셀_등록";
            this.btn엑셀_등록.Size = new System.Drawing.Size(115, 31);
            this.btn엑셀_등록.TabIndex = 148;
            this.btn엑셀_등록.Text = " 엑셀 등록";
            this.btn엑셀_등록.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀_등록.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀_등록.UseVisualStyleBackColor = true;
            this.btn엑셀_등록.Click += new System.EventHandler(this.btn엑셀_등록_Click);
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
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(826, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "    삭 제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(648, 7);
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
            this.btnEdit.Location = new System.Drawing.Point(737, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "    수 정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btninit
            // 
            this.btninit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninit.Image = ((System.Drawing.Image)(resources.GetObject("btninit.Image")));
            this.btninit.Location = new System.Drawing.Point(551, 7);
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
            // frm기초데이타_자재등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 615);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.pan데이타);
            this.Controls.Add(this.pan등록);
            this.Name = "frm기초데이타_자재등록";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "frm기초데이타_자재등록";
            this.Text = "자재 등록";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm기초데이타_자재등록_Load);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn엑셀_등록;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt13;
        private System.Windows.Forms.Label label13;
    }
}