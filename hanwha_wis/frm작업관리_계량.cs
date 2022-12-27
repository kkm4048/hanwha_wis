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
    public partial class frm작업관리_계량 : Form
    {

        int 메세지_에러_CNT = 0; 
        TextBox ret; 
        string sql = "";
        string rBuf = "",r계량 = ""  ;
        string r수식 = "", r특기사항 = "", r안전검토사항 = "", r기타 = "", r작성자 = "", r배치무게 = "";
        string r자재명 = "", r바코드 = "", r계량일자 = "", r제조사 = "", r제조사로트 = "", r로트번호 = "", r자재코드 = "";
        string r번호 = "", r번호2 = "";
        private PrintDocument printDoc = new PrintDocument();
        public frm작업관리_계량()
        {
            InitializeComponent();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm작업관리_계량_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txt제품명.Tag = "";
            lbl타이틀.Text = "【 " + this.Text + " 】";
            초기화();
          //  Add생산라인();
            조회();
            조회2();
            포커스(txt바코드);
        }

        private void 초기화()
        {
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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회();
            조회2();
        }
        private void 조회()
        {

            txt제품명.Tag = "";
            txt제품명.Text = "";
            txt사업명.Text = "";
            txt사업코드.Text = "";
            txt공실번호.Text = "";
            txt혼화량.Text = "";
            r작성자 = "";
            r수식 = "";
            r특기사항 = "";
            r안전검토사항 = "";
            r기타 = "";

            sql = " exec s_a301_작업지시서_조회 '2','" + txt작업지시번호.Text + "','','','' ,'',''   ";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0 )
            {
                cmb창고.Text = ds.Tables[0].Rows[0]["창고"].ToString();
                txt제품명.Tag  = ds.Tables[0].Rows[0]["제품코드"].ToString();
                txt제품명.Text = ds.Tables[0].Rows[0]["제품명"].ToString();
                txt사업명.Text = ds.Tables[0].Rows[0]["사업명"].ToString();
                txt사업코드.Text = ds.Tables[0].Rows[0]["사업코드"].ToString();
                txt공실번호.Text = ds.Tables[0].Rows[0]["공실번호"].ToString();
                txt혼화량.Text = ds.Tables[0].Rows[0]["혼화량"].ToString();
                txt혼화일.Text = ds.Tables[0].Rows[0]["혼화일"].ToString();
                txtBTNo.Text = ds.Tables[0].Rows[0]["BTNO"].ToString();
                r작성자 = ds.Tables[0].Rows[0]["작성자"].ToString();
                r수식 = ds.Tables[0].Rows[0]["수식"].ToString();
                r특기사항 = ds.Tables[0].Rows[0]["특기사항"].ToString();
                r안전검토사항 = ds.Tables[0].Rows[0]["안전검토사항"].ToString();
                r기타 = ds.Tables[0].Rows[0]["기타"].ToString();
                if( ds.Tables[0].Rows[0]["완료"].ToString().Equals(""))
                {
                    txt완료.Text = ds.Tables[0].Rows[0]["완료"].ToString();
                    txt완료.BackColor = Color.White;
                } else
                {
                    txt완료.Text = ds.Tables[0].Rows[0]["완료"].ToString();
                    txt완료.BackColor = Color.Pink;
                }
            }
        }

        private void 조회2()
        {
            string 자재코드;
            int irow1 = 0, irow2 = 0; 
            FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
            nc.DecimalPlaces = 3;
            nc.ShowSeparator = true;
            FarPoint.Win.Spread.CellType.TextCellType tc = new FarPoint.Win.Spread.CellType.TextCellType();
            tc.Multiline = true;
            
            FarPoint.Win.BevelBorder bevelBorder = new FarPoint.Win.BevelBorder
                (
                    FarPoint.Win.BevelBorderType.Raised,
                    Color.White,
                    Color.Black
                );
            

            sql = " exec s_a301_작업지시서_계량_조회 '1','" + txt작업지시번호.Text + "',''   ";

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
                spr.Sheets[0].Rows.Get(0, spr.Sheets[0].RowCount - 1).Height = 35;

            }
           
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
             spr.ActiveSheet.RowCount++;

            spr.Sheets[0].Rows.Get(spr.Sheets[0].RowCount - 1, spr.Sheets[0].RowCount - 1).Height = 35;

            spr.ActiveSheet.AddSpanCell(spr.ActiveSheet.RowCount - 1, 0, 1, 3);
            spr.ActiveSheet.Cells.Get(spr.ActiveSheet.RowCount - 1, 0, spr.ActiveSheet.RowCount - 1, 3).CellType = tc; ;
            spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text = "합 계";


            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;

           
            spr.Sheets[0].Cells.Get(0, 3, spr.Sheets[0].RowCount - 1, 5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            spr.Sheets[0].Cells.Get(0, 7, spr.Sheets[0].RowCount - 1, 7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            spr.Sheets[0].Cells.Get(0, 9, spr.Sheets[0].RowCount - 1, 9).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            spr.Sheets[0].Cells.Get(0, 10, spr.Sheets[0].RowCount - 1, 12).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;

           
            spr.Sheets[0].Cells.Get(0, 3, spr.Sheets[0].RowCount - 1, 5).CellType = nc;
            spr.Sheets[0].Cells.Get(0, 10, spr.Sheets[0].RowCount - 1, 12).CellType = nc;

            spr.ActiveSheet.RowCount++;
            spr.Sheets[0].Cells.Get(spr.ActiveSheet.RowCount - 1, 0).CellType = tc;
            spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text = r수식;
            spr.ActiveSheet.AddSpanCell(spr.ActiveSheet.RowCount - 1, 0, 1, spr.ActiveSheet.ColumnCount);

            spr.ActiveSheet.RowCount++;
            spr.Sheets[0].Cells.Get(spr.ActiveSheet.RowCount - 1, 0).CellType = tc;
            spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text = r특기사항;
            spr.ActiveSheet.AddSpanCell(spr.ActiveSheet.RowCount - 1, 0, 1, spr.ActiveSheet.ColumnCount);

            spr.ActiveSheet.RowCount++;
            spr.Sheets[0].Cells.Get(spr.ActiveSheet.RowCount - 1, 0).CellType = tc;
            spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text = r안전검토사항;
            spr.ActiveSheet.AddSpanCell(spr.ActiveSheet.RowCount - 1, 0, 1, spr.ActiveSheet.ColumnCount);

            기타_높이(r기타);

            
            spr.ActiveSheet.SetColumnMerge(0, FarPoint.Win.Spread.Model.MergePolicy.Restricted);
            spr.ActiveSheet.SetColumnMerge( 1, FarPoint.Win.Spread.Model.MergePolicy.Restricted);
            spr.ActiveSheet.SetColumnMerge(2, FarPoint.Win.Spread.Model.MergePolicy.Restricted);
            spr.ActiveSheet.SetColumnMerge(3, FarPoint.Win.Spread.Model.MergePolicy.Restricted);
            spr.ActiveSheet.SetColumnMerge(4, FarPoint.Win.Spread.Model.MergePolicy.Restricted);
            spr.ActiveSheet.SetColumnMerge(5, FarPoint.Win.Spread.Model.MergePolicy.Restricted);
            spr.ActiveSheet.SetColumnMerge(6, FarPoint.Win.Spread.Model.MergePolicy.Restricted);

            Cursor.Current = Cursors.Default;


            무게비계산();
            중량계산();


            spr.Sheets[0].ColumnHeader.Cells.Get(0, 0, spr.Sheets[0].ColumnHeader.RowCount - 1, spr.Sheets[0].ColumnCount - 1).Border = bevelBorder;
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Border = bevelBorder;

            spr.ActiveSheet.Columns[0].Width = 40;  // 번호
            spr.ActiveSheet.Columns[1].Width = 0;   //자재코드
            spr.ActiveSheet.Columns[2].Width = 200;  //자재명
            spr.ActiveSheet.Columns[3].Width = 80;  // 계획량
            spr.ActiveSheet.Columns[4].Width = 80;   //혼합비
            spr.ActiveSheet.Columns[5].Width = 80;   // 허용값
            spr.ActiveSheet.Columns[6].Width = 120;   //적용
            spr.ActiveSheet.Columns[7].Width = 200;   // 예약로트번호
            spr.ActiveSheet.Columns[8].Width = 40;   // 번호2
            spr.ActiveSheet.Columns[9].Width = 200;   // 로트번호
            spr.ActiveSheet.Columns[10].Width = 60;   //용기무게
            spr.ActiveSheet.Columns[11].Width = 80;   //계량
            spr.ActiveSheet.Columns[12].Width = 80;   //총무게
            spr.ActiveSheet.Columns[13].Width = 50;   //완료
            spr.ActiveSheet.Columns[14].Width = 0;   //일자
            spr.ActiveSheet.Columns[15].Width = 0;   //시간
            Cursor.Current = Cursors.Default;

            자재코드 = spr.ActiveSheet.Cells[0, 1].Text;
            irow1 = 0;
            irow2 = 0; 
            for (int i = 0;i < spr.ActiveSheet.RowCount -3; i ++)
            {
                if (!자재코드.Equals(spr.ActiveSheet.Cells[i,1].Text))   {

                    spr.ActiveSheet.AddSpanCell(irow2, 10, i - irow1 , 1);
                    spr.ActiveSheet.AddSpanCell(irow2, 12, i - irow1 , 1);
                    spr.ActiveSheet.AddSpanCell(irow2, 13, i - irow1, 1);

                    irow1 = i;
                    irow2 = i; 
                    자재코드  = spr.ActiveSheet.Cells[i, 1].Text;

                }
            }
        }

        private void 기타_높이(string 기타)
        {
            string[] arr;
            arr = 기타.Split(',');

            if (arr.Length >= 3)
            {
                spr.ActiveSheet.Rows[spr.ActiveSheet.Rows.Count - 3].Height = cls_com.Val(arr[0]);
                spr.ActiveSheet.Rows[spr.ActiveSheet.Rows.Count - 2].Height = cls_com.Val(arr[1]);
                spr.ActiveSheet.Rows[spr.ActiveSheet.Rows.Count - 1].Height = cls_com.Val(arr[2]);

            }
        }
        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

       
        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            try
            {
                r번호  = spr.ActiveSheet.Cells[e.Row, 0].Text;
                r자재코드  = spr.ActiveSheet.Cells[e.Row, 1].Text;
                r번호2 = spr.ActiveSheet.Cells[e.Row, 8].Text;
                txt로트번호.Text = spr.ActiveSheet.Cells[e.Row, 9].Text;
                txt일자.Text = spr.ActiveSheet.Cells[e.Row, 14].Text;
                txt시간.Text = spr.ActiveSheet.Cells[e.Row, 15].Text;

                포커스(txt바코드);
            } catch
            {

            }
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


 

        private void btn제품명_Click(object sender, EventArgs e)
        {
            작업지시서생성();
        }
        private void 작업지시서생성()
        {

            /*
                frm기초데이타_제품등록 frm기초데이타_제품등록 = new frm기초데이타_제품등록(cmb생산라인.Text, txt작업지시번호.Text, cls_com.GetDate(dtp.Value)
                    , txt제품명.Tag.ToString(), txt제품명.Text, txt사업명.Text, txt사업코드.Text, txt공실번호.Text, txt혼화량.Text, txt혼화일.Text
                    , txt제품명.Text, txt특기사항.Text);
                frm기초데이타_제품등록.ShowDialog();
                txt작업지시번호.Text = frm기초데이타_제품등록.r작업지시번호;
                조회();
                조회2();
            */
        }

        private void txt작업지시번호_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt제품명_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt공실번호_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt혼화량_TextChanged(object sender, EventArgs e)
        {
            중량계산();
        }
         private void 중량계산()
         {
            int i;
            if (spr.ActiveSheet.Rows.Count <= 0) return;
            float 계획량합 = 0, 혼합비합 = 0,계량합=0;
            
            for (i = 0; i < spr.ActiveSheet.RowCount - 4; i++)
            {
                계획량합 = 계획량합 + cls_com.Val_f(spr.ActiveSheet.Cells[i, 3].Text); ;
                혼합비합 = 혼합비합 + cls_com.Val_f(spr.ActiveSheet.Cells[i, 4].Text);
                계량합 = 계량합 + cls_com.Val_f(spr.ActiveSheet.Cells[i, 10].Text); ;

            }

            spr.ActiveSheet.Cells[i, 3].Text = 계획량합.ToString();
            spr.ActiveSheet.Cells[i, 4].Text = 혼합비합.ToString();
            spr.ActiveSheet.Cells[i, 11].Text = 계량합.ToString();

            r배치무게 = 계획량합.ToString() + " kg";

        }
            private void 무게비계산()
        {
            float 무게비 = 0 ;
            txt무게비.Text = "";
            for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
            {
                무게비 = 무게비 +  cls_com.Val_f(spr.ActiveSheet.Cells[i, 4].Text) ;
            }
            txt무게비.Text = 무게비.ToString();
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
        }
        private void 저장()
        {
            저장_작업지시서();
            저장_작업지시서_계획();
            조회2();
        }
        private void 저장_작업지시서()
        {


            r수식 = spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 3, 0].Text;
            r특기사항 = spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 2, 0].Text;
            r안전검토사항= spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text;
            r기타 = spr.ActiveSheet.Rows[spr.ActiveSheet.Rows.Count - 3].Height.ToString() + "," + spr.ActiveSheet.Rows[spr.ActiveSheet.Rows.Count - 2].Height.ToString()
                    + "," + spr.ActiveSheet.Rows[spr.ActiveSheet.Rows.Count - 1].Height.ToString();

            sql = " exec s_a301_작업지시서_저장 '2','','','" + cls_com.g공장 + "','" + cmb창고.Text + "','" + txt작업지시번호.Text + "','','','" + txt제품명.Tag.ToString() + "','" + txt사업명.Text + "','" + txt사업코드.Text
                  + "','" + txt공실번호.Text + "','" + txt혼화량.Text + "','" + txt혼화일.Text + "','" + txtBTNo.Text + "','" + r수식 + "','" + r특기사항 + "','" + r안전검토사항
                  + "','','','','','" + r기타 + "'"; 
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            else
            {
            }
        }
        private void 저장_작업지시서_계획()
        {
            for (int i = 0; i < spr.ActiveSheet.RowCount; i ++)
            {
                sql = "";
                sql = sql + " exec s_a301_작업지시서_계획_저장 '2','" + txt작업지시번호.Text + "','" + spr.ActiveSheet.Cells[i, 0].Text + "','" + spr.ActiveSheet.Cells[i, 1].Text + "' ";
                sql = sql + ",' " + spr.ActiveSheet.Cells[i, 3].Text + "','" + spr.ActiveSheet.Cells[i, 4].Text + "','" + spr.ActiveSheet.Cells[i, 5].Text + "' ";
                sql = sql + ",' " + spr.ActiveSheet.Cells[i, 6].Text + "','' " ;
                DataSet ds = cls_com.Select_Query(sql);
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
        }

        private void btn작업지시번호_Click(object sender, EventArgs e)
        {
            frm기타_작업지시서조회 frm기타_작업지시서조회 = new frm기타_작업지시서조회(cmb창고.Text);
            frm기타_작업지시서조회.ShowDialog();
            txt작업지시번호.Text = frm기타_작업지시서조회.r작업지시번호;
            조회();
            조회2();
            포커스(txt바코드);
           
        }

        private void btn수정_Click(object sender, EventArgs e)
        {

            수정();
        }
        private void 수정()
        {
            if (spr.ActiveSheet.Rows.Count <= 0) return;
            spr.ActiveSheet.Cells.Get(0, 4, spr.ActiveSheet.RowCount - 1, 5).Locked = false;
            spr.ActiveSheet.Cells.Get(0, 4, spr.ActiveSheet.RowCount - 1, 5).BackColor = cls_color.gColor_수정;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void spr_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (e.Column== 4)
            {
                무게비계산();
                중량계산();
            }
        }


        private void cmb생산라인_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_생산라인", cmb창고.Text);
        }

        private void 포커스(TextBox tb )
        {
            ret = tb;
            t포커스.Enabled = true;
        }

        private void t포커스_Tick(object sender, EventArgs e)
        {
            t포커스.Enabled = false;
            ret.Text = "";
            ret.Focus();
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
            string 자재코드 = "";
            txt로트번호.Text = "";
            txt재고량.Text = "";
            txt바코드.Text = txt바코드.Text.ToUpper();
            sql = " exec s_a301_작업지시서_계량_저장  '1','','','" + cls_com.g공장 + "','" + cmb창고.Text + "','" + txt작업지시번호.Text + "','" + txt바코드.Text + "','','" + cls_com.s사용자.성명 + "','0' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                메세지_에러(ds.Tables[0].Rows[0]["msg"].ToString());
                txt로트번호.Text = "";
                포커스(txt바코드);
            } else
            {
                txt로트번호.Text = txt바코드.Text;
                자재코드 = ds.Tables[0].Rows[0]["자재코드"].ToString();
                txt재고량.Text = ds.Tables[0].Rows[0]["재고량"].ToString();

                for (int i = 0;i < spr.ActiveSheet.Rows.Count;i ++)
                {
                    if (spr.ActiveSheet.Cells[i,1].Text.Equals(자재코드))
                    {
                   //     spr.ActiveSheet.Cells[i, 6].Text = txt로트번호.Text;
                        spr.ActiveSheet.Cells.Get(i, 0, i, spr.ActiveSheet.ColumnCount - 1).BackColor = Color.Pink;
                        break;
                    }
                }
                포커스(txt바코드);
                
            }

        }

        private void pan특기사항_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn취소_Click(object sender, EventArgs e)
        {
            취소();
        }
        private void 취소()
        {
            DialogResult dr = MessageBox.Show("로트번호 : " + txt로트번호.Text + "  계량 취소 하시겠습니까 ?", "취소", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;
            if (txt일자.Text.Equals(""))
            {
                sql = " exec s_a301_작업지시서_계량_저장 '3','" + txt일자.Text + "','" + txt시간.Text + "','" + cls_com.g공장 + "','" + cmb창고.Text + "','" + txt작업지시번호.Text + "','" + r자재코드 + "','','" + cls_com.s사용자.성명 + "','' ";
            } else
            {
                sql = " exec s_a301_작업지시서_계량_저장 '3','" + txt일자.Text + "','" + txt시간.Text + "','" + cls_com.g공장 + "','" + cmb창고.Text + "','" + txt작업지시번호.Text + "','" + txt로트번호.Text + "','','" + cls_com.s사용자.성명 + "','' ";
            }
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            } else
            {
                cls_com.로그(cls_com.s사용자.성명, "작업지시서", "취소", sql);

            }
            txt로트번호.Text = "";
            조회();
            조회2();
        }

        private void t저울_Tick(object sender, EventArgs e)
        {
            if (rBuf.Length > 0 )
            {
                 계량값저장();
            }
        }
        private void 계량값저장()
        {


            r계량 = 저울();
            if (r계량.Length > 0 )
            {

                if (txt로트번호.Text.Equals(""))
                {
                    메세지_에러("로트바코드를 먼저 리딩 하세요");
                    return;
                }
                sql = " exec s_a301_작업지시서_계량_저장  '1','','','" + cls_com.g공장 + "','" + cmb창고.Text + "','" + txt작업지시번호.Text + "','" + txt로트번호.Text + "','" + r계량 + "','" + cls_com.s사용자.성명 + "','1' ";
                DataSet ds = cls_com.Select_Query(sql);
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    메세지_에러(ds.Tables[0].Rows[0]["msg"].ToString());
                    포커스(txt바코드);
                }
                else
                {
                    cls_com.소리_정상();
                    txt로트번호.Text = "";
                    cls_com.로그(cls_com.s사용자.성명, "계량", "저장", sql);
                    if (ds.Tables[0].Rows[0]["계량구분"].ToString().Equals("계량"))
                    {
                        바코드출력(ds.Tables[0].Rows[0]["작업지시번호"].ToString(), ds.Tables[0].Rows[0]["번호"].ToString(), ds.Tables[0].Rows[0]["번호2"].ToString());
                    }

                    조회();
                    조회2();
                    if (ds.Tables[0].Rows[0]["작업지시서_완료"].ToString().Equals("완료") ) {
                        MessageBox.Show("작업지시서 계량 완료");

                     }
                    포커스(txt바코드);

                }

            } else
            {
                메세지_에러("계량값이 0 입니다.");
            }
        }
        private string 저울()
        {
            string d = "";
            int ipos;
            ipos = rBuf.IndexOf("\r");
            if (ipos > 0 )
            {
                d = rBuf.Substring(0, ipos);
                d = cls_com.문자만(d);
                rBuf = rBuf.Substring(ipos + 1);
            }

            return d; 
        }

        private void btn출력_Click(object sender, EventArgs e)
        {
            출력();
        }
        private void 출력()
        {
            string title = "계 량 일 지";
            string d1;
            this.Cursor = Cursors.WaitCursor;
            d1 = String.Format("{0:yyyy-MM-dd HH:mm}", DateTime.Now);
            cls_com.SetDefaultPrinter(cls_com.gA4프린터);

            if (spr.Sheets[0].RowCount != 0)
            {
                try
                {
                    FarPoint.Win.Spread.PrintInfo pi = new FarPoint.Win.Spread.PrintInfo();
                    FarPoint.Win.Spread.SmartPrintRulesCollection prules = new FarPoint.Win.Spread.SmartPrintRulesCollection();
                    pi.ShowPrintDialog = true;

                    pi.Margin.Top = 30;
                    pi.Margin.Header = 60;
                    pi.Margin.Bottom = 0;
                    pi.Margin.Left = 0;
                    pi.Margin.Right = 0;
                    pi.Header = "";
                    pi.Header = pi.Header + "/n/c/fu1/fn\"굴림체\"/fz\"20\"" + title + "/n  /n";
                    //    pi.Header = pi.Header + "/n/fz\"14\"/l" + "제  목 : " + txt사업명.Text + "  ";
                    //    pi.Header = pi.Header + "/c/fz\"12\"테스트병원/fz\"7\"/rPage : /p / /pc"; ;
                    //  pi.Header = pi.Header + "  /n/fz\"8\"/l" + "BT NO : " + txt사업명.Text + "/f/fn\"궁서체\"/fz\"8\"/r " + " 배치무게:";
                    //                   pi.Header = pi.Header + "/n/fz\"10\"/l" + "작업지시번호 : " + txt작업지시번호.Text  + "   발행일자 : "  + cls_com.GetDate(DateTime.Now) +  "/n/n/n";
                    //'                   pi.Header = pi.Header + "/n/n/l" + "BT No : "  + txtBtno.Text + "/c" + "배치무게 : " +  r배치무게  + "            혼화일 : "  +txt혼화일.Text + "" + "/r" + "작성자 : " + r작성자 ;

                    pi.ShowColor = true;
                    pi.Footer = "";
                    pi.ShowGrid = true;//셀
                    pi.ShowBorder = true;//셀
                    pi.ShowRowHeaders = false;  // RowHeaders 안보이게 한다.
                    pi.ShowColumnHeaders = true;//해드
                    pi.Centering = FarPoint.Win.Spread.Centering.Horizontal;
                    pi.Orientation = FarPoint.Win.Spread.PrintOrientation.Portrait;
                    //       pi.Orientation = FarPoint.Win.Spread.PrintOrientation.Landscape;

                    pi.Preview = true;//미리보기 선언/ 아니면 바로인쇄

                    FarPoint.Win.Spread.SmartPrintRulesCollection printrules = new FarPoint.Win.Spread.SmartPrintRulesCollection();
                    // FarPoint.Win.Spread.ScaleRule lr = new FarPoint.Win.Spread.LandscapeRule(FarPoint.Win.Spread.ResetOption.None);

                    //                    FarPoint.Win.Spread.ScaleRule lr = new FarPoint.Win.Spread.ScaleRule(FarPoint.Win.Spread.ResetOption.All);

                    //      lr.ResetOption = FarPoint.Win.Spread.ResetOption.None;

                    printrules.Add(new FarPoint.Win.Spread.BestFitColumnRule(FarPoint.Win.Spread.ResetOption.All));
                    printrules.Add(new FarPoint.Win.Spread.LandscapeRule(FarPoint.Win.Spread.ResetOption.All));
                    printrules.Add(new FarPoint.Win.Spread.ScaleRule(FarPoint.Win.Spread.ResetOption.Current, 3.0f, 0.1f, 0.05f));

                    pi.BestFitCols = false;
                    pi.BestFitRows = false;
                    pi.SmartPrintRules = printrules;
                    pi.ShowPrintDialog = true;
                    pi.Preview = true;
                    pi.UseSmartPrint = true;
                    // Set the PrintInfo property for the first sheet.

                    spr.Sheets[0].PrintInfo = pi;

                    // Print the sheet.

                    spr.PrintSheet(0);
                }
                catch (Exception)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
        }

        private void spr_PrintHeaderFooterArea(object sender, FarPoint.Win.Spread.PrintHeaderFooterAreaEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            SolidBrush blueBrush = new SolidBrush(Color.YellowGreen);
            SolidBrush blueBrush2 = new SolidBrush(Color.Black);
            Rectangle rect = new Rectangle(10, 100, 800, 30);
            //          e.Graphics.FillRectangle(blueBrush, rect);

            // e.Graphics.DrawString("작업 지시서", new Font("굴림체",12,FontStyle.Bold) , blueBrush2, 200, 105);
            e.Graphics.DrawString("사 업 명 : " + txt사업명.Text, new Font("굴림체", 16, FontStyle.Bold), blueBrush2, 10, 80);
            e.Graphics.DrawString("작업지시번호 : " + txt작업지시번호.Text, new Font("굴림체", 12, FontStyle.Regular), blueBrush2, 11, 110);
            e.Graphics.DrawString("배치번호 : " + txtBTNo.Text, new Font("굴림체", 10, FontStyle.Regular), blueBrush2, 13, 130);
            e.Graphics.DrawString("배치무게 : " + r배치무게, new Font("굴림체", 10, FontStyle.Regular), blueBrush2, 230, 130);
            e.Graphics.DrawString("혼화일 : " + txt혼화일.Text, new Font("굴림체", 10, FontStyle.Regular), blueBrush2, 430, 130);
            e.Graphics.DrawString("작성자 : " + r작성자, new Font("굴림체", 10, FontStyle.Regular), blueBrush2, 660, 130);

        }

        private void spr_PrintPreviewShowing(object sender, FarPoint.Win.Spread.PrintPreviewShowingEventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            e.PreviewDialog.Left = 0;
            e.PreviewDialog.Top = 0;
            e.PreviewDialog.Height = 800;
            e.PreviewDialog.Width = 1000;
        }

        private void btn바코드출력_Click(object sender, EventArgs e)
        {
            바코드출력(txt작업지시번호.Text,r번호,r번호2 );
        }

        private void 바코드출력(string 작업지시번호,string 번호,string 번호2)
        {

            if (cls_com.Val(번호) <= 0)
            {
                return;
            }

            sql = "exec s_a301_작업지시서_계량_라벨_조회 '1' ,'" + 작업지시번호 + "','" + 번호 + "',' " + 번호2 + "','' ";
            DataSet ds = cls_com.Select_Query(sql);
            r계량일자 = ds.Tables[0].Rows[0]["일자"].ToString();
            r자재코드 = ds.Tables[0].Rows[0]["자재코드"].ToString();
            r자재명 = ds.Tables[0].Rows[0]["자재명"].ToString();
            r바코드 = ds.Tables[0].Rows[0]["작업지시번호"].ToString() + "^" + ds.Tables[0].Rows[0]["번호"].ToString()  +  "^"  + ds.Tables[0].Rows[0]["번호2"].ToString() + "^" + ds.Tables[0].Rows[0]["로트번호"].ToString();
            r로트번호 = ds.Tables[0].Rows[0]["로트번호"].ToString();
            r제조사 = ds.Tables[0].Rows[0]["제조사"].ToString();
            r제조사로트 = ds.Tables[0].Rows[0]["제조사로트"].ToString();
            r계량 = ds.Tables[0].Rows[0]["계량"].ToString();

            String print;
            print = cls_com.GetDefaultPrinter();
            cls_com.SetDefaultPrinter(cls_com.g라벨프린터);
            PrinterSettings settings = new PrinterSettings();
            settings.Copies = 1; //I put number 2 here
            printDoc.PrinterSettings = settings;
            Application.DoEvents();

        
            
                printDoc.Print();
            cls_com.SetDefaultPrinter(print);

        }
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Fath.bcType bcType = Fath.bcType.QRCode;
            Font ifont, ifont2, ifont3;
            ifont = new Font("HY견고딕", 10, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 20, GraphicsUnit.Pixel);
            ifont3 = new Font("HY견고딕", 25, GraphicsUnit.Pixel);

            cls_com.PrintBarcode(e, r바코드, 20, 20, 200, 200, "0", "False", ifont2, bcType);
            cls_com.PrintText(e, "계량일자 : " + r계량일자, ifont2, "LEFT", "0", 120, 20, 1, 1);
            cls_com.PrintText(e, "자재코드 : " + r자재코드, ifont2, "LEFT", "0", 120, 45, 1, 1);
            cls_com.PrintText(e, "제품명 : " + r자재명, ifont2, "LEFT", "0", 120, 70, 1, 1);
            cls_com.PrintText(e, "로트번호 : " + r로트번호, ifont2, "LEFT", "0", 20, 100, 1, 1);
            cls_com.PrintText(e, "제조사 : " + r제조사, ifont2, "LEFT", "0", 20, 125, 1, 1);
            cls_com.PrintText(e, "제조사 로트 : " + r제조사, ifont2, "LEFT", "0", 20, 150, 1, 1);
            cls_com.PrintText(e, "관리번호 : ", ifont2, "LEFT", "0", 20, 175, 1, 1);
            cls_com.PrintText(e, "드럼번호 : ", ifont2, "LEFT", "0", 20, 200, 1, 1);
            cls_com.PrintText(e, "계량무게 : " + r계량 + " kg", ifont3, "LEFT", "0", 20, 230, 1, 1);

        }
        private void txt저울_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn저울값전송_Click(object sender, EventArgs e)
        {
            rBuf = rBuf + txt저울.Text + " kg " + cls_com.CR;
            메세지(rBuf);
        }

        private void 메세지(string d)
        {
                 
        }

        private void txt바코드_TextChanged(object sender, EventArgs e)
        {

        }

        private void pan비고_Paint(object sender, PaintEventArgs e)
        {

        }


        private void 메세지_에러(string d)
        {
            if (txt메세지.Text.Length > 10000)
            {
                txt메세지.Text = "";
                메세지_에러_CNT=0 ;
            }
            메세지_에러_CNT++;
            txt메세지.Text = 메세지_에러_CNT.ToString() + " " + cls_com.GetDate(DateTime.Now) + " " + cls_com.GetTime() + " " + d + "\r\n" + txt메세지.Text;
            Application.DoEvents();
            cls_com.소리_에러(3);


        }
    }
}
