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
    public partial class frm자재입출고관리_입고등록 : Form
    {

        string sql = "";
        int rRow0 = -1, rRow1 = -1, rRow2 = -1;
        string r자재명 = "", r바코드 = "", r입고일자 = "", r제조사 = "", r제조사로트 = "", r로트번호 = "", r자재코드 = "";
        
        private PrintDocument printDoc = new PrintDocument();
        public frm자재입출고관리_입고등록()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm자재입출고관리_입고등록_Load(object sender, EventArgs e)
        {
            string d;
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            d = cls_com.ConfigLoad(this.Name + "_sc넓이","500");
            sc.SplitterDistance = cls_com.Val(d);

            d= cls_com.ConfigLoad(this.Name + "_출력매수");
            txt출력매수.Text = d;

            dtp.Value = cls_com.GetDate();
            초기화();
            Add창고();
            Add상태();
            Add구분();
            조회();
            조회2();

        }
        private void Add창고()
        {
            cls_com.ComboAdd(cmb창고, " select 창고 from a101_창고 where 공장 = '" + cls_com.g공장 + "' ",1);
        }


        private void Add상태()
        {
            cls_com.ComboAdd(cmb상태, " exec s_a101_공통코드_조회 '2','자재상태','','' ", 1);

        }
        private void Add구분()
        {
            cls_com.ComboAdd(cmb구분, " exec s_a101_공통코드_조회 '2','자재구분','','' ", 1);

        }
        private void 조회()
        {
            sql = " exec s_a101_자재_조회 '1','','','" + txt조회.Text + "'";
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 40;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

                cls_com.색삭_spr(spr, spr.ActiveSheet.ColumnCount - 1, 2);
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
            cls_com.Sort표시(spr.ActiveSheet);
        }
        private void 조회2()
        {
            FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
            nc.DecimalPlaces = 3;
            nc.ShowSeparator = true;
            

            sql = " exec s_a201_자재_입고_조회 '1','" + cls_com.g공장 + "','','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetDate(dtp.Value) + "','','','','','','','' ";
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
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 5, spr2.Sheets[0].RowCount - 1, 5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr2.Sheets[0].Cells.Get(0, 8, spr2.Sheets[0].RowCount - 1, 8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr2.Sheets[0].Cells.Get(0, 13, spr2.Sheets[0].RowCount - 1, 14).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                spr2.Sheets[0].Cells.Get(0, 13, spr2.Sheets[0].RowCount - 1, 14).CellType = nc;
                cls_com.색삭_spr(spr2, spr2.ActiveSheet.ColumnCount - 1, 8);
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
            sql = sql + "EXEC [s_a201_자재_입고_저장] '1'";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + cmb창고.Text  + "' ";
            sql = sql + "   ,'" + cls_com.GetDate(dtp.Value) + "','' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + cmb상태.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "   ,'" + txt로트번호.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";     //제조사
            sql = sql + "   ,'" + txt4.Text + "' ";     //제조사로트
            sql = sql + "   ,'" + txt5.Text + "' ";     // ind    
            sql = sql + "   ,'" + txt6.Text + "' ";    //용도
            sql = sql + "   ,'" + txt7.Text + "' ";    // 입고량
            sql = sql + "   ,'" + txt7.Text + "' ";    // 재고량
            sql = sql + "   ,'" + txt8.Text + "' ";    // 비고
            sql = sql + "   ,'" + cls_com.s사용자.성명 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }
                else
                {
                    cls_com.로그(cls_com.s사용자.성명, "입고등록", "등록", sql);
                    txt로트번호.Text = ds.Tables[0].Rows[0][1].ToString();
                }

            }
            조회2();
        }
        private void 수정()
        {

            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a201_자재_입고_저장] '2'";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + cmb창고.Text + "' ";
            sql = sql + "   ,'" + txt일자.Text  + "','" + txt시간.Text +"' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + cmb상태.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "   ,'" + txt로트번호.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt8.Text + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.성명 + "' ";
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
        private void 삭제()
        {

            if (MessageBox.Show("취소 하시겠습니까 ? ", "취소", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a201_자재_입고_저장] '3'";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + cmb창고.Text + "' ";
            sql = sql + "   ,'" + txt일자.Text  + "','" + txt시간.Text + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + cmb상태.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "   ,'" + txt로트번호.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt8.Text + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.성명 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }else
                {
                    cls_com.로그(cls_com.s사용자.성명, "입고등록", "취소", sql);

                }

            }
            조회2();
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
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt일자.Text = "";
            txt시간.Text = "";
            조회2();

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

      
        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void btn등록_Click(object sender, EventArgs e)
        {
            등록();
        }

        private void btn수정_Click(object sender, EventArgs e)
        {
            수정();
        }

        private void btn삭제_Click(object sender, EventArgs e)
        {
            삭제();
        }

        private void btn초기화_Click(object sender, EventArgs e)
        {
            초기화();
        }
        private void 초기화()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

            if (e.Row < 0 || e.Column < 0  || spr2.ActiveSheet.RowCount <= 0  ) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt일자.Text = spr2.ActiveSheet.Cells[e.Row, 2].Text;
            txt시간.Text = spr2.ActiveSheet.Cells[e.Row, 3].Text;
            txt1.Text = spr2.ActiveSheet.Cells[e.Row, 4].Text;
            txt2.Text = spr2.ActiveSheet.Cells[e.Row, 5].Text;
            cmb상태.Text = spr2.ActiveSheet.Cells[e.Row, 6].Text;
            cmb구분.Text = spr2.ActiveSheet.Cells[e.Row, 7].Text;
            txt로트번호.Text = spr2.ActiveSheet.Cells[e.Row, 8].Text;
            txt3.Text = spr2.ActiveSheet.Cells[e.Row, 9].Text;
            txt4.Text = spr2.ActiveSheet.Cells[e.Row, 10].Text;
            txt5.Text = spr2.ActiveSheet.Cells[e.Row, 11].Text;
            txt6.Text = spr2.ActiveSheet.Cells[e.Row, 12].Text;
            txt7.Text = spr2.ActiveSheet.Cells[e.Row, 13].Text;
            txt8.Text = spr2.ActiveSheet.Cells[e.Row, 15].Text;

        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_sc넓이", sc.SplitterDistance.ToString());
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
            조회2();
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            자재_로트번호();
            조회2();
        }

        private void btn바코드출력_Click(object sender, EventArgs e)
        {
            바코드출력();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            자재_로트번호();
        }

        private void cmb창고_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_창고", cmb창고.Text);
        }

        private void txt출력매수_TextChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_출력매수", txt출력매수.Text);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pan입고_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 바코드출력()
        {
            String print;
            print = cls_com.GetDefaultPrinter();
            cls_com.SetDefaultPrinter(cls_com.g라벨프린터);
            PrinterSettings settings = new PrinterSettings();
            settings.Copies = (short)cls_com.Val(txt출력매수.Text) ; //I put number 2 here
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
            for (int i = rRow1; i < rRow2; i++) { 
                rRow0 = i;
                printDoc.Print();
            }
            //      Application.DoEvents();
            //            }

            cls_com.SetDefaultPrinter(print);

        }
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Fath.bcType bcType = Fath.bcType.QRCode;
            Font ifont, ifont2, ifont3;
            ifont = new Font("HY견고딕", 10, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 20, GraphicsUnit.Pixel);
            ifont3 = new Font("HY견고딕", 8, GraphicsUnit.Pixel);
            r입고일자 = spr2.ActiveSheet.Cells[rRow0, 2].Text;
            r자재코드 = spr2.ActiveSheet.Cells[rRow0, 4].Text;
            r자재명 = spr2.ActiveSheet.Cells[rRow0, 5].Text;
            r바코드 = spr2.ActiveSheet.Cells[rRow0, 8].Text;
            r로트번호 = spr2.ActiveSheet.Cells[rRow0, 8].Text;
            r제조사 = spr2.ActiveSheet.Cells[rRow0, 9].Text;
            r제조사로트 = spr2.ActiveSheet.Cells[rRow0, 10].Text;

            cls_com.PrintBarcode(e, r바코드, 20, 20, 200, 200, "0", "False", ifont2, bcType);
            cls_com.PrintText(e, "입고일자 : " + r입고일자, ifont2, "LEFT", "0", 120, 20, 1, 1);
            cls_com.PrintText(e, "자재코드 : " + r자재코드, ifont2, "LEFT", "0", 120, 45, 1, 1);
            cls_com.PrintText(e, "제품명 : " + r자재명, ifont2, "LEFT", "0", 120, 70, 1, 1);
            cls_com.PrintText(e, "로트번호 : " + r로트번호, ifont2, "LEFT", "0", 20, 100, 1, 1);
            cls_com.PrintText(e, "제조사 : " + r제조사 ,ifont2, "LEFT", "0", 20, 125, 1, 1);
            cls_com.PrintText(e, "제조사 로트 : " + r제조사, ifont2, "LEFT", "0", 20, 150, 1, 1);
            cls_com.PrintText(e, "관리번호 : " , ifont2, "LEFT", "0", 20, 175, 1, 1);
            cls_com.PrintText(e, "드럼번호 : ", ifont2, "LEFT", "0", 20, 200, 1, 1);

        }

        private void 자재_로트번호()
        {
            sql = " SELECT DBO.F_자재_로트번호('" +  cls_com.g공장+ "','" + cmb창고.Text + "','" + txt1.Text + "','" + cls_com.GetDate(dtp.Value) + "' ) 자재_로트번호 ";
            DataSet ds = cls_com.Select_Query(sql);
            txt로트번호.Text = ds.Tables[0].Rows[0][0].ToString();

        }
    }
}
