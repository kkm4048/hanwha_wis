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
    public partial class frm자재입출고관리_투입예정원료예약 : Form
    {

        string sql = "";
        int rRow0 = -1, rRow1 = -1, rRow2 = -1;
        string r위치코드 = "", r위치명;
        TextBox rtxt;
        private PrintDocument printDoc = new PrintDocument();
        public frm자재입출고관리_투입예정원료예약()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm자재입출고관리_투입예정원료예약_Load(object sender, EventArgs e)
        {
            string d;
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            dtp.Value = cls_com.GetDate();
            dtp2.Value = cls_com.GetDate();

            d = cls_com.ConfigLoad(this.Name + "_sc넓이","500");
            sc.SplitterDistance = cls_com.Val(d);
            초기화();
            Add창고();
            Add자재();
            조회();
            조회2();
        }
        private void Add창고()
        {
            sql = " exec s_a101_창고_조회 '1','" + cls_com.g공장 + "','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            cmb창고0.Items.Clear();
            cmb창고0.Items.Add("");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb창고0.Items.Add(ds.Tables[0].Rows[i]["창고"].ToString());
            }

        }

        private void Add자재()
        {
            sql = " exec s_a101_자재_조회 '1','','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            cmb자재.Items.Clear();
            cmb자재.Items.Add("");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb자재.Items.Add(ds.Tables[0].Rows[i]["자재코드"].ToString() + " " + ds.Tables[0].Rows[i]["자재명"].ToString());
            }

        }
        private void 조회()
        {
            sql = " exec s_a201_자재_재고_조회 '1','" + cls_com.g공장 + "','" + cmb창고0.Text + "','" + cls_com.GetCode(cmb자재.Text) + "','','','','','','" + txt조회.Text + "'";
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 40;
            if (ds.Tables[0].Rows.Count > 0)
            {
                FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
                nc.DecimalPlaces = 3;
                nc.ShowSeparator = true;

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr.Sheets[0].Cells.Get(0, 12, spr.Sheets[0].RowCount - 1, 12).CellType = nc;
                spr.Sheets[0].Cells.Get(0, 12, spr.Sheets[0].RowCount - 1, 12).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;

            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
            cls_com.Sort표시(spr.ActiveSheet);
        }
        private void 조회2()
        {
            //SPEC


            sql = " exec s_a201_자재_예약_조회 '1','" + cls_com.g공장 + "','" + cmb창고0.Text +"','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetDate(dtp.Value) + "','','','','" +  txt조회2.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr2.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();
            spr2.DataSource = ds;
            spr2.ActiveSheet.ColumnHeader.Rows[0].Height = 40;
            if (ds.Tables[0].Rows.Count > 0)
            {

                FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
                nc.DecimalPlaces = 3;
                nc.ShowSeparator = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr2.Sheets[0].Cells.Get(0, 10, spr2.Sheets[0].RowCount - 1, 12).CellType = nc;
                spr2.Sheets[0].Cells.Get(0, 10, spr2.Sheets[0].RowCount - 1, 12).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
            cls_com.Sort표시(spr2.ActiveSheet);
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
            sql = sql + "EXEC [s_a201_자재_예약_저장] '1'";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + txt창고.Text + "' ";
            sql = sql + "   ,'" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetTime() + "' ";
            sql = sql + "   ,'" + cls_com.GetDate(dtp2.Value) + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt로트번호.Text + "' ";
            sql = sql + "   ,'" + txt사용자.Text + "' ";
            sql = sql + "   ,'" + txt목적.Text + "' ";
            sql = sql + "   ,'" + txt재고량.Text + "' ";
            sql = sql + "   ,'" + txt투입예정무게.Text + "' ";
            sql = sql + "   ,'" + txt투입후잔여량.Text + "' ";
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
                    
                }

            }
            조회2();
//            포커스(txt바코드);
        }
        private void 수정()
        {

            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a201_자재_예약_저장] '2'";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + cmb창고0.Text + "' ";
            sql = sql + "   ,'" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetTime() + "' ";
            sql = sql + "   ,'" + cls_com.GetDate(dtp2.Value) + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt로트번호.Text + "' ";
            sql = sql + "   ,'" + txt사용자.Text + "' ";
            sql = sql + "   ,'" + txt목적.Text + "' ";
            sql = sql + "   ,'" + txt재고량.Text + "' ";
            sql = sql + "   ,'" + txt투입예정무게.Text + "' ";
            sql = sql + "   ,'" + txt투입후잔여량.Text + "' ";
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

            if (MessageBox.Show("취소 하시겠습니까 ? ", "출고 취소", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a201_자재_예약_저장] '3'";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + txt창고.Text + "' ";
            sql = sql + "   ,'" + txt일자.Text + "','" + txt시간.Text + "' ";
            sql = sql + "   ,'" + cls_com.GetDate(dtp2.Value) + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt로트번호.Text + "' ";
            sql = sql + "   ,'" + txt사용자.Text + "' ";
            sql = sql + "   ,'" + txt목적.Text + "' ";
            sql = sql + "   ,'" + txt재고량.Text + "' ";
            sql = sql + "   ,'" + txt투입예정무게.Text + "' ";
            sql = sql + "   ,'" + txt투입후잔여량.Text + "' ";
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
            txt창고.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;

            txt1.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt2.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            txt로트번호.Text = spr.ActiveSheet.Cells[e.Row, 7].Text;
            txt3.Text = spr.ActiveSheet.Cells[e.Row, 8].Text;
            txt4.Text = spr.ActiveSheet.Cells[e.Row, 9].Text;
            txt5.Text = spr.ActiveSheet.Cells[e.Row, 10].Text;

            txt재고량.Text = spr.ActiveSheet.Cells[e.Row, 12].Text;

            txt투입예정무게.Text = "";
            txt투입후잔여량.Text = "";
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
            txt재고량.Text = "";

        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

            if (e.Row < 0 || e.Column < 0  || spr2.ActiveSheet.RowCount <= 0  ) return;
            txt창고.Text = spr2.ActiveSheet.Cells[e.Row, 1].Text;
            txt일자.Text = spr2.ActiveSheet.Cells[e.Row, 2].Text;
            txt시간.Text = spr2.ActiveSheet.Cells[e.Row, 3].Text;
            dtp2.Text =  spr2.ActiveSheet.Cells[e.Row, 4].Text;

            txt1.Text = spr2.ActiveSheet.Cells[e.Row, 5].Text;
            txt2.Text = spr2.ActiveSheet.Cells[e.Row, 6].Text;


            txt로트번호.Text = spr2.ActiveSheet.Cells[e.Row, 7].Text;
            txt사용자.Text = spr2.ActiveSheet.Cells[e.Row, 8].Text;
            txt목적.Text = spr2.ActiveSheet.Cells[e.Row, 9].Text;
            txt재고량.Text = spr2.ActiveSheet.Cells[e.Row, 10].Text;
            txt투입예정무게.Text = spr2.ActiveSheet.Cells[e.Row, 11].Text;
            txt투입후잔여량.Text = spr2.ActiveSheet.Cells[e.Row, 12].Text;

            조회_재고로트(txt로트번호.Text);

        }
        private void 조회_재고로트(string 로트번호)
        {
            //SPEC


            sql = " exec s_a201_자재_재고_로트번호_조회 '1','" + 로트번호 + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            if (ds.Tables[0].Rows.Count > 0)
            {

                txt1.Text = ds.Tables[0].Rows[0]["자재코드"].ToString();
                txt2.Text = ds.Tables[0].Rows[0]["자재명"].ToString();
                txt3.Text = ds.Tables[0].Rows[0]["제조사로트"].ToString();
                txt4.Text = ds.Tables[0].Rows[0]["INDEX"].ToString();
                txt5.Text = ds.Tables[0].Rows[0]["용도"].ToString();
            }
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
            조회2();
        }

        private void btn바코드출력_Click(object sender, EventArgs e)
        {
            바코드출력();
        }


        private void txt바코드_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                바코드조회();
            }
        }
        private void 바코드조회()
        {
            /*
            초기화_데이타();
            txt바코드.Text = txt바코드.Text.ToUpper();
            sql = " exec s_a201_자재_로트번호_조회 '1','" + cls_com.g공장 + "','" + cmb창고0.Text + "','" + txt바코드.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count <= 0 )
            {
                MessageBox.Show("재고에 없는 로트번호 입니다. 확인하세요");
                포커스(txt바코드);
                return;
            }
            txt1.Text = ds.Tables[0].Rows[0]["자재코드"].ToString();
            txt2.Text = ds.Tables[0].Rows[0]["자재명"].ToString();
            txt3.Text = ds.Tables[0].Rows[0]["제조사로트"].ToString();
            txt4.Text = ds.Tables[0].Rows[0]["INDEX"].ToString();
            txt5.Text = ds.Tables[0].Rows[0]["용도"].ToString();
            cmb상태.Text = ds.Tables[0].Rows[0]["상태"].ToString();
            cmb구분.Text = ds.Tables[0].Rows[0]["구분"].ToString();
            txt재고량.Text = ds.Tables[0].Rows[0]["재고량"].ToString();
            포커스(txt출고량);
            */

        }
        private void 초기화_데이타()
        {
            txt일자.Text = "";
            txt시간.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt재고량.Text = "";
        }
        private void cmb창고0_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
            조회2();
        }

        private void t포커스_Tick(object sender, EventArgs e)
        {
            t포커스.Enabled = false;
            rtxt.Focus();
            
        }

        
        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txt손실량_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt바코드_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txt재고량_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt출고량_TextChanged(object sender, EventArgs e)
        {

        }

        private void pan입고_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt투입예정무게_TextChanged(object sender, EventArgs e)
        {
            txt투입후잔여량.Text = (cls_com.Val_f(txt재고량.Text) - cls_com.Val_f(txt투입예정무게.Text)).ToString() ;
        }

        private void cmb자재_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt투입후잔여량_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt조회2_TextChanged(object sender, EventArgs e)
        {
            조회2();
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
        void 포커스(TextBox tb)
        {
            rtxt = tb;
            t포커스.Enabled = true;
        }
      
    }
}
