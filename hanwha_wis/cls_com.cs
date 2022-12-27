﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Media;
using System.IO;
using System.Threading;

namespace hanwha_wis
{
    class cls_com
    {
        public static string g시스템명 = "hanwha_wis";
        public static string g상호 = "한화";

        public static string sql;

 //      public static string gConn_String = "Data Source=49.1.232.110,5000;Initial Catalog=hanwha_wis;User Id=syst5132;Password=tltmxm5132!@#";
        public static string gConn_String = "Data Source=49.1.232.110,5000;Initial Catalog=hanwha_wis;User Id=syst5132;Password=tltmxm5132!@#";


        public static string gId = "", gPassword = "";
        public static SqlConnection gConn = null;
        public static string gPath = Environment.CurrentDirectory;
        public static string Speadinifile = Environment.CurrentDirectory + "\\Spread.ini";
        public static string ConfigIniFile = Environment.CurrentDirectory + "\\Config.ini";
        public static string gOKFile = Environment.CurrentDirectory + "\\OK.wav";
        public static string gFailFile = Environment.CurrentDirectory + "\\Fail.wav";
        public static string gPath_폼 = Environment.CurrentDirectory + "\\폼";
        public static string g라벨프린터 = "";
        public static string gA4프린터 = "";
        public static string g공장 = "";
        public static string STX = char.ConvertFromUtf32(2);
        public static string ETX = char.ConvertFromUtf32(3);
        public static string EOT = char.ConvertFromUtf32(4);
        public static string ENQ = char.ConvertFromUtf32(5);
        public static string ACK = char.ConvertFromUtf32(6);
        public static string LF = char.ConvertFromUtf32(10);
        public static string CR = char.ConvertFromUtf32(13);
        public static string CRLF = char.ConvertFromUtf32(13) + char.ConvertFromUtf32(10); 

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32")]
        public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);
        [DllImport("winmm")]
        private static extern int PlaySound(string szSound, IntPtr hModule, int flags);

