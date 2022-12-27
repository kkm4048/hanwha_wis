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
    public partial class frm자재입출고관리_출고조회 : Form
    {

        string sql = "";
        public frm자재입출고관리_출고조회()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm자재입출고관리_출고조회_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            dtp1.Value = cls_com.GetDate();
            dtp2.Value = cls_com.GetDate();
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
            cmb창고2.Items.Clear();
            cmb창고2.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb창고.Items.Add(ds.Tables[0].Rows[i]["창고"].ToString() );
                cmb창고2.Items.Add(ds.Tables[0].Rows[i]["창고"].ToString());
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
            sql = " exec s_a201_자재_출고_조회 '1','" + cls_com.g공장 + "','" + cmb창고.Text + "','" + cls_com.g공장 + "','" + cmb창고2.Text + "','" + cls_com.GetDate(dtp1.Value) + "','" + cls_com.GetDate(dtp2.Value) + "','" + cls_com.GetCode(cmb자재.Text) + "',''   "
                        + ",'','','','','','" + txt조회.Text + "'  ";
                        
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
                spr.Sheets[0].Cells.Get(0, 14, spr.Sheets[0].RowCount - 1, 16).CellType = nc;
                cls_com.색삭_spr(spr, spr.ActiveSheet.ColumnCount - 1, 10);
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
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

        private void cmb자재_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void cmb창고2_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }
    }
}
