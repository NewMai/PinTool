using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace MyProject
{
    public partial class PinTool : Form
    {
        public PinTool()
        {
            InitializeComponent();
        }

        // 执行 cmd.exe
        public void RunExe(String strExe, String strCommand)
        {
            try
            {
                // 保证控制台自动退出
                //MessageBox.Show(null, strCommand, "Output result");

                // 把命令写入 bat 文件
                String strBat = "__.bat";
                String strTmp = "cd " + Application.StartupPath + "\r\n";
                StreamWriter sw = new StreamWriter(strBat);
                String strDel = String.Format("\r\ndel {0} /q /f \r\nexit", strBat);
                sw.Write(strTmp + strCommand + strDel);
                sw.Close();
               

                Process MyProcess = new Process();

                MyProcess.StartInfo.FileName = strBat;
                MyProcess.StartInfo.UseShellExecute = false;
                //MyProcess.StartInfo.RedirectStandardInput = true;
                //MyProcess.StartInfo.RedirectStandardOutput = true;
                //MyProcess.StartInfo.RedirectStandardError = true;
                MyProcess.StartInfo.CreateNoWindow = true;

                MyProcess.Start();  // 启动程序
                //MyProcess.StandardInput.WriteLine(strCommand);
                //MyProcess.StandardInput.AutoFlush = true;

                // 显示执行结果，如果需要的话
                //String strResult = MyProcess.StandardOutput.ReadToEnd();
                //MessageBox.Show(null,strResult, "Output result");

                // 结束（无需等待,因为如果等待的话，可能会卡住）
                //MyProcess.WaitForExit();

                
                MyProcess.Close();

            }
            catch (Exception except)
            {
                MessageBox.Show(null, except.ToString(), "Execute process error!");
            }
        }

        // 保存配置信息到文件中
        public void SaveConfigureFile()
        {
            String strExten = "\r\n";
            StringBuilder strBuffer = new StringBuilder();
            strBuffer.Append("codeStartAddr=" + tb_codeStartAddr.Text + strExten);
            strBuffer.Append("codeEndAddr=" + tb_codeEndAddr.Text + strExten);
            strBuffer.Append("switchOnAddr=" + tb_switchOnAddr.Text + strExten);
            strBuffer.Append("switchOffAddr=" + tb_switchOffAddr.Text + strExten);
            strBuffer.Append("detachPoint=" + tb_detachPoint.Text + strExten);
            strBuffer.Append("threadToMonitor=" + tb_threadToMonitor.Text + strExten);
            strBuffer.Append("instRecNum=" + tb_instRecNum.Text + strExten);
            strBuffer.Append("ksFilter=" + cb_ksFilter.Text + strExten);
            strBuffer.Append("ksSwitch=" + cb_ksSwitch.Text + strExten);

            strBuffer.Append("dllPath=" + tb_DllPath.Text + strExten);
            strBuffer.Append("exePath=" + tb_ExePath.Text + strExten);
            strBuffer.Append("pinPath=" + tb_PinPath.Text + strExten);

            strBuffer.Append("====");

            // 检测目录是否存在，不存在的就创建目录
            String strDir = Application.StartupPath + "\\config";
            if (false == Directory.Exists(strDir))
            {
                Directory.CreateDirectory(strDir);
            }

            String strConfig = Application.StartupPath + "\\config\\kscope.cfg";
            StreamWriter fileWriter;

            try
            {
                fileWriter = new StreamWriter(strConfig);
                // 输出配置文件
                fileWriter.Write(strBuffer.ToString());
                fileWriter.Close();
            }
            catch (Exception except)
            {
                MessageBox.Show(null, except.ToString(), "写入配置文件发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // 取得等号右边的值
        public String GetValueFromString(String str)
        {
            String strValue;

            int i = str.IndexOf("=");
            strValue = str.Substring(i + 1);

            return strValue;
        }

        // 从配置文件中读取信息填写到应用程序中
        public void ReadConfigureFile()
        {
            String strConfig = Application.StartupPath + "\\config\\kscope.cfg";

            // 检测目录是否存在，不存在的就创建目录
            String strDir = Application.StartupPath + "\\config";
            if (false == Directory.Exists(strDir))
            {
                Directory.CreateDirectory(strDir);
            }

            StreamReader fileReader = null;
            String strTmp = null;

            try
            {
                fileReader = new StreamReader(strConfig);
                
                // 填写到相应的字段中
                strTmp = fileReader.ReadLine();
                tb_codeStartAddr.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                tb_codeEndAddr.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                tb_switchOnAddr.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                tb_switchOffAddr.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                tb_detachPoint.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                tb_threadToMonitor.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                tb_instRecNum.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                cb_ksFilter.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                cb_ksSwitch.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                tb_DllPath.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                tb_ExePath.Text = GetValueFromString(strTmp);

                strTmp = fileReader.ReadLine();
                tb_PinPath.Text = GetValueFromString(strTmp);


                fileReader.Close();
            }
            catch (Exception except)
            {
                //MessageBox.Show(null, except.ToString(), "读取配置文件发生错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (null != fileReader)
                {
                    fileReader.Close();
                }
            }

        }

        // 执行函数
        private void bt_Execute_Click(object sender, EventArgs e)
        {

            String strTmp = Application.StartupPath + "\\pin-2.13-65163-msvc9\\pin";

            // 如果 tb_PinPath 中的值不为空就是用这个值作为  目标文件
            if (null != tb_PinPath.Text.ToString())
            {
                strTmp = tb_PinPath.Text.ToString();
            }
            String strCmd = String.Format("{0} -t {1} -- {2}", 
                strTmp, tb_DllPath.Text, tb_ExePath.Text);

            String strExePath = "cmd.exe";

            // 保存配置文件，方便下次启动时直接输入
            SaveConfigureFile();

            try
            {
                // 执行 命令行
                RunExe(strExePath, strCmd);

            }
            catch (Exception except)
            {
                MessageBox.Show(null, except.ToString(), "写入配置文件发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 处理 bbl.dll 生成的结果
        private void DealBblResualt()
        {
            try
            {
                // 保证控制台自动退出
                //MessageBox.Show(null, strCommand, "Output result");

                String strCommand = "mkdir bblResult&" +
                                    "copy /Y data\\bblInst.log                bblResult\\bblInst.log&" +
                                    "copy /Y data\\bblTracing.lzo             utils\\unlzo\\bblTracing.lzo&" +
                                    "cd utils\\unlzo&" +
                                    "unlzo.bat&" +
                                    "cd ..\\..&" +
                                    "copy /Y utils\\unlzo\\bblTracing.log     bblResult\\bblTracing.log&";

                // 把命令写入 bat 文件
                String strBat = "__DealBblResualt.bat";
                String strTmp = "cd " + Application.StartupPath + "&";
                StreamWriter sw = new StreamWriter(strBat);
                String strDel = String.Format("del {0} /q /f &exit", strBat);
                sw.Write(strTmp + strCommand + strDel);
                sw.Close();

                Process MyProcess = new Process();

                MyProcess.StartInfo.FileName = strBat;
                MyProcess.StartInfo.UseShellExecute = false;
                //MyProcess.StartInfo.RedirectStandardInput = true;
                //MyProcess.StartInfo.RedirectStandardOutput = true;
                //MyProcess.StartInfo.RedirectStandardError = true;
                MyProcess.StartInfo.CreateNoWindow = true;
                MyProcess.Start();  // 启动程序
                MyProcess.Close();

            }
            catch (Exception except)
            {
                MessageBox.Show(null, except.ToString(), "Execute process error!");
            }


        }

        // 处理 ksTracer.dll 生成的结果
        private void DealksTracerResualt()
        {
            try
            {
                // 保证控制台自动退出
                //MessageBox.Show(null, strCommand, "Output result");

                String strCommand = "mkdir ksTracerResult&" +
                                    "copy /Y data\\ksTracing.lzo                utils\\unlzo\\ksTracing.lzo&" +
                                    "cd utils\\unlzo&" +
                                    "unlzo.bat&" +
                                    "cd ..\\..&" +
                                    "copy /Y utils\\unlzo\\ksTrace.log          ksTracerResult\\ksTrace.log&";

                // 把命令写入 bat 文件
                String strBat = "__DealksTracerResualt.bat";
                String strTmp = "cd " + Application.StartupPath + "&";
                StreamWriter sw = new StreamWriter(strBat);
                String strDel = String.Format("&del {0} /q /f &exit", strBat);
                sw.Write(strTmp + strCommand + strDel);
                sw.Close();


                Process MyProcess = new Process();

                MyProcess.StartInfo.FileName = strBat;
                MyProcess.StartInfo.UseShellExecute = false;
                //MyProcess.StartInfo.RedirectStandardInput = true;
                //MyProcess.StartInfo.RedirectStandardOutput = true;
                //MyProcess.StartInfo.RedirectStandardError = true;
                MyProcess.StartInfo.CreateNoWindow = true;
                MyProcess.Start();  // 启动程序
                MyProcess.Close();

            }
            catch (Exception except)
            {
                MessageBox.Show(null, except.ToString(), "Execute process error!");
            }


        }

        // 打开 DLL 文件
        private void bt_OpenDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDlg = new OpenFileDialog();
            if (FileDlg.ShowDialog() == DialogResult.OK)
            {
                tb_DllPath.Text = FileDlg.FileName;
            }

        }

        // 打开 Exe 文件
        private void bt_OpenExe_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDlg = new OpenFileDialog();
            if (FileDlg.ShowDialog() == DialogResult.OK)
            {
                tb_ExePath.Text = FileDlg.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 从配置文件中读取信息填写到应用程序中
            ReadConfigureFile();
        }

        private void bt_PinPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDlg = new OpenFileDialog();
            if (FileDlg.ShowDialog() == DialogResult.OK)
            {
                tb_PinPath.Text = FileDlg.FileName;
            }
        }

        private void bt_bbl_Click(object sender, EventArgs e)
        {
            // 处理 bbl.dll 生成的结果
            DealBblResualt();
        }

        private void bt_ksTracer_Click(object sender, EventArgs e)
        {
            // 处理 ksTracer.dll 生成的结果
            DealksTracerResualt();
        }

        private void bt_entropy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null, "这个功能还没有实现", "不好意思");
        }

        private void bt_ksAddrFilter_Click(object sender, EventArgs e)
        {
            ksAddrFilter ksAddrFlt = new ksAddrFilter();
            ksAddrFlt.ShowDialog();
        }


    }
}
