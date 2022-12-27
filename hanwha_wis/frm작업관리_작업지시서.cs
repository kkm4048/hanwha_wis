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
    public partial class frm작업관리_작업지시서 : Form
    {

        string r수식 = "", r특기사항 = "", r안전검토사항 = "", r기타 = "",r작성자 = "" ,r배치무게 = "" ;
        string sql = "";
        public frm작업관리_작업지시서()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm작업관리_작업지시서_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txt제품명.Tag = "";
            lbl타이틀.Text = "【 " + this.Text + " 】";
            초기화();
            Add창고();
            조회();
            조회2();
        }

        private void 초기화()
        {
        }
        private void Add창고()
        {
            sql = " exec s_a101_창고_조회 '2','"  + cls_com.g공장  +"','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            cmb창고.Items.Clear();
            cmb창고.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb창고.Items.Add(ds.Tables[0].Rows[i]["창고"].ToString() );
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회();
            조회2();
        }
        private void 조회()
        {

            cmb창고.Text = "";
            txt제품명.Tag = "";
            txt제품명.Text = "";
            txt사업명.Text = "";
            txt사업코드.Text = "";
            txt공실번호.Text = "";
            txt혼화량.Text = "";
            r수식 = "";
            r특기사항 = "";
            r안전검토사항 = "";
            r기타 = "";

            sql = " exec s_a301_작업지시서_조회 '2','" + txt작업지시번호.Text + "','','','' ,'' ,''  ";

            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0 )
            {
                cmb창고.Text = ds.Tables[0].Rows[0]["창고"].ToString();
                txt제품명.Tag = ds.Tables[0].Rows[0]["제품코드"].ToString();
                txt제품명.Text = ds.Tables[0].Rows[0]["제품명"].ToString();
                txt사업명.Text = ds.Tables[0].Rows[0]["사업명"].ToString();
                txt사업코드.Text = ds.Tables[0].Rows[0]["사업코드"].ToString();
                txt공실번호.Text = ds.Tables[0].Rows[0]["공실번호"].ToString();
                txt혼화량.Text = ds.Tables[0].Rows[0]["혼화량"].ToString();
                txt혼화일.Text = ds.Tables[0].Rows[0]["혼화일"].ToString();
                txtBtno.Text = ds.Tables[0].Rows[0]["BTNO"].ToString();
                r작성자 = ds.Tables[0].Rows[0]["작성자"].ToString();
                r수식 = ds.Tables[0].Rows[0]["수식"].ToString();
                r특기사항  = ds.Tables[0].Rows[0]["특기사항"].ToString();
                r안전검토사항 = ds.Tables[0].Rows[0]["안전검토사항"].ToString();
                r기타 = ds.Tables[0].Rows[0]["기타"].ToString();
            }
        }

        private void 조회2()
        {
            
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
                /*
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Border = bevelBorder;
            */


            sql = " exec s_a301_작업지시서_계획_조회 '1','" + txt작업지시번호.Text + "',''   ";
                        
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
            spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 3].Text = spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 3].Text + "                                                                                     .";
            spr.Sheets[0].Rows.Get(spr.Sheets[0].RowCount - 1, spr.Sheets[0].RowCount - 1).Height = 35;
            spr.ActiveSheet.AddSpanCell(spr.ActiveSheet.RowCount - 1, 0, 1, 3);
            spr.ActiveSheet.Cells.Get(spr.ActiveSheet.RowCount - 1, 0, spr.ActiveSheet.RowCount - 1, 3).CellType = tc; ;
            spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text = "합 계";


            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            spr.Sheets[0].Cells.Get(0, 3, spr.Sheets[0].RowCount - 1, 3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            spr.Sheets[0].Cells.Get(0, 4, spr.Sheets[0].RowCount - 1, 6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            spr.Sheets[0].Cells.Get(0, 4, spr.Sheets[0].RowCount - 1, 6).CellType = nc;
            spr.Sheets[0].Cells.Get(0, 8, spr.Sheets[0].RowCount - 1, 8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            spr.Sheets[0].Cells.Get(0, 8, spr.Sheets[0].RowCount - 1, 8).CellType = nc;


            spr.ActiveSheet.RowCount++;
            spr.Sheets[0].Cells.Get(spr.ActiveSheet.RowCount - 1, 0).CellType = tc;
            spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text = r수식;
            spr.ActiveSheet.AddSpanCell(spr.ActiveSheet.RowCount - 1, 0, 1, spr.ActiveSheet.ColumnCount);

            spr.ActiveSheet.RowCount++;
            spr.Sheets[0].Cells.Get(spr.ActiveSheet.RowCount - 1, 0).CellType = tc;
            spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text = r특기사항;
            spr.ActiveSheet.AddSpanCell(spr.ActiveSheet.RowCount - 1, 0, 1,spr.ActiveSheet.ColumnCount );
            spr.ActiveSheet.RowCount++;
            spr.Sheets[0].Cells.Get(spr.ActiveSheet.RowCount - 1, 0).CellType = tc;
            spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text = r안전검토사항 ;
            spr.ActiveSheet.AddSpanCell(spr.ActiveSheet.RowCount - 1, 0, 1, spr.ActiveSheet.ColumnCount);

            기타_높이(r기타);

            Cursor.Current = Cursors.Default;
         
            //   cls_com.SpreadLoad(this, spr.Sheets[0]);

            무게비계산();
            중량계산();

            // FarPoint.Win.ComplexBorderSide oneborder = new FarPoint.Win.ComplexBorderSide(Color.Black, 1,System.Drawing.Drawing2D.DashStyle.Solid );
            // FarPoint.Win.ComplexBorderSide oneborder2 = new FarPoint.Win.ComplexBorderSide(Color.Black, 2);
            // FarPoint.Win.ComplexBorder border = new FarPoint.Win.ComplexBorder(oneborder, oneborder, oneborder, oneborder);
            // spr.ActiveSheet.ColumnHeader.Cells.Get(0, 0, 0, spr.ActiveSheet.ColumnCount - 1).Border = border;
            // spr.ActiveSheet.Cells.Get(0, 0,spr.ActiveSheet.Rows.Count-1, spr.ActiveSheet.ColumnCount - 1).Border = border;

            spr.Sheets[0].ColumnHeader.Cells.Get(0, 0,  spr.Sheets[0].ColumnHeader.RowCount - 1, spr.Sheets[0].ColumnCount - 1).Border = bevelBorder;
            spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Border = bevelBorder;

            spr.ActiveSheet.Columns[0].Width = 40;
            spr.ActiveSheet.Columns[1].Width = 0;
            spr.ActiveSheet.Columns[2].Width = 200;
            spr.ActiveSheet.Columns[3].Width = 200;
            spr.ActiveSheet.Columns[4].Width = 100;
            spr.ActiveSheet.Columns[5].Width = 100;
            spr.ActiveSheet.Columns[6].Width = 100;
            spr.ActiveSheet.Columns[7].Width = 100;
            spr.ActiveSheet.Columns[8].Width = 100;
            spr.ActiveSheet.Columns[9].Width = 100;
        }

        private void 기타_높이(string 기타)
        {
            string[] arr;
            arr = 기타.Split(',');

            if (arr.Length >= 3 )
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
                frm기초데이타_제품등록 frm기초데이타_제품등록 = new frm기초데이타_제품등록(cmb창고.Text, txt작업지시번호.Text, cls_com.GetDate(dtp.Value)
                    , txt제품명.Tag.ToString(), txt제품명.Text , txt사업명.Text, txt사업코드.Text, txt공실번호.Text, txt혼화량.Text, txt혼화일.Text 
                    , txtBtno.Text, spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount-3,0].Text  , spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 2, 0].Text, spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text);
                frm기초데이타_제품등록.ShowDialog();
                txt작업지시번호.Text = frm기초데이타_제품등록.r작업지시번호;
                조회();
                조회2();
        }

        private void txt작업지시번호_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt제품명_TextChanged(object sender, EventArgs e)
        {
            BTNO();
        }

        private void txt공실번호_TextChanged(object sender, EventArgs e)
        {
            BTNO();
        }

        private void txt혼화량_TextChanged(object sender, EventArgs e)
        {
            중량계산();
        }
        private void 중량계산()
        {
            int i;
            float 중량=0;
            float 중량합=0, 혼합비합=0; 
            for (i = 0;i < spr.ActiveSheet.RowCount-4; i ++)
            {
                중량 = cls_com.Val_f(txt혼화량.Text) * cls_com.Val_f(spr.ActiveSheet.Cells[i, 4].Text) / 100;
                spr.ActiveSheet.Cells[i, 6].Text = 중량.ToString();
                중량합 = 중량합 + 중량;
                혼합비합 = 혼합비합 + cls_com.Val_f(spr.ActiveSheet.Cells[i,4].Text);

            }
            spr.ActiveSheet.Cells[i, 0].Text = "합 계";

            spr.ActiveSheet.Cells[i, 4].Text = 혼합비합.ToString() ;
            spr.ActiveSheet.Cells[i, 6].Text = 중량합.ToString() ;


            r배치무게 = 중량합.ToString() + " kg";

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
            조회();
            조회2();

        }
        private void 저장_작업지시서()
        {

            r기타 = spr.ActiveSheet.Rows[spr.ActiveSheet.Rows.Count - 3].Height.ToString() +  "," + spr.ActiveSheet.Rows[spr.ActiveSheet.Rows.Count - 2].Height.ToString()
                    + "," + spr.ActiveSheet.Rows[spr.ActiveSheet.Rows.Count - 1].Height.ToString();
            r수식 = spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 3, 0].Text;
            r특기사항 = spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 2, 0].Text;
            r안전검토사항 = spr.ActiveSheet.Cells[spr.ActiveSheet.RowCount - 1, 0].Text;


            sql = " exec s_a301_작업지시서_저장 '2','" + cls_com.g공장 + "','" + cmb창고.Text + "','" + txt작업지시번호.Text + "','','','" + txt제품명.Tag.ToString() + "','" + txt사업명.Text + "','" + txt사업코드.Text 
                  + "','" + txt공실번호.Text + "','" + txt혼화량.Text + "','" + txt혼화일.Text + "','" + txtBtno.Text + "','" + r수식
                  + "','" + r특기사항 + "','" + r안전검토사항 + "','','" + cls_com.s사용자.성명  +"','','','" + r기타  +"' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            else
            {
                cls_com.로그(cls_com.s사용자.성명, "작업지시서", "저장", sql);

            }
        }
        private void 저장_작업지시서_계획()
        {
            for (int i = 0; i < spr.ActiveSheet.RowCount-4; i ++)
            {
                sql = "";
                sql = sql + " exec s_a301_작업지시서_계획_저장 '2','" + txt작업지시번호.Text + "','" + spr.ActiveSheet.Cells[i, 0].Text + "','" + spr.ActiveSheet.Cells[i, 1].Text + "' ";
                sql = sql + ",'" + spr.ActiveSheet.Cells[i, 3].Text + "','" + spr.ActiveSheet.Cells[i, 4].Text + "','" + spr.ActiveSheet.Cells[i, 5].Text + "' ";
                sql = sql + ",'" + spr.ActiveSheet.Cells[i, 6].Text + "','" + spr.ActiveSheet.Cells[i, 7].Text + "','" + spr.ActiveSheet.Cells[i, 8].Text + "' ";
                sql = sql + ",'" + spr.ActiveSheet.Cells[i, 9].Text + "',''" ;
                DataSet ds = cls_com.Select_Query(sql);
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                } else
                {
                    cls_com.로그(cls_com.s사용자.성명, "작업지시서 계획", "저장", sql);

                }

            }
        }

        private void btn작업지시번호_Click(object sender, EventArgs e)
        {
            frm기타_작업지시서조회 frm기타_작업지시서조회 = new frm기타_작업지시서조회();
            frm기타_작업지시서조회.ShowDialog();
            txt작업지시번호.Text = frm기타_작업지시서조회.r작업지시번호;
            조회();
            조회2();
           
        }

        private void btn수정_Click(object sender, EventArgs e)
        {

            수정();
        }
        private void 수정()
        {
            if (spr.ActiveSheet.Rows.Count <= 0) return;
            try
            {
                spr.ActiveSheet.Cells.Get(0, 3, spr.ActiveSheet.RowCount - 5, 5).Locked = false;
                spr.ActiveSheet.Cells.Get(0, 3, spr.ActiveSheet.RowCount - 5, 5).BackColor = cls_color.gColor_수정;
                spr.ActiveSheet.Cells.Get(0, 9, spr.ActiveSheet.RowCount - 5, 9).Locked = false;
                spr.ActiveSheet.Cells.Get(0, 9, spr.ActiveSheet.RowCount - 5, 9).BackColor = cls_color.gColor_수정;

            }
            catch
            {

            }
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

        private void pan수식_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt혼화일_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt사업코드_TextChanged(object sender, EventArgs e)
        {
            BTNO();
        }

        private void btn출력_Click(object sender, EventArgs e)
        {
            출력();
        }

        private void 출력()
        {
            string title = "작 업 지 시 서";
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
                    pi.Margin.Header = 65;
                    pi.Margin.Bottom = 0;
                    pi.Margin.Left = 0;
                    pi.Margin.Right = 0;
                    pi.Header = "";
                    pi.Header = pi.Header + "/n/c/fu1/fn\"굴림체\"/fz\"20\"" + title  + "/n  /n" ;
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

        private void lblCnt_Click(object sender, EventArgs e)
        {

        }

        private void btn재고량_Click(object sender, EventArgs e)
        {
            재고량();
        }
        private void 재고량()
        {
            
            for (int i = 0; i < spr.ActiveSheet.RowCount-4; i++ )
            {
                DataSet ds = cls_com.Select_Query(" SELECT DBO.F_재고량('" + cls_com.g공장 + "','" + cmb창고.Text + "','" + spr.ActiveSheet.Cells[i, 1].Text + "' )   재고량" ) ;
                spr.ActiveSheet.Cells[i, 8].Text = ds.Tables[0].Rows[0]["재고량"].ToString();
            }
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

        private void spr_PrintHeaderFooterArea(object sender, FarPoint.Win.Spread.PrintHeaderFooterAreaEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            SolidBrush blueBrush = new SolidBrush(Color.YellowGreen);
            SolidBrush blueBrush2 = new SolidBrush(Color.Black);
            Rectangle rect = new Rectangle(10, 100, 800, 30);
            //          e.Graphics.FillRectangle(blueBrush, rect);

            // e.Graphics.DrawString("작업 지시서", new Font("굴림체",12,FontStyle.Bold) , blueBrush2, 200, 105);
            e.Graphics.DrawString("사 업 명  : " + txt사업명.Text , new Font("굴림체",16,FontStyle.Bold) , blueBrush2, 10, 80);
            e.Graphics.DrawString("작업지시번호 : " + txt작업지시번호.Text, new Font("굴림체", 12, FontStyle.Regular), blueBrush2, 11, 110);
            e.Graphics.DrawString("배치번호 : " +  txtBtno.Text , new Font("굴림체", 10, FontStyle.Regular), blueBrush2, 13, 130);
            e.Graphics.DrawString("배치무게 : " + r배치무게 , new Font("굴림체", 10, FontStyle.Regular), blueBrush2, 230, 130);
            e.Graphics.DrawString("혼화일 : " + txt혼화일.Text , new Font("굴림체", 10, FontStyle.Regular), blueBrush2, 430, 130);
            e.Graphics.DrawString("작성자 : " + r작성자, new Font("굴림체", 10, FontStyle.Regular), blueBrush2, 660, 130);

            // e.Graphics.DrawString("작업 지시서", new Font("굴림체",12,FontStyle.Bold) , blueBrush2, 200, 105);
        }

        private void BTNO()
        {
            sql = " select dbo.f_작업지시서_btno('" + txt사업코드.Text + "','" + txt공실번호.Text + "','" + cls_com.GetDate(dtp.Value) + "','" + txt제품명.Tag.ToString() + "' ) ";
            DataSet ds = cls_com.Select_Query(sql);
            txtBtno.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            BTNO();
        }

        private void spr_EditModeOff(object sender, EventArgs e)
        {
            int icol,irow;
            string 자재코드="",로트번호 = "";
            irow = spr.ActiveSheet.ActiveRow.Index;
            icol = spr.ActiveSheet.ActiveColumn.Index;

            if (icol == 3)
            {
                자재코드 = spr.ActiveSheet.Cells[irow, 1].Text;
                로트번호 = spr.ActiveSheet.Cells[irow, icol].Text;
                if (!로트번호.Equals(""))
                {
                    sql = "select 자재코드,SUM(재고량) 재고량  from a201_자재_재고 where 로트번호 = '" + 로트번호 + "' GROUP BY 자재코드  ";
                    DataSet ds = cls_com.Select_Query(sql);
                    if (ds.Tables[0].Rows.Count > 0 )
                    {
                        if (!자재코드.Equals(ds.Tables[0].Rows[0]["자재코드"].ToString() ))
                        {
                            MessageBox.Show("다론 원료 로트번호입니다.");
                            spr.ActiveSheet.Cells[irow, icol].Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("미등록 로트번호입니다.");
                        spr.ActiveSheet.Cells[irow, icol].Text = "";
                    }
                }
            }
        }
    }
}
