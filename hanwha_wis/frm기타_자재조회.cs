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
    public partial class frm기타_자재조회 : Form
    {

        public string r자재코드 = "", r자재명 = "";
        string sql = "";
        public frm기타_자재조회()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기타_자재조회_Load(object sender, EventArgs e)
        {
            lbl타이틀.Text = "【 " + this.Text + " 】";
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
            //SPEC


            sql = " exec s_a101_자재_조회 '1','','','" +  txt조회.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 35;

            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr.Sheets[0].Rows.Get(0, spr.Sheets[0].RowCount - 1).Height = 35;
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
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
 
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

        private void spr_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            r자재코드 =  spr.ActiveSheet.Cells[e.Row, 0].Text;
            r자재명 = spr.ActiveSheet.Cells[e.Row, 2].Text;
            Close();
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }
    }
}
