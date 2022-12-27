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
    public partial class frm기타_작업지시서조회 : Form
    {

        public string r작업지시번호 = "";
        string r창고 ="" ;
        string sql = "";
        public frm기타_작업지시서조회()
        {
            InitializeComponent();
        }
        public frm기타_작업지시서조회(string 창고 )
        {
            InitializeComponent();
            r창고 = 창고;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기타_작업지시서조회_Load(object sender, EventArgs e)
        {
            lbl타이틀.Text = "【 " + this.Text + " 】";
            초기화();
            dtp1.Value = cls_com.GetDate();
            dtp2.Value = cls_com.GetDate();
            Add창고();
            Add완료();
            조회();

        }
        private void Add창고()
        {
            sql = " exec s_a101_창고_조회 '2','" + cls_com.g공장 + "','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            cmb창고.Items.Clear();
            cmb창고.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb창고.Items.Add(ds.Tables[0].Rows[i]["창고"].ToString());
            }
        }

        private void Add완료()
        {
            cmb완료.Items.Add("");
            cmb완료.Items.Add("미완료");
            cmb완료.Items.Add("완료");
            cmb완료.Text = "미완료";
            if (!r창고.Equals(""))
            {
                cmb완료.Text = "미완료";
                cmb완료.Enabled = false;
            }
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

            string dt1 = "", dt2 = "";
            if (r창고.Equals(""))
            {
                dt1 = cls_com.GetDate(dtp1.Value);
                dt2 = cls_com.GetDate(dtp2.Value);
            }

            sql = " exec s_a301_작업지시서_조회 '1','','" + dt1  + "','" + dt2 + "','" + cmb창고.Text + "','" + cmb완료.Text + "','" +  txt조회.Text + "' ";
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
            r작업지시번호 =  spr.ActiveSheet.Cells[e.Row, 1].Text;
            Close();
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void cmb완료_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }
    }
}
