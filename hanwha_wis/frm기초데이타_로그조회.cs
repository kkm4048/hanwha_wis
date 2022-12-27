using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hanwha_wis
{
    public partial class frm기초데이타_로그조회 : Form
    {

        string sql = "";
        public frm기초데이타_로그조회()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기초데이타_로그조회_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            dtp1.Value = cls_com.GetDate();
            dtp2.Value = cls_com.GetDate();

            초기화();
            조회();
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
            FarPoint.Win.Spread.CellType.TextCellType tc = new FarPoint.Win.Spread.CellType.TextCellType();
            tc.WordWrap = true;
            tc.Multiline = true;
            sql = " exec s_a101_로그_조회 '1','" +   cls_com.GetDate(dtp1.Value) + "','" + cls_com.GetDate(dtp2.Value) + "','" + txt메뉴.Text + "'   "
                        + ",'" + txt작업.Text + "','" + txt조회.Text + "'  ";
                        
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = false ;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).CellType = tc;

             //  cls_com.높이자동조절(spr);

            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();



        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
            cls_com.높이자동조절(spr);

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
            tb.BackColor = tb.BackColor = cls_color.gColor_수정;
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }
    }
}
