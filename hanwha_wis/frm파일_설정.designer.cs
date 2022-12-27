namespace hanwha_wis
{
    partial class frm파일_설정
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm파일_설정));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb라벨프린터 = new System.Windows.Forms.ComboBox();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.btn저장 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb공장 = new System.Windows.Forms.ComboBox();
            this.cmbA4프린터 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "라벨 프린터";
            // 
            // cmb라벨프린터
            // 
            this.cmb라벨프린터.FormattingEnabled = true;
            this.cmb라벨프린터.Location = new System.Drawing.Point(160, 94);
            this.cmb라벨프린터.Name = "cmb라벨프린터";
            this.cmb라벨프린터.Size = new System.Drawing.Size(403, 20);
            this.cmb라벨프린터.TabIndex = 1;
            // 
            // btn닫기
            // 
            this.btn닫기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn닫기.Image = ((System.Drawing.Image)(resources.GetObject("btn닫기.Image")));
            this.btn닫기.Location = new System.Drawing.Point(22, 13);
            this.btn닫기.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(90, 32);
            this.btn닫기.TabIndex = 43;
            this.btn닫기.Text = "    닫 기";
            this.btn닫기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn닫기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.btn닫기_Click);
            // 
            // btn저장
            // 
            this.btn저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn저장.Image = ((System.Drawing.Image)(resources.GetObject("btn저장.Image")));
            this.btn저장.Location = new System.Drawing.Point(160, 13);
            this.btn저장.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(90, 32);
            this.btn저장.TabIndex = 44;
            this.btn저장.Text = "   저 장";
            this.btn저장.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn저장.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "공장";
            // 
            // cmb공장
            // 
            this.cmb공장.FormattingEnabled = true;
            this.cmb공장.Location = new System.Drawing.Point(160, 63);
            this.cmb공장.Name = "cmb공장";
            this.cmb공장.Size = new System.Drawing.Size(403, 20);
            this.cmb공장.TabIndex = 46;
            // 
            // cmbA4프린터
            // 
            this.cmbA4프린터.FormattingEnabled = true;
            this.cmbA4프린터.Location = new System.Drawing.Point(160, 130);
            this.cmbA4프린터.Name = "cmbA4프린터";
            this.cmbA4프린터.Size = new System.Drawing.Size(403, 20);
            this.cmbA4프린터.TabIndex = 48;
            this.cmbA4프린터.SelectedIndexChanged += new System.EventHandler(this.A4프린터_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "A4 프린터";
            // 
            // frm파일_설정
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbA4프린터);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb공장);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn닫기);
            this.Controls.Add(this.btn저장);
            this.Controls.Add(this.cmb라벨프린터);
            this.Controls.Add(this.label1);
            this.Name = "frm파일_설정";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "설 정";
            this.Load += new System.EventHandler(this.frm파일_설정_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb라벨프린터;
        private System.Windows.Forms.Button btn닫기;
        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb공장;
        private System.Windows.Forms.ComboBox cmbA4프린터;
        private System.Windows.Forms.Label label3;
    }
}