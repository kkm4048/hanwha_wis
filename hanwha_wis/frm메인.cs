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
    public partial class frm메인 : Form
    {
        public frm메인()
        {
            InitializeComponent();
        }

        private void m기초데이타_사용자등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_사용자등록");
        }

        private void FrmShow(String formToCall)
        {
            try
            {
                var type = Type.GetType("hanwha_wis." + formToCall);
                Form frm = Activator.CreateInstance(type) as Form;

                if (frm != null)
                {
                    bool FrmisExist = new bool();
                    FrmisExist = false;

                    foreach (Form form1 in Application.OpenForms)
                    {
                        if (form1.GetType() == frm.GetType())
                        {
                            form1.Activate();
                            form1.Focus();
                            FrmisExist = true;
                        }
                    }

                    // 폼존재여부에 따라서 생성과 파기
                    if (!FrmisExist)
                    {

                        frm.Show();
                        frm.Activate();
                        frm.Focus();
                        frm.BringToFront();
                    }
                    else
                    {
                        frm.Dispose();
                    }
                }
            }
            catch
            {
            }


        }


        private void FrmShow2(String formToCall)
        {
            try
            {
                var type = Type.GetType("hanwha_wis." + formToCall);
                Form frm = Activator.CreateInstance(type) as Form;

                if (frm != null)
                {
                    bool FrmisExist = new bool();
                    FrmisExist = false;

                    foreach (Form form1 in Application.OpenForms)
                    {
                        if (form1.GetType() == frm.GetType())
                        {

                            form1.Activate();
                            form1.Focus();
                            FrmisExist = true;
                        }
                    }

                    // 폼존재여부에 따라서 생성과 파기
                    if (!FrmisExist)
                    {

                        frm.MdiParent = this;
                        frm.WindowState = FormWindowState.Maximized;
                        frm.Show();
                        frm.Activate();
                        frm.Focus();
                        frm.BringToFront();
                    }
                    else
                    {
                        frm.Dispose();
                    }
                }
            }
            catch
            {
            }


        }

        private void m기초데이타_공장부서창고등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_공장부서창고등록");

        }

        private void m기초데이타_자재등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_자재등록");
        }

        private void m자재입출고관리_입고등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm자재입출고관리_입고등록");
        }

        private void frm메인_Load(object sender, EventArgs e)
        {
            String d;
            d = cls_com.ConfigLoad("설정", "공장", "대전사업장").Trim() ;

            cls_com.g공장 = d;

            cls_com.g라벨프린터 = cls_com.ConfigLoad("라벨프린터");
            cls_com.gA4프린터 = cls_com.ConfigLoad("A4프린터");


            ssl.Text = cls_com.g공장 + " " + cls_com.s사용자.아이디 + " " + cls_com.s사용자.아이디 + " " + cls_com.s사용자.성명 + " " + cls_com.s사용자.소속;
        }

        private void m파일_설정_Click(object sender, EventArgs e)
        {
            FrmShow2("frm파일_설정");
        }

        private void m작업관리_계량_Click(object sender, EventArgs e)
        {
            FrmShow2("frm작업관리_계량");
        }

        private void m자재입출고관리_입고조회_Click(object sender, EventArgs e)
        {
            FrmShow2("frm자재입출고관리_입고조회");
        }

        private void m자재입출고관리_재고조회_Click(object sender, EventArgs e)
        {
            FrmShow("frm자재입출고관리_재고조회");
        }

        private void m자재입출고관리_출고등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm자재입출고관리_출고등록");
        }

        private void m자재입출고관리_출고조회_Click(object sender, EventArgs e)
        {
            FrmShow2("frm자재입출고관리_출고조회");
        }

        private void m기초데이타_제품등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_제품등록");
        }

        private void m작업관리_작업지시서_Click(object sender, EventArgs e)
        {
            FrmShow2("frm작업관리_작업지시서");
        }

        private void m자재입출고관리_투입예정원료예약_Click(object sender, EventArgs e)
        {
            FrmShow2("frm자재입출고관리_투입예정원료예약");
        }

        private void 로그조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShow("frm기초데이타_로그조회");
        }

        private void m기초데이타_공통코드등록_Click(object sender, EventArgs e)
        {
            FrmShow("frm기초데이타_공통코드등록");
        }
    }
}
