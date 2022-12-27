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
    public partial class frm자재입출고관리_출고등록 : Form
    {

        string sql = "";
        int rRow0 = -1, rRow1 = -1, rRow2 = -1;
        string r위치코드 = "", r위치명;
        TextBox rtxt;
        private PrintDocument printDoc = new PrintDocument();
        public frm자재입출고관리_출고등록()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm자재입출고관리_출고등록_Load(object sender, EventArgs e)
        {
            string d;
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            d = cls_com.ConfigLoad(this.Name + "_sc넓이","500");
            sc.SplitterDistance = cls_com.Val(d);
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
            sql = " exec s_a101_창고_조회 '1','" + cls_com.g공장 + "','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            cmb창고0.Items.Clear();
            cmb창고.Items.Clear();
            cmb창고0.Items.Add("");
            cmb창고.Items.Add("");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb창고0.Items.Add(ds.Tables[0].Rows[i]["창고"].ToString());
                cmb창고.Items.Add(ds.Tables[0].Rows[i]["창고"].ToString());
            }
            cmb창고0.Text = cls_com.ConfigLoad(this.Name + "_창고0");

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
            FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
            nc.DecimalPlaces = 3;
            sql = " exec s_a201_자재_재고_조회 '1','" + cls_com.g공장 + "','" + cmb창고0.Text + "','','','','','','','" + txt조회.Text + "'";
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
                spr.Sheets[0].Cells.Get(0, 11, spr.Sheets[0].RowCount - 1, 11).CellType = nc;
                cls_com.색삭_spr(spr, spr.ActiveSheet.ColumnCount - 1, 7);
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 조회2()
        {
            FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
            nc.DecimalPlaces = 3;
            sql = " exec s_a201_자재_출고_조회 '1','" + cls_com.g공장 + "','" + cmb창고0.Text +"','" + cls_com.g공장 + "','" +  cmb창고.Text + "','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetDate(dtp.Value) + "','','','','','','','','' ";
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
                spr2.Sheets[0].Cells.Get(0, 14, spr2.Sheets[0].RowCount - 1, 16).CellType = nc;
                cls_com.색삭_spr(spr2, spr2.ActiveSheet.ColumnCount - 1, 10);
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
            sql = sql + "EXEC [s_a201_자재_출고_저장] '1'";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + cmb창고0.Text + "' ";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + cmb창고.Text  + "' ";
            sql = sql + "   ,'" + cls_com.GetDate(dtp.Value) + "','' ";
            sql = sql + "   ,'" + txt사업명.Text + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + cmb상태.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "   ,'" + txt바코드.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt출고량.Text + "' ";
            sql = sql + "   ,'" + txt손실량.Text + "' ";
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
                    cls_com.로그(cls_com.s사용자.성명, "출고등록", "등록", sql);

                }

            }
            txt바코드.Text = "";
            txt출고량.Text = "";
            txt손실량.Text = "";
            조회2();
            포커스(txt바코드);
        }
        private void 수정()
        {

            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a201_자재_출고_저장] '2'";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + cmb창고0.Text + "' ";
            sql = sql + "   ,'" + cmb창고.Text + "' ";
            sql = sql + "   ,'" + cls_com.GetDate(dtp.Value) + "','' ";
            sql = sql + "   ,'" + txt사업명.Text + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + cmb상태.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "   ,'" + txt바코드.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt출고량.Text + "' ";
            sql = sql + "   ,'" + txt손실량.Text + "' ";
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
            sql = sql + "EXEC [s_a201_자재_출고_저장] '3'";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + cmb창고0.Text + "' ";
            sql = sql + "   ,'" + cls_com.g공장 + "' ";
            sql = sql + "   ,'" + cmb창고.Text + "' ";
            sql = sql + "   ,'" + txt일자.Text + "','"  + txt시간.Text + "' ";
            sql = sql + "   ,'" + txt사업명.Text + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + cmb상태.Text + "' ";
            sql = sql + "   ,'" + cmb구분.Text + "' ";
            sql = sql + "   ,'" + txt바코드.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt출고량.Text + "' ";
            sql = sql + "   ,'" + txt손실량.Text + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.성명 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                } else
                {
                    cls_com.로그(cls_com.s사용자.성명, "출고등록", "취소", sql);

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
            string 로트번호 = "";
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            로트번호 = spr.ActiveSheet.Cells[e.Row, 7].Text;
            txt바코드.Text = 로트번호;
            바코드조회();

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
            txt바코드.Text = "";
            txt출고량.Text = "";
            txt손실량.Text = "";
            txt재고량.Text = "";
            포커스(txt바코드);

        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

            if (e.Row < 0 || e.Column < 0  || spr2.ActiveSheet.RowCount <= 0  ) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt일자.Text = spr2.ActiveSheet.Cells[e.Row, 3].Text;
            txt시간.Text = spr2.ActiveSheet.Cells[e.Row, 4].Text;
            txt사업명.Text = spr2.ActiveSheet.Cells[e.Row, 5].Text;
            txt1.Text = spr2.ActiveSheet.Cells[e.Row, 6].Text;
            txt2.Text = spr2.ActiveSheet.Cells[e.Row, 7].Text;
            cmb상태.Text = spr2.ActiveSheet.Cells[e.Row, 8].Text;
            cmb구분.Text = spr2.ActiveSheet.Cells[e.Row, 9].Text;
            txt바코드.Text = spr2.ActiveSheet.Cells[e.Row, 10].Text;
            txt3.Text = spr2.ActiveSheet.Cells[e.Row, 11].Text;
            txt4.Text = spr2.ActiveSheet.Cells[e.Row, 12].Text;
            txt5.Text = spr2.ActiveSheet.Cells[e.Row, 13].Text;
            txt출고량.Text = spr2.ActiveSheet.Cells[e.Row, 14].Text;
            txt손실량.Text = spr2.ActiveSheet.Cells[e.Row, 15].Text;


        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_sc넓이", sc.SplitterDistance.ToString());
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
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


        private void cmb창고_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_창고", cmb창고.Text);
            조회2();
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
            txt3.Text = ds.Tables[0].Rows[0]["제조사"].ToString();
            txt4.Text = ds.Tables[0].Rows[0]["제조사로트"].ToString();
            txt5.Text = ds.Tables[0].Rows[0]["INDEX"].ToString();
            txt6.Text = ds.Tables[0].Rows[0]["용도"].ToString();
            txt7.Text = ds.Tables[0].Rows[0]["비고"].ToString();
            cmb상태.Text = ds.Tables[0].Rows[0]["상태"].ToString();
            cmb구분.Text = ds.Tables[0].Rows[0]["구분"].ToString();
            txt재고량.Text = ds.Tables[0].Rows[0]["재고량"].ToString();
            포커스(txt출고량);

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
            cmb상태.Text = "";
            cmb구분.Text = "";
            txt출고량.Text = "";
            txt손실량.Text = "";
            txt재고량.Text = "";
        }
        private void cmb창고0_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_창고0",cmb창고0.Text);
            조회();

        }

        private void t포커스_Tick(object sender, EventArgs e)
        {
            t포커스.Enabled = false;
            rtxt.Focus();
            
        }

        private void txt바코드_Enter(object sender, EventArgs e)
        {
            txt바코드.SelectAll();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

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
