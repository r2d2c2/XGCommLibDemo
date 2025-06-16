using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace XGCommLibDemo
{
    public partial class Form1 : Form
    {
        private XGCommSocket XGComm = new XGCommSocket();
        delegate bool SetTextCallBack(string strLog);
        private long lCountErrorRead = 0;
        private long lCountErrorWrite = 0;
        private long lCountErrorCheck = 0;
        private long lMaxAccessTimeRead = 0;
        private long lMaxAccessTimeWrite = 0;

        public Form1()
        {
            InitializeComponent();

            txtIpAddrPlc.Text = "192.168.1.2";
            txtPortNo.Text = "2004";

            cboDeviceType.SelectedIndex = 0;
            cboDataType.SelectedIndex = 0;
            txtSize.Text = "10";

            txtScanTime.Text = "100";
            tmUpdateCtrl.Enabled = true;

            //AccessTime.HiPerfTimer();
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (XGComm.Connect(txtIpAddrPlc.Text, Convert.ToInt32(txtPortNo.Text)) != (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
            {
                AddLog("==> Connect Fail !! \n");
            }
            else
            {
                AddLog("Connect success... (IP: {0}, PORT: {1})", txtIpAddrPlc.Text, txtPortNo.Text);
            }
        }

        private bool AddLog(string strLog)
        {
            string strTimeLog;

            DateTime dt = DateTime.Now;

            strTimeLog = dt.ToString("[hh:mm:ss.fff] ") + strLog;
            lstLog.SelectedIndex = lstLog.Items.Count - 1;

            if (lstLog.Items.Count > 100)
            {
                lstLog.Items.RemoveAt(0);
            }

            if (this.lstLog.InvokeRequired)
            {
                SetTextCallBack dele = new SetTextCallBack(AddLog);
                this.Invoke(dele, new object[] { strTimeLog });
            }
            else
            {
                this.lstLog.Items.Add(strTimeLog);
                this.lstLog.SelectedIndex = this.lstLog.Items.Count - 1;
            }

            return true;
        }

        private bool AddLog(string strLog, params object[] values)
        { 
            string strValue;

            strValue = string.Format(strLog, values);
            return AddLog(strValue);
        }

        private void lstLog_DoubleClick(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }
       
        private void btnReadData_Click(object sender, EventArgs e)
        {
            long lSize, lOffset;
            uint nDataType;
            char szDeviceType;

            lSize = Convert.ToInt32(txtSize.Text);
            lOffset = Convert.ToInt32(txtOffset.Text);
            if (lSize <= 0)
                return;

            nDataType = (uint)cboDataType.SelectedIndex;
            szDeviceType = (char)cboDeviceType.Items[cboDeviceType.SelectedIndex].ToString()[0];

            switch (nDataType)
            {
                case (uint)DEF_DATA_TYPE.DATA_TYPE_BIT:
                    ReadDataBit(szDeviceType, lSize, lOffset);
                    break;

                case (uint)DEF_DATA_TYPE.DATA_TYPE_BYTE:
                    ReadDataByte(szDeviceType, lSize, lOffset);
                    break;

                case (uint)DEF_DATA_TYPE.DATA_TYPE_WORD:
                    ReadDataWord(szDeviceType, lSize, lOffset);
                    break;
            }            
        }

        private uint ReadDataBit(char szDeviceType, long lSize, long lOffset)
        {
            long lCount;
            uint uReturn;
            string strFull, strLog;
            double dAccessTime;

            byte[] bufRead = new byte[lSize]; 
            btnReadData.Enabled = false;             
            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();
            uReturn = XGComm.ReadDataBit(szDeviceType, lOffset, lSize, bufRead);

            stopwatch.Stop();
            dAccessTime = stopwatch.ElapsedMilliseconds;
            txtAccessTime.Text = Convert.ToString((long)dAccessTime);

            if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
            {
                strFull = string.Format("Read  Data [{0,4}][{1,4}] <-", lSize, (long)dAccessTime);
                for (lCount = 0; lCount < lSize; lCount++)
                {
                    strLog = string.Format(" {0:X1}", bufRead[lCount]);
                    strFull += strLog;
                }

                AddLog(strFull);
            }
            else
            {
                AddLog(XGComm.GetReturnCodeString(uReturn));
            }
            btnReadData.Enabled = true;

            return uReturn;
        }

        private uint ReadDataByte(char szDeviceType, long lSize, long lOffset)
        {
            long lCount;
            uint uReturn;
            string strFull, strLog;
            double dAccessTime;

            byte[] bufRead = new byte[lSize];

            btnReadData.Enabled = false;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            uReturn = XGComm.ReadDataByte((char)cboDeviceType.Items[cboDeviceType.SelectedIndex].ToString()[0], lOffset, lSize, bufRead);

            stopwatch.Stop();
            dAccessTime = stopwatch.ElapsedMilliseconds;
            txtAccessTime.Text = Convert.ToString((long)dAccessTime);

            if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
            {
                strFull = string.Format("Read  Data [{0,4}][{1,4}] <-", lSize, (long)dAccessTime);
                for (lCount = 0; lCount < lSize; lCount++)
                {
                    strLog = string.Format(" {0:X2}", bufRead[lCount]);
                    strFull += strLog;
                }

                AddLog(strFull);
            }
            else
            {
                AddLog(XGComm.GetReturnCodeString(uReturn));
            }
            btnReadData.Enabled = true;

            return uReturn;
        }

        private uint ReadDataWord(char szDeviceType, long lSize, long lOffset)
        {
            long lCount;
            uint uReturn;
            string strFull, strLog;
            double dAccessTime;

            UInt16[] bufRead = new UInt16[lSize];

            btnReadData.Enabled = false;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            uReturn = XGComm.ReadDataWord(szDeviceType, lOffset, lSize, false, bufRead);

            stopwatch.Stop();
            dAccessTime = stopwatch.ElapsedMilliseconds;
            txtAccessTime.Text = Convert.ToString((long)dAccessTime);

            if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
            {
                strFull = string.Format("Read  Data [{0,4}][{1,4}] <-", lSize, (long)dAccessTime);
                for (lCount = 0; lCount < lSize; lCount++)
                {
                    strLog = string.Format(" {0:X4}", bufRead[lCount]);
                    strFull += strLog;
                }

                AddLog(strFull);
            }
            else
            {
                AddLog(XGComm.GetReturnCodeString(uReturn));
            }
            btnReadData.Enabled = true;

            return uReturn;
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            long lSize, lOffset;
            uint nDataType;
            char szDeviceType;

            lSize = Convert.ToInt32(txtSize.Text);
            lOffset = Convert.ToInt32(txtOffset.Text);
            if (lSize <= 0)
                return;
            
            nDataType = (uint)cboDataType.SelectedIndex;
            szDeviceType = (char)cboDeviceType.Items[cboDeviceType.SelectedIndex].ToString()[0];

            switch (nDataType)
            {
                case (uint)DEF_DATA_TYPE.DATA_TYPE_BIT:
                    WriteDataBit(szDeviceType, lSize, lOffset);
                    break;

                case (uint)DEF_DATA_TYPE.DATA_TYPE_BYTE:
                    WriteDataByte(szDeviceType, lSize, lOffset);
                    break;

                case (uint)DEF_DATA_TYPE.DATA_TYPE_WORD:
                    WriteDataWord(szDeviceType, lSize, lOffset);
                    break;
            }            
        }

       private uint  WriteDataBit(char szDeviceType, long lSize, long lOffset)
       {
           long lCount;
           uint uReturn;
           bool bUseWriteData;
           string strFull, strLog;
           double dAccessTime;
           byte byEditData;

           Stopwatch stopwatch = new Stopwatch();
            Random rand = new Random();

            byEditData = Convert.ToByte(txtWriteData.Text);
            bUseWriteData = chkUseData.Checked;
            btnWriteData.Enabled = false;

            byte[] byWrite = new byte[lSize];
            for (lCount = 0; lCount < lSize; lCount++)
            {
                if (bUseWriteData)
                {
                    byWrite[lCount] = (byte)byEditData;
                }
                else
                {
                    byWrite[lCount] = (byte)rand.Next(0, 2);
                }
            }

            stopwatch.Start();
            uReturn = XGComm.WriteDataBit(szDeviceType, lOffset, lSize, byWrite);
            stopwatch.Stop();

            dAccessTime = stopwatch.ElapsedMilliseconds;
            txtAccessTime.Text = Convert.ToString((long)dAccessTime);

            if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
            {
                strFull = string.Format("Write Data [{0,4}][{1,4}] ->", lSize, (long)dAccessTime);
                for (lCount = 0; lCount < lSize; lCount++)
                {
                    strLog = string.Format(" {0:X1}", byWrite[lCount]);
                    strFull += strLog;
                }

                AddLog(strFull);
            }
            else
            {
                AddLog(XGComm.GetReturnCodeString(uReturn));
            }

            btnWriteData.Enabled = true;
            return uReturn;
        }

       private uint WriteDataByte(char szDeviceType, long lSize, long lOffset)
       {
           long lCount;
           uint uReturn;
           bool bUseWriteData;
           string strFull, strLog;
           double dAccessTime;
           byte byEditData;

           Stopwatch stopwatch = new Stopwatch();
           Random rand = new Random();

           byEditData = Convert.ToByte(txtWriteData.Text);
           bUseWriteData = chkUseData.Checked;
           btnWriteData.Enabled = false;

           byte[] byWrite = new byte[lSize];
           for (lCount = 0; lCount < lSize; lCount++)
           {
               if (bUseWriteData)
               {
                   byWrite[lCount] = (byte)byEditData;
               }
               else
               {
                   byWrite[lCount] = (byte)rand.Next(0, 256);
               }
           }

           stopwatch.Start();
           uReturn = XGComm.WriteDataByte(szDeviceType, lOffset, lSize, byWrite);
           stopwatch.Stop();

           dAccessTime = stopwatch.ElapsedMilliseconds;
           txtAccessTime.Text = Convert.ToString((long)dAccessTime);

           if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
           {
               strFull = string.Format("Write Data [{0,4}][{1,4}] ->", lSize, (long)dAccessTime);
               for (lCount = 0; lCount < lSize; lCount++)
               {
                   strLog = string.Format(" {0:X2}", byWrite[lCount]);
                   strFull += strLog;
               }

               AddLog(strFull);
           }
           else
           {
               AddLog(XGComm.GetReturnCodeString(uReturn));
           }

           btnWriteData.Enabled = true;
           return uReturn;
       }

       private uint WriteDataWord(char szDeviceType, long lSize, long lOffset)
       {
           long lCount;
           uint uReturn;
           bool bUseWriteData;
           string strFull, strLog;
           double dAccessTime;
           UInt16 uEditData;

           Stopwatch stopwatch = new Stopwatch();
           Random rand = new Random();

           uEditData = Convert.ToUInt16(txtWriteData.Text);
           bUseWriteData = chkUseData.Checked;
           btnWriteData.Enabled = false;

           UInt16[] uWrite = new UInt16[lSize];
           for (lCount = 0; lCount < lSize; lCount++)
           {
               if (bUseWriteData)
               {
                   uWrite[lCount] = uEditData;
               }
               else
               {
                   uWrite[lCount] = (UInt16)rand.Next(0, 65536);
               }
           }

           stopwatch.Start();
           uReturn = XGComm.WriteDataWord(szDeviceType, lOffset, lSize, false, uWrite);
           stopwatch.Stop();

           dAccessTime = stopwatch.ElapsedMilliseconds;
           txtAccessTime.Text = Convert.ToString((long)dAccessTime);

           if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
           {
               strFull = string.Format("Write Data [{0,4}][{1,4}] ->", lSize, (long)dAccessTime);
               for (lCount = 0; lCount < lSize; lCount++)
               {
                   strLog = string.Format(" {0:X4}", uWrite[lCount]);
                   strFull += strLog;
               }

               AddLog(strFull);
           }
           else
           {
               AddLog(XGComm.GetReturnCodeString(uReturn));
           }

           btnWriteData.Enabled = true;
           return uReturn;
       }

        private void chkKeepAlive_CheckedChanged(object sender, EventArgs e)
        {
            tmKeepAlive.Enabled = chkKeepAlive.Checked;
        }

        private void tmKeepAlive_Tick(object sender, EventArgs e)
        {
            uint uReturn;

            uReturn = XGComm.UpdateKeepAlive();
            if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
            {
                chkAliveStatus.Checked = true;
            }
            else
            {
                chkAliveStatus.Checked = false;
            }
        }

        private void tmLibTest_Tick(object sender, EventArgs e)
        {
            DoTest();
        }

        private void chkTest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTest.Checked == true)
            {
                Int32 lScanTime;

                lCountErrorRead = 0;
                lCountErrorWrite = 0;
                lCountErrorCheck = 0;
                lMaxAccessTimeRead = 0;
                lMaxAccessTimeWrite = 0;

                lScanTime = Convert.ToInt32(txtScanTime.Text);
                lScanTime = (10 > lScanTime) ? 10 : lScanTime;

                tmLibTest.Interval = lScanTime;
                tmLibTest.Enabled = true;
            }
            else
            {
                tmLibTest.Enabled = false;
            }
        }

        private void DoTest()
        {
            uint uReturn;

            long lSize, lOffset, lCount;

            double dReadTime, dWriteTime;
            string strLog = "", strRead = "", strWrite = "", strHead = "", strFull = "";
            Random rand = new Random();
            Stopwatch stopwatch = new Stopwatch();

            lSize = Convert.ToInt32(txtSize.Text);
            lOffset = Convert.ToInt32(txtOffset.Text);

            if (lSize <= 0)
                return;

            byte[] byWrite = new byte[lSize];
            byte[] byRead = new byte[lSize];

            for (lCount = 0; lCount < lSize; lCount++)
            {
                byWrite[lCount] = (byte)rand.Next(0, 255); ;
            }

            stopwatch.Start();
            uReturn = XGComm.WriteDataByte((char)cboDeviceType.Items[cboDeviceType.SelectedIndex].ToString()[0], lOffset, lSize, byWrite);
            stopwatch.Stop();

            dWriteTime = stopwatch.ElapsedMilliseconds;
            if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
            {
                lMaxAccessTimeWrite = Math.Max((long)dWriteTime, lMaxAccessTimeWrite);

                strHead = string.Format("Write Data [{0, 4}][{1, 4}] ->", lSize, (long)dWriteTime);
                for (lCount = 0; lCount < lSize; lCount++)
                {
                    strLog = string.Format((" {0:X2}"), byWrite[lCount]);
                    strWrite += strLog;
                }
                strFull = strHead + strWrite;
                AddLog(strFull);

                stopwatch.Start();
                uReturn = XGComm.ReadDataByte((char)cboDeviceType.Items[cboDeviceType.SelectedIndex].ToString()[0], lOffset, lSize, byRead);
                stopwatch.Stop();

                dReadTime = stopwatch.ElapsedMilliseconds;
                lMaxAccessTimeRead = Math.Max((long)dReadTime, lMaxAccessTimeRead);
                if (uReturn == (uint)XGCOMM_FUNC_RESULT.RT_XGCOMM_SUCCESS)
                {
                    strHead = string.Format("Read  Data [{0, 4}][{1, 4}] <-", lSize, (long)dReadTime);
                    for (lCount = 0; lCount < lSize; lCount++)
                    {
                        strLog = string.Format(" {0:X2}", byRead[lCount]);
                        strRead += strLog;
                    }
                    strFull = strHead + strRead;
                    AddLog(strFull);

                    if (strWrite != strRead)
                    {
                        lCountErrorCheck++;
                        if (chkUseErrorStop.Checked == true)
                        {
                            tmLibTest.Enabled = false;
                            chkTest.Checked = false;
                        }
                    }
                }
                else
                {
                    lCountErrorRead++;
                }
            }
            else
            {
                lCountErrorWrite++;
                AddLog(XGComm.GetReturnCodeString(uReturn));
            }
        }

        private void tmUpdateCtrl_Tick(object sender, EventArgs e)
        {
            txtErrorCountWrite.Text = Convert.ToString(lCountErrorWrite);
            txtErrorCountRead.Text = Convert.ToString(lCountErrorRead);
            txtErrorCountCheck.Text = Convert.ToString(lCountErrorCheck);

            txtMaxTime.Text = string.Format("{0, 3}  :{1, 3}", lMaxAccessTimeWrite, lMaxAccessTimeRead);
        }

        private void chkUseData_CheckedChanged(object sender, EventArgs e)
        {
            txtWriteData.Enabled = chkUseData.Checked;
        }
    }
}
