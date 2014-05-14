namespace MyTest
{
    partial class PingTest
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
            this.runButton = new System.Windows.Forms.Button();
            this.resultLable = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.result2Lable = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(76, 156);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.Location = new System.Drawing.Point(101, 89);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(41, 12);
            this.resultLable.TabIndex = 1;
            this.resultLable.Text = "结果：";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(103, 39);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(29, 12);
            this.ipLabel.TabIndex = 2;
            this.ipLabel.Text = "ip：";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(150, 36);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(100, 21);
            this.ipBox.TabIndex = 3;
            // 
            // result2Lable
            // 
            this.result2Lable.AutoSize = true;
            this.result2Lable.Location = new System.Drawing.Point(150, 89);
            this.result2Lable.Name = "result2Lable";
            this.result2Lable.Size = new System.Drawing.Size(53, 12);
            this.result2Lable.TabIndex = 4;
            this.result2Lable.Text = "        ";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(208, 156);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // PingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 228);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.result2Lable);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.runButton);
            this.Name = "PingTest";
            this.Text = "PingTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label result2Lable;
        private System.Windows.Forms.Button clearButton;
    }
}

