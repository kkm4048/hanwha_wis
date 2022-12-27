using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hanwha_wis
{
    public partial class frm파일_설정 : Form
    {
        string sql = "";
        public frm파일_설정()
        {
            InitializeComponent();
        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
            Close();
        }

        private void frm파일_설정_Load(object sender, EventArgs e)
        {
            Add공장();
            Add프린터();
        }
        private void Add공장()
        {
            sql = " exec s_a101_공장_조회 '1','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            cmb공장.Items.Clear();
            for (int i = 0;i < ds.Tables[0].Rows.Count; i ++ )
            {
                cmb공장.Items.Add(ds.Tables[0].Rows[i]["공장"].ToString());
            }
            cmb공장.Text = cls_com.g공장;

        }
        private void Add프린터()
        {
            //프린터리스트
            cmb라벨프린터.Items.Clear();
            cmbA4프린터.Items.Clear();
            PrinterSettings.StringCollection AllPrinters = PrinterSettings.InstalledPrinters;

            for (int i = 0; i < AllPrinters.Count; i++)
            {
                cmb라벨프린터.Items.Add(AllPrinters[i].ToString());
                cmbA4프린터.Items.Add(AllPrinters[i].ToString());
            }
            cmb라벨프린터.Text = cls_com.g라벨프린터;
            cmbA4프린터.Text = cls_com.gA4프린터;

        }
        private void 저장()
        {
            cls_com.g공장 = cmb공장.Text;
            cls_com.ConfigSave("설정", "공장", cmb공장.Text);
            cls_com.g라벨프린터 = cmb라벨프린터.Text;
            cls_com.ConfigSave("라벨프린터", cmb라벨프린터.Text);
            cls_com.gA4프린터 = cmbA4프린터.Text;
            cls_com.ConfigSave("A4프린터", cmbA4프린터.Text);

        }

        private void A4프린터_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
