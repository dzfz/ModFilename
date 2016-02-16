namespace ModFilename
{
    partial class Form1
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
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.button_selectPath = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.Location = new System.Drawing.Point(12, 12);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.Size = new System.Drawing.Size(162, 21);
            this.textBox_filePath.TabIndex = 0;
            // 
            // button_selectPath
            // 
            this.button_selectPath.Location = new System.Drawing.Point(197, 13);
            this.button_selectPath.Name = "button_selectPath";
            this.button_selectPath.Size = new System.Drawing.Size(75, 23);
            this.button_selectPath.TabIndex = 1;
            this.button_selectPath.Text = "目录";
            this.button_selectPath.UseVisualStyleBackColor = true;
            this.button_selectPath.Click += new System.EventHandler(this.button_selectPath_Click);
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(99, 76);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(75, 23);
            this.button_run.TabIndex = 2;
            this.button_run.Text = "开始";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.button_selectPath);
            this.Controls.Add(this.textBox_filePath);
            this.Name = "Form1";
            this.Text = "格式化文件名";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Button button_selectPath;
        private System.Windows.Forms.Button button_run;
    }
}

