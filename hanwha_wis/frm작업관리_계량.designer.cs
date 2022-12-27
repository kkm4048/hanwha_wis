namespace hanwha_wis
{
    partial class frm작업관리_계량
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm작업관리_계량));
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan데이타 = new System.Windows.Forms.Panel();
            this.txt완료 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pan메세지 = new System.Windows.Forms.Panel();
            this.txt메세지 = new System.Windows.Forms.TextBox();
            this.txtBTNo = new System.Windows.Forms.TextBox();
            this.txt혼화일 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pan저울 = new System.Windows.Forms.Panel();
            this.btn저울값전송 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt저울 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt재고량 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt로트번호 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt바코드 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt무게비 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btn바코드출력 = new System.Windows.Forms.Button();
            this.btn출력 = new System.Windows.Forms.Button();
            this.txt시간 = new System.Windows.Forms.TextBox();
            this.txt일자 = new System.Windows.Forms.TextBox();
            this.btn취소 = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.t포커스 = new System.Windows.Forms.Timer(this.components);
            this.t저울 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan데이타.SuspendLayout();
            this.pan메세지.SuspendLayout();
            this.pan저울.SuspendLayout();
            this.pan등록.SuspendLayout();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.spr.Location = new System.Drawing.Point(0, 229);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1375, 386);
            this.spr.TabIndex = 98;
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
            this.pan데이타.Controls.Add(this.txt완료);
            this.pan데이타.Controls.Add(this.label14);
            this.pan데이타.Controls.Add(this.pan메세지);
            this.pan데이타.Controls.Add(this.txtBTNo);
            this.pan데이타.Controls.Add(this.txt혼화일);
            this.pan데이타.Controls.Add(this.label16);
            this.pan데이타.Controls.Add(this.pan저울);
            this.pan데이타.Controls.Add(this.label12);
            this.pan데이타.Controls.Add(this.txt재고량);
            this.pan데이타.Controls.Add(this.label11);
            this.pan데이타.Controls.Add(this.txt로트번호);
            this.pan데이타.Controls.Add(this.label10);
            this.pan데이타.Controls.Add(this.txt바코드);
            this.pan데이타.Controls.Add(this.label9);
            this.pan데이타.Controls.Add(this.label7);
            this.pan데이타.Controls.Add(this.txt무게비);
            this.pan데이타.Controls.Add(this.label8);
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
            this.pan데이타.Size = new System.Drawing.Size(1375, 179);
            this.pan데이타.TabIndex = 100;
            // 
            // txt완료
            // 
            this.txt완료.BackColor = System.Drawing.Color.White;
            this.txt완료.Enabled = false;
            this.txt완료.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt완료.Location = new System.Drawing.Point(1007, 10);
            this.txt완료.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt완료.MaxLength = 0;
            this.txt완료.Name = "txt완료";
            this.txt완료.Size = new System.Drawing.Size(90, 32);
            this.txt완료.TabIndex = 213;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(940, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 19);
            this.label14.TabIndex = 212;
            this.label14.Text = "완료";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pan메세지
            // 
            this.pan메세지.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan메세지.Controls.Add(this.txt메세지);
            this.pan메세지.Location = new System.Drawing.Point(822, 133);
            this.pan메세지.Name = "pan메세지";
            this.pan메세지.Size = new System.Drawing.Size(424, 40);
            this.pan메세지.TabIndex = 101;
            // 
            // txt메세지
            // 
            this.txt메세지.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt메세지.Location = new System.Drawing.Point(0, 0);
            this.txt메세지.Multiline = true;
            this.txt메세지.Name = "txt메세지";
            this.txt메세지.Size = new System.Drawing.Size(422, 38);
            this.txt메세지.TabIndex = 0;
            // 
            // txtBTNo
            // 
            this.txtBTNo.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBTNo.Location = new System.Drawing.Point(331, 10);
            this.txtBTNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBTNo.MaxLength = 0;
            this.txtBTNo.Name = "txtBTNo";
            this.txtBTNo.Size = new System.Drawing.Size(196, 32);
            this.txtBTNo.TabIndex = 211;
            // 
            // txt혼화일
            // 
            this.txt혼화일.BackColor = System.Drawing.Color.White;
            this.txt혼화일.Enabled = false;
            this.txt혼화일.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt혼화일.Location = new System.Drawing.Point(628, 94);
            this.txt혼화일.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt혼화일.MaxLength = 0;
            this.txt혼화일.Name = "txt혼화일";
            this.txt혼화일.ReadOnly = true;
            this.txt혼화일.Size = new System.Drawing.Size(165, 32);
            this.txt혼화일.TabIndex = 209;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(559, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 19);
            this.label16.TabIndex = 210;
            this.label16.Text = "혼화일";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pan저울
            // 
            this.pan저울.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pan저울.Controls.Add(this.btn저울값전송);
            this.pan저울.Controls.Add(this.label13);
            this.pan저울.Controls.Add(this.txt저울);
            this.pan저울.Location = new System.Drawing.Point(1091, 41);
            this.pan저울.Name = "pan저울";
            this.pan저울.Size = new System.Drawing.Size(312, 43);
            this.pan저울.TabIndex = 208;
            // 
            // btn저울값전송
            // 
            this.btn저울값전송.Location = new System.Drawing.Point(174, 3);
            this.btn저울값전송.Name = "btn저울값전송";
            this.btn저울값전송.Size = new System.Drawing.Size(103, 39);
            this.btn저울값전송.TabIndex = 194;
            this.btn저울값전송.Text = "저울값전송";
            this.btn저울값전송.UseVisualStyleBackColor = true;
            this.btn저울값전송.Click += new System.EventHandler(this.btn저울값전송_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(123, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 19);
            this.label13.TabIndex = 193;
            this.label13.Text = "kg";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt저울
            // 
            this.txt저울.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt저울.Location = new System.Drawing.Point(16, 9);
            this.txt저울.Name = "txt저울";
            this.txt저울.Size = new System.Drawing.Size(101, 26);
            this.txt저울.TabIndex = 0;
            this.txt저울.TextChanged += new System.EventHandler(this.txt저울_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(771, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 19);
            this.label12.TabIndex = 207;
            this.label12.Text = "kg";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt재고량
            // 
            this.txt재고량.BackColor = System.Drawing.Color.White;
            this.txt재고량.Enabled = false;
            this.txt재고량.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt재고량.Location = new System.Drawing.Point(628, 136);
            this.txt재고량.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt재고량.MaxLength = 0;
            this.txt재고량.Name = "txt재고량";
            this.txt재고량.Size = new System.Drawing.Size(137, 32);
            this.txt재고량.TabIndex = 205;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(558, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 206;
            this.label11.Text = "재고량";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt로트번호
            // 
            this.txt로트번호.BackColor = System.Drawing.Color.White;
            this.txt로트번호.Enabled = false;
            this.txt로트번호.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt로트번호.Location = new System.Drawing.Point(884, 94);
            this.txt로트번호.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt로트번호.MaxLength = 0;
            this.txt로트번호.Name = "txt로트번호";
            this.txt로트번호.Size = new System.Drawing.Size(362, 32);
            this.txt로트번호.TabIndex = 203;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(789, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 204;
            this.label10.Text = "로트번호";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt바코드
            // 
            this.txt바코드.BackColor = System.Drawing.Color.White;
            this.txt바코드.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt바코드.Location = new System.Drawing.Point(169, 136);
            this.txt바코드.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt바코드.MaxLength = 0;
            this.txt바코드.Name = "txt바코드";
            this.txt바코드.Size = new System.Drawing.Size(383, 32);
            this.txt바코드.TabIndex = 0;
            this.txt바코드.TextChanged += new System.EventHandler(this.txt바코드_TextChanged);
            this.txt바코드.Enter += new System.EventHandler(this.txt_Enter);
            this.txt바코드.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt바코드_KeyDown);
            this.txt바코드.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(47, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 202;
            this.label9.Text = "바코드";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(500, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 19);
            this.label7.TabIndex = 201;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt무게비
            // 
            this.txt무게비.BackColor = System.Drawing.Color.White;
            this.txt무게비.Enabled = false;
            this.txt무게비.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt무게비.Location = new System.Drawing.Point(404, 94);
            this.txt무게비.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt무게비.MaxLength = 0;
            this.txt무게비.Name = "txt무게비";
            this.txt무게비.ReadOnly = true;
            this.txt무게비.Size = new System.Drawing.Size(81, 32);
            this.txt무게비.TabIndex = 199;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(335, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 200;
            this.label8.Text = "혼합비";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn수정
            // 
            this.btn수정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn수정.Image = ((System.Drawing.Image)(resources.GetObject("btn수정.Image")));
            this.btn수정.Location = new System.Drawing.Point(1187, 0);
            this.btn수정.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn수정.Name = "btn수정";
            this.btn수정.Size = new System.Drawing.Size(107, 40);
            this.btn수정.TabIndex = 198;
            this.btn수정.Text = "    수 정";
            this.btn수정.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정.UseVisualStyleBackColor = true;
            this.btn수정.Visible = false;
            this.btn수정.Click += new System.EventHandler(this.btn수정_Click);
            // 
            // btn저장
            // 
            this.btn저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn저장.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn저장.Image = ((System.Drawing.Image)(resources.GetObject("btn저장.Image")));
            this.btn저장.Location = new System.Drawing.Point(1229, 0);
            this.btn저장.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(123, 82);
            this.btn저장.TabIndex = 197;
            this.btn저장.Text = "    저 장";
            this.btn저장.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn저장.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Visible = false;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // txt공실번호
            // 
            this.txt공실번호.BackColor = System.Drawing.Color.White;
            this.txt공실번호.Enabled = false;
            this.txt공실번호.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt공실번호.Location = new System.Drawing.Point(934, 52);
            this.txt공실번호.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt공실번호.MaxLength = 0;
            this.txt공실번호.Name = "txt공실번호";
            this.txt공실번호.ReadOnly = true;
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
            this.label6.Location = new System.Drawing.Point(830, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 196;
            this.label6.Text = "공실번호";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt제품명
            // 
            this.txt제품명.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt제품명.Location = new System.Drawing.Point(628, 10);
            this.txt제품명.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt제품명.MaxLength = 0;
            this.txt제품명.Name = "txt제품명";
            this.txt제품명.Size = new System.Drawing.Size(291, 32);
            this.txt제품명.TabIndex = 1;
            this.txt제품명.TextChanged += new System.EventHandler(this.txt제품명_TextChanged);
            // 
            // btn제품명
            // 
            this.btn제품명.Enabled = false;
            this.btn제품명.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn제품명.Location = new System.Drawing.Point(537, 7);
            this.btn제품명.Name = "btn제품명";
            this.btn제품명.Size = new System.Drawing.Size(85, 39);
            this.btn제품명.TabIndex = 194;
            this.btn제품명.Text = "제품명";
            this.btn제품명.UseVisualStyleBackColor = true;
            this.btn제품명.Click += new System.EventHandler(this.btn제품명_Click);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(13, 151);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 193;
            this.lblCnt.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(280, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 192;
            this.label5.Text = "kg";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt혼화량
            // 
            this.txt혼화량.BackColor = System.Drawing.Color.White;
            this.txt혼화량.Enabled = false;
            this.txt혼화량.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt혼화량.Location = new System.Drawing.Point(169, 94);
            this.txt혼화량.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt혼화량.MaxLength = 0;
            this.txt혼화량.Name = "txt혼화량";
            this.txt혼화량.ReadOnly = true;
            this.txt혼화량.Size = new System.Drawing.Size(105, 32);
            this.txt혼화량.TabIndex = 5;
            this.txt혼화량.TextChanged += new System.EventHandler(this.txt혼화량_TextChanged);
            this.txt혼화량.Enter += new System.EventHandler(this.txt_Enter);
            this.txt혼화량.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt사업코드
            // 
            this.txt사업코드.BackColor = System.Drawing.Color.White;
            this.txt사업코드.Enabled = false;
            this.txt사업코드.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt사업코드.Location = new System.Drawing.Point(628, 52);
            this.txt사업코드.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt사업코드.MaxLength = 0;
            this.txt사업코드.Name = "txt사업코드";
            this.txt사업코드.ReadOnly = true;
            this.txt사업코드.Size = new System.Drawing.Size(186, 32);
            this.txt사업코드.TabIndex = 3;
            this.txt사업코드.Enter += new System.EventHandler(this.txt_Enter);
            this.txt사업코드.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt사업명
            // 
            this.txt사업명.BackColor = System.Drawing.Color.White;
            this.txt사업명.Enabled = false;
            this.txt사업명.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt사업명.Location = new System.Drawing.Point(169, 52);
            this.txt사업명.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt사업명.MaxLength = 0;
            this.txt사업명.Name = "txt사업명";
            this.txt사업명.ReadOnly = true;
            this.txt사업명.Size = new System.Drawing.Size(358, 32);
            this.txt사업명.TabIndex = 2;
            this.txt사업명.Enter += new System.EventHandler(this.txt_Enter);
            this.txt사업명.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(47, 101);
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
            this.label3.Location = new System.Drawing.Point(538, 59);
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
            this.label2.Location = new System.Drawing.Point(47, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 186;
            this.label2.Text = "사업명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn작업지시번호
            // 
            this.btn작업지시번호.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn작업지시번호.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn작업지시번호.Location = new System.Drawing.Point(12, 7);
            this.btn작업지시번호.Name = "btn작업지시번호";
            this.btn작업지시번호.Size = new System.Drawing.Size(151, 39);
            this.btn작업지시번호.TabIndex = 185;
            this.btn작업지시번호.Text = "작업지시번호";
            this.btn작업지시번호.UseVisualStyleBackColor = false;
            this.btn작업지시번호.Click += new System.EventHandler(this.btn작업지시번호_Click);
            // 
            // txt작업지시번호
            // 
            this.txt작업지시번호.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt작업지시번호.Location = new System.Drawing.Point(169, 10);
            this.txt작업지시번호.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt작업지시번호.MaxLength = 0;
            this.txt작업지시번호.Name = "txt작업지시번호";
            this.txt작업지시번호.Size = new System.Drawing.Size(156, 32);
            this.txt작업지시번호.TabIndex = 101;
            this.txt작업지시번호.TextChanged += new System.EventHandler(this.txt작업지시번호_TextChanged);
            // 
            // cmb창고
            // 
            this.cmb창고.Enabled = false;
            this.cmb창고.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb창고.FormattingEnabled = true;
            this.cmb창고.Location = new System.Drawing.Point(623, 10);
            this.cmb창고.Name = "cmb창고";
            this.cmb창고.Size = new System.Drawing.Size(190, 27);
            this.cmb창고.TabIndex = 182;
            this.cmb창고.SelectionChangeCommitted += new System.EventHandler(this.cmb생산라인_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(568, 14);
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
            this.pan등록.Controls.Add(this.btn바코드출력);
            this.pan등록.Controls.Add(this.btn출력);
            this.pan등록.Controls.Add(this.txt시간);
            this.pan등록.Controls.Add(this.txt일자);
            this.pan등록.Controls.Add(this.btn취소);
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
            this.pan등록.Size = new System.Drawing.Size(1375, 50);
            this.pan등록.TabIndex = 99;
            // 
            // btn바코드출력
            // 
            this.btn바코드출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn바코드출력.Image = ((System.Drawing.Image)(resources.GetObject("btn바코드출력.Image")));
            this.btn바코드출력.Location = new System.Drawing.Point(910, 6);
            this.btn바코드출력.Name = "btn바코드출력";
            this.btn바코드출력.Size = new System.Drawing.Size(116, 36);
            this.btn바코드출력.TabIndex = 693;
            this.btn바코드출력.Text = "  바코드 출력";
            this.btn바코드출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn바코드출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn바코드출력.UseVisualStyleBackColor = true;
            this.btn바코드출력.Click += new System.EventHandler(this.btn바코드출력_Click);
            // 
            // btn출력
            // 
            this.btn출력.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn출력.Image = ((System.Drawing.Image)(resources.GetObject("btn출력.Image")));
            this.btn출력.Location = new System.Drawing.Point(822, 6);
            this.btn출력.Name = "btn출력";
            this.btn출력.Size = new System.Drawing.Size(82, 35);
            this.btn출력.TabIndex = 692;
            this.btn출력.Text = "   출 력";
            this.btn출력.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn출력.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn출력.UseVisualStyleBackColor = true;
            this.btn출력.Click += new System.EventHandler(this.btn출력_Click);
            // 
            // txt시간
            // 
            this.txt시간.Enabled = false;
            this.txt시간.Location = new System.Drawing.Point(1134, 27);
            this.txt시간.Name = "txt시간";
            this.txt시간.Size = new System.Drawing.Size(86, 21);
            this.txt시간.TabIndex = 185;
            // 
            // txt일자
            // 
            this.txt일자.Enabled = false;
            this.txt일자.Location = new System.Drawing.Point(1134, 4);
            this.txt일자.Name = "txt일자";
            this.txt일자.Size = new System.Drawing.Size(86, 21);
            this.txt일자.TabIndex = 184;
            // 
            // btn취소
            // 
            this.btn취소.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn취소.Image = ((System.Drawing.Image)(resources.GetObject("btn취소.Image")));
            this.btn취소.Location = new System.Drawing.Point(1032, 7);
            this.btn취소.Name = "btn취소";
            this.btn취소.Size = new System.Drawing.Size(90, 32);
            this.btn취소.TabIndex = 183;
            this.btn취소.Text = "    취 소";
            this.btn취소.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn취소.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn취소.UseVisualStyleBackColor = true;
            this.btn취소.Click += new System.EventHandler(this.btn취소_Click);
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp.Location = new System.Drawing.Point(330, 10);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(232, 26);
            this.dtp.TabIndex = 149;
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
            this.btnSearch.Visible = false;
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
            // t포커스
            // 
            this.t포커스.Tick += new System.EventHandler(this.t포커스_Tick);
            // 
            // t저울
            // 
            this.t저울.Enabled = true;
            this.t저울.Tick += new System.EventHandler(this.t저울_Tick);
            // 
            // frm작업관리_계량
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 615);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.pan데이타);
            this.Controls.Add(this.pan등록);
            this.Name = "frm작업관리_계량";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "계 량";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm작업관리_계량_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan데이타.ResumeLayout(false);
            this.pan데이타.PerformLayout();
            this.pan메세지.ResumeLayout(false);
            this.pan메세지.PerformLayout();
            this.pan저울.ResumeLayout(false);
            this.pan저울.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt무게비;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt바코드;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer t포커스;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt재고량;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt로트번호;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn취소;
        private System.Windows.Forms.Panel pan저울;
        private System.Windows.Forms.Button btn저울값전송;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt저울;
        private System.Windows.Forms.Timer t저울;
        private System.Windows.Forms.TextBox txt시간;
        private System.Windows.Forms.TextBox txt일자;
        private System.Windows.Forms.TextBox txt혼화일;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBTNo;
        private System.Windows.Forms.Button btn출력;
        private System.Windows.Forms.Panel pan메세지;
        private System.Windows.Forms.TextBox txt메세지;
        private System.Windows.Forms.TextBox txt완료;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn바코드출력;
    }
}