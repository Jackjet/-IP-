namespace 用户查询
{
    partial class zgIP
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zgIP));
            this.txt1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.Analysis = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.RichTextBox();
            this.PortPanel = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.Port = new System.Windows.Forms.Button();
            this.text4 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.ForeColor = System.Drawing.Color.Red;
            this.txt1.Location = new System.Drawing.Point(5, 19);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(59, 12);
            this.txt1.TabIndex = 5;
            this.txt1.Text = "用户名/IP";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt2.Location = new System.Drawing.Point(5, 46);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(233, 12);
            this.txt2.TabIndex = 6;
            this.txt2.Text = "解析的数据：    解析过程中卡属于正常！";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(73, 16);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(199, 21);
            this.text1.TabIndex = 0;
            // 
            // Analysis
            // 
            this.Analysis.ForeColor = System.Drawing.Color.Fuchsia;
            this.Analysis.Location = new System.Drawing.Point(32, 182);
            this.Analysis.Name = "Analysis";
            this.Analysis.Size = new System.Drawing.Size(130, 26);
            this.Analysis.TabIndex = 2;
            this.Analysis.Text = "解析";
            this.Analysis.UseVisualStyleBackColor = true;
            this.Analysis.Click += new System.EventHandler(this.Analysis_Click);
            // 
            // text2
            // 
            this.text2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.text2.Location = new System.Drawing.Point(7, 69);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(265, 105);
            this.text2.TabIndex = 1;
            this.text2.Text = "";
            // 
            // PortPanel
            // 
            this.PortPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PortPanel.Location = new System.Drawing.Point(168, 182);
            this.PortPanel.Name = "PortPanel";
            this.PortPanel.Size = new System.Drawing.Size(79, 26);
            this.PortPanel.TabIndex = 3;
            this.PortPanel.Text = "端口扫描";
            this.PortPanel.UseVisualStyleBackColor = true;
            this.PortPanel.Click += new System.EventHandler(this.PortPanel_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Port);
            this.panel.Controls.Add(this.text4);
            this.panel.Controls.Add(this.text3);
            this.panel.Controls.Add(this.txt5);
            this.panel.Controls.Add(this.txt4);
            this.panel.Controls.Add(this.txt3);
            this.panel.Location = new System.Drawing.Point(7, 65);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(267, 145);
            this.panel.TabIndex = 4;
            this.panel.Visible = false;
            // 
            // Port
            // 
            this.Port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Port.Location = new System.Drawing.Point(94, 105);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(79, 26);
            this.Port.TabIndex = 2;
            this.Port.Text = "开始扫描";
            this.Port.UseVisualStyleBackColor = true;
            this.Port.Click += new System.EventHandler(this.Port_Click);
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(81, 67);
            this.text4.MaxLength = 7;
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(152, 21);
            this.text4.TabIndex = 1;
            this.text4.Text = "100";
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(81, 38);
            this.text3.MaxLength = 7;
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(152, 21);
            this.text3.TabIndex = 0;
            this.text3.Text = "1";
            // 
            // txt5
            // 
            this.txt5.AutoSize = true;
            this.txt5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt5.Location = new System.Drawing.Point(37, 70);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(29, 12);
            this.txt5.TabIndex = 5;
            this.txt5.Text = "结束";
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt4.Location = new System.Drawing.Point(37, 41);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(29, 12);
            this.txt4.TabIndex = 4;
            this.txt4.Text = "开始";
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.ForeColor = System.Drawing.Color.Red;
            this.txt3.Location = new System.Drawing.Point(76, 13);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(125, 12);
            this.txt3.TabIndex = 3;
            this.txt3.Text = "输入扫描IP端口的范围";
            // 
            // zgIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.PortPanel);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.Analysis);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 255);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 255);
            this.Name = "zgIP";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户IP 查询";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zgIP_KeyPress);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button Analysis;
        private System.Windows.Forms.RichTextBox text2;
        private System.Windows.Forms.Button PortPanel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Port;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Label txt5;
        private System.Windows.Forms.Label txt4;
        private System.Windows.Forms.Label txt3;
    }
}

