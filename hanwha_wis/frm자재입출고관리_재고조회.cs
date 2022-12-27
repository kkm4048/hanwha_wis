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
    public partial class frm자재입출고관리_재고조회 : Form
    {

        string sql = "";
        string r자재명 = "", r바코드 = "", r입고일자 = "", r제조사 = "", r제조사로트 = "", r로트번호 = "", r자재코드 = "";
        int rRow0, rRow1, rRow2;
        private PrintDocument printDoc = new PrintDocument();
        public frm자재입출고관리_재고조회()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm자재입출고관리_재고조회_Load(object sender, EventArgs e)
        {
            string d;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            d = cls_com.ConfigLoad(this.Name + "_출력매수");
            txt출력매수.Text = d;

            초기화();
            Add창고();
            Add자재();
            조회();
        }

        private void 초기화()
        {
        }
        private void Add창고()
        {
            sql = " exec s_a101_창고_조회 '1','" + cls_com.g공장 + "','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            cmb창고.Items.Clear();
            cmb창고.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb창고.Items.Add(ds.Tables[0].Rows[i]["창고"].ToString() );
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
                cmb자재.Items.Add(ds.Tables[0].Rows[i]["자재코드"].ToString() + " "  + ds.Tables[0].Rows[i]["자재명"].ToString() );
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void 조회()
        {
            FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
            nc.DecimalPlaces = 3;
            nc.ShowSeparator = true;

            sql = " exec s_a201_자재_재고_조회 '1','" + cls_com.g공장 + "','" + cmb창고.Text + "','" + cls_com.GetCode(cmb자재.Text) + "'   "
                        + ",'','','','','','" + txt조회.Text + "'  ";
                        
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
                spr.Sheets[0].Cells.Get(0, 12, spr.Sheets[0].RowCount - 1, 12).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
                spr.Sheets[0].Cells.Get(0, 12, spr.Sheets[0].RowCount - 1, 12).CellType = nc;
                cls_com.색삭_spr(spr, spr.ActiveSheet.ColumnCount - 1, 7);

            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
            cls_com.Sort표시(spr.ActiveSheet);
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

       
        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
          
        }

        
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor =  cls_color.gColor_수정;
        }

        private void cmb창고_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt출력매수_TextChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_출력매수", txt출력매수.Text);
        }

        private void cmb자재_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void btn수정_Click(object sender, EventArgs e)
        {
            수정();
        }
        private void 수정()
        {
            spr.ActiveSheet.Cells.Get(0, 5, spr.ActiveSheet.RowCount - 1, 6).Locked = false;
            spr.ActiveSheet.Cells.Get(0, 5, spr.ActiveSheet.RowCount - 1, 6).BackColor = cls_color.gColor_수정;

            spr.ActiveSheet.Cells.Get(0, 8, spr.ActiveSheet.RowCount - 1, 13).Locked = false;
            spr.ActiveSheet.Cells.Get(0, 8, spr.ActiveSheet.RowCount - 1, 13).BackColor = cls_color.gColor_수정;

        }

        private void spr_EditModeOff(object sender, EventArgs e)
        {
            int irow;
            irow = spr.ActiveSheet.ActiveRow.Index;

            sql = "";
            sql = sql  + "EXEC s_a201_자재_재고_저장 '2' ";
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 0].Text + "' ";    // 공장
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 1].Text + "' ";     // 창고
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 3].Text + "' ";     // 자재코드
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 7].Text + "' ";    // 로트번호
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 5].Text + "' ";     // 상태
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 6].Text + "' ";    // 구분  
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 8].Text + "' ";     // 제조사
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 9].Text + "' ";    // 제조사로트
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 10].Text + "' ";     //, INDEX
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 11].Text + "' ";     // 용도
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 12].Text + "' ";     // 재고량
            sql = sql + " ,'" + spr.ActiveSheet.Cells[irow, 13].Text + "' ";     // 비고

            DataSet ds = cls_com.Select_Query(sql);
            cls_com.로그(cls_com.s사용자.성명, "재고조회", "수정", sql);
            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }
            }
           // 조회();
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
            settings.Copies = (short)cls_com.Val(txt출력매수.Text); //I put number 2 here
            printDoc.PrinterSettings = settings;
            Application.DoEvents();
            FarPoint.Win.Spread.Model.CellRange[] cr;
            cr = spr.ActiveSheet.GetSelections();

            if (cr[0].RowCount < 0)
            {
                rRow1 = 0;
                rRow2 = spr.ActiveSheet.RowCount;
            }
            else
            {
                rRow1 = cr[0].Row;
                rRow2 = cr[0].Row + cr[0].RowCount;
            }
            for (int i = rRow1; i < rRow2; i++)
            {
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
            r입고일자 = spr.ActiveSheet.Cells[rRow0, 2].Text;
            r자재코드 = spr.ActiveSheet.Cells[rRow0, 3].Text;
            r자재명 = spr.ActiveSheet.Cells[rRow0, 4].Text;
            r바코드 = spr.ActiveSheet.Cells[rRow0, 7].Text;
            r로트번호 = spr.ActiveSheet.Cells[rRow0, 7].Text;
            r제조사 = spr.ActiveSheet.Cells[rRow0, 8].Text;
            r제조사로트 = spr.ActiveSheet.Cells[rRow0, 9].Text;

            cls_com.PrintBarcode(e, r바코드, 20, 20, 200, 200, "0", "False", ifont2, bcType);
            cls_com.PrintText(e, "입고일자 : " + r입고일자, ifont2, "LEFT", "0", 120, 20, 1, 1);
            cls_com.PrintText(e, "자재코드 : " + r자재코드, ifont2, "LEFT", "0", 120, 45, 1, 1);
            cls_com.PrintText(e, "제품명 : " + r자재명, ifont2, "LEFT", "0", 120, 70, 1, 1);
            cls_com.PrintText(e, "로트번호 : " + r로트번호, ifont2, "LEFT", "0", 20, 100, 1, 1);
            cls_com.PrintText(e, "제조사 : " + r제조사, ifont2, "LEFT", "0", 20, 125, 1, 1);
            cls_com.PrintText(e, "제조사 로트 : " + r제조사, ifont2, "LEFT", "0", 20, 150, 1, 1);
            cls_com.PrintText(e, "관리번호 : ", ifont2, "LEFT", "0", 20, 175, 1, 1);
            cls_com.PrintText(e, "드럼번호 : ", ifont2, "LEFT", "0", 20, 200, 1, 1);

        }

    }
}
