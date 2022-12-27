using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace  hanwha_wis

{
    public partial class frm기타_엑셀등록_자재 : Form
    {
        String sql = "";
        public string rFileName = "";
        public frm기타_엑셀등록_자재()
        {
            InitializeComponent();
        }
        public frm기타_엑셀등록_자재(string iFileName)
        {
            InitializeComponent();
            rFileName = iFileName;
        }

        private void btn엑셀_불러오기_Click(object sender, EventArgs e)
        {

        }
        private void LoadExcel()
        {

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // sprList.ActiveSheet.OpenExcel(rfileName, 0);
                spr.OpenExcel(rFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Cursor.Current = Cursors.Default;

        }

        private void frm기타_엑셀등록_자재_Load(object sender, EventArgs e)
        {
            LoadExcel();
            초기화();
         }
     
        private void 초기화()
        {

            헤드();            

        }
        private void 헤드()
        {
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "자재코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "자재코드명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "자재명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "제조국가";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "제조국가코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "제조사";
            spr.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "제조사약어";
            spr.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "INDEX유무";
            spr.ActiveSheet.ColumnHeader.Cells[0, 8].Text = "단위중량";
            spr.ActiveSheet.ColumnHeader.Cells[0, 9].Text = "적용Seive";
            spr.ActiveSheet.ColumnHeader.Cells[0, 10].Text = "비고";

        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
        }

        private void 저장()
        {

            int i, j, cnt = 0, cnt2 = 0; 
            String[] b = new String[100];
            string sql1 = "";
            
            for (i = 1; i < spr.ActiveSheet.RowCount; i++)
            {
                lblCnt2.Text = i.ToString();
                Application.DoEvents();

                sql1 = "";
                for (j = 0; j < 12; j++)
                {
                    b[j] = spr.ActiveSheet.Cells[i, j].Text.Trim();
                    sql1 = sql1 + ",'" + b[j].Trim() + "' ";
                }

                if (b[0].Equals("")  )
                {
                    cnt++;
                    if (cnt > 10)
                    {
                        MessageBox.Show(cnt2.ToString() + " 건 저장 완료");
                        return;
                    } else
                    {
                        continue;
                    }
                } else
                {
                    cnt = 0;
                }


                sql = " exec s_a101_자재_저장 '11' " + sql1;
                DataSet ds = cls_com.Select_Query(sql);
                cnt2++;

            }
        }
    
        private void btn조회_Click(object sender, EventArgs e)
        {
            
        }
    }

}
