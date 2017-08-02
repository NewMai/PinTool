using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyProject
{
    public partial class ksAddrFilter : Form
    {
        public ksAddrFilter()
        {
            InitializeComponent();

            ReadksAddrFilter();  // Read configuration from file: ksAddrFilter.txt
        }

        private bool ReadksAddrFilter()
        {
            bool ret = true;

            String strConfig = Application.StartupPath + "\\config\\ksAddrFilter.txt";

            // 检测目录是否存在，不存在的就创建目录
            String strDir = Application.StartupPath + "\\config";
            if (false == Directory.Exists(strDir))
            {
                Directory.CreateDirectory(strDir);
            }

            StreamReader fileReader = null;
            String strTmp = null;
            int iAddr = 0;

            try
            {
                fileReader = new StreamReader(strConfig);
                

                while (true)
                {
                    // 填写到相应的字段中
                    strTmp = fileReader.ReadLine();
                    if (string.IsNullOrEmpty(strTmp))
                    {
                        break;
                    }

                    iAddr = Convert.ToInt32(strTmp, 16);
                    string strResult = String.Format("0x{0:X8}", iAddr);
                    lb_ksAddrFilter.Items.Add(strResult);

                }

                fileReader.Close();
            }
            catch (Exception except)
            {
                //MessageBox.Show(null, except.ToString(), "读取配置文件发生错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (null != fileReader)
                {
                    fileReader.Close();
                }
                ret = false;
            }



            return ret;
        }

        private bool SaveksAddrFilter()
        {
            bool ret = true;

            String strConfig = Application.StartupPath + "\\config\\ksAddrFilter.txt";

            // 检测目录是否存在，不存在的就创建目录
            String strDir = Application.StartupPath + "\\config";
            if (false == Directory.Exists(strDir))
            {
                Directory.CreateDirectory(strDir);
            }

            StreamWriter fileWriter = null;
            String strTmp = null;
            int iAddr = 0;

            try
            {
                fileWriter = new StreamWriter(strConfig);
                int i =0 ;
                for (i = 0; i < lb_ksAddrFilter.Items.Count; i++ )
                {
                    // 填写到相应的字段中
                    strTmp = lb_ksAddrFilter.Items[i].ToString();
                    iAddr = Convert.ToInt32(strTmp, 16);
                    string strResult = String.Format("{0:X8}", iAddr);
                    fileWriter.WriteLine(strResult);
                }

                fileWriter.Close();
            }
            catch (Exception except)
            {
                //MessageBox.Show(null, except.ToString(), "读取配置文件发生错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (null != fileWriter)
                {
                    fileWriter.Close();
                }
                ret = false;
            }


            return ret;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            string strAddr = tb_Add_ksAddrFilter.Text;
            //MessageBox.Show(null, strAddr, "Test");
            int iAddr = 0;

            try
            {
                iAddr = Convert.ToInt32(strAddr, 16);
                string strResult = String.Format("0x{0:X8}", iAddr);
                lb_ksAddrFilter.Items.Add(strResult);
                //tb_Add_ksAddrFilter.Text = "";    // Clear
            }
            catch (Exception exp)
            {
                //MessageBox.Show(null, "请输入合法的数字！", "提示");
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            int idx = 0;

            try
            {

                idx = lb_ksAddrFilter.SelectedIndex;
                lb_ksAddrFilter.Items.RemoveAt(idx);
            }
            catch (Exception exp)
            {
                //MessageBox.Show(null, "移除列表项失败！", "提示");
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            SaveksAddrFilter();
            this.Close();
        }

        private void lb_ksAddrFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = 0;
            int iAddr = 0;
            string strAddr;

            try
            {

                idx = lb_ksAddrFilter.SelectedIndex;
                strAddr = lb_ksAddrFilter.Items[idx].ToString();
                iAddr = Convert.ToInt32(strAddr, 16);
                string strResult = String.Format("0x{0:X8}", iAddr);
                tb_Add_ksAddrFilter.Text = strResult;
            }
            catch (Exception exp)
            {
                //MessageBox.Show(null, "移除列表项失败！", "提示");
            }
        }

        private void ksAddrFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
