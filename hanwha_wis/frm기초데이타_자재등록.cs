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
    public partial class frm기초데이타_자재등록 : Form
    {

        string sql = "";
        public frm기초데이타_자재등록()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기초데이타_자재등록_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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


            sql = " exec s_a101_자재_조회 '1','','','" + txt조회.Text + "' ";
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
                
                spr.ActiveSheet.Rows.Get(0, spr.ActiveSheet.Rows.Count - 1).Height = 30;
                for (int i = 0;i < spr.ActiveSheet.RowCount; i ++ )
                {
                    try
                    {
                        spr.ActiveSheet.Cells[i, 12].BackColor = ColorTranslator.FromHtml(spr.ActiveSheet.Cells[i, 12].Text);
                    }
                    catch
                    {

                    }
                }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            등록();
        }

        private void 등록()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_자재_저장] '1'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt8.Text + "' ";
            sql = sql + "   ,'" + txt9.Text + "' ";
            sql = sql + "   ,'" + txt10.Text + "' ";
            sql = sql + "   ,'" + txt11.Text + "' ";
            sql = sql + "   ,'" + txt12.Text + "' ";
            sql = sql + "   ,'" + txt13.Text + "' ";
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

            //            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            //          if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_자재_저장] '2'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt8.Text + "' ";
            sql = sql + "   ,'" + txt9.Text + "' ";
            sql = sql + "   ,'" + txt10.Text + "' ";
            sql = sql + "   ,'" + txt11.Text + "' ";
            sql = sql + "   ,'" + txt12.Text + "' ";
            sql = sql + "   ,'" + txt13.Text + "' ";
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

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "사용자 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_자재_저장] '3'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt8.Text + "' ";
            sql = sql + "   ,'" + txt9.Text + "' ";
            sql = sql + "   ,'" + txt10.Text + "' ";
            sql = sql + "   ,'" + txt11.Text + "' ";
            sql = sql + "   ,'" + txt12.Text + "' ";
            sql = sql + "   ,'" + txt13.Text + "' ";
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
            txt4.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt5.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            txt6.Text = spr.ActiveSheet.Cells[e.Row, 5].Text;
            txt7.Text = spr.ActiveSheet.Cells[e.Row, 6].Text;
            txt8.Text = spr.ActiveSheet.Cells[e.Row, 7].Text;
            txt9.Text = spr.ActiveSheet.Cells[e.Row, 8].Text;
            txt10.Text = spr.ActiveSheet.Cells[e.Row, 9].Text;
            txt11.Text = spr.ActiveSheet.Cells[e.Row, 10].Text;
            txt12.Text = spr.ActiveSheet.Cells[e.Row, 11].Text;
            txt13.Text = spr.ActiveSheet.Cells[e.Row, 12].Text;
            try
            {
                txt13.BackColor = ColorTranslator.FromHtml( txt13.Text);
            } catch
            {

            }
        }

        private void btninit_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
            txt13.Text = "";
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = cls_color.gColor_수정;
        }

        private void btn엑셀_등록_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            openFileDialog.RestoreDirectory = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    frm기타_엑셀등록_자재 frm기타_엑셀등록_자재 = new frm기타_엑셀등록_자재(openFileDialog.FileName);
                    frm기타_엑셀등록_자재.ShowDialog();
                    조회();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }


        private void txt13_MouseDown(object sender, MouseEventArgs e)
        {



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt13_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = true;
            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                txt13.BackColor = MyDialog.Color;
                txt13.Text = Color2Hex(MyDialog.Color);
            }
        }

        private void txt13_TextChanged(object sender, EventArgs e)
        {



        }
        private string Color2Hex(Color color)
        {
            return string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}",
                         color.A,
                         color.R,
                         color.G,
                         color.B);
        }

    }
}
