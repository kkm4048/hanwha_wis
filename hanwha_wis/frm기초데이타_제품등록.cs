using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hanwha_wis
{
    public partial class frm기초데이타_제품등록 : Form
    {

        public string r창고 = "", r작업지시번호 = "", r일자 = "", r사업명 = "", r사업코드 = "", r공실번호 = "", r혼화량 = "", r혼화일 = "", rBtno = "", r수식 = "";
        public string r특기사항 = "", r안전검토사항 = "", r제품코드 = "", r제품명 = "";
        string sql = "";
        int rRow0 = -1, rRow1 = -1, rRow2 = -1;
        string r위치코드 = "", r위치명;
        private PrintDocument printDoc = new PrintDocument();
        bool r에러 = false;
        public frm기초데이타_제품등록()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            btn작업지시서생성.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }
        public frm기초데이타_제품등록(string 창고,string 작업지시번호,string 일자, string 제품코드, string 제품명, string 사업명,string 사업코드,string 공실번호,string 혼화량
                , string 혼화일, string Btno, string 수식, string 특기사항, string 안전검토사항)
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            btn작업지시서생성.Visible = true;
            pan등록1.Visible = false;
            pan등록2.Visible = false;
            btn자재코드.Enabled = false;
            this.TopMost = true;

            r창고 = 창고;
            r작업지시번호 = 작업지시번호;
            r일자 = 일자;
            r제품코드 = 제품코드;
            r제품명 = 제품명;
            r사업명 = 사업명;
            r사업코드 = 사업코드;
            r공실번호 = 공실번호;
            r혼화량 = 혼화량;
            r혼화일 = 혼화일;
            rBtno = Btno;
            r수식 = 수식;
            r특기사항 = 특기사항;
            r안전검토사항 = 안전검토사항;

            r특기사항 = 특기사항;
            if (r창고.Equals(""))
            {
                MessageBox.Show("창고를 선택하세요");
                r에러 = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기초데이타_제품등록_Load(object sender, EventArgs e)
        {
            lbl타이틀.Text = "【 " + this.Text + " 】";
            초기화();
            Add구분();
            조회();
            조회2();
            if (r에러)
            {
                Close();
            }
        }
        private void Add구분()
        {
            cls_com.ComboAdd(cmb구분, " select 데이타 from a101_공통코드 where 구분 = '제품구분' order by 번호  ", 1);
        }


        private void 초기화()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void 조회()
        {
            //SPEC


            sql = " exec s_a101_제품_조회 '1','','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 조회2()
        {
            //SPEC
            float d=0;
            lbl혼합비합.Text = "";
            FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
            nc.DecimalPlaces = 3;

            sql = " exec s_a101_제품_BOM_조회 '1','"  +txt21.Text + "','','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr2.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();
            spr2.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr2.Sheets[0].Cells.Get(0, 5, spr2.Sheets[0].RowCount - 1, 6).CellType = nc; 

                for (int i = 0;i < spr2.ActiveSheet.RowCount; i ++)
                {
                    d = d + cls_com.Val_f(spr2.ActiveSheet.Cells[i,5].Text);
                }
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
            if (d > 0 )
            {
                lbl혼합비합.Text = d.ToString() + " %";
            }
             초기화_데이타2();

        }
        private void 초기화_데이타2()
        {
            txt23.Text = "";
            txt24.Text = "";
            txt25.Text = "";
            txt26.Text = "";
            txt27.Text = "";

        }
        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            등록();
        }

        private void 등록()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_제품_저장] '1'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }
        private void 수정()
        {

            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_제품_저장] '2'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }
        private void 삭제()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "데이타 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_제품_저장] '3'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            수정();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            삭제();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt1.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt2.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
            txt3.Text = spr.ActiveSheet.Cells[e.Row, 2].Text;
            cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt4.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            txt5.Text = spr.ActiveSheet.Cells[e.Row, 5].Text;
            txt21.Text = txt1.Text;
            txt22.Text = txt2.Text;
            조회2();
        }

        private void btninit_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;

        }

        private void t시작_Tick(object sender, EventArgs e)
        {
            t시작.Enabled = false;
        }

        private void 등록2()
        {


            sql = " ";
            sql = sql + "EXEC [s_a101_제품_BOM_저장] '1'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            sql = sql + "   ,'" + txt26.Text + "' ";
            sql = sql + "   ,'" + txt27.Text + "' ";
            sql = sql + "   ,'" + txt28.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회2();
        }
        private void 수정2()
        {

            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_제품_BOM_저장] '2'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            sql = sql + "   ,'" + txt26.Text + "' ";
            sql = sql + "   ,'" + txt27.Text + "' ";
            sql = sql + "   ,'" + txt28.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회2();
        }
        private void 삭제2()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "데이타 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_제품_BOM_저장] '3'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            sql = sql + "   ,'" + txt26.Text + "' ";
            sql = sql + "   ,'" + txt27.Text + "' ";
            sql = sql + "   ,'" + txt28.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회2();
        }

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void btn등록2_Click(object sender, EventArgs e)
        {
            등록2();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt27_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt24_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt28_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt26_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt25_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt21_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn복사_Click(object sender, EventArgs e)
        {
            복사();
        }

        private void 복사()
        {
            sql = " ";
            sql = sql + "EXEC [s_a101_제품_복사] '1'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt제품코드.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                } else
                {
                    txt제품코드.Text = "";
                }

            }
            조회();
        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txt22_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt23_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn수정2_Click(object sender, EventArgs e)
        {
            수정2();
        }

        private void btn삭제2_Click(object sender, EventArgs e)
        {
            삭제2();
        }

        private void btn초기화2_Click(object sender, EventArgs e)
        {
            초기화2();
        }
        private void 초기화2()
        {
            txt21.Text = "";
            txt22.Text = "";
            txt23.Text = "";
            txt24.Text = "";
            txt25.Text = "";
            txt26.Text = "";
            txt27.Text = "";
        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt21.Text = spr2.ActiveSheet.Cells[e.Row, 0].Text;
            txt22.Text = spr2.ActiveSheet.Cells[e.Row, 1].Text;
            txt23.Text = spr2.ActiveSheet.Cells[e.Row, 2].Text;
            txt24.Text = spr2.ActiveSheet.Cells[e.Row, 3].Text;
            txt25.Text = spr2.ActiveSheet.Cells[e.Row, 4].Text;
            txt26.Text = spr2.ActiveSheet.Cells[e.Row, 5].Text;
            txt27.Text = spr2.ActiveSheet.Cells[e.Row, 6].Text;
        }

    

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn자재코드_Click(object sender, EventArgs e)
        {
            frm기타_자재조회 frm기타_자재조회 = new frm기타_자재조회();
            frm기타_자재조회.ShowDialog();
            txt24.Text = frm기타_자재조회.r자재코드;
            txt25.Text = frm기타_자재조회.r자재명;
            txt26.Focus();
        }

        private void btn작업지시서생성_Click(object sender, EventArgs e)
        {
            작업지시서생성();
        }

        private void 작업지시서생성()
        {
            sql = " exec s_a301_작업지시서_저장 '1','" + cls_com.g공장 + "','" + r창고 + "','" + r작업지시번호 + "','" + r일자 + "','','" + txt21.Text 
                +"','" +  r사업명 + "','" + r사업코드 + "','" + r공실번호 + "','" + r혼화량 + "','" + r혼화일 + "','" + rBtno  + "','" + r수식 + "','" + r특기사항 
               + "','" + r안전검토사항 + "','','" + cls_com.s사용자.성명 + "','','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            } else
            {
                cls_com.로그(cls_com.s사용자.성명, "작업지시서생성", "생성", sql);

                r작업지시번호 = ds.Tables[0].Rows[0]["작업지시번호"].ToString();
            }
            Close();
        }

        private void btn바코드출력_Click(object sender, EventArgs e)
        {
            바코드출력();
        }

        private void 바코드출력()
        {
            String print;
            print = cls_com.GetDefaultPrinter();
            cls_com.SetDefaultPrinter(cls_com.g라벨프린터);
            PrinterSettings settings = new PrinterSettings();
            settings.Copies = 1; //I put number 2 here
            printDoc.PrinterSettings = settings;
            Application.DoEvents();
            FarPoint.Win.Spread.Model.CellRange[] cr;
            cr = spr2.ActiveSheet.GetSelections();

            if (cr[0].RowCount < 0)
            {
                rRow1 = 0;
                rRow2 = spr2.ActiveSheet.RowCount;
            }
            else
            {
                rRow1 = cr[0].Row;
                rRow2 = cr[0].Row + cr[0].RowCount;
            }
            rRow0 = rRow1;
            printDoc.Print();
            //      Application.DoEvents();
            //            }

            cls_com.SetDefaultPrinter(print);

        }
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Fath.bcType bcType = Fath.bcType.QRCode;
            Font ifont, ifont2, ifont3;
            ifont = new Font("HY견고딕", 10, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 30, GraphicsUnit.Pixel);
            ifont3 = new Font("HY견고딕", 8, GraphicsUnit.Pixel);
            r위치코드 = spr2.ActiveSheet.Cells[rRow0, 2].Text;
            r위치명 = spr2.ActiveSheet.Cells[rRow0, 3].Text;
            cls_com.PrintBarcode(e, r위치코드, 20, 10, 150, 150, "0", "False", ifont2, bcType);
            cls_com.PrintText(e, r위치코드, ifont2, "LEFT", "0", 100, 5, 1, 1);
            cls_com.PrintText(e, r위치명, ifont2, "LEFT", "0", 100, 40, 1, 1);
            if (rRow0 < (rRow2 - 1))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            rRow0++;
        }
    }
}
