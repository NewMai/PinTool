namespace MyProject
{
    partial class ksAddrFilter
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
            this.bt_Add = new System.Windows.Forms.Button();
            this.tb_Add_ksAddrFilter = new System.Windows.Forms.TextBox();
            this.lb_ksAddrFilter = new System.Windows.Forms.ListBox();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(252, 23);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 0;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // tb_Add_ksAddrFilter
            // 
            this.tb_Add_ksAddrFilter.Location = new System.Drawing.Point(24, 25);
            this.tb_Add_ksAddrFilter.Name = "tb_Add_ksAddrFilter";
            this.tb_Add_ksAddrFilter.Size = new System.Drawing.Size(193, 21);
            this.tb_Add_ksAddrFilter.TabIndex = 1;
            // 
            // lb_ksAddrFilter
            // 
            this.lb_ksAddrFilter.FormattingEnabled = true;
            this.lb_ksAddrFilter.ItemHeight = 12;
            this.lb_ksAddrFilter.Location = new System.Drawing.Point(24, 67);
            this.lb_ksAddrFilter.Name = "lb_ksAddrFilter";
            this.lb_ksAddrFilter.Size = new System.Drawing.Size(193, 100);
            this.lb_ksAddrFilter.TabIndex = 2;
            this.lb_ksAddrFilter.SelectedIndexChanged += new System.EventHandler(this.lb_ksAddrFilter_SelectedIndexChanged);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(252, 65);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 3;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(252, 144);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 4;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // ksAddrFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 188);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.lb_ksAddrFilter);
            this.Controls.Add(this.tb_Add_ksAddrFilter);
            this.Controls.Add(this.bt_Add);
            this.Name = "ksAddrFilter";
            this.Text = "ksAddrFilter";
            this.Load += new System.EventHandler(this.ksAddrFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox tb_Add_ksAddrFilter;
        private System.Windows.Forms.ListBox lb_ksAddrFilter;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Save;
    }
}