namespace MyProject
{
    partial class PinTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_codeStartAddr = new System.Windows.Forms.TextBox();
            this.lb_codeStartAddr = new System.Windows.Forms.Label();
            this.lb_codeEndAddr = new System.Windows.Forms.Label();
            this.tb_codeEndAddr = new System.Windows.Forms.TextBox();
            this.lb_switchOnAddr = new System.Windows.Forms.Label();
            this.lb_detachPoint = new System.Windows.Forms.Label();
            this.tb_detachPoint = new System.Windows.Forms.TextBox();
            this.lb_switchOffAddr = new System.Windows.Forms.Label();
            this.lb_instRecNum = new System.Windows.Forms.Label();
            this.lb_ksFilter = new System.Windows.Forms.Label();
            this.lb_ksSwitch = new System.Windows.Forms.Label();
            this.lb_threadToMonitor = new System.Windows.Forms.Label();
            this.tb_threadToMonitor = new System.Windows.Forms.TextBox();
            this.tb_switchOffAddr = new System.Windows.Forms.TextBox();
            this.tb_instRecNum = new System.Windows.Forms.TextBox();
            this.lb_DllPath = new System.Windows.Forms.Label();
            this.lb_ExePath = new System.Windows.Forms.Label();
            this.tb_DllPath = new System.Windows.Forms.TextBox();
            this.tb_ExePath = new System.Windows.Forms.TextBox();
            this.bt_Execute = new System.Windows.Forms.Button();
            this.cb_ksFilter = new System.Windows.Forms.ComboBox();
            this.cb_ksSwitch = new System.Windows.Forms.ComboBox();
            this.bt_OpenDll = new System.Windows.Forms.Button();
            this.bt_OpenExe = new System.Windows.Forms.Button();
            this.tb_switchOnAddr = new System.Windows.Forms.TextBox();
            this.bt_PinPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_PinPath = new System.Windows.Forms.TextBox();
            this.bt_bbl = new System.Windows.Forms.Button();
            this.bt_ksTracer = new System.Windows.Forms.Button();
            this.bt_entropy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_ksAddrFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_codeStartAddr
            // 
            this.tb_codeStartAddr.Location = new System.Drawing.Point(139, 17);
            this.tb_codeStartAddr.Name = "tb_codeStartAddr";
            this.tb_codeStartAddr.Size = new System.Drawing.Size(100, 21);
            this.tb_codeStartAddr.TabIndex = 0;
            // 
            // lb_codeStartAddr
            // 
            this.lb_codeStartAddr.AutoSize = true;
            this.lb_codeStartAddr.Location = new System.Drawing.Point(24, 20);
            this.lb_codeStartAddr.Name = "lb_codeStartAddr";
            this.lb_codeStartAddr.Size = new System.Drawing.Size(89, 12);
            this.lb_codeStartAddr.TabIndex = 1;
            this.lb_codeStartAddr.Text = "codeStartAddr:";
            // 
            // lb_codeEndAddr
            // 
            this.lb_codeEndAddr.AutoSize = true;
            this.lb_codeEndAddr.Location = new System.Drawing.Point(34, 57);
            this.lb_codeEndAddr.Name = "lb_codeEndAddr";
            this.lb_codeEndAddr.Size = new System.Drawing.Size(77, 12);
            this.lb_codeEndAddr.TabIndex = 2;
            this.lb_codeEndAddr.Text = "codeEndAddr:";
            // 
            // tb_codeEndAddr
            // 
            this.tb_codeEndAddr.Location = new System.Drawing.Point(139, 54);
            this.tb_codeEndAddr.Name = "tb_codeEndAddr";
            this.tb_codeEndAddr.Size = new System.Drawing.Size(100, 21);
            this.tb_codeEndAddr.TabIndex = 3;
            // 
            // lb_switchOnAddr
            // 
            this.lb_switchOnAddr.AutoSize = true;
            this.lb_switchOnAddr.Location = new System.Drawing.Point(22, 92);
            this.lb_switchOnAddr.Name = "lb_switchOnAddr";
            this.lb_switchOnAddr.Size = new System.Drawing.Size(83, 12);
            this.lb_switchOnAddr.TabIndex = 4;
            this.lb_switchOnAddr.Text = "switchOnAddr:";
            // 
            // lb_detachPoint
            // 
            this.lb_detachPoint.AutoSize = true;
            this.lb_detachPoint.Location = new System.Drawing.Point(28, 167);
            this.lb_detachPoint.Name = "lb_detachPoint";
            this.lb_detachPoint.Size = new System.Drawing.Size(77, 12);
            this.lb_detachPoint.TabIndex = 6;
            this.lb_detachPoint.Text = "detachPoint:";
            // 
            // tb_detachPoint
            // 
            this.tb_detachPoint.Location = new System.Drawing.Point(139, 164);
            this.tb_detachPoint.Name = "tb_detachPoint";
            this.tb_detachPoint.Size = new System.Drawing.Size(100, 21);
            this.tb_detachPoint.TabIndex = 7;
            // 
            // lb_switchOffAddr
            // 
            this.lb_switchOffAddr.AutoSize = true;
            this.lb_switchOffAddr.Location = new System.Drawing.Point(16, 131);
            this.lb_switchOffAddr.Name = "lb_switchOffAddr";
            this.lb_switchOffAddr.Size = new System.Drawing.Size(89, 12);
            this.lb_switchOffAddr.TabIndex = 8;
            this.lb_switchOffAddr.Text = "switchOffAddr:";
            // 
            // lb_instRecNum
            // 
            this.lb_instRecNum.AutoSize = true;
            this.lb_instRecNum.Location = new System.Drawing.Point(313, 60);
            this.lb_instRecNum.Name = "lb_instRecNum";
            this.lb_instRecNum.Size = new System.Drawing.Size(71, 12);
            this.lb_instRecNum.TabIndex = 9;
            this.lb_instRecNum.Text = "instRecNum:";
            // 
            // lb_ksFilter
            // 
            this.lb_ksFilter.AutoSize = true;
            this.lb_ksFilter.Location = new System.Drawing.Point(325, 98);
            this.lb_ksFilter.Name = "lb_ksFilter";
            this.lb_ksFilter.Size = new System.Drawing.Size(59, 12);
            this.lb_ksFilter.TabIndex = 10;
            this.lb_ksFilter.Text = "ksFilter:";
            // 
            // lb_ksSwitch
            // 
            this.lb_ksSwitch.AutoSize = true;
            this.lb_ksSwitch.Location = new System.Drawing.Point(325, 131);
            this.lb_ksSwitch.Name = "lb_ksSwitch";
            this.lb_ksSwitch.Size = new System.Drawing.Size(59, 12);
            this.lb_ksSwitch.TabIndex = 11;
            this.lb_ksSwitch.Text = "ksSwitch:";
            // 
            // lb_threadToMonitor
            // 
            this.lb_threadToMonitor.AutoSize = true;
            this.lb_threadToMonitor.Location = new System.Drawing.Point(283, 26);
            this.lb_threadToMonitor.Name = "lb_threadToMonitor";
            this.lb_threadToMonitor.Size = new System.Drawing.Size(101, 12);
            this.lb_threadToMonitor.TabIndex = 12;
            this.lb_threadToMonitor.Text = "threadToMonitor:";
            // 
            // tb_threadToMonitor
            // 
            this.tb_threadToMonitor.Location = new System.Drawing.Point(417, 20);
            this.tb_threadToMonitor.Name = "tb_threadToMonitor";
            this.tb_threadToMonitor.Size = new System.Drawing.Size(100, 21);
            this.tb_threadToMonitor.TabIndex = 13;
            // 
            // tb_switchOffAddr
            // 
            this.tb_switchOffAddr.Location = new System.Drawing.Point(139, 128);
            this.tb_switchOffAddr.Name = "tb_switchOffAddr";
            this.tb_switchOffAddr.Size = new System.Drawing.Size(100, 21);
            this.tb_switchOffAddr.TabIndex = 14;
            // 
            // tb_instRecNum
            // 
            this.tb_instRecNum.Location = new System.Drawing.Point(417, 57);
            this.tb_instRecNum.Name = "tb_instRecNum";
            this.tb_instRecNum.Size = new System.Drawing.Size(100, 21);
            this.tb_instRecNum.TabIndex = 15;
            // 
            // lb_DllPath
            // 
            this.lb_DllPath.AutoSize = true;
            this.lb_DllPath.Location = new System.Drawing.Point(37, 215);
            this.lb_DllPath.Name = "lb_DllPath";
            this.lb_DllPath.Size = new System.Drawing.Size(59, 12);
            this.lb_DllPath.TabIndex = 18;
            this.lb_DllPath.Text = "Dll Path:";
            // 
            // lb_ExePath
            // 
            this.lb_ExePath.AutoSize = true;
            this.lb_ExePath.Location = new System.Drawing.Point(37, 252);
            this.lb_ExePath.Name = "lb_ExePath";
            this.lb_ExePath.Size = new System.Drawing.Size(59, 12);
            this.lb_ExePath.TabIndex = 19;
            this.lb_ExePath.Text = "Exe Path:";
            // 
            // tb_DllPath
            // 
            this.tb_DllPath.Location = new System.Drawing.Point(138, 212);
            this.tb_DllPath.Name = "tb_DllPath";
            this.tb_DllPath.Size = new System.Drawing.Size(289, 21);
            this.tb_DllPath.TabIndex = 20;
            // 
            // tb_ExePath
            // 
            this.tb_ExePath.Location = new System.Drawing.Point(138, 249);
            this.tb_ExePath.Name = "tb_ExePath";
            this.tb_ExePath.Size = new System.Drawing.Size(289, 21);
            this.tb_ExePath.TabIndex = 21;
            // 
            // bt_Execute
            // 
            this.bt_Execute.Location = new System.Drawing.Point(451, 331);
            this.bt_Execute.Name = "bt_Execute";
            this.bt_Execute.Size = new System.Drawing.Size(75, 23);
            this.bt_Execute.TabIndex = 22;
            this.bt_Execute.Text = "Execute";
            this.bt_Execute.UseVisualStyleBackColor = true;
            this.bt_Execute.Click += new System.EventHandler(this.bt_Execute_Click);
            // 
            // cb_ksFilter
            // 
            this.cb_ksFilter.FormattingEnabled = true;
            this.cb_ksFilter.Items.AddRange(new object[] {
            "on",
            "off"});
            this.cb_ksFilter.Location = new System.Drawing.Point(417, 95);
            this.cb_ksFilter.Name = "cb_ksFilter";
            this.cb_ksFilter.Size = new System.Drawing.Size(100, 20);
            this.cb_ksFilter.TabIndex = 23;
            // 
            // cb_ksSwitch
            // 
            this.cb_ksSwitch.FormattingEnabled = true;
            this.cb_ksSwitch.Items.AddRange(new object[] {
            "on",
            "off"});
            this.cb_ksSwitch.Location = new System.Drawing.Point(417, 131);
            this.cb_ksSwitch.Name = "cb_ksSwitch";
            this.cb_ksSwitch.Size = new System.Drawing.Size(100, 20);
            this.cb_ksSwitch.TabIndex = 24;
            // 
            // bt_OpenDll
            // 
            this.bt_OpenDll.Location = new System.Drawing.Point(450, 210);
            this.bt_OpenDll.Name = "bt_OpenDll";
            this.bt_OpenDll.Size = new System.Drawing.Size(75, 23);
            this.bt_OpenDll.TabIndex = 25;
            this.bt_OpenDll.Text = "Open Dll";
            this.bt_OpenDll.UseVisualStyleBackColor = true;
            this.bt_OpenDll.Click += new System.EventHandler(this.bt_OpenDll_Click);
            // 
            // bt_OpenExe
            // 
            this.bt_OpenExe.Location = new System.Drawing.Point(450, 249);
            this.bt_OpenExe.Name = "bt_OpenExe";
            this.bt_OpenExe.Size = new System.Drawing.Size(75, 23);
            this.bt_OpenExe.TabIndex = 26;
            this.bt_OpenExe.Text = "Open Exe";
            this.bt_OpenExe.UseVisualStyleBackColor = true;
            this.bt_OpenExe.Click += new System.EventHandler(this.bt_OpenExe_Click);
            // 
            // tb_switchOnAddr
            // 
            this.tb_switchOnAddr.Location = new System.Drawing.Point(139, 92);
            this.tb_switchOnAddr.Name = "tb_switchOnAddr";
            this.tb_switchOnAddr.Size = new System.Drawing.Size(100, 21);
            this.tb_switchOnAddr.TabIndex = 28;
            // 
            // bt_PinPath
            // 
            this.bt_PinPath.Location = new System.Drawing.Point(451, 289);
            this.bt_PinPath.Name = "bt_PinPath";
            this.bt_PinPath.Size = new System.Drawing.Size(75, 23);
            this.bt_PinPath.TabIndex = 29;
            this.bt_PinPath.Text = "Open Pin";
            this.bt_PinPath.UseVisualStyleBackColor = true;
            this.bt_PinPath.Click += new System.EventHandler(this.bt_PinPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pin Path:";
            // 
            // tb_PinPath
            // 
            this.tb_PinPath.Location = new System.Drawing.Point(138, 289);
            this.tb_PinPath.Name = "tb_PinPath";
            this.tb_PinPath.Size = new System.Drawing.Size(289, 21);
            this.tb_PinPath.TabIndex = 31;
            // 
            // bt_bbl
            // 
            this.bt_bbl.Location = new System.Drawing.Point(138, 331);
            this.bt_bbl.Name = "bt_bbl";
            this.bt_bbl.Size = new System.Drawing.Size(75, 23);
            this.bt_bbl.TabIndex = 32;
            this.bt_bbl.Text = "bbl";
            this.bt_bbl.UseVisualStyleBackColor = true;
            this.bt_bbl.Click += new System.EventHandler(this.bt_bbl_Click);
            // 
            // bt_ksTracer
            // 
            this.bt_ksTracer.Location = new System.Drawing.Point(232, 331);
            this.bt_ksTracer.Name = "bt_ksTracer";
            this.bt_ksTracer.Size = new System.Drawing.Size(75, 23);
            this.bt_ksTracer.TabIndex = 33;
            this.bt_ksTracer.Text = "ksTracer";
            this.bt_ksTracer.UseVisualStyleBackColor = true;
            this.bt_ksTracer.Click += new System.EventHandler(this.bt_ksTracer_Click);
            // 
            // bt_entropy
            // 
            this.bt_entropy.Location = new System.Drawing.Point(327, 331);
            this.bt_entropy.Name = "bt_entropy";
            this.bt_entropy.Size = new System.Drawing.Size(75, 23);
            this.bt_entropy.TabIndex = 34;
            this.bt_entropy.Text = "entropy";
            this.bt_entropy.UseVisualStyleBackColor = true;
            this.bt_entropy.Click += new System.EventHandler(this.bt_entropy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "---------------------------------------------------------------------------------" +
                "--------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(539, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "---------------------------------------------------------------------------------" +
                "--------";
            // 
            // bt_ksAddrFilter
            // 
            this.bt_ksAddrFilter.Location = new System.Drawing.Point(417, 162);
            this.bt_ksAddrFilter.Name = "bt_ksAddrFilter";
            this.bt_ksAddrFilter.Size = new System.Drawing.Size(100, 23);
            this.bt_ksAddrFilter.TabIndex = 36;
            this.bt_ksAddrFilter.Text = "==>";
            this.bt_ksAddrFilter.UseVisualStyleBackColor = true;
            this.bt_ksAddrFilter.Click += new System.EventHandler(this.bt_ksAddrFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "ksAddrFilter:";
            // 
            // PinTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_ksAddrFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_entropy);
            this.Controls.Add(this.bt_ksTracer);
            this.Controls.Add(this.bt_bbl);
            this.Controls.Add(this.tb_PinPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_PinPath);
            this.Controls.Add(this.tb_switchOnAddr);
            this.Controls.Add(this.bt_OpenExe);
            this.Controls.Add(this.bt_OpenDll);
            this.Controls.Add(this.cb_ksSwitch);
            this.Controls.Add(this.cb_ksFilter);
            this.Controls.Add(this.bt_Execute);
            this.Controls.Add(this.tb_ExePath);
            this.Controls.Add(this.tb_DllPath);
            this.Controls.Add(this.lb_ExePath);
            this.Controls.Add(this.lb_DllPath);
            this.Controls.Add(this.tb_instRecNum);
            this.Controls.Add(this.tb_switchOffAddr);
            this.Controls.Add(this.tb_threadToMonitor);
            this.Controls.Add(this.lb_threadToMonitor);
            this.Controls.Add(this.lb_ksSwitch);
            this.Controls.Add(this.lb_ksFilter);
            this.Controls.Add(this.lb_instRecNum);
            this.Controls.Add(this.lb_switchOffAddr);
            this.Controls.Add(this.tb_detachPoint);
            this.Controls.Add(this.lb_detachPoint);
            this.Controls.Add(this.lb_switchOnAddr);
            this.Controls.Add(this.tb_codeEndAddr);
            this.Controls.Add(this.lb_codeEndAddr);
            this.Controls.Add(this.lb_codeStartAddr);
            this.Controls.Add(this.tb_codeStartAddr);
            this.Name = "PinTool";
            this.Text = "PinTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_codeStartAddr;
        private System.Windows.Forms.Label lb_codeStartAddr;
        private System.Windows.Forms.Label lb_codeEndAddr;
        private System.Windows.Forms.TextBox tb_codeEndAddr;
        private System.Windows.Forms.Label lb_switchOnAddr;
        //private System.Windows.Forms.TextBox tb_switchOnAddr;
        private System.Windows.Forms.Label lb_detachPoint;
        private System.Windows.Forms.TextBox tb_detachPoint;
        private System.Windows.Forms.Label lb_switchOffAddr;
        private System.Windows.Forms.Label lb_instRecNum;
        private System.Windows.Forms.Label lb_ksFilter;
        private System.Windows.Forms.Label lb_ksSwitch;
        private System.Windows.Forms.Label lb_threadToMonitor;
        private System.Windows.Forms.TextBox tb_threadToMonitor;
        private System.Windows.Forms.TextBox tb_switchOffAddr;
        private System.Windows.Forms.TextBox tb_instRecNum;
        private System.Windows.Forms.Label lb_DllPath;
        private System.Windows.Forms.Label lb_ExePath;
        private System.Windows.Forms.TextBox tb_DllPath;
        private System.Windows.Forms.TextBox tb_ExePath;
        private System.Windows.Forms.Button bt_Execute;
        private System.Windows.Forms.ComboBox cb_ksFilter;
        private System.Windows.Forms.ComboBox cb_ksSwitch;
        private System.Windows.Forms.Button bt_OpenDll;
        private System.Windows.Forms.Button bt_OpenExe;
        private System.Windows.Forms.TextBox tb_switchOnAddr;
        private System.Windows.Forms.Button bt_PinPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_PinPath;
        private System.Windows.Forms.Button bt_bbl;
        private System.Windows.Forms.Button bt_ksTracer;
        private System.Windows.Forms.Button bt_entropy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_ksAddrFilter;
        private System.Windows.Forms.Label label4;
    }
}