        private enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0,             // play synchronously (default)
            SND_ASYNC = 0x1,            // play asynchronously
            SND_NODEFAULT = 0x2,        // silence (!default) if sound not found
            SND_MEMORY = 0x4,           // pszSound points to a memory file
            SND_LOOP = 0x8,             // loop the sound until next sndPlaySound
            SND_NOSTOP = 0x10,          // don't stop any currently playing sound
            SND_NOWAIT = 0x2000,        // don't wait if the driver is busy
            SND_ALIAS = 0x10000,        // name is a registry alias
            SND_ALIAS_ID = 0x110000,    // alias is a predefined ID
            SND_FILENAME = 0x20000,     // name is file name
            SND_RESOURCE = 0x40004,     // name is resource name or atom
        };
        //로그인 사용자 정보

        public static string g아이디 = "", g암호 = "";
        public struct sDB
        {
            public static string 아이피 = "";
            public static string 포트 = "";
            public static string 외부아이피 = "";
            public static string 외부포트 = "";
            public static string DB = "";
            public static string 아이디 = "";
            public static string 암호 = "";
        }
        public struct s기본
        {
            public static string 사업장코드 = "";
            public static string 사업장명 = "";
        }
        public struct s사용자
        {
            public static string 아이디 = "";
            public static string 암호 = "";
            public static string 성명 = "";
            public static string 소속 = "";
            public static string 연락처 = "";
            public static string 권한 = "";
            public static string 비고 = "";
        }




        public static DataSet Select_Query(string sQuery)
        {
            try
            {

                SqlConnection con = new SqlConnection(gConn_String);
                DataSet ds = new DataSet();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sQuery, con);
                sqlAdapter.Fill(ds);
                con.Close();
                return ds;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("[Select_Query2]" + ex.Message + "\n" + sql);
                return null;
            }
        }
        public static string ExcuteNonQuery(string sQuery)
        {
            try
            {
                SqlConnection con = new SqlConnection(gConn_String);
                con.Open();
                SqlCommand com = new SqlCommand(sQuery, con);
                com.ExecuteNonQuery();
                con.Close();
                string sResult = "success";
                return sResult;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(sQuery + Keys.Enter + "[ExcuteNonQuery]" + ex.Message);
                return "[ExcuteNonQuery]" + ex.Message;
            }
        }



        public static void SpreadSave(Form iForm, FarPoint.Win.Spread.SheetView iSpread)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName;
                string sSection = "SPREAD_WIDTH";
                string sData = "";
                for (int i = 0; i < iSpread.ColumnCount; ++i)
                {
                    sData = sData + Convert.ToString(iSpread.ColumnHeader.Cells.Get(0, i).Column.Width) + "|";
                }

                WritePrivateProfileString(sSection, ikey, sData, Speadinifile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }
        public static void SpreadSave(Form iForm, FarPoint.Win.Spread.SheetView iSpread, string 구분)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName + "_" + 구분;
                string sSection = "SPREAD_WIDTH";
                string sData = "";
                for (int i = 0; i < iSpread.ColumnCount; ++i)
                {
                    sData = sData + Convert.ToString(iSpread.ColumnHeader.Cells.Get(0, i).Column.Width) + "|";
                }

                WritePrivateProfileString(sSection, ikey, sData, Speadinifile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }
        public static void SpreadLoad(Form iForm, FarPoint.Win.Spread.SheetView iSpread)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName;
                string sSection = "SPREAD_WIDTH";
                StringBuilder sData = new StringBuilder(512);

                GetPrivateProfileString(sSection, ikey, "", sData, 512, Speadinifile);
                string arr = sData.ToString();
                if (arr.Length != 0)
                {
                    string[] arrSplit = arr.Split('|');
                    for (int i = 0; i < arrSplit.Length - 1; ++i)
                    {
                        if (i == iSpread.ColumnCount) break;
                        iSpread.ColumnHeader.Cells.Get(0, i).Column.Width = Convert.ToInt32(arrSplit[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
            }
        }
        public static void SpreadLoad(Form iForm, FarPoint.Win.Spread.SheetView iSpread, string 구분)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName + "_" + 구분;
                string sSection = "SPREAD_WIDTH";
                StringBuilder sData = new StringBuilder(512);

                GetPrivateProfileString(sSection, ikey, "", sData, 512, Speadinifile);
                string arr = sData.ToString();
                if (arr.Length != 0)
                {
                    string[] arrSplit = arr.Split('|');
                    for (int i = 0; i < arrSplit.Length - 1; ++i)
                    {
                        if (i == iSpread.ColumnCount) break;
                        iSpread.ColumnHeader.Cells.Get(0, i).Column.Width = Convert.ToInt32(arrSplit[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
            }
        }

        public static void 높이자동조절(FarPoint.Win.Spread.FpSpread spr)
        {
            Application.DoEvents();
            int irow1, irow2;
            irow1 = spr.GetViewportTopRow(0);
            irow2 = spr.GetViewportBottomRow(0);

            for (int i = irow1; i < irow2; i++)
            {
                spr.ActiveSheet.Rows[i].Height = spr.ActiveSheet.Rows[i].GetPreferredHeight();
            }

        }
        public static void ConfigSave(string iKey, string iData)
        {
            try
            {
                string sSection = "CONFIG";
                WritePrivateProfileString(sSection, iKey, iData, ConfigIniFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }
        public static void ConfigSave(string iKey, string iKey2, string iData)
        {
            try
            {
                string sSection = iKey;

                WritePrivateProfileString(sSection, iKey2, iData, ConfigIniFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }

        public static string ConfigLoad(string iKey)
        {
            string sSection = "CONFIG";
            StringBuilder sData = new StringBuilder(512);
            string iData;
            GetPrivateProfileString(sSection, iKey, "", sData, 512, ConfigIniFile);
            iData = sData.ToString();
            return iData;
        }
        public static string ConfigLoad(string iKey, string value)
        {
            string sSection = "CONFIG";
            StringBuilder sData = new StringBuilder(512);
            string iData;
            GetPrivateProfileString(sSection, iKey, "", sData, 512, ConfigIniFile);
            iData = sData.ToString();
            if (iData.Equals(""))
            {
                iData = value;
            }
            return iData;
        }

        public static string ConfigLoad(string iKey, string key2, string value)
        {


            string sSection = iKey;

            StringBuilder sData = new StringBuilder(512);
            string iData;


            GetPrivateProfileString(sSection, key2, "", sData, 512, ConfigIniFile);

            iData = sData.ToString();
            if (iData.Equals(""))
            {
                cls_com.ConfigSave(iKey, key2, value);
                iData = value;

            }
            return iData;
        }

        public static DateTime GetDate()
        {
            DateTime DT;
            DT = DateTime.Now;
            sql = "";
            sql = sql + " SELECT Convert(nvarchar(10),getdate(),102)  DT_TM ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return DT;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                return DT;
            }
            DT = DateTime.Parse(ds.Tables[0].Rows[0]["DT_TM"].ToString());
            ds.Dispose();
            return DT;
        }
        public static String GetDate2()
        {
            String Dt = "";
            sql = "";
            sql = sql + " SELECT Convert(nvarchar(19),getdate(),102)  DT_TM ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return Dt;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                return Dt;
            }
            Dt = ds.Tables[0].Rows[0]["DT_TM"].ToString().Substring(0, 10);
            ds.Dispose();
            return Dt;
        }
        public static string GetDate_년월일(String dt)
        {
            //SPEC
            String d = "";
            d = dt.Substring(0, 4) + "년 " + dt.Substring(5, 2) + "월 " + dt.Substring(8, 2) + "일";
            return d;
        }

        public static int DB_정기점검일_수량()
        {
            int i = 0;
            sql = "";
            sql = sql + " SELECT DBO.F_정기점검_수량('') 수량";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return i;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                return i;
            }
            i = cls_com.Val(ds.Tables[0].Rows[0]["수량"].ToString());

            return i;
        }
        public static String GetCode(String cb)
        {
            String[] a;
            String d = "";
            a = cb.Split(' ');
            if (a.Length > 0)
            {
                d = a[0];
            }
            return d;
        }
        public static String GetName(String cb)
        {
            String d = "";
            int ipos = cb.IndexOf(' ');

            if (ipos >= 0)
            {
                d = cb.Substring(ipos).Trim();
            }
            return d;
        }
        public static String GetDate(String dt)
        {
            return String.Format("{0:yyyy.MM.dd}", dt);
        }
        public static String GetDate(DateTime dt)
        {
            return String.Format("{0:yyyy.MM.dd}", dt);
        }
        public static String GetDate_현재일(String dt)
        {
            String d = "";
            try
            {
                return String.Format("{0:yyyy.MM.dd}", dt);
            }
            catch
            {
                d = String.Format("{0:yyyy.MM.dd}", DateTime.Now);
                return d;
            }

        }
        public static string GetTime()
        {
            return String.Format("{0:HH:mm:ss}", DateTime.Now);
        }

        public static string Left(string target, int length)
        {


            if (target.Length < length) return target;
            return target.Substring(0, length);

        }
        public static string Right(string target, int length)
        {
            if (length <= target.Length)
            {
                return target.Substring(target.Length - length);
            }
            return target;
        }
        public static int Val2(string d)
        {
            string d2;
            int d3;

            if (String.IsNullOrEmpty(d))
            {
                d = "0";
            }
            d2 = d.Replace(",", "");


            if (numericCheck(d2))
            {
            }
            else
            {
                d2 = "0";
            }
            d3 = (int)Convert.ToDouble(d2);
            return d3;
        }

        public static int Val(string d)
        {
            string d2;
            int d3;

            if (String.IsNullOrEmpty(d))
            {
                d = "0";
            }
            d2 = d.Replace(",", "");


            if (numericCheck(d2))
            {
            }
            else
            {
                d2 = "0";
            }
            d3 = (int)Convert.ToDouble(d2);
            return d3;
        }

        public static double Val3(string d)
        {
            string d2;
            double d3;
            try
            {
                if (String.IsNullOrEmpty(d))
                {
                    d = "0";
                }
                d2 = d.Replace(",", "");



                d3 = Convert.ToDouble(d2);
                return d3;
            }
            catch (Exception e)
            {
                Trace.Write(e.Message);
                return 0;
            }
        }

        public static string Val_c(string d)
        {
            string d2;
            string d3;

            if (String.IsNullOrEmpty(d))
            {
                d = "0";
            }
            d2 = d.Replace(",", "");



            d3 = String.Format("{0:#,0}", Convert.ToDouble(d2));
            return d3;
        }


        public static float Val_f(string d)
        {
            string d2;
            float d3;

            if (String.IsNullOrEmpty(d))
            {
                d = "0";
            }
            d2 = d.Replace(",", "");


            if (numericCheck(d2))
            {
            }
            else
            {
                d2 = "0";
            }
            d3 = (float)Convert.ToDouble(d2);
            return d3;
        }

        //숫자여부 체크
        public static bool numericCheck(string strNumber)
        {
            try
            {
                double iNumber = Convert.ToDouble(strNumber);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string 숫자(string 값)
        {
            string d;
            d = 값.Replace(",", "").Trim();
            if (numericCheck(값))
            {
                return String.Format("{0:#,0}", Convert.ToInt32(d));
            }
            else
            {
                return "0";
            }
        }



        public static string 계산(string d)
        {
            try
            {
                d = d.Replace(",", "");
                sql = " SELECT " + d + " 값 ";
                DataSet ds = cls_com.Select_Query(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return "";
            }

        }
        public static bool 날짜여부(String d)
        {

            try
            {
                DateTime date = DateTime.Parse(d);

                if (d.Equals(String.Format("{0:yyyy-MM-dd}", date)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return false;
            }
        }
        // 월요일 기준
        public static int WeekDay(String 일자)
        {
            int i = 1;
            DayOfWeek 요일;
            요일 = Convert.ToDateTime(일자).DayOfWeek;

            if (요일.ToString().Equals("Monday"))
            {
                i = 1;
            }
            else if (요일.ToString().Equals("Tuesday"))
            {
                i = 2;
            }
            else if (요일.ToString().Equals("Wednesday"))
            {
                i = 3;
            }
            else if (요일.ToString().Equals("Thursday"))
            {
                i = 4;
            }
            else if (요일.ToString().Equals("Friday"))
            {
                i = 5;
            }
            else if (요일.ToString().Equals("Saturday"))
            {
                i = 6;
            }
            else if (요일.ToString().Equals("Sunday"))
            {
                i = 7;
            }
            return i;
        }

        public static void Excel_Process_Kill(IntPtr handle)
        {

            uint pid = 0;

            cls_com.GetWindowThreadProcessId((IntPtr)handle, out pid); // 핸들로 프로세스아이디 얻어옴 
            Process[] AllProcesses = Process.GetProcessesByName("excel");
            foreach (Process excelProcess in AllProcesses)
            {
                if (excelProcess.Id == pid)
                {
                    excelProcess.Kill();
                }
            }

        }
        public static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }
        // 프린터 텍스트
        public static void PrintText(System.Drawing.Printing.PrintPageEventArgs e, string iData, Font iFont, string iAlign, string iDir, int iX, int iY, int iW, int iH)
        {
            int iWidth;
            if (iData == "") return;

            //       iX = Convert.ToInt32(iX * 0.3937);
            //     iY = Convert.ToInt32(iY * 0.3937);

            iWidth = Convert.ToInt32(e.Graphics.MeasureString(iData, iFont).Width);

            if (iDir == "0")
            {

                if (iAlign == "CENTER")
                {
                    iX = iX - (iWidth / 2);

                }
                else if (iAlign == "RIGHT")
                {
                    iX = iX - iWidth;
                }
                else
                {


                }
                // e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);



                Matrix matrix = new Matrix();

                //글자를 270도 회전
                matrix.RotateAt(0, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);


                e.Graphics.Transform = origin;

            }
            else if (iDir == "90")
            {


                Matrix matrix = new Matrix();

                //글자를 270도 회전
                matrix.RotateAt(90, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);
                e.Graphics.Transform = origin;



            }
            else if (iDir == "180")
            {


                Matrix matrix = new Matrix();

                //글자를 180도 회전
                matrix.RotateAt(180, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);
                e.Graphics.Transform = origin;

            }
            else
            {


                Matrix matrix = new Matrix();

                //글자를 270도 회전
                matrix.RotateAt(270, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);
                e.Graphics.Transform = origin;
            }



        }

        public static void PrintBox(System.Drawing.Printing.PrintPageEventArgs e, int iX, int iY, int iWidth, int iHeight, int iThick)
        {
            Pen blackPen = new Pen(System.Drawing.Color.Black, iThick);

            // ' Create points that define line.
            iX = Convert.ToInt32(iX * 0.3937);
            iY = Convert.ToInt32(iY * 0.3937);
            iWidth = Convert.ToInt32(iWidth * 0.3937);
            iHeight = Convert.ToInt32(iHeight * 0.3937);
            Point point1 = new Point(iX, iY);
            Point point2 = new Point(iWidth, iHeight);

            e.Graphics.ScaleTransform(1, 1);
            e.Graphics.DrawRectangle(blackPen, iX, iY, iWidth, iHeight);
            e.Graphics.ScaleTransform(1, 1);

        }


        public static void PrintBarcode(System.Drawing.Printing.PrintPageEventArgs e, string iData, int iX, int iY, decimal iWidth, decimal iHeight, string iDir, string show, Font font, Fath.bcType bctype)
        {
            //int i;
            if (iData == "") return;
            Font ifont = new Font("굴림체", 18);

            Fath.BarcodeX BarcodeX1 = new Fath.BarcodeX();


            BarcodeX1.Font = ifont;
            if (show.Equals("True"))
            {
                BarcodeX1.ShowText = true;
                BarcodeX1.Font = font;
            }
            else
            {
                BarcodeX1.ShowText = false;
            }

            BarcodeX1.Symbology = (Fath.bcType)bctype;


            BarcodeX1.Orientation = Convert.ToInt32(iDir);

            //     iData = "\xb0\xa1\xb0\xa2\xb0\xa3";
            //   iData = "가나다";
            //byte[] eb = System.Text.Encoding.Unicode.GetBytes(iData);
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding e949 = Encoding.GetEncoding(949);
            byte[] utf8Bytes = e949.GetBytes(iData);

            byte[] eb = System.Text.Encoding.UTF8.GetBytes(iData);
            String bv2 = "";
            bv2 = Convert.ToBase64String(eb).ToString();
            string decodedStringByUTF8 = utf8.GetString(utf8Bytes);


            BarcodeX1.Data = iData;

            //  BarcodeX1.Data = bv;
            //  BarcodeX1.Data = decodedStringByUTF8;




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //  원본
            //iX = Convert.ToInt32(iX * 0.3937);
            //iY = Convert.ToInt32(iY * 0.3937);

            //BarcodeX1.Width = (int)(iWidth * (decimal)0.003937 * (int)150);
            //BarcodeX1.Height = (int)(iHeight * (decimal)0.003937 * (int)150);

            //System.Drawing.Rectangle rc = new System.Drawing.Rectangle(iX, iY, (int)(iWidth * (decimal)0.003937 * 100), (int)(iHeight * (decimal)0.003937 * 100));
            //e.Graphics.DrawImage(BarcodeX1.Image((int)((float)(iWidth * (decimal)0.003937) * e.Graphics.DpiX), (int)((float)(iHeight * (decimal)0.003937) * e.Graphics.DpiY)), rc);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // BarcodeX1 샘플 소스 수정 (0.3937 -> 0.3779)
            // config값 mm 로 변환

            //iX = Convert.ToInt32(iX * 10 * 0.3779);
            //iY = Convert.ToInt32(iY * 10 * 0.3779);                                  // 1 mm = 3.779 px

            //iX = Convert.ToInt32(iX * 0.3937);
            //iY = Convert.ToInt32(iY * 0.3937);                                     // 1 cm = 0.3937 inch     

            BarcodeX1.Width = (int)(iWidth * (decimal)0.003779 * (int)150);          // 0.003937
            BarcodeX1.Height = (int)(iHeight * (decimal)0.003779 * (int)150);

            System.Drawing.Rectangle rc = new System.Drawing.Rectangle(iX, iY, (int)(iWidth * (decimal)0.003779 * 100), (int)(iHeight * (decimal)0.003779 * 100));
            e.Graphics.DrawImage(BarcodeX1.Image((int)((float)(iWidth * (decimal)0.003779) * e.Graphics.DpiX), (int)((float)(iHeight * (decimal)0.003779) * e.Graphics.DpiY)), rc);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }



        public static Image PrintBarcode2Image(string iData, int iX, int iY, decimal iWidth, decimal iHeight, string iDir, string show, Fath.bcType bctype)
        {
            //int i;
            Image im = null;
            if (iData == "") return null;
            Font ifont = new Font("굴림체", 18);

            Fath.BarcodeX BarcodeX1 = new Fath.BarcodeX();



            BarcodeX1.ShowText = false;

            BarcodeX1.Symbology = (Fath.bcType)bctype;

            BarcodeX1.Orientation = Convert.ToInt32(iDir);

            //     iData = "\xb0\xa1\xb0\xa2\xb0\xa3";
            //   iData = "가나다";
            //byte[] eb = System.Text.Encoding.Unicode.GetBytes(iData);
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding e949 = Encoding.GetEncoding(949);
            byte[] utf8Bytes = e949.GetBytes(iData);

            byte[] eb = System.Text.Encoding.UTF8.GetBytes(iData);
            String bv2 = "";
            bv2 = Convert.ToBase64String(eb).ToString();
            string decodedStringByUTF8 = utf8.GetString(utf8Bytes);


            BarcodeX1.Data = iData;

            //  BarcodeX1.Data = bv;
            //  BarcodeX1.Data = decodedStringByUTF8;




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //  원본
            //iX = Convert.ToInt32(iX * 0.3937);
            //iY = Convert.ToInt32(iY * 0.3937);

            //BarcodeX1.Width = (int)(iWidth * (decimal)0.003937 * (int)150);
            //BarcodeX1.Height = (int)(iHeight * (decimal)0.003937 * (int)150);

            //System.Drawing.Rectangle rc = new System.Drawing.Rectangle(iX, iY, (int)(iWidth * (decimal)0.003937 * 100), (int)(iHeight * (decimal)0.003937 * 100));
            //e.Graphics.DrawImage(BarcodeX1.Image((int)((float)(iWidth * (decimal)0.003937) * e.Graphics.DpiX), (int)((float)(iHeight * (decimal)0.003937) * e.Graphics.DpiY)), rc);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // BarcodeX1 샘플 소스 수정 (0.3937 -> 0.3779)
            // config값 mm 로 변환

            //iX = Convert.ToInt32(iX * 10 * 0.3779);
            //iY = Convert.ToInt32(iY * 10 * 0.3779);                                  // 1 mm = 3.779 px

            //iX = Convert.ToInt32(iX * 0.3937);
            //iY = Convert.ToInt32(iY * 0.3937);                                     // 1 cm = 0.3937 inch     

            BarcodeX1.Width = (int)(iWidth * (decimal)0.003779 * (int)150);          // 0.003937
            BarcodeX1.Height = (int)(iHeight * (decimal)0.003779 * (int)150);

            System.Drawing.Rectangle rc = new System.Drawing.Rectangle(iX, iY, (int)(iWidth * (decimal)0.003779 * 100), (int)(iHeight * (decimal)0.003779 * 100));

            im = BarcodeX1.Image(100, 100);

            return im;
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        public static void PrintImage(System.Drawing.Printing.PrintPageEventArgs e, Image image, int iX, int iY, int iW, int iH)
        {

            e.Graphics.DrawImage(image, iX, iY, iW, iH);
        }

        public static String Comma(String d)
        {
            String d2 = "";
            int i;
            d2 = d.Replace(",", "");
            if (d2.Equals("")) return "0";
            i = cls_com.Val(d2);
            return String.Format("{0:#,0}", i);

        }

        public static void Sort표시(FarPoint.Win.Spread.SheetView iSpread)
        {

            for (int i = 0; i < iSpread.ColumnCount; i++)
            {
                FarPoint.Win.Spread.Column col;
                col = iSpread.Columns[i];
                col.SortIndicator = FarPoint.Win.Spread.Model.SortIndicator.Descending;
                col.ShowSortIndicator = true;
                col.AllowAutoSort = true;
            }
        }
        public static Form 폼_실행(String 폼명)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == 폼명)
                {
                    frm.Close();

                    var form0 = Activator.CreateInstance(Type.GetType("PhoenixContact_mes." + 폼명)) as Form;
                    form0.Show();
                    form0.TopMost = true;
                    form0.TopMost = false;

                    return frm;

                }
            }
            var form = Activator.CreateInstance(Type.GetType("PhoenixContact_mes." + 폼명)) as Form;
            form.Show();
            form.TopMost = true;
            form.TopMost = false;
            return null;
        }


        public static Form 폼_실행2(String 폼명)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == 폼명)
                {

                    return frm;

                }
            }
            return null;
        }

        public static Form 폼_실행3(String 폼명)
        {
            FormCollection fc = Application.OpenForms;
            Form frm0 = null;
            foreach (Form frm in fc)
            {
                frm0 = frm;
                //iterate through
                if (frm.Name == 폼명)
                {

                    return null;

                }
            }

            frm0.Show();
            return null;
        }

        public static void 소리_에러(int cnt )
        {

            for (int i = 0; i < cnt; i++)
            {
                SoundPlayer sndPlay = new SoundPlayer(Properties.Resources.fail);
                sndPlay.Play();
                Thread.Sleep(500);
            }
        }
        public static void 소리_정상()
        {
            SoundPlayer sndPlay = new SoundPlayer(Properties.Resources.ok);
            sndPlay.Play();

        }

        public static void 커서(FarPoint.Win.Spread.FpSpread spr, int row, int col)
        {
            FarPoint.Win.Spread.SheetView spr1 = spr.ActiveSheet;
            ;
            if (spr1.Rows.Count > row && spr1.ColumnCount > col)
            {

                spr1.SetActiveCell(row, col);
                spr.ShowActiveCell(FarPoint.Win.Spread.VerticalPosition.Nearest, FarPoint.Win.Spread.HorizontalPosition.Nearest);

            }

        }
        public static void 엑셀_저장(FarPoint.Win.Spread.FpSpread spr, string filename, int cnt)
        {
            spr.ActiveSheet.Protect = false;
            spr.ActiveSheet.AddRows(0, cnt);
            for (int i = 0; i < spr.ActiveSheet.ColumnCount; i++)
            {
                for (int j = 0; j < cnt; j++)
                {
                    spr.ActiveSheet.Cells[j, i].Text = spr.ActiveSheet.ColumnHeader.Cells[j, i].Text;
                }

            }
            spr.SaveExcel(filename);
            spr.ActiveSheet.RemoveRows(0, cnt);
        }
        public static Image 사진_맞춤(PictureBox pic, Image img)
        {
            int w1, h1, w2, h2, w3, h3;
            double a1, a2;
            Image img2;
            if (img == null) return null;

            w1 = pic.Width;
            h1 = pic.Height;

            w2 = img.Width;
            h2 = img.Height;


            a1 = 1.0 * w1 / h1;
            a2 = 1.0 * w2 / h2;

            // pic 박스에 세로기준으로 맞추기
            if (a1 > a2)
            {

                h3 = h1;
                w3 = h1 * w2 / h2;

            }
            else   // pic 박스에 가로기준으로 맞추기
            {
                w3 = w1;


                h3 = w1 * h2 / w2;

            }

            img2 = Resize(img, w3, h3);
            return img2;
        }
        public static Image 사진_해상도_저장(Image img)
        {

            if (img == null) return null;
            Image img2 = null;
            int w = 0, h = 0;
            if (img.Height > img.Width)
            {
                if (img.Height > 1440)
                {
                    h = 1440;
                    w = img.Width * 1440 / img.Height;
                }
                else
                {
                    h = img.Height;
                    w = img.Width;

                }
            }
            else
            {
                if (img.Width > 1440)
                {
                    w = 1440;
                    h = img.Height * 1440 / img.Width;

                }
                else
                {
                    w = img.Width;
                    h = img.Height;

                }
            }


            // 사이즈가 변경된 이미지(1/2로 축소)
            Size resize = new Size(w, h);
            img2 = new Bitmap(img, resize);

            return img2;
        }

        public static Bitmap Resize(Image img, int w, int h)
        {
            Size resize = new Size(w, h);
            Bitmap resizeImage = new Bitmap(img, resize);
            return resizeImage;
        }


        public static Image 사진_저장(Image img, int width, int height)
        {
            int w1, h1, w2, h2, w3, h3;
            double a1, a2;
            Image img2;
            if (img == null) return null;

            w1 = img.Width;
            h1 = img.Height;

            w2 = width;
            h2 = height;


            a1 = 1.0 * w1 / h1;
            a2 = 1.0 * w2 / h2;

            // pic 박스에 가로기준 맞추기
            if (a1 > a2)
            {

                w3 = w2;
                h3 = w2 * h1 / w1;

            }
            else   // pic 박스에 가로기준으로 맞추기
            {

                h3 = h2;


                w3 = w1 * h1 / h2;

            }
            img2 = Resize(img, w3, h3);
            return img2;
        }

        public static byte[] 파일2Byte(string fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName,
                                           FileMode.Open,
                                           FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            return buff;
        }


        public static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;

        }
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {

            Image returnImage = null;
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return returnImage;
        }

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
            catch
            {
                return null;
            }
        }
        public static void ComboAdd(ComboBox cmb, string sql,int 구분 )
        {
            DataSet ds = cls_com.Select_Query(sql);
            cmb.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            if (구분 == 1)
            {
                cmb.Text = cmb.Items[0].ToString();
            } 
        }

        public static string 문자만(string d )
        {
            string d2 = "";
            d2 = d.Replace(CR, "").Replace(LF,"").Replace(" ","").Replace(",","").Replace(STX,"").Replace(ETX, "").Replace(ACK, "").Replace(ENQ, "").Replace(EOT, "");
            d2 = d2.Replace("k", "").Replace("K", "").Replace("g", "").Replace("G", ""); 

            return d2;
        }

        
        public static void  색삭_spr(FarPoint.Win.Spread.FpSpread spr,int col_pos,int col_sel)
        {
            for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
            {
                if (!spr.ActiveSheet.Cells[i, spr.ActiveSheet.ColumnCount - 1].Text.Equals(""))
                {
                    spr.ActiveSheet.Cells[i, col_sel].BackColor = ColorTranslator.FromHtml(spr.ActiveSheet.Cells[i, col_pos ].Text);
                }
            } 
        } 
        public static void 로그(string 작업자,string 메뉴,string 메세지,string 쿼리)
        {
            sql = "";
            sql = sql + "  exec s_a101_로그_저장 '1' ";
            sql = sql + "  ,'" + 작업자 + "' ";
            sql = sql + "  ,'" + 메뉴 + "' ";
            sql = sql + "  ,'" + 메세지 + "' ";
            sql = sql + "  ,'" + 쿼리.Replace("'","''") + "' ";

            cls_com.ExcuteNonQuery(sql);

        }
    }
}
