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
    public partial class frm기초데이타_공장부서창고등록 : Form
    {

        string sql = "";
        int rRow0 = -1, rRow1 = -1, rRow2 = -1;
        string r위치코드 = "", r위치명;
        private PrintDocument printDoc = new PrintDocument();
        public frm기초데이타_공장부서창고등록()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기초데이타_공장부서창고등록_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            초기화();
            조회();
            조회2();
            조회3();
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


            sql = " exec s_a101_공장_조회 '1','','' ";
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


            sql = " exec s_a101_부서_조회 '1','"  +txt21.Text + "','','' ";
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
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
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
            sql = sql + "EXEC [s_a101_공장_저장] '1'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
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
            sql = sql + "EXEC [s_a101_공장_저장] '2'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
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

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "공장 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_공장_저장] '3'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
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
            txt21.Text = txt1.Text;
            txt31.Text = txt1.Text;
            조회2();
            조회3();
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
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Maximized;
        }

        private void 등록2()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_부서_저장] '1'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
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
            sql = sql + "EXEC [s_a101_부서_저장] '2'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
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

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "부서 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_부서_저장] '3'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
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
        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt21.Text = spr2.ActiveSheet.Cells[e.Row, 0].Text;
            txt22.Text = spr2.ActiveSheet.Cells[e.Row, 1].Text;
            txt23.Text = spr2.ActiveSheet.Cells[e.Row, 2].Text;
        }

        private void btn등록3_Click(object sender, EventArgs e)
        {
            등록3();
        }

        private void btn수정3_Click(object sender, EventArgs e)
        {
            수정3();
        }

        private void btn삭제3_Click(object sender, EventArgs e)
        {
            삭제3();
        }

        private void btn초기화3_Click(object sender, EventArgs e)
        {
            초기화3();
        }
        private void 등록3()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_창고_저장] '1'";
            sql = sql + "   ,'" + txt31.Text + "' ";
            sql = sql + "   ,'" + txt32.Text + "' ";
            sql = sql + "   ,'" + txt33.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회3();
        }
        private void 수정3()
        {

            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_창고_저장] '2'";
            sql = sql + "   ,'" + txt31.Text + "' ";
            sql = sql + "   ,'" + txt32.Text + "' ";
            sql = sql + "   ,'" + txt33.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회3();
        }
        private void 삭제3()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "창고 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_창고_저장] '3'";
            sql = sql + "   ,'" + txt31.Text + "' ";
            sql = sql + "   ,'" + txt32.Text + "' ";
            sql = sql + "   ,'" + txt33.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회3();
        }
        private void 조회3()
        {
            //SPEC


            sql = " exec s_a101_창고_조회 '1','" + txt31.Text + "','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr3.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt3.Text = ds.Tables[0].Rows.Count.ToString();
            spr3.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).Locked = true;
                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr3.Sheets[0]);
            lblCnt3.Text = spr3.ActiveSheet.RowCount.ToString();
        }
        private void 초기화3()
        {
            txt31.Text = "";
            txt32.Text = "";
            txt33.Text = "";
        }

        private void spr3_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt31.Text = spr3.ActiveSheet.Cells[e.Row, 0].Text;
            txt32.Text = spr3.ActiveSheet.Cells[e.Row, 1].Text;
            txt33.Text = spr3.ActiveSheet.Cells[e.Row, 2].Text;
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
